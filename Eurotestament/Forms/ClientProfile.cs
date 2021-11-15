using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eurotestament
{
    public partial class ClientProfile : Form
    {
        SQLFunctions sqlfunc = new SQLFunctions();
        DataTable data = new DataTable();
        Account account = new Account();
        Checks checks = new Checks();

        private Button currentButton;
        private Form activeForm;


        public ClientProfile()
        {
            InitializeComponent();

        }

        public ClientProfile(string login)
        {
            InitializeComponent();
            btnCloseChild.Visible = false;
            OpenChildForm(new ClientForm.Profile());
            data.Clear();
            data = sqlfunc.GetClient(login); 

            account.Id = data.Rows[0][0].ToString();
            account.Login = data.Rows[0][1].ToString();
            account.Name = data.Rows[0][3].ToString();
            account.Surname = data.Rows[0][4].ToString();
            account.Phone = data.Rows[0][5].ToString();

            checks.update(account.Id);
 

            //dgv_checks.DataSource = sqlfunc.ClientCheck(account.Id);

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void ClientProfile_Load(object sender, EventArgs e)
        {
            lblNameUser.Text = "Здравствуйте,"+ account.Name;
           
        }



        /*private void переводыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transact tran = new Transact(account,checks);
            tran.ShowDialog();
        }*/


        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = ColorTranslator.FromHtml("#41905f");
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                    btnCloseChild.Visible = true;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(31, 39, 48);
                    previousBtn.ForeColor = Color.WhiteSmoke;
                    previousBtn.Font = new Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));

                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelForm.Controls.Add(childForm);
            this.panelForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelForm.Controls.Add(childForm);
            this.panelForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void btnCloseChild_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            currentButton = null;
            btnCloseChild.Visible = false;
            OpenChildForm(new ClientForm.Profile());
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnMaximaze_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;



        }

        private void btnMinimaze_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void btnTransactHistory_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ClientForm.TransactionHistory(), sender);
        }

        private void btnChecks_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ClientForm.ClientChecks(), sender);
        }

        private void btnTrans_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Transact(account,checks), sender);
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ClientForm.Settings(), sender);
        }
    }

}

