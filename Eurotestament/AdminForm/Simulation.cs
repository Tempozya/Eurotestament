using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bogus;
using Bogus.DataSets;
using Bogus.Extensions;
using Newtonsoft.Json;
using System.Threading;

namespace Eurotestament
{
    public partial class simulation : Form
    {
        SQLFunctions sqlfunc = new SQLFunctions();
        Check chData = new Check();
        User usData = new User();
        Dictionary<string, Double> currency = new Dictionary<string, Double>();

        private bool _working;
        private int _counter;
        public simulation()
        {
            InitializeComponent();
        }

        public void SetCurrency()
        {
            currency.Add("EUR", 81.65);
            currency.Add("USD", 71.19);
            currency.Add("EURUSD", 1.14);
            currency.Add("USDEUR", 0.87);

        }

        public string Converter(string from, string to, string sum)
        {
            currency.Clear();
            SetCurrency();
            string SumToCurrency;
            if (from == "RUB")
                SumToCurrency = (Convert.ToDouble(sum) / currency[to]).ToString();
            else if (from == "EUR" && to == "USD")
                SumToCurrency = (Convert.ToDouble(sum) * currency[from + to]).ToString();
            else if (from == "USD" && to == "EUR")
                SumToCurrency = (Convert.ToDouble(sum) / currency[to + from]).ToString();
            else
                SumToCurrency = (Convert.ToDouble(sum) * currency[from]).ToString();




            return SumToCurrency;

        }

        private void transaction(object arg)
        {
            IProgress<int> progress = (IProgress<int>)arg;
            string UserNum;
            string RecipientNum;
            string SumWriteOff;
            string uCurrency;
            string rCurrency;
            string rBank;
            DataTable data = new DataTable();
            data = sqlfunc.AllChecksSimulat();
            while (_working)
            {
                data = sqlfunc.AllChecksSimulat();
                var random = new Randomizer();
                var rndU = random.Number(data.Rows.Count-1);
                var rndR = random.Number(data.Rows.Count-1);


                UserNum = data.Rows[rndU][1].ToString();
                if (rndU == rndR)
                    rndR = random.Number(data.Rows.Count-1);
                RecipientNum = data.Rows[rndR][1].ToString();

                SumWriteOff = random.Number(Convert.ToInt32(data.Rows[rndU][3])).ToString();
                uCurrency = data.Rows[rndU][4].ToString();
                rCurrency = data.Rows[rndR][4].ToString();
                rBank = data.Rows[rndR][6].ToString();


                if (uCurrency == rCurrency)
                {
                    sqlfunc.MoneyTransfer(UserNum, RecipientNum, SumWriteOff, SumWriteOff, uCurrency, rCurrency, rBank);
                        
                }
                else
                {
                    sqlfunc.MoneyTransfer(UserNum, RecipientNum, SumWriteOff, Converter(uCurrency, rCurrency, SumWriteOff), uCurrency, rCurrency, rBank);
                    

                }



                //sqlfunc.MoneyTransfer(UserNum, RecipientNum, SumWriteOff, SumWriteOff, uCurrency, rCurrency, rBank);
                Thread.Sleep(1000);
                progress.Report(_counter++);
            }
        }


        private void registration(object arg)
        {
            IProgress<int> progress = (IProgress<int>)arg;
            string[] checkForm = { "Зарплатный", "Валютный", "Накопительный" };
            string checkCurrencyRub = "RUB";
            string[] checkCurrencyVal = { "USD", "EUR" };

            var UserData = usData.generate();
            var CheckData = chData.generate();


            while (_working)
            {
                var rnd = new Randomizer().Number(4);

                ArrayList checkNum  = new ArrayList();
                ArrayList form = new ArrayList();
                ArrayList balance = new ArrayList();
                ArrayList currency = new ArrayList(); 

                User usData = new User();
                Check chData = new Check();
                var user = UserData.Generate(1);
                var check = CheckData.Generate(rnd);

                foreach (var item in check)
                {
                    chData = item;
                    checkNum.Add(chData.CheckNum);
                    form.Add(checkForm[chData.Form]);
                    balance.Add(chData.Balance);
                    if (checkForm[chData.Form] == "Валютный")
                        currency.Add(checkCurrencyVal[chData.Currency]);
                    else
                        currency.Add(checkCurrencyRub);

                }

                foreach (var item in user)
                {
                    usData = item;
                }

                sqlfunc.RegUser(usData.Id, usData.Login, usData.Password, usData.FirstName, usData.LastName, usData.PhoneNum);
                sqlfunc.RegUserCheck(checkNum, form, balance, currency, usData.Id);

                Thread.Sleep(1000);
                
                progress.Report(_counter++);
            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Start();   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Stop();
        }




        private void Start()
        {
            if (_working)
            {
                label2.Text = "Поток уже работает!";
                return;
            }

            Thread t = new Thread(transaction) { IsBackground = true };

            IProgress<int> progress = new Progress<int>((i) => label1.Text = $"Counter: {i}");

            _working = true;

            label2.Text = "Поток работает!";

            t.Start(progress);
        }

        private void Stop()
        {
            if (!_working)
            {
                label2.Text = "Поток уже не работает!";
                return;
            }

            _working = false;

            label2.Text = "Поток не работает!";
        }
    }
}
