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
using System.Windows.Forms.DataVisualization.Charting;
using ZedGraph;

namespace Eurotestament
{
    public partial class dashboard : Form
    {
        SQLFunctions sqlfunc = new SQLFunctions();

        public dashboard()
        {
            InitializeComponent();
            zedGraph.IsShowPointValues = true;
            zedGraph.PointValueEvent +=
            new ZedGraphControl.PointValueHandler(zedGraph_PointValueEvent);
        }

        private string zedGraph_PointValueEvent(ZedGraphControl sender, GraphPane pane, CurveItem curve, int iPt)
        {
            PointPair point = curve[iPt];

            // Сформируем строку
            string result = string.Format("Колво: {0:F0}", point.Y);

            return result;
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            labelCount.Text = sqlfunc.CountUser();
            labelTrans.Text = sqlfunc.CountTransaction();
            labelComis.Text = sqlfunc.GetComission().ToString("C");
        }

 

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DataTable data = new DataTable();

            data = sqlfunc.GetTransactionPeriod(dtpStart.Text, dtpEnd.Text);
            paintDiagram(data);


        }


        private void paintDiagram(DataTable data)
        {
            GraphPane pane = zedGraph.GraphPane;

            pane.CurveList.Clear();

            pane.Title.Text = "График кол-ва транзакций";
            pane.XAxis.Title.Text = "Дни";
            pane.YAxis.Title.Text = "Кол-во";

            double[] YValues1 = new double[data.Rows.Count];
            string[] XValues = new string[data.Rows.Count];


            for (int i = 0; i < data.Rows.Count; i++)

            {
                DateTime date = Convert.ToDateTime(data.Rows[i][1]);
                XValues[i] = date.ToString("dd-MM");

                YValues1[i] = Convert.ToDouble(data.Rows[i][0]);

            }

  
            BarItem bar1 = pane.AddBar("Кол-во", null, YValues1, Color.Blue);

            pane.XAxis.Scale.TextLabels = XValues;
            pane.XAxis.Type = ZedGraph.AxisType.Text;


            // !!! Расстояния между столбиками в кластере (группами столбиков)
            pane.BarSettings.MinBarGap = 0.0f;

            // !!! Увеличим расстояние между кластерами в 2.5 раза
            pane.BarSettings.MinClusterGap = 2.5f;


           
            // Вызываем метод AxisChange (), чтобы обновить данные об осях.
            zedGraph.AxisChange();

            // Обновляем график
            zedGraph.Invalidate();






        }

        private void labelCount_Click(object sender, EventArgs e)
        {

        }
    }
}
