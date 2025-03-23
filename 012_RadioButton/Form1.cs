using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _012_RadioButton
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string s = "";

            RadioButton[] nationalButtons = { rbKR, rbCHN, rbJP, rbOthers };
            foreach (var rb in nationalButtons)
            {
                if (rb.Checked)
                    s += $"국적 : {rb.Text}\n";
                    break;
            }

            RadioButton[] genderButtons = { rbMale, rbFemale };
            foreach (var rb in genderButtons)
            {
                if (rb.Checked)
                    s += $"성별 : {rb.Text}\n";
                break;
            }

            //if (rbKR.Checked)
            //    s += "국적 : 대한민국\n";
            //else if (rbCHN.Checked)
            //    s += "국적 : 중국\n";
            //else if (rbJP.Checked)
            //    s += "국적 : 일본\n";
            //else if (rbOthers.Checked)
            //    s += "국적 : 그 외의 국가\n";

            //if (rbMale.Checked)
            //    s += "성별 : 남성\n";
            //else if (rbFemale.Checked)
            //    s += "성별 : 여성\n";

            MessageBox.Show(s, "Result");
        }
    }
}
