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
    public partial class Register : Form
    {
        SQLFunctions sqlfunc = new SQLFunctions();


        public Register()
        {
            InitializeComponent();

        }

        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            if (loginField.Texts.Length == 0 || passField.Texts.Length == 0 || nameField.Texts.Length == 0 || surnameField.Texts.Length == 0 || phoneField.Texts.Length == 0)
            {
                MessageBox.Show("Поля не должны быть пустыми!");
            }
            else if (sqlfunc.RegUser(loginField.Texts, passField.Texts, nameField.Texts, surnameField.Texts, phoneField.Texts))
            {
                this.DialogResult = DialogResult.Yes;
            }
            else
            {
                this.DialogResult = DialogResult.No;
            }

        }

    }
}
