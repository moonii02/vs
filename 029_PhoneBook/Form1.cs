using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace _029_PhoneBook
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "t6DlpJkADL5PnbOVHLhWChwI4c32yQZtTz8oniAL",
            BasePath = "https://vp01-6befa-default-rtdb.firebaseio.com"
        };

        IFirebaseClient client;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);

            if(client != null)
            {
                MessageBox.Show("Connection 성공!");
            }
            else
            {
                MessageBox.Show("Connection 실패!");
            }

            dt.Columns.Add("ID");
            dt.Columns.Add("학번");
            dt.Columns.Add("이름");
            dt.Columns.Add("전화번호");

            dataGridView1.DataSource = dt;

            dt.Rows.Clear();
            export();
        }

        private async void btnInsert_Click(object sender, EventArgs e)
        {
            //if (txtID.Text == "")
            //    return;
            FirebaseResponse resp = await client.GetAsync("Counter/");
            Counter c = resp.ResultAs<Counter>();
            MessageBox.Show("cnt = " + c.cnt);

            Data data = new Data
            {
                ID = (c.cnt + 1).ToString(),
                SId = txtSid.Text,
                Name = txtName.Text,
                Phone = txtPhone.Text
            };

            SetResponse response = 
                await client.SetAsync("PhoneBook/" + data.ID, data);

            Data result = response.ResultAs<Data>();

            MessageBox.Show("Data Inserted : ID = " + result.ID);

            var obj = new Counter
            {
                cnt = c.cnt + 1
            };
            SetResponse response1 = await client.SetAsync("Counter/", obj);
            
            dt.Rows.Clear();
            export();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtSid.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            FirebaseResponse response =
                await client.GetAsync("PhoneBook/" + txtID.Text);
            Data data = response.ResultAs<Data>();

            txtID.Text = data.ID;
            txtSid.Text = data.SId;
            txtName.Text = data.Name;
            txtPhone.Text = data.Phone;

            MessageBox.Show("Data reterived successfully!");
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            var data = new Data
            {
                ID = txtID.Text,
                SId = txtSid.Text,
                Name = txtName.Text,
                Phone = txtPhone.Text
            };

            FirebaseResponse response = 
                await client.UpdateAsync("PhoneBook/" + txtID.Text, data);
            Data result = response.ResultAs<Data>();
            MessageBox.Show("Data updated successfully! : id = " +
          result.ID);

            dt.Rows.Clear();
            export();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            FirebaseResponse response = 
                await client.DeleteAsync("PhoneBook/" + txtID.Text);
            MessageBox.Show("Deleted! : id = " + txtID.Text);

            dt.Rows.Clear();
            export();
        }

        private async void btnDeleteAll_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("정말로 삭제하시겠습니까?", "Delete All", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (answer == DialogResult.No)
                return;

            var obj = new Counter
            {
                cnt = 0
            };
            SetResponse response1 = await client.SetAsync("Counter/", obj);
            FirebaseResponse response = 
                await client.DeleteAsync("PhoneBook");
            MessageBox.Show("All Data at /PhoneBook node deleted!");

            dt.Rows.Clear();
            export();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            dt.Rows.Clear();
            export();
        }

        private async Task export()
        {
            int i = 0;
            FirebaseResponse response = await client.GetAsync("Counter/");
            Counter obj = response.ResultAs<Counter>();
            int cnt = obj.cnt;

            while (i != cnt)
            {
                i++;
                FirebaseResponse resp = await client.GetAsync("PhoneBook/" + i);
                Data d = resp.ResultAs<Data>();

                if (d != null)
                { 
                    DataRow row = dt.NewRow();
                    row["ID"] = d.ID;
                    row["학번"] = d.SId;
                    row["이름"] = d.Name;
                    row["전화번호"] = d.Phone;
                    dt.Rows.Add(row);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            txtID.Text = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtSid.Text = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtName.Text = dgv.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPhone.Text = dgv.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
    }
}
