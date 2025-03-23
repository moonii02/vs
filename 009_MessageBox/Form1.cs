using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _009_MessageBox
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) //폼이 로드될 때, 즉 프로그램이 시작 될 때
        {
            MessageBox.Show("가장 간단한 메시지 박스입니다.");

            MessageBox.Show("타이틀을 갖는 메시지 박스입니다.", "Title Message");

            DialogResult r1 = MessageBox.Show("두 개의 버튼을 갖는 메시지 박스", "Title",
                MessageBoxButtons.YesNo);

            DialogResult r2 = MessageBox.Show("세 개의 버튼과 물음표 메시지 박스", "Title",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            DialogResult r3 = MessageBox.Show("디폴트 버튼을 두 번째 버튼으로 지정한 메시지박스", "Title",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            MessageBox.Show("느낌표와 알람 메시지박스", "Alarm",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            string msg = string.Format("당신의 선택은 {0} {1} {2}",
                r1.ToString(), r2.ToString(), r3.ToString());
            MessageBox.Show(msg, "Selections");
        }   
    }
}
