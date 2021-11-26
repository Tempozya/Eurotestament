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
    public partial class dashboard : Form
    {
        SQLFunctions sqlfunc = new SQLFunctions();
        public dashboard()
        {
            InitializeComponent();
           
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            labelCount.Text = sqlfunc.CountUser();
            labelTrans.Text = sqlfunc.CountTransaction();
            labelComis.Text = sqlfunc.GetComission().ToString("C");
        }
    }
}
