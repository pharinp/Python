using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Btn_Show_Click(object sender, EventArgs e)//ไปหน้าแสดงรายการ
        {
            Form3 a = new Form3();
            this.Hide();
            a.Show();
        }

        private void Btn_Home_Click(object sender, EventArgs e)//ไปหน้าขายของ
        {
            Form4 a = new Form4();
            this.Hide();
            a.Show();
        }

        private void Btn_Exit_Click(object sender, EventArgs e)//ปุ่มออก
        {
            DialogResult dialogResult = MessageBox.Show("คุณต้องการออกจากระบบใช่หรือไม่", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Information);//เงื่อนไงปุ่มลบ
            if (dialogResult == DialogResult.Yes)
            {
                Form1 a = new Form1();
                this.Hide();
                a.Show();
            }
        }
    }
}
