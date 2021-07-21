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
    public partial class Form5 : Form
    {
        private MySqlConnection databaseConnection()//เชื่อม database
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=project;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        private void clear()
        {
            NameText.Text = "";//คำสั่งเคลียร์
            UnitText.Text = "";
            SelectUnit_f5.Text = "";
            AmountText.Text = "";
            PriceText.Text = "";
            CommentText.Text = "";
            //OrderText.Focus();//คำสั่งเคลียร์
        }
        private void showequipment()//ฟังก์ชั่นโชว์
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT id AS ลำดับ,name AS ชื่อ,product_unit AS หน่วยขาย,unit AS ราคาต่อหน่วย,amount AS จำนวน,price AS ราคา,home_user AS บันทึกโดย,edit_user AS แก้ไขโดย,time AS เวลา,comment AS หมายเหตุ FROM home";

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);
            conn.Close();
            DataEquipment.DataSource = ds.Tables[0].DefaultView;
        }
        public Form5()
        {
            InitializeComponent();
            showequipment();
        }
        private void button1_Click(object sender, EventArgs e)//ปุ่มแก้ไข
        {
            if ( NameText.Text != "" && AmountText.Text != "" && PriceText.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show("คุณต้องการแก้ไขข้อมูลใช่หรือไม่", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);//เงื่อนไงปุ่มลบ
                if (dialogResult == DialogResult.Yes)
                {

                    int selectRow = DataEquipment.CurrentCell.RowIndex;
                    int editId = Convert.ToInt32(DataEquipment.Rows[selectRow].Cells["ลำดับ"].Value);

                    MySqlConnection conn = databaseConnection();

                    string sql = "UPDATE home SET name='" + NameText.Text + "',product_unit='"+ SelectUnit_f5 .Text+ "',unit='" + UnitText .Text+ "',amount='" + AmountText.Text + "',comment='" + CommentText.Text + "',price='" + PriceText.Text + "',edit_user='แก้ไขโดย "+Program.checkname+ "' WHERE id ='" + editId + "'";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    conn.Open();

                    int rows = cmd.ExecuteNonQuery();
                    conn.Close();

                    if (rows > 0)
                    {
                        MessageBox.Show("แก้ไขข้อมูลสำเร็จ", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        showequipment();
                        clear();
                    }
                }
                else
                { }
            }
            else
            {
                MessageBox.Show("กรอกข้อมูลไม่ครบ ", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                clear();
            }
        }
        private void DataEquipment_CellContentClick(object sender, DataGridViewCellEventArgs e)//นำข้อมูลไปใส่ text
        {
            DataEquipment.CurrentRow.Selected = true;
            NameText.Text = DataEquipment.Rows[e.RowIndex].Cells["ชื่อ"].FormattedValue.ToString();
            AmountText.Text = DataEquipment.Rows[e.RowIndex].Cells["จำนวน"].FormattedValue.ToString();
            PriceText.Text = DataEquipment.Rows[e.RowIndex].Cells["ราคา"].FormattedValue.ToString();
            CommentText.Text = DataEquipment.Rows[e.RowIndex].Cells["หมายเหตุ"].FormattedValue.ToString();
        }

        private void button2_Click(object sender, EventArgs e)//ปุ่มย้อนกลับไปหน้าหลัก
        {
            Form2 a = new Form2();
            this.Hide();
            a.Show();
        }

        private void Btn_Del_f5_Click(object sender, EventArgs e)//ปุ่มลบ
        {
            if (NameText.Text != "" && AmountText.Text != "" && PriceText.Text != "")//เงื่อนไงเช็ค TextBoxว่ามีค่าว่างไหม
            {
                DialogResult dialogResult = MessageBox.Show("คุณต้องการลบข้อมูลใช่หรือไม่??", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);//เงื่อนไงปุ่มลบ
                if (dialogResult == DialogResult.Yes)
                {
                    int selectRow = DataEquipment.CurrentCell.RowIndex;
                    int deleteId = Convert.ToInt32(DataEquipment.Rows[selectRow].Cells["ลำดับ"].Value);

                    MySqlConnection conn = databaseConnection();

                    string sql = "DELETE FROM home WHERE id='" + deleteId + "'";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    conn.Open();

                    int rows = cmd.ExecuteNonQuery();
                    conn.Close();

                    if (rows > 0)
                    {
                        MessageBox.Show("ลบข้อมูลสำเร็จ", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        showequipment();
                        clear();
                    }
                }
                else
                {  }
            }
            else
            {
                MessageBox.Show("กรอกข้อมูลไม่ครบ ", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                clear();
            }
            
 
        }

        private void OrderText_KeyPress(object sender, KeyPressEventArgs e)
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

        private void AmountText_KeyPress(object sender, KeyPressEventArgs e)
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
        private void PriceText_KeyPress(object sender, KeyPressEventArgs e)
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
        private void Unit_Click(object sender, EventArgs e)
        {
            float Amount = float.Parse(AmountText.Text);
            float sum;
            //float amount = float.Parse(AmountText_f6.Text);
            //PriceText_f6.Text = (amount * unit).ToString();
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
        }//ป๊อบอัพจำนวน

        private void PriceText_Click(object sender, EventArgs e)//ป๊อบอัพราคา
        {
            float unit = float.Parse(UnitText.Text);
            float amount = float.Parse(AmountText.Text);
            PriceText.Text = (amount * unit).ToString();
        }
    }
}
