using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _015_GradeCal
{
    public partial class Form1: Form
    {
        TextBox[] titles;
        ComboBox[] crds;
        ComboBox[] grds;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt1.Text = "인체의 구조와 기능";
            txt2.Text = "일반수학I";
            txt3.Text = "비주얼 프로그래밍";
            txt4.Text = "전기전자공학";
            txt5.Text = "데이터 사이언스";
            txt6.Text = "설계 및 프로젝트 기본 I";
            txt7.Text = "박물관으로의 초대";
            txt8.Text = "영어I";

            //crd1.Items.Add("1");
            //crd1.Items.Add("2");
            //crd1.Items.Add("3");
            //crd1.Items.Add("4");
            //crd1.Items.Add("5");

            crds = new ComboBox[] { crd1, crd2, crd3, crd4, crd5, crd6, crd7, crd8 };
            grds = new ComboBox[] { grd1, grd2, grd3, grd4, grd5, grd6, grd7, grd8 };
            titles = new TextBox[] { txt1, txt2, txt3, txt4, txt5, txt6, txt7, txt8 };

            int[] arrCredit = { 1, 2, 3, 4, 5, };
            List<string> lstGrade = new List<string> { "A+", "A0", "B+", "B0", "C+", "C0", "D+", "D0", "F" };

            foreach (ComboBox c in crds)
            {
                foreach (int i in arrCredit)
                {
                    c.Items.Add(i);
                }
                c.SelectedItem = 2;
            }

            foreach (ComboBox g in grds)
            {
                foreach (string s in lstGrade)
                {
                    g.Items.Add(s);
                }
                g.SelectedItem = "B+";
            }
            //foreach (ComboBox c in crds)
            //{
            //    c.Items.Add("1");
            //    c.Items.Add("2");
            //    c.Items.Add("3");
            //    c.Items.Add("4");
            //    c.Items.Add("5");
            //}

            //foreach (ComboBox g in grds)
            //{
            //    g.Items.Add("A+");
            //    g.Items.Add("A0");
            //    g.Items.Add("B+");
            //    g.Items.Add("B0");
            //    g.Items.Add("C+");
            //    g.Items.Add("C0");
            //    g.Items.Add("D+");
            //    g.Items.Add("D0");
            //    g.Items.Add("F");
            //}


        }

        private void button1_Click(object sender, EventArgs e)
        {
            double tScore = 0;
            double tCredit = 0;

            for (int i = 0; i < crds.Length; i++)
            {
                if (titles[i].Text != "")
                { 
                    int crd = int.Parse(crds[i].SelectedItem.ToString());
                    tCredit += crd;
                    tScore += crd * GetScore(grds[i].SelectedItem.ToString());
                }
            }

            txtGrade.Text = (tScore / tCredit).ToString("0.00");
        }

        private double GetScore(string v)
        {
            if (v == "A+") return 4.5;
            else if (v == "A0") return 4.0;
            else if (v == "B+") return 3.5;
            else if (v == "B0") return 3.0;
            else if (v == "C+") return 2.5;
            else if (v == "C0") return 2.0;
            else if (v == "D+") return 1.5;
            else if (v == "D0") return 1.0;
            else return 0;
        }
    }
}
