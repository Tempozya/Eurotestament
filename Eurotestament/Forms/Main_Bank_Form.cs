using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eurotestament
{
    public partial class Main_Bank_Form : Form
    {
        SQLFunctions sqlfunc = new SQLFunctions();

        public Main_Bank_Form()
        {
            InitializeComponent();
            dgv_client.DataSource = sqlfunc.AllClients();
            Timer timer1 = new Timer();
            timer1.Interval = 300000;//5 minutes
            timer1.Tick += new System.EventHandler(timer1_Tick);
            timer1.Start();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //do whatever you want 
            dgv_client.DataSource = sqlfunc.AllClients();

        }




        private void dgv_client_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txt_clientID.Text = dgv_client.Rows[e.RowIndex].Cells["id"].Value.ToString();
            txt_Login.Text = dgv_client.Rows[e.RowIndex].Cells["login"].Value.ToString();
            txt_clientNSM.Text = dgv_client.Rows[e.RowIndex].Cells["name"].Value.ToString();
            txt_clientSurname.Text = dgv_client.Rows[e.RowIndex].Cells["surname"].Value.ToString();
            string phone = dgv_client.Rows[e.RowIndex].Cells["phone"].Value.ToString();
            txt_clientPhone.Text = (phone == String.Empty) ? "Нет Данных" : phone;
            

            dgv_check.DataSource = sqlfunc.AllChecks(dgv_client.CurrentRow.Cells["id"].Value.ToString());

            //ChecksSettings();
        }

        private void dgv_check_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txt_check.Text = dgv_check.Rows[e.RowIndex].Cells["num"].Value.ToString();
            txt_check_form.Text = dgv_check.Rows[e.RowIndex].Cells["form"].Value.ToString();
            txt_balance.Text = dgv_check.Rows[e.RowIndex].Cells["balance"].Value.ToString();
            txt_currency.Text = dgv_check.Rows[e.RowIndex].Cells["currency"].Value.ToString();
        }

        private void but_search_Click(object sender, EventArgs e)
        {
            {
                
                dgv_client.DataSource = sqlfunc.AllClientsSearch(txt_search.Text);
                
            }
        }

        private void платежиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void изменитьДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clients client = new Clients();

            if (client.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Операция успешно выполнено!", "EuroTestament", MessageBoxButtons.OK);
                dgv_client.DataSource = sqlfunc.AllClients();
            }
            else
            {
                MessageBox.Show("Операция 'НЕ' выполнено!", "EuroTestament", MessageBoxButtons.OK);
                dgv_client.DataSource = sqlfunc.AllClients();
            }
            
        }

        private void симуляцияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            simulation simulate = new simulation();
            simulate.ShowDialog();
        }

        private void dgv_client_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
