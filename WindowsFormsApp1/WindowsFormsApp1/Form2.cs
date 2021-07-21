using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Btn_Show_Click(object sender, EventArgs e)
        {
            Form3 a = new Form3();
            this.Hide();
            a.Show();
        }

        private void Btn_Home_Click(object sender, EventArgs e)//ปุ่มขาย

        {
            Form4 a = new Form4();
            this.Hide();
            a.Show();
        }

        private void Btn_Exit_Click(object sender, EventArgs e)//ปุ่มออก
        {
            DialogResult dialogResult = MessageBox.Show("คุณต้องการออกจากระบบใช่หรือไม่", "Alert", MessageBoxButtons.YesNo,MessageBoxIcon.Information);//เงื่อนไงปุ่มลบ
            if (dialogResult == DialogResult.Yes)
            {
                Form1 a = new Form1();
                this.Hide();
                a.Show();
            }
        }

        private void Btn_Edit_Click(object sender, EventArgs e)//ปุ่มแก้ไข
        {
            Form5 a = new Form5();
            this.Hide();
            a.Show();
        }

        private void Btn_member_Click(object sender, EventArgs e)
        {
            Form11 a = new Form11();
            this.Hide();
            a.Show();
        }
    }
}
