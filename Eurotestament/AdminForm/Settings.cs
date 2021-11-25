using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eurotestament.AdminForm
{
    public partial class Settings : Form
    {

        public int DayInterval = 1000;
        public int MaxNewUser = 10;
        public int MaxNewTransaction = 1;

        public Settings()
        {
            InitializeComponent();
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            if (txtDay != null && txtMaxUsers !=null && txtMaxTrans != null)
            {
                DayInterval = Convert.ToInt16(txtDay.Texts);
                MaxNewUser = Convert.ToInt16(txtMaxUsers.Texts);
                MaxNewTransaction = Convert.ToInt16(txtMaxTrans.Texts);

            }

        }
    }
}
