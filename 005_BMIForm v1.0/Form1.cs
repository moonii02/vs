using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _005_BMIForm_v1._0
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBMI_Click(object sender, EventArgs e)
        {
            double h = double.Parse(txtH.Text);
            double w = double.Parse(txtW.Text);
            h /= 100;
            double bmi = w / (h * h);
            lblBMI.Text = "BMI = " + bmi.ToString("F2");

            if (bmi < 20)
            {
                lblResult.Text = "저체중";
                picC.BackColor = Color.LightBlue;
            }
            else if (bmi < 25)
            {
                lblResult.Text = "정상";
                picC.BackColor = Color.LightGreen;
            }
            else if (bmi < 30)
            {
                lblResult.Text = "경도비만";
                picC.BackColor = Color.Yellow;
            }
            else if (bmi < 40)
            {
                lblResult.Text = "비만";
                picC.BackColor = Color.Orange;
            }
            else if (bmi >= 40)
            {
                lblResult.Text = "고도비만";
                picC.BackColor = Color.Red;
            }
        }

    }
}

