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
    public partial class Clients : Form
    {
        SQLFunctions sqlfunc = new SQLFunctions();


        public Clients()
        {
            InitializeComponent();
            dgv_client.DataSource = sqlfunc.AllClients();
        }

        private void Clients_Load(object sender, EventArgs e)
        {

        }

        private void dgv_client_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txt_name.Text = dgv_client.Rows[e.RowIndex].Cells["name"].Value.ToString();
            txt_surname.Text = dgv_client.Rows[e.RowIndex].Cells["surname"].Value.ToString();
            string phone = dgv_client.Rows[e.RowIndex].Cells["phone"].Value.ToString();
            txt_phone.Text = (phone == String.Empty) ? "Нет Данных" : phone;

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (rb_update.Checked)
            {
                UpdateSection();
            }
            else if (rb_delete.Checked)
            {
                DeleteSection();
            }
        }

        private void UpdateSection()
        {
            if (MessageBox.Show("Вы действительно хотите Обновить данные?", "EuroTestament", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (sqlfunc.UpdateClientsData(dgv_client.CurrentRow.Cells[0].Value.ToString(), txt_name.Text, txt_surname.Text, txt_phone.Text))
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    this.DialogResult = DialogResult.No;
                }
            }
        }

        private void DeleteSection()
        {
            if (MessageBox.Show("Вы действительно хотите Удалить данные?", "EuroTestament", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (sqlfunc.DeleteClientsData(dgv_client.CurrentRow.Cells[0].Value.ToString()))
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    this.DialogResult = DialogResult.No;
                }
            }
        }

        private void rb_update_CheckedChanged(object sender, EventArgs e)
        {
            txt_name.Enabled = txt_phone.Enabled = txt_surname.Enabled = true;
            btn_update.Text = "Обновить";
        }

        private void rb_delete_CheckedChanged(object sender, EventArgs e)
        {
            txt_name.Enabled = txt_phone.Enabled = txt_surname.Enabled = false;
            btn_update.Text = "Удалить";
        }
    }
}
