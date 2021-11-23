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

namespace Eurotestament.ClientForm
{
    public partial class TransactionHistory : Form
    {
        SQLFunctions sqlfunc = new SQLFunctions();
        Account account = new Account();
        Checks checks = new Checks();
        public TransactionHistory(Account account, Checks checks)
        {
            InitializeComponent();
            this.account = account;
            this.checks = checks;

        }

        private void comBoxControl1_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            rbGet.Enabled = true;
            rbTake.Enabled = true;

            txtBalance.Text = Convert.ToDouble(checks.BalanceCheck[checksBox.SelectedIndex]).ToString("C");

            rbGet.Checked = false;
            rbTake.Checked = false;

            dgvHistory.Rows.Clear();

            dgvHistory.Visible = true;
        }

        private void TransactionHistory_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < checks.NumCheck.Count; i++)
            {
                checksBox.Items.Add(checks.NumCheck[i]);
            }
        }

        private void rbGet_CheckedChanged(object sender, EventArgs e)
        {
            List<string[]> historyGet = new List<string[]>();
            historyGet = sqlfunc.HistoryGet(checks.NumCheck[checksBox.SelectedIndex]);

            dgvHistory.Rows.Clear();
            foreach (string[] s in historyGet)
                dgvHistory.Rows.Add(s);

        }

        private void rbTake_CheckedChanged(object sender, EventArgs e)
        {
            List<string[]> historyTake = new List<string[]>();
            historyTake = sqlfunc.HistoryTake(checks.NumCheck[checksBox.SelectedIndex]);

            dgvHistory.Rows.Clear();
            foreach (string[] s in historyTake)
                dgvHistory.Rows.Add(s);
            
        }
    }
}
