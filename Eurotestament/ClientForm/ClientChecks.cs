using System;
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
    public partial class ClientChecks : Form
    {
        Account account = new Account();
        Checks checks = new Checks();   
        public ClientChecks(Account account,Checks checks)
        {
            InitializeComponent();
            this.account = account;
            this.checks = checks;

        }

        private void addBalance(int i,FlowLayoutPanel flw)
        {
            Label nbomb = new Label();
            nbomb.Name = "txtBal" + i;
            nbomb.Location = new Point(1, i * 50 + 10);
            nbomb.ForeColor = Color.LimeGreen;
            nbomb.Size = new Size(200, 30);
            nbomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            nbomb.Text = checks.BalanceCheck[i] + " " + checks.CurrencyCheck[i];
            flw.Controls.Add(nbomb);
        }

        private void addNum(int i,FlowLayoutPanel flw)
        {
            Label nbomb = new Label();
            nbomb.Name = "txtNum" + i;
            nbomb.Location = new Point(1, i * 50 + 10);
            nbomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            nbomb.ForeColor = Color.White;
            nbomb.Size = new Size(200, 30);
            nbomb.Text = checks.NumCheck[i];
            flw.Controls.Add(nbomb);
        }

        private void addForm(int i, FlowLayoutPanel flw)
        {
            Label nbomb = new Label();
            nbomb.Name = "txtForm" + i;
            nbomb.Location = new Point(1, i * 50 + 10);
            nbomb.ForeColor = Color.White;
            nbomb.Size = new Size(200, 30);
            nbomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            nbomb.Text = checks.FromCheck[i];
            flw.Controls.Add(nbomb);
        }

        private void ClientChecks_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < checks.BalanceCheck.Count; i++)
            {
                FlowLayoutPanel flw = new FlowLayoutPanel();
                flw.Name = "flw" + i;
                flw.Location = new Point(40, i * 100 + 50);
                flw.FlowDirection = FlowDirection.TopDown;
                flw.AutoSize = true;
                flw.BorderStyle = BorderStyle.FixedSingle;
                this.Controls.Add(flw);
                addBalance(i,flw);
                addNum(i,flw);
                addForm(i, flw);
                Console.WriteLine("Имя:"+flw.Name);
                Console.WriteLine("Loc:" + flw.Location);
                flw = null;

                //lblBalance.Text = checks.BalanceCheck[i] +" "+ checks.CurrencyCheck[i];
                // lblNum.Text = checks.NumCheck[i];
                //lblForm.Text = checks.FromCheck[i];
            }
           
            //MessageBox.Show(flowLayoutPanel1.Location.ToString());

        }
    }
}
