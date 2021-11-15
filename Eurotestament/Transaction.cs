using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eurotestament
{
    class Transaction
    {
        SQLFunctions sqlfunc = new SQLFunctions();
        Dictionary<string, Double> currency = new Dictionary<string, Double>();



        public bool transfer(string UserNumCheck, string RecipientNumCheck, string Sum,string Currency)
        {
            bool flag = false;
            string RecipientCurrency = sqlfunc.GetRecipienCurrency(RecipientNumCheck);
            string RecipientBank = sqlfunc.GetRecipienBank(RecipientNumCheck);
            if (sqlfunc.VerificatUserBalance(UserNumCheck, Sum) && sqlfunc.VerificatRecipientNumCheck(RecipientNumCheck))
                if(Currency == RecipientCurrency)
                {
                    if (sqlfunc.MoneyTransfer(UserNumCheck, RecipientNumCheck, Sum, Sum, Currency, RecipientCurrency, RecipientBank))
                        flag = true;
                }
                else
                {
                    sqlfunc.MoneyTransfer(UserNumCheck, RecipientNumCheck, Sum, Converter(Currency, RecipientCurrency, Sum), Currency, RecipientCurrency, RecipientBank);
                    flag = true;

                }
                

            


            return flag;
        }

        public void SetCurrency()
        {
            currency.Add("EUR", 81.65);
            currency.Add("USD", 71.19);
            currency.Add("EURUSD", 1.14);
            currency.Add("USDEUR", 0.87);

        }

        public string Converter(string from,string to,string sum)
        {
            currency.Clear();
            SetCurrency();
            string SumToCurrency;
            if (from == "RUB")
                SumToCurrency = (Convert.ToDouble(sum) / currency[to]).ToString();
            else if (from == "EUR" && to == "USD")
                SumToCurrency = (Convert.ToDouble(sum) * currency[from+to]).ToString();
            else if (from == "USD" && to == "EUR")
                SumToCurrency = (Convert.ToDouble(sum) / currency[to+from]).ToString();
            else
                SumToCurrency = (Convert.ToDouble(sum) * currency[from]).ToString();




            return SumToCurrency;

        }
    }
}
