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
    public partial class Form3 : Form
    {

        private MySqlConnection databaseConnection()//เชื่อม database
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=project;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        private void showequipment()//ฟังก์ชั่นโชว์
        {
            string name = textBox1.Text;
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = ("SELECT id AS ลำดับ, name AS ชื่อ, product_unit AS หน่วยการขาย, amount AS จำนวน, unit AS ราคาต่อหน่วย, price AS ราคา, home_user AS บันทึกโดย,edit_user AS แก้ไขโดย, time AS เวลา, comment AS หมายเหตุ FROM home WHERE id LIKE'%" + name+ "%' OR name LIKE'%" + name + "%' OR product_unit LIKE'%" + name + "%' OR amount LIKE'%" + name + "%' OR unit LIKE'%" + name + "%' OR price LIKE'%" + name + "%' OR home_user LIKE'%" + name + "%' OR edit_user OR time LIKE'%" + name + "%'OR comment LIKE'%" + name + "%' ");


            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);
            conn.Close();
            DataEquipment.DataSource = ds.Tables[0].DefaultView;
            
        }
        private void showequipment2()//ฟังก์ชั่นโชว์
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT id AS ลำดับ, name AS ชื่อ,product_unit AS หน่วยการขาย,amount AS จำนวน,unit AS ราคาต่อหน่วย,price AS ราคา,home_user AS บันทึกโดย,edit_user AS แก้ไขโดย,time AS เวลา,comment AS หมายเหตุ FROM home";

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);
            conn.Close();
            DataEquipment.DataSource = ds.Tables[0].DefaultView;
        }
        private void showequipmentforuser()//ฟังก์ชั่นโชว์
        {
            
            string name2 = Program.checkname;
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = cmd.CommandText = ("SELECT id AS ลำดับ, name AS ชื่อ, product_unit AS หน่วยการขาย, amount AS จำนวน, unit AS ราคาต่อหน่วย, price AS ราคา, home_user AS บันทึกโดย,edit_user AS แก้ไขโดย, time AS เวลา, comment AS หมายเหตุ FROM home WHERE id LIKE'%" + name2 + "%' OR name LIKE'%" + name2 + "%' OR product_unit LIKE'%" + name2 + "%' OR amount LIKE'%" + name2 + "%' OR unit LIKE'%" + name2 + "%' OR price LIKE'%" + name2 + "%' OR home_user LIKE'%" + Program.checkname + "%' OR edit_user OR time LIKE'%" + name2 + "%'OR comment LIKE'%" + name2 + "%'  ");
                                                
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);
            conn.Close();
            DataEquipment.DataSource = ds.Tables[0].DefaultView;
        }
        private void showequipmentforuser2()//ฟังก์ชั่นโชว์
        {

            string name2 = Program.checkname;
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = cmd.CommandText = ("SELECT id AS ลำดับ, name AS ชื่อ, product_unit AS หน่วยการขาย, amount AS จำนวน, unit AS ราคาต่อหน่วย, price AS ราคา, home_user AS บันทึกโดย,edit_user AS แก้ไขโดย, time AS เวลา, comment AS หมายเหตุ FROM home WHERE id LIKE'%" + name2 + "%' OR name LIKE'%" + name2 + "%' OR product_unit LIKE'%" + name2 + "%' OR amount LIKE'%" + name2 + "%' OR unit LIKE'%" + name2 + "%' OR price LIKE'%" + name2 + "%' OR home_user LIKE'%" + name2 + "%' OR edit_user OR time LIKE'%" + name2 + "%'OR comment LIKE'%" + name2 + "%' ");

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);
            conn.Close();
            DataEquipment.DataSource = ds.Tables[0].DefaultView;
        }
        private void total()//ราคาสินค้ารวม
        {
            label2.Text = "0";
            for (int i = 0; i < DataEquipment.Rows.Count; i++)
            {
                label2.Text = Convert.ToString(double.Parse(label2.Text) + double.Parse(DataEquipment.Rows[i].Cells[5].Value.ToString()));
                Program.checkraka = label2.Text;
            }
        }
        private void total_amount()//จำนวนสินค้ารวม
        {
            label3.Text = "0";
            for (int i = 0; i < DataEquipment.Rows.Count; i++)
            {
                label3.Text = Convert.ToString(double.Parse(label3.Text) + double.Parse(DataEquipment.Rows[i].Cells[3].Value.ToString()));
                Program.checkamount= label3.Text;
            }
        }
        public Form3()
        {
            InitializeComponent();
            if (Program.checkstatus == "ADMIN")
            {
                showequipment();
                showequipment2();
                total();
                total_amount();
            }
            else
            {
                showequipment();
                showequipmentforuser();
                total();
                total_amount();
            }
            //showequipment2();
            label7.Text = Program.checkname;
            //total();
            //total_amount();
            
        }

        private void button1_Click(object sender, EventArgs e)//ย้อนกลับหน้าแรก
        {
            if (Program.checkstatus == "ADMIN") //เช็คระบบadmin
            {
                Form2 a = new Form2();
                this.Hide();
                a.Show();
            }
            else
            {
                Form10 a = new Form10();
                this.Hide();
                a.Show();
            }
        }

        private void Btn_Toltal_f3_Click(object sender, EventArgs e)//ราคาสินค้ารวม
        {
            label2.Text = "0";
            for (int i = 0; i < DataEquipment.Rows.Count; i++)
            {
                label2.Text = Convert.ToString(double.Parse(label2.Text) + double.Parse(DataEquipment.Rows[i].Cells[5].Value.ToString()));
                Program.checkraka = label2.Text;
            }
        }

        private void Btn_Amount_f3_Click(object sender, EventArgs e)//จำนวนสินค้า
        {
            label3.Text = "0";
            for (int i = 0; i < DataEquipment.Rows.Count; i++)
            {
                label3.Text = Convert.ToString(double.Parse(label3.Text) + double.Parse(DataEquipment.Rows[i].Cells[3].Value.ToString()));
            }
        }
        private List<Class1> allbook = new List<Class1>();
        private void BtnPrint_f3_Click(object sender, EventArgs e)
        {
            allbook.Clear();
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)//ปริ้น
        {
            //   e.Graphics.DrawImage(logo, new PointF(50, 50));
            e.Graphics.DrawString("บันทึกรายการสินค้า", new Font("TH SarabunPSK", 24, FontStyle.Bold), Brushes.Black, new PointF(315, 40));
            e.Graphics.DrawString("ปริญ ฟาร์ม", new Font("TH SarabunPSK", 24, FontStyle.Bold), Brushes.Black, new PointF(355, 80));
            e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------------------------------", new Font("TH SarabunPSK", 18, FontStyle.Bold), Brushes.Black, new PointF(50, 115));
            e.Graphics.DrawString("รายการสินค้า     ปกติ", new Font("TH SarabunPSK", 18, FontStyle.Bold), Brushes.Black, new PointF(50, 140));
            e.Graphics.DrawString("สถานะ "+Program.checkstatus, new Font("TH SarabunPSK", 18, FontStyle.Bold), Brushes.Black, new PointF(410, 140));
            e.Graphics.DrawString("พิมพ์เมื่อ " + System.DateTime.Now.ToString("dd / MM / yyyy   HH : mm : ss น."), new Font("TH SarabunPSK", 18, FontStyle.Bold), Brushes.Black, new PointF(50, 165));
            e.Graphics.DrawString("พิมพ์โดย     "+ Program.checkname+"     "+ Program.checklastname + "", new Font("TH SarabunPSK", 18, FontStyle.Bold), Brushes.Black, new PointF(410, 165));
            //e.Graphics.DrawString(Program.checklastname, new Font("TH SarabunPSK", 18, FontStyle.Bold), Brushes.Black, new PointF(590, 165));
            e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------------------------------", new Font("TH SarabunPSK", 18, FontStyle.Bold), Brushes.Black, new PointF(50, 185));
            e.Graphics.DrawString("ID", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new PointF(50, 205));
            e.Graphics.DrawString("NAME", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new PointF(80, 205));
            e.Graphics.DrawString("AMOUNT", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new PointF(230, 205));
            e.Graphics.DrawString("PRICE", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new PointF(335, 205));
            e.Graphics.DrawString("USER", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new PointF(415, 205));
            e.Graphics.DrawString("TIME", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new PointF(570, 205));
            e.Graphics.DrawString("NOTE", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new PointF(700, 205));
            e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------------------------------", new Font("TH SarabunPSK", 18, FontStyle.Bold), Brushes.Black, new PointF(50, 220));
            int y = 240;
            allbook.Clear();
            loaddata();
            foreach (var i in allbook)
            {
                e.Graphics.DrawString(i.id, new Font("TH SarabunPSK", 14, FontStyle.Regular), Brushes.Black, new PointF(50, y));
                e.Graphics.DrawString(i.name, new Font("TH SarabunPSK", 14, FontStyle.Regular), Brushes.Black, new PointF(80, y));
                e.Graphics.DrawString(i.amount, new Font("TH SarabunPSK", 14, FontStyle.Regular), Brushes.Black, new PointF(255, y));
                e.Graphics.DrawString(i.price, new Font("TH SarabunPSK", 14, FontStyle.Regular), Brushes.Black, new PointF(337, y));
                e.Graphics.DrawString(i.user, new Font("TH SarabunPSK", 14, FontStyle.Regular), Brushes.Black, new PointF(420, y));
                e.Graphics.DrawString(i.time, new Font("TH SarabunPSK", 14, FontStyle.Regular), Brushes.Black, new PointF(530, y));
                e.Graphics.DrawString(i.note, new Font("TH SarabunPSK", 14, FontStyle.Regular), Brushes.Black, new PointF(685, y));
                //e.Graphics.DrawString("ราคารวมสินค้า", new Font("TH SarabunPSK", 16, FontStyle.Regular), Brushes.Black, new PointF(580, 1100));
                //e.Graphics.DrawString(i.checkraka+"\tบาท", new Font("TH SarabunPSK", 16, FontStyle.Regular), Brushes.Black, new PointF(680, 1100));
                //e.Graphics.DrawString("จำนวนสินค้า", new Font("TH SarabunPSK", 16, FontStyle.Regular), Brushes.Black, new PointF(580, 1120));
                //e.Graphics.DrawString(i.checkamount + "\tกก.", new Font("TH SarabunPSK", 16, FontStyle.Regular), Brushes.Black, new PointF(680, 1120));
                y = y + 20;

            }
            e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------------------------------------------------", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new Point(50, y + 10));
            e.Graphics.DrawString("รวมทั้งสิ้น\t  " + Program.checkraka + "\tบาท", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new Point(540, (y + 0) + 45));
            e.Graphics.DrawString("จำนวนสินค้า\t  " + Program.checkamount + "\tหน่วย", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new Point(540, (y + 0) + 75));
            //e.Graphics.DrawString("ชื่อผู้ให้บริการ    " + Program.userid.ToString(), new Font("DB Helvethaica X v3.2", 16, FontStyle.Bold), Brushes.Black, new Point(80, (y + 30) + 45));
            //e.Graphics.DrawString("รับเงิน            " + textBox2.Text + " บาท", new Font("supermarket", 16, FontStyle.Regular), Brushes.Black, new Point(570, ((y + 30) + 45) + 45));
            //e.Graphics.DrawString("เงินทอน           " + textBox3.Text + " บาท", new Font("supermarket", 16, FontStyle.Regular), Brushes.Black, new Point(570, (((y + 30) + 45) + 45) + 45));
            //e.Graphics.DrawString("       ร้านปังหลายรสอุปกรณ์เบเกอรี่       ", new Font("supermarket", 16, FontStyle.Regular), Brushes.Black, new Point(290, ((((y + 30) + 45) + 45) + 45) + 45));
           //e.Graphics.DrawString("           ขอบคุณที่ใช้บริการ      ", new Font("supermarket", 16, FontStyle.Regular), Brushes.Black, new Point(290, (((((y + 30) + 45) + 45) + 45) + 45) + 45));
        }

        private void loaddata()
        {
            MySqlConnection conn = databaseConnection();
            string name = textBox1.Text;
            conn.Open();
            if (Program.checkstatus == "ADMIN")
            {


                //Program.checksearch= name;
                if (name == "")
                {

                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM home  ", conn);
                    MySqlDataReader adapter = cmd.ExecuteReader();

                    while (adapter.Read())
                    {
                        Program.id = adapter.GetString("id");
                        Program.name = adapter.GetString("name");
                        Program.amount = adapter.GetString("amount");
                        Program.price = adapter.GetString("price");
                        Program.user = adapter.GetString("home_user");
                        Program.time = adapter.GetString("time");
                        Program.note = adapter.GetString("comment");
                        Class1 item = new Class1()
                        {
                            id = Program.id,
                            name = Program.name,
                            amount = Program.amount,
                            price = Program.price,
                            user = Program.user,
                            time = Program.time,
                            note = Program.note,
                            checkraka = Program.checkraka,
                            checkamount = Program.checkamount
                        };
                        allbook.Add(item);
                    }
                }
                else
                {
                    MySqlCommand cmd = new MySqlCommand("SELECT id AS ลำดับ, name AS ชื่อ, product_unit AS หน่วยการขาย, amount AS จำนวน, unit AS ราคาต่อหน่วย, price AS ราคา, home_user AS บันทึกโดย, time AS เวลา, comment AS หมายเหตุ FROM home WHERE id LIKE'%" + name + "%' OR name LIKE'%" + name + "%' OR product_unit LIKE'%" + name + "%' OR amount LIKE'%" + name + "%' OR unit LIKE'%" + name + "%' OR price LIKE'%" + name + "%' OR home_user LIKE'%" + name + "%' OR time LIKE'%" + name + "%'OR comment LIKE'%" + name + "%' ", conn); ;
                    MySqlDataReader adapter = cmd.ExecuteReader();
                    while (adapter.Read())
                    {
                        Program.id = adapter.GetString("ลำดับ");
                        Program.name = adapter.GetString("ชื่อ");
                        Program.amount = adapter.GetString("จำนวน");
                        Program.price = adapter.GetString("ราคา");
                        Program.user = adapter.GetString("บันทึกโดย");
                        Program.time = adapter.GetString("เวลา");
                        Program.note = adapter.GetString("หมายเหตุ");
                        Class1 item = new Class1()
                        {
                            id = Program.id,
                            name = Program.name,
                            amount = Program.amount,
                            price = Program.price,
                            user = Program.user,
                            time = Program.time,
                            note = Program.note,
                            checkraka = Program.checkraka,
                            checkamount = Program.checkamount

                        };
                        allbook.Add(item);
                    }

                }

            }
            else
            {

                string name2 = Program.checkname;
               
                 MySqlCommand cmd = new MySqlCommand("SELECT id AS ลำดับ, name AS ชื่อ, product_unit AS หน่วยการขาย, amount AS จำนวน, unit AS ราคาต่อหน่วย, price AS ราคา, home_user AS บันทึกโดย,edit_user AS แก้ไขโดย, time AS เวลา, comment AS หมายเหตุ FROM home WHERE id LIKE'%" + name2 + "%' OR name LIKE'%" + name2 + "%' OR product_unit LIKE'%" + name2 + "%' OR amount LIKE'%" + name2 + "%' OR unit LIKE'%" + name2 + "%' OR price LIKE'%" + name2 + "%' OR home_user LIKE'%" + Program.checkname + "%' OR edit_user OR time LIKE'%" + name2 + "%'OR comment LIKE'%" + name2 + "%' ", conn);
                //cmd.CommandText = cmd.CommandText = ("SELECT id AS ลำดับ, name AS ชื่อ, product_unit AS หน่วยการขาย, amount AS จำนวน, unit AS ราคาต่อหน่วย, price AS ราคา, home_user AS บันทึกโดย,edit_user AS แก้ไขโดย, time AS เวลา, comment AS หมายเหตุ FROM home WHERE id ='" + name2 + "' OR name ='" + name2 + "' OR product_unit='" + name2 + "' OR amount='" + name2 + "' OR unit='" + name2 + "' OR price='" + name2 + "' OR home_user='" + Program.checkname + "' OR edit_user OR time='" + name2 + "'OR comment='" + name2 + "' ");
                MySqlDataReader adapter = cmd.ExecuteReader();
                while (adapter.Read())
                {
                    Program.id = adapter.GetString("ลำดับ");
                    Program.name = adapter.GetString("ชื่อ");
                    Program.amount = adapter.GetString("จำนวน");
                    Program.price = adapter.GetString("ราคา");
                    Program.user = adapter.GetString("บันทึกโดย");
                    Program.time = adapter.GetString("เวลา");
                    Program.note = adapter.GetString("หมายเหตุ");
                    Class1 item = new Class1()
                    {
                        id = Program.id,
                        name = Program.name,
                        amount = Program.amount,
                        price = Program.price,
                        user = Program.user,
                        time = Program.time,
                        note = Program.note,
                        checkraka = Program.checkraka,
                        checkamount = Program.checkamount

                    };
                    allbook.Add(item);
                }
                
               
            }

            conn.Close();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (Program.checkstatus == "ADMIN")
            {
                showequipment();
                total();
                total_amount();
            }
            else
            {
                showequipmentforuser();
                total();
                total_amount();
                
            }
            
            
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)//ค้นหา
        {
            if (textBox1.Text=="") { 
            if (Program.checkstatus == "ADMIN")
            {
                showequipment2();
                total();
                total_amount();
            }
            else
            {
                showequipmentforuser2();
                total();
                total_amount();
            }
            }
            else
            {

                if (Program.checkstatus == "ADMIN")
                {
                    showequipment();
                    total();
                    total_amount();
                }
                else
                {
                    showequipmentforuser();
                    total();
                    total_amount();

                }
            }
        }
        
    }
}
