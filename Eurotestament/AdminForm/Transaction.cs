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

namespace Eurotestament.AdminForm
{
    public partial class Transaction : Form
    {
        SQLFunctions sqlfunc = new SQLFunctions();
        ArrayList data = new ArrayList();
        public Transaction()
        {
           
            InitializeComponent();
            
        }

        private void Transaction_Load(object sender, EventArgs e)
        {
            List<string[]> history = new List<string[]>();
            history = sqlfunc.GetAllHistory();

            dgvHis.Rows.Clear();
            foreach (string[] s in history)
                dgvHis.Rows.Add(s);


        }

        private void buttonControl1_Click(object sender, EventArgs e)
        {
            

           
        }
    }
}
