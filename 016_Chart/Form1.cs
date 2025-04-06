using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _016_Chart
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.Titles.Add("성적");
            Random r = new Random();

            for (int i = 0; i < 100; i++)
            {
                //chart1.Series[0].Points.Add((i + 1) * 10);
                chart1.Series[0].Points.Add(r.Next(101));
            }
            chart1.Series[0].LegendText = "비주얼\n프로그래밍";

            // Random r = new Random();     <----- Random 객체 생성
            // Button btn = new Button();   <----- Button 객체 생성
        }
    }
}
