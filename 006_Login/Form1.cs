using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _006_Login
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnL_Click(object sender, EventArgs e)
        {
       
            if (txtID.Text == "abcd" && txtPW.Text == "1234")
            {
                txtRe.Text = "로그인 성공";
            }
            else 
            {
                txtRe.Text = "로그인 실패";
            }
        }
    }
}
