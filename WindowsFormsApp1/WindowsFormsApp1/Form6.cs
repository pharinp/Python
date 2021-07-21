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
    public partial class Form6 : Form
    {
        private MySqlConnection databaseConnection()//เชื่อม database
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=project;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        private void showequipment()//ฟังก์ชั่นโชว์
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT id AS ลำดับ, name AS ชื่อ,product_unit AS หน่วยการขาย,amount AS จำนวน,unit AS ราคาต่อหน่วย,price AS ราคา,home_user AS บันทึกโดย,time AS เวลา,comment AS หมายเหตุ FROM home";

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

        public Form6()
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
        private void Btn_Submit_f6_Click(object sender, EventArgs e)//กดเพื่อยืนยัน
        {
           
            if (NameText_f6.Text !=""&& UnitText.Text!=""&& SelectUnit.Text!=""&&AmountText_f6.Text !=""&& PriceText_f6.Text !="")
            {
                MySqlConnection conn = databaseConnection();

                String sql = "INSERT INTO home(name,amount,price,comment,home_user,unit,product_unit) VALUES('" + NameText_f6.Text + "' ,'" + AmountText_f6.Text + "','" + PriceText_f6.Text + "','" + CommentText_f6.Text + "','"+Program.checkname+"','"+ UnitText .Text+ "','"+SelectUnit.Text+"')";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                conn.Close();
                if (rows > 0)
                {
                    MessageBox.Show("เพิ่มข้อมูลสำเร็จ", "Alert");
                    clear();
                    if (Program.checkstatus == "ADMIN") { 
                        showequipment();//เรียกแสดงข้อมูลใหม่
                    }
                    else
                    {
                        showequipmentforuser();
                    }
                }
            }
            else
            {
                MessageBox.Show("กรอกข้อมูลไม่ครบ ", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                clear();
            }
            }
        private void button1_Click(object sender, EventArgs e)//กลับไปหน้าขายของ
        {
            Form4 a = new Form4();
            this.Hide();
            a.Show();
        }
        private void clear()
        {
            NameText_f6.Text = "";//คำสั่งเคลียร์
            UnitText.Text = "";
            AmountText_f6.Text = "";
            PriceText_f6.Text = "";
            CommentText_f6.Text = "";
            //OrderText.Focus();//คำสั่งเคลียร์
        }

        private void Btn_Total_f6_Click(object sender, EventArgs e)//ปุ่มเช็คราคา
        {
            showtxt2.Text = "0";
  
            for (int i = 0; i < DataEquipment_f6.Rows.Count; i++)
            {
                showtxt2.Text = Convert.ToString(double.Parse(showtxt2.Text) + double.Parse(DataEquipment_f6.Rows[i].Cells[5].Value.ToString()));
            }
        }

        private void OrderText_f6_KeyPress(object sender, KeyPressEventArgs e)//ช่องลำดับ
        {
            //ให้กรอกเฉพาะตัวเลข
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        

        private void PriceText_f6_KeyPress(object sender, KeyPressEventArgs e)//ช่องราคา
        {
            //ให้กรอกเฉพาะตัวเลข
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
        private void PriceText_f6_Click(object sender, EventArgs e)
        {
            float unit = float.Parse(UnitText.Text);
            float amount = float.Parse(AmountText_f6.Text);
            PriceText_f6.Text = (amount * unit).ToString();
        }

        private void UnitText_KeyPress(object sender, KeyPressEventArgs e) //ให้กรอกเฉพาะตัวเลขช่องราคา/หน่วย
        {
            //ให้กรอกเฉพาะตัวเลข
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void AmountText_f6_KeyPress(object sender, KeyPressEventArgs e)//ให้กรอกเฉพาะตัวเลขช่องจำนวน
        {
            //ให้กรอกเฉพาะตัวเลข
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
