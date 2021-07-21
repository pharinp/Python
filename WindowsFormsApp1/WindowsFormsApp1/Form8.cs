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
using System.Net;
using System.Net.Mail;

namespace WindowsFormsApp1
{
    public partial class Form8 : Form
    {
        string randomCode;
        public static string to,user;
        private MySqlConnection databaseConnection()//เชื่อม database
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=project;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        public Form8()
        {
            InitializeComponent();
        }
        private void Btn_Code_f8_Click(object sender, EventArgs e)//รับรหัสทางอีเมล
        {
            if (!this.txt_Email.Text.Contains('@') || !this.txt_Email.Text.Contains('.'))//เช็คformat email
            {
                MessageBox.Show("โปรดป้อนอีเมลให้ถูกต้อง", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MySqlConnection conn = databaseConnection();
                conn.Open();
                MySqlCommand cmd;
                cmd = conn.CreateCommand();
                cmd.CommandText = $"SELECT * FROM members WHERE member_email=\"{txt_Email.Text}\"";
                MySqlDataReader rowss = cmd.ExecuteReader();

                if (rowss.HasRows)
                {
                    rowss.Read();
                    //เลือกข้อมูลจากตารางมาแสดง
                    Program.checkuser = rowss.GetString("member_user");
                    string from, pass, messagebody;
                    Random ran = new Random();
                    string randText = "0123456789";
                    int Length_randText = randText.Length;
                    for (int i = 0; i <= 5; i++)
                    {
                        randomCode += randText[ran.Next(Length_randText)];
                    }
                    MailMessage message = new MailMessage();
                    to = txt_Email.Text.ToString();
                    from = "pharin2001@gmail.com";
                    pass = "pharin0918289986";
                    messagebody = "You have requested to reset your password. Enter this \"" + randomCode + "\" - code to change your password";
                    message.To.Add(to);
                    message.From = new MailAddress(from);
                    message.Body = messagebody;
                    message.Subject = "Password resetting request";
                    SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
                    smtpClient.EnableSsl = true;
                    smtpClient.Port = 587;
                    smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtpClient.Credentials = new NetworkCredential(from, pass);
                    try
                    {
                        smtpClient.Send(message);
                        MessageBox.Show("I have sent your resetting code to you email. Check your inbox :)", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("ไม่พบอีเมลที่สมัคร", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void txt_Email_KeyPress(object sender, KeyPressEventArgs e)//กรอกเฉพาะภาษาอังกฤษช่องอีเมล
        {
            if (System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1)
            {
                e.Handled = true;
            }
        }

        private void txtVerCode_f7_KeyPress(object sender, KeyPressEventArgs e)//กรอกเฉพาะภาษาอังกฤษช่องรหัสผ่าน
        {
            if (System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1)
            {
                e.Handled = true;
            }
        }

        private void Btn_Send_f8_Click(object sender, EventArgs e)//ตรวจสอบรหัส
        {
            if(randomCode== txtVerCode_f7.Text.ToString())
            {
                to = txt_Email.Text;
                Form9 a = new Form9();
                this.Hide();
                a.Show();
            }
            else{
                MessageBox.Show("รหัส OTP ไม่ถูกต้อง","Alert",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        
    }
}
