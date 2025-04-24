using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace _024_Graph
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();

            if (chart1.ChartAreas.Count == 0)
            {
                chart1.ChartAreas.Add("ChartArea1");
            }

            chart1.ChartAreas[0].BackColor = Color.LightBlue;

            Random r = new Random();
            Series s = new Series("점수");
            s.ChartType = SeriesChartType.Spline;
            s.Color = Color.HotPink;
            s.BorderWidth = 10;


            for (int i = 1; i < 11; i++)
            {
                int randNum = r.Next(1, 101);
                s.Points.AddXY(i, randNum);
            }

            chart1.Series.Add(s);

            chart1.ChartAreas[0].AxisX.Minimum = 1;
            chart1.ChartAreas[0].AxisX.Maximum = 10;
            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Maximum = 100;
            chart1.ChartAreas[0].AxisX.Interval = 1;
        }
    }
}
