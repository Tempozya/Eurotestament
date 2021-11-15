using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Eurotestament
{
    public partial class Transact : Form
    {
        SQLFunctions sqlfunc = new SQLFunctions();
        Transaction Tran = new Transaction();
        Account account = new Account();
        Checks checks = new Checks();


        public Transact(Account account, Checks checks)
        {
            InitializeComponent();
            this.account = account;
            this.checks = checks;
        }

        private void but_transaction_Click(object sender, EventArgs e)
        {
    
            if (Tran.transfer(check_box.SelectedItem.ToString(), TxtRecepientNum.Texts, TxtSum.Texts, checks.CurrencyCheck[check_box.SelectedIndex]))
            {
                MessageBox.Show("Переведено");
                checks.update(account.Id);
                txtBalance.Text = checks.BalanceCheck[check_box.SelectedIndex] + " " + checks.CurrencyCheck[check_box.SelectedIndex];
            }


        }

        private void Transact_Load(object sender, EventArgs e)

        {

            for (int i=0;i<checks.NumCheck.Count;i++)
            {
               
                
                check_box.Items.Add(checks.NumCheck[i]);
            }
        }

        private void check_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = check_box.SelectedIndex;
            var culture = new CultureInfo("eu-EU");
            txtBalance.Text = Convert.ToDouble(checks.BalanceCheck[index]).ToString("C");
            label1.Text = "Комисиия равна";
            
        }

    }
}
