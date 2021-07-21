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
    public partial class Form9 : Form
    {
        string email = Form8.to;
        private MySqlConnection databaseConnection()//เชื่อม database
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=project;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        public Form9()
        {
            InitializeComponent();
            label4.Text= Program.checkuser;
        }

        private void Btn_Changpass_f9_Click(object sender, EventArgs e)//แก้ไขรหัสผ่าน
        {
            if(PassText_f9.Text== ConPassText_f9.Text)
            {
                MySqlConnection conn = databaseConnection();
                string sql = "UPDATE members SET member_password='" + ConPassText_f9.Text + "' WHERE member_email='" + email+"'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                conn.Close();
                if (rows > 0)
                {
                    MessageBox.Show("เปลี่ยนรหัสผ่านสำเร็จ", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form1 a = new Form1();
                    this.Hide();
                    a.Show();
                }
            }
            else
            {
                MessageBox.Show("รหัสผ่านไม่ตรงกัน", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PassText_f9_KeyPress(object sender, KeyPressEventArgs e)//กรอกเฉพาะภาษาอังกฤษช่องยืนยันรหัส
        {
            if (System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1)
            {
                e.Handled = true;
            }
        }

        private void ConPassText_f9_KeyPress(object sender, KeyPressEventArgs e)//กรอกเฉพาะภาษาอังกฤษช่องยืนยันรหัส
        {
            if (System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1)
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)//ยกเลิก
        {
            DialogResult dialogResult = MessageBox.Show("คุณต้องการยกเลิกการเปลี่ยนรหัสผ่านใช่หรือไม่", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialogResult == DialogResult.Yes) { 
                Form1 a = new Form1();
            this.Hide();
            a.Show();
            }
            else { };
        }
    }
}
