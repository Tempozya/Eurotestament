using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SqlConn;

namespace Eurotestament
{
    public partial class Login : Form
    {
        SQLFunctions sqlfunc = new SQLFunctions();


        public Login()
        {
            InitializeComponent();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            FlatMainForm main_form = new FlatMainForm();
            
            if (loginField.Texts.Length == 0 || passField.Texts.Length == 0)
            {
                MessageBox.Show("Поля не должны быть пустыми!");
            }
            else
            {
                if (sqlfunc.LoginUser(loginField.Texts, passField.Texts))
                {
                    Login.ActiveForm.Hide();
                    ClientProfile profile = new ClientProfile(loginField.Texts);
                    profile.ShowDialog();
                }
                else if (sqlfunc.LoginAdmin(loginField.Texts, passField.Texts))
                {
                    Login.ActiveForm.Hide();
                    main_form.ShowDialog();
                }


            }


            /*
                    Form2 f2 = new Form2();
                    f2.Show();
                    this.Hide();
                    
                
           */
            }

        private void ButtonRegistr_Click(object sender, EventArgs e)
        {
            Register registration = new Register();
            if (registration.ShowDialog() == DialogResult.Yes)
            {
                MessageBox.Show("Ваш АККАУНТ успешно создан!");
            }
            else
            {
                MessageBox.Show("Ваш АККАУНТ 'HE' создан!");
            }
        }

        private void Login_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите Выйти?", "Eurotestament", MessageBoxButtons.OKCancel) == DialogResult.OK)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void Login_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ButtonLogin_Click(this, EventArgs.Empty);
            }
                
        }


    }
}

