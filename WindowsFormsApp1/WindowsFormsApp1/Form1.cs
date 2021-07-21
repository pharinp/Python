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
    public partial class Form1 : Form
    {
        private MySqlConnection databaseConnection()//เชื่อม database
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=project;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        public Form1()
        {
            InitializeComponent();
        }    
        private void Btn_Login_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            conn.Open();
            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM members WHERE member_user=\"{user.Text}\" AND member_password=\"{pass.Text}\"";
            MySqlDataReader rowss = cmd.ExecuteReader();
            rowss.Read();
            if (rowss.HasRows)
            {
                Program.checkstatus = rowss.GetString("member_status");
                if (Program.checkstatus == "ADMIN")//เช็คระบบadmin
                { 
                    MessageBox.Show("เข้าสู่ระบบ Admin แล้ว ", "Alert");
                    Form2 a = new Form2();
                    this.Hide();
                    a.Show();
                }
                else
                {
                    MessageBox.Show("เข้าสู่ระบบแล้ว ", "Alert");
                    Form10 a = new Form10();
                    this.Hide();
                    a.Show();
                }
            }
            else
            {
                MessageBox.Show("ชื่อผู้ใช้หรือรหัสผ่านไม่ถูกต้อง ", "Alert",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                
                user.Text = "";//คำสั่งเคลียร์
                pass.Clear();//คำสั่งเคลียร์
                user.Focus();//คำสั่งเคลียร์
            }
            conn.Close();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void login_press()
        {
            MySqlConnection conn = databaseConnection();
            conn.Open();
            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM members WHERE member_user=\"{user.Text}\" AND member_password=\"{pass.Text}\"";
            MySqlDataReader rowss = cmd.ExecuteReader();
            if (rowss.HasRows)
            {
                rowss.Read();
                //เลือกข้อมูลจากตารางมาแสดง
                Program.checkname = rowss.GetString("member_name");
                Program.checklastname = rowss.GetString("member_lastname");
                Program.checkstatus = rowss.GetString("member_status");
                if (Program.checkstatus == "ADMIN")//เช็คระบบadmin
                {
                    MessageBox.Show("เข้าสู่ระบบ Admin แล้ว ", "Alert");
                    // MessageBox.Show($"เข้าสู่ระบบแล้ว \"{Program.checkname}\"", "Alert",MessageBoxButtons.OK,MessageBoxIcon.Information);//โชว์ชื่อหน้าล็อคอิน
                    Form2 a = new Form2();
                    this.Hide();
                    a.Show();
                }
                else
                {
                    MessageBox.Show("เข้าสู่ระบบแล้ว ", "Alert");
                    Form10 a = new Form10();
                    this.Hide();
                    a.Show();
                }
            }
            else
            {
                MessageBox.Show("ชื่อผู้ใช้หรือรหัสผ่านไม่ถูกต้อง ", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                user.Text = "";//คำสั่งเคลียร์
                pass.Clear();//คำสั่งเคลียร์
                user.Focus();//คำสั่งเคลียร์
            }
        }
        private void pass_KeyPress(object sender, KeyPressEventArgs e)//กดEnter Login
        {
            if (System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1)//กรอกเฉพาะภาษาอังกฤษ
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                login_press();
            }
        }

        private void Hide_pass_Click(object sender, EventArgs e)//ฟังชั่นซ่อนรหัสผ่าน
        {
            if (pass.PasswordChar == '\0')
            {
                Show_pass.BringToFront();
                pass.PasswordChar = '•';
            }
        }

        private void Show_pass_Click(object sender, EventArgs e)//ฟังก์ชั่นแสดงรหัสผ่าน
        {
            if (pass.PasswordChar == '•')
            {
                Hide_pass.BringToFront();
                pass.PasswordChar = '\0';
            }
        }

        private void button1_Click(object sender, EventArgs e)//สมัครสมาชิก
        {
            Form7 a = new Form7();
            a.Show();
        }

        private void label1_Click(object sender, EventArgs e)//ลืมรหัสผ่าน
        {
            Form8 a = new Form8();
            this.Hide();
            a.Show();
        }

        private void user_KeyPress(object sender, KeyPressEventArgs e)//กรอกได้เฉพาะภาษาอังกฤษ
        {
            if (System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1)
            {
                e.Handled = true;
            }
        }

     
    }

}
