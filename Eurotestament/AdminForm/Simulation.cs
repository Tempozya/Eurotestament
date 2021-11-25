using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bogus;
using System.Threading;
using Eurotestament.AdminForm;

namespace Eurotestament
{
    public partial class simulation : Form
    {
        SQLFunctions sqlfunc = new SQLFunctions();
        Check chData = new Check();
        User usData = new User();
        Settings settings = new Settings();


        Dictionary<string, Double> currency = new Dictionary<string, Double>();
        string checkedRB;
        private DateTime date = new DateTime(2021, 11, 1);
        private  int countTrans = 0;
        private int countReg = 0;
        private double AllTransact = 0;
        private bool _working;

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




        private  void transaction()
        {
            string UserNum;
            string RecipientNum;
            string SumWriteOff;
            string uCurrency;
            string rCurrency;
            string rBank;
            DataTable data = new DataTable();
            
            while (_working)
            {
                for (int i = 0; i < settings.MaxNewTransaction; i++)
                {

                    data = sqlfunc.AllChecksSimulat();
                    Console.WriteLine(data.Rows.Count);
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

                    if (uCurrency == "RUB")
                        AllTransact += Convert.ToDouble(SumWriteOff);
                    else              
                        AllTransact += Convert.ToDouble(Converter(uCurrency, "RUB", SumWriteOff));
                    
                        


                    countTrans += 1;

                
                    Thread.Sleep(settings.DayInterval/settings.MaxNewTransaction);
                }
            }
        }


        private  void registration()
        {
            string[] checkForm = { "Зарплатный", "Валютный", "Накопительный" };
            string checkCurrencyRub = "RUB";
            string[] checkCurrencyVal = { "USD", "EUR" };

            var UserData = usData.generate();
            var CheckData = chData.generate();


            while (_working)
            {
                for (int i = 0; i < settings.MaxNewUser; i++)
                {
                    var rnd = new Randomizer().Number(4);

                    ArrayList checkNum = new ArrayList();
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
                    countReg += 1;
                    Console.WriteLine("Проход");
                    Thread.Sleep(settings.DayInterval / settings.MaxNewUser);

                }  
            } 
        }




        private void SimLoop()
        {
            while (_working)
            {
                if(date.DayOfWeek == DayOfWeek.Monday)
                {

                }
                labelNewClients.Invoke(new Action(() => labelNewClients.Text = countReg.ToString()));
                labelNewTransaction.Invoke(new Action(() => labelNewTransaction.Text = countTrans.ToString()));
                labelSumTransact.Invoke(new Action(() => labelSumTransact.Text = AllTransact.ToString("C")));
                labelDate.Invoke(new Action(() => labelDate.Text = date.ToString("d")));

                date = date.AddDays(1);
                Thread.Sleep(settings.DayInterval);

            }
        }

        private  void Start(string state)
        {
   

            if (_working)
            {
                label2.Text = "Симуляция уже работает!";
                return;
            }

            _working = true;
            if (state == "rbReg")
            {
                Task.Run(() => SimLoop());
                Task.Run(() => registration());
            }
                
            else if (state == "rbTrans")
            {
                Task.Run(() => SimLoop());
                Task.Run(() => transaction());
                
            }

            else if (state == "rbAll")
            {
                Task.Run(() => SimLoop());
                Task.Run(() => registration());
                Task.Run(() => transaction());

            }


            

            label2.Text = "Симуляция запущена";


        }

        private void Stop()
        {
            if (!_working)
            {
                label2.Text = "Симуляция уже не работает!";
                return;
            }

            _working = false;
            
            label2.Text = "Симуляция не работает!";
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            labelNewClients.Invoke(new Action(() => labelNewClients.Text = countReg.ToString()));
            labelNewTransaction.Invoke(new Action(() => labelNewTransaction.Text = countTrans.ToString()));
            labelSumTransact.Invoke(new Action(() => labelSumTransact.Text = AllTransact.ToString("C")));
            labelDate.Invoke(new Action(() => labelDate.Text = date.ToString("d")));
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {

            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                btnStart.Enabled = true;
                btnStop.Enabled = true;
                checkedRB = radioButton.Name;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Start(checkedRB);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Stop();
        }

        private void labelDate_Click(object sender, EventArgs e)
        {

        }
    }
}
