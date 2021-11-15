using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eurotestament
{
    
    public class Account
    {
        public string Id { get; set; }
        public string Login { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }


        public Account()
        {
            
        }

        public void messageId()
        {
            MessageBox.Show(Id);
        }


    }

    public class Checks
    {
        SQLFunctions sqlfunc = new SQLFunctions();
        public List<string> NumCheck { get; set; }
        public List<string> FromCheck { get; set; }
        public List<string> BalanceCheck { get; set; }
        public List<string> CurrencyCheck { get; set; }
        public List<string> ClientCheck { get; set; }
        public List<string> BankCheck { get; set; }


        public Checks()
        {
            NumCheck = new List<string>();
            FromCheck = new List<string>();
            BalanceCheck = new List<string>();
            CurrencyCheck = new List<string>();
            ClientCheck = new List<string>();
            BankCheck = new List<string>();
        }

        public void update(string id)
        {

            clear();
            DataTable data_check = new DataTable();
            data_check = sqlfunc.DataClientCheck(id);
            for (int i = 0; i < data_check.Rows.Count; i++)
            {
                NumCheck.Add(data_check.Rows[i][0].ToString());
                FromCheck.Add(data_check.Rows[i][1].ToString());
                BalanceCheck.Add(data_check.Rows[i][2].ToString());
                CurrencyCheck.Add(data_check.Rows[i][3].ToString());
                ClientCheck.Add(data_check.Rows[i][4].ToString());
                BankCheck.Add(data_check.Rows[i][5].ToString());
            }


        }

        public void clear()
        {
            NumCheck.Clear();
            FromCheck.Clear();
            BalanceCheck.Clear();
            CurrencyCheck.Clear();
            ClientCheck.Clear();
            BankCheck.Clear();
        }
    }
}
