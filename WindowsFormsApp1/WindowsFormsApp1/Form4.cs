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
    public partial class Form4 : Form
    {
        private MySqlConnection databaseConnection()//เชื่อม database
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=project;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        private void clear()
        {
            
            NameText.Text="";//คำสั่งเคลียร์
            UnitText.Text = "";
            AmountText.Text = "";
            Price_Text_f4.Text = "";
            CommentText_f4.Text = "";
            //OrderText.Focus();//คำสั่งเคลียร์
        }
        private void showequipment()//ฟังก์ชั่นโชว์
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT id AS ลำดับ,name AS ชื่อ,amount AS จำนวน,price AS ราคา,home_user AS บันทึกโดย,edit_user AS แก้ไขโดย,time AS เวลา,comment AS หมายเหตุ FROM home";

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);
            conn.Close();
            DataEquipment_f6.DataSource = ds.Tables[0].DefaultView;
        }
        private void showequipmentforuser()//ฟังก์ชั่นโชว์
        {

            string name = Program.checkname;
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = cmd.CommandText = ("SELECT id AS ลำดับ, name AS ชื่อ, product_unit AS หน่วยการขาย, amount AS จำนวน, unit AS ราคาต่อหน่วย, price AS ราคา, home_user AS บันทึกโดย,edit_user AS แก้ไขโดย, time AS เวลา, comment AS หมายเหตุ FROM home WHERE id ='" + name + "' OR name ='" + name + "' OR product_unit='" + name + "' OR amount='" + name + "' OR unit='" + name + "' OR price='" + name + "' OR home_user='" + name + "' OR edit_user OR time='" + name + "'OR comment='" + name + "' ");

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);
            conn.Close();
            DataEquipment_f6.DataSource = ds.Tables[0].DefaultView;
        }
        public Form4()
        {
            InitializeComponent();
            if (Program.checkstatus == "ADMIN")
            {
                showequipment();
            }
            else
            {
               showequipmentforuser();
            }
            
        }

        private void Btn_submit_Click(object sender, EventArgs e)//เพิ่มข้อมูล
        {

            MySqlConnection conn = databaseConnection();
            
                String sql = "INSERT INTO home(name,unit,amount,product_unit,price,comment,home_user) VALUES('" + NameText.Text + "','" + UnitText.Text + "' ,'" + AmountText.Text + "','กิโลกรัม','" + Price_Text_f4.Text + "','" + CommentText_f4.Text + "','" + Program.checkname + "')";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                conn.Close();
            if (rows > 0)
            {
                MessageBox.Show("เพิ่มข้อมูลสำเร็จ", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
                if (Program.checkstatus=="ADMIN") { 
                    showequipment();//เรียกแสดงข้อมูลใหม่
                }
                else
                {
                    showequipmentforuser();
                }
                }
            
        }

        private void button1_Click(object sender, EventArgs e)//ย้อนกลับไปหน้าหลัก
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
        private void Btn_Total_f4_Click_1(object sender, EventArgs e)//ปุ่มเช็คราคา
        {
            showtxt.Text = "0";
            
            for (int i = 0; i < DataEquipment_f6.Rows.Count; i++)
            {
                showtxt.Text = Convert.ToString(double.Parse(showtxt.Text) + double.Parse(DataEquipment_f6.Rows[i].Cells[3].Value.ToString()));
            }
        }

        private void button2_Click(object sender, EventArgs e)//ไปหน้าอื่นๆ
        {
            Form6 a = new Form6();
            this.Hide();
            a.Show();
        }

        private void AmountText_KeyPress(object sender, KeyPressEventArgs e)//ให้กรอกเฉพาะตัวเลขช่องจำนวน
        {   //ให้กรอกเฉพาะตัวเลข
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void Price_Text_f4_Click(object sender, EventArgs e)//ป๊อบอัพราคารวม
        {
            float Amount = float.Parse(AmountText.Text);
            float Unit = float.Parse(UnitText.Text);
            float sum;
            //float amount = float.Parse(AmountText_f6.Text);
            //PriceText_f6.Text = (amount * unit).ToString();
            if(NameText.Text== "เห็ดขอนขาว")
            {
                sum = Amount * Unit;
                Price_Text_f4.Text = sum.ToString();
            }
            else if(NameText.Text == "เห็ดนางฟ้า")
            {
                sum = Amount * Unit;
                Price_Text_f4.Text = sum.ToString();
            }
            else if (NameText.Text == "เห็ดฟาง")
            {
                sum = Amount * Unit;
                Price_Text_f4.Text = sum.ToString();
            }
            else if (NameText.Text == "เห็ดบด")
            {
                sum = Amount * Unit;
                Price_Text_f4.Text = sum.ToString();
            }
        }

        private void UnitText_Click(object sender, EventArgs e)//ป๊อบอัพราคา/หน่วย
        {
            if (NameText.Text == "เห็ดขอนขาว")
            {
                UnitText.Text = 100.ToString();
            }
            else if (NameText.Text == "เห็ดนางฟ้า")
            {
                
                UnitText.Text = 80.ToString();
            }
            else if (NameText.Text == "เห็ดฟาง")
            {
                
                UnitText.Text = 80.ToString();
            }
            else if (NameText.Text == "เห็ดบด")
            {
                
                UnitText.Text = 150.ToString();
            }
        }

        private void UnitText_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ให้กรอกเฉพาะตัวเลข
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
