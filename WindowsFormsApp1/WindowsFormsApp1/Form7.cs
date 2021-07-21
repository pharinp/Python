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
using System.Text.RegularExpressions; //ต้องใส่

namespace WindowsFormsApp1
{
    public partial class Form7 : Form
    {
        private MySqlConnection databaseConnection()//เชื่อม database
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=project;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        public Form7()
        {
            InitializeComponent();
        }
        private void clearf7()
        {
            UserText_f7.Text = "";//คำสั่งเคลียร์
            PassText_f7.Text = "";
            ConPassText_f7.Text = "";//คำสั่งเคลียร์
            NameText_f7.Text = "";
            LastnameText_f7.Text = "";
            PhoneNumberText_f7.Text = "";
            EmailText_f7.Text = "";
            AddressText_f7.Text = "";
            //OrderText.Focus();//คำสั่งเคลียร์
        }
        private bool validateURL()//เช็คอีเมล
        {

            Regex urlCheck = new Regex("^[a-zA-Z0-9/@/./]+(com|org|net|mil|edu|COM|ORG|NET|MIL|EDU)$");

            if (urlCheck.IsMatch(EmailText_f7.Text))
            {
                return true;
            }
            else
            {
                return false;

            }
        }
        private void Submit_f7_Click(object sender, EventArgs e)
        {
            if (UserText_f7.Text != "" && PassText_f7.Text != "" && ConPassText_f7.Text != "" && NameText_f7.Text != ""
                && LastnameText_f7.Text != "" && PhoneNumberText_f7.Text != "" && EmailText_f7.Text != "" && AddressText_f7.Text != "")
            {
                if (PassText_f7.Text == ConPassText_f7.Text)//เช็ครหัสผ่านตรงกัน
                { //เช็คอีเมลกับuserซ้ำ
                    MySqlConnection conn = databaseConnection();
                    conn.Open();
                    MySqlCommand cmd;
                    cmd = conn.CreateCommand();
                    cmd.CommandText = $"SELECT member_email FROM members WHERE member_email ='{ EmailText_f7.Text}' OR member_user='{UserText_f7.Text}'";
                    MySqlDataReader row = cmd.ExecuteReader();
                    row.Read();
                    if (row.HasRows)
                    {
                        MessageBox.Show("ชื่อผู้ใช้หรืออีเมลนี้มีอยู่แล้ว");
                    }
                    else {
                        if (PhoneNumberText_f7.TextLength == 10)//เช็คเบอร์โทรศัพท์
                        {
                                validateURL();
                            if (validateURL() == true)
                            {


                                MySqlConnection connn = databaseConnection();
                                string sql = "INSERT INTO members(member_user,member_password,member_name,member_lastname,member_phone,member_email,member_address,member_status)" +
                                                                                 "VALUE('" + UserText_f7.Text + "','" + PassText_f7.Text + "','" + NameText_f7.Text + "','" + LastnameText_f7.Text + "','" + PhoneNumberText_f7.Text + "'" +
                                                                                 ",'" + EmailText_f7.Text + "','" + AddressText_f7.Text + "','USER')";
                                MySqlCommand cmd2 = new MySqlCommand(sql, connn);
                                connn.Open();
                                int rows = cmd2.ExecuteNonQuery();
                                connn.Close();
                                if (rows > 0)
                                {
                                    MessageBox.Show("สมัครสมาชิกเรียบร้อย", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    clearf7();
                                    this.Hide();
                                }

                            }
                            else { MessageBox.Show("Email ไม่ถูกต้อง", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
                        
                        
                        }
                        else
                        {
                            MessageBox.Show("กรุณากรอกตัวเลขให้ครบ 10 ตัว", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                 }
                  else//เช็ครหัสผ่านตรงกัน
                        {
                        MessageBox.Show("รหัสผ่านไม่ตรงกัน", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                         PassText_f7.Text = "";
                        ConPassText_f7.Text = "";
                      }
            }
            else//กรอกข้อมูลไม่ครบ
            {
                MessageBox.Show("กรอกข้อมูลไม่ครบ ", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Hide_pass_f7_Click(object sender, EventArgs e)//ซ่อนรหัสผ่าน
        {
            if (PassText_f7.PasswordChar == '\0')
            {
                Show_pass_f7.BringToFront();
                PassText_f7.PasswordChar = '•';
            }
        }
        private void Show_pass_f7_Click(object sender, EventArgs e)//แสดงรหัสผ่าน
        {
            if (PassText_f7.PasswordChar == '•')
            {
                Hide_pass_f7.BringToFront();
                PassText_f7.PasswordChar = '\0';
            }
        }
        private void Hide_pass_Click(object sender, EventArgs e)//ซ่อนรหัสผ่านช่องยืนยัน
        {
            if (ConPassText_f7.PasswordChar == '\0')
            {
                Show_pass.BringToFront();
                ConPassText_f7.PasswordChar = '•';
            }
        }
        private void Show_pass_Click(object sender, EventArgs e)//แสดงรหัสผ่านช่องยืนยัน
        {
            if (ConPassText_f7.PasswordChar == '•')
            {
                Hide_pass.BringToFront();
                ConPassText_f7.PasswordChar = '\0';
            }
        }

        private void Btn_cancel_f7_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void PhoneNumberText_f7_KeyPress(object sender, KeyPressEventArgs e)//เช็คกรอกเฉพาะตัวเลขเบอร์โทรศัพท์
        {
            //ให้กรอกเฉพาะตัวเลข
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void UserText_f7_KeyPress(object sender, KeyPressEventArgs e)//เฉพาะภาษาอังกฤษช่องusername
        {
            if (System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1)
            {
                e.Handled = true;
            }
        }

        private void PassText_f7_KeyPress(object sender, KeyPressEventArgs e)//เฉพาะภาษาอังกฤษช่องรหัส
        {
            if (System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1)
            {
                e.Handled = true;
            }
        }
        private void ConPassText_f7_KeyPress(object sender, KeyPressEventArgs e)//เฉพาะภาษาอังกฤษช่องรหัส
        {
            if (System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1)
            {
                e.Handled = true;
            }
        }

        private void EmailText_f7_KeyPress(object sender, KeyPressEventArgs e)//เฉพาะภาษาอังกฤษช่องอีเมล
        {
            if (System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1)
            {
                e.Handled = true;
            }
        }
    }
    
}
