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
    public partial class Form11 : Form
    {
        private MySqlConnection databaseConnection()//เชื่อม database
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=project;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        private void clear_f11()
        {
            UserText_f11.Text = "";//คำสั่งเคลียร์
            PassText_f11.Text = "";//คำสั่งเคลียร์
            NameText_f11.Text = "";
            LastnameText_f11.Text = "";
            EmailText_f11.Text = "";
            PhoneText_f11.Text = "";//คำสั่งเคลียร์
            StatusText_f11.Text = "";//คำสั่งเคลียร์
            AddressText_f11.Text = "";
            //OrderText.Focus();//คำสั่งเคลียร์
        }
        private void showmember()//โชว์ข้อมูลสมาชิก
        {
            string name = SearchMember.Text;
            if (SearchMember.Text == "") {
                MySqlConnection conn = databaseConnection();
                DataSet ds = new DataSet();
                conn.Open();

                MySqlCommand cmd;

                cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT member_id AS ID,member_user AS User,member_password AS Password,member_name AS Name,member_lastname AS Lastname,member_email AS Email,member_phone AS Phone,member_address AS Address,member_status AS Status,member_date AS Date FROM members";


                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(ds);
                conn.Close();
                DataEquipmentmember.DataSource = ds.Tables[0].DefaultView;
            }
            else
            {
                MySqlConnection conn = databaseConnection();
                DataSet ds = new DataSet();
                conn.Open();

                MySqlCommand cmd;

                cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT member_id AS ID,member_user AS User ,member_password AS Password,member_name AS Name,member_lastname AS Lastname,member_email AS Email,member_phone AS Phone,member_address AS Address,member_status AS Status,member_date AS Date FROM members WHERE member_user LIKE'%" + name+ "%' OR member_password LIKE'%" + name + "%' OR member_name LIKE'%" + name + "%' OR member_lastname LIKE'%" + name + "%' OR member_email LIKE'%" + name + "%' OR member_phone LIKE'%" + name + "%'OR member_address LIKE'%" + name + "%' OR member_status LIKE'%" + name + "%' OR member_date LIKE'%"+name+"%' ";


                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(ds);
                conn.Close();
                DataEquipmentmember.DataSource = ds.Tables[0].DefaultView;
            }
        }
        public Form11()
        {
            InitializeComponent();
            showmember();
        }

        private void button1_Click(object sender, EventArgs e)//ย้อนกลับไปหน้าแรก
        {

            Form2 a = new Form2();
            this.Hide();
            a.Show();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            showmember();
        }

        private void DataEquipmentmember_CellClick(object sender, DataGridViewCellEventArgs e)//นำข้อมูลไปใส่Text
        {
            DataEquipmentmember.CurrentRow.Selected = true;
            UserText_f11.Text = DataEquipmentmember.Rows[e.RowIndex].Cells["User"].FormattedValue.ToString();
            PassText_f11.Text = DataEquipmentmember.Rows[e.RowIndex].Cells["Password"].FormattedValue.ToString();
            NameText_f11.Text = DataEquipmentmember.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
            LastnameText_f11.Text = DataEquipmentmember.Rows[e.RowIndex].Cells["Lastname"].FormattedValue.ToString();
            EmailText_f11.Text = DataEquipmentmember.Rows[e.RowIndex].Cells["Email"].FormattedValue.ToString();
            PhoneText_f11.Text = DataEquipmentmember.Rows[e.RowIndex].Cells["Phone"].FormattedValue.ToString();
            StatusText_f11.Text = DataEquipmentmember.Rows[e.RowIndex].Cells["Status"].FormattedValue.ToString();
            AddressText_f11.Text = DataEquipmentmember.Rows[e.RowIndex].Cells["Address"].FormattedValue.ToString();

        }
        private void Btn_Edit_f11_Click_1(object sender, EventArgs e)//ปุ่มแก้ไข
        {

            if (UserText_f11.Text != "" && PassText_f11.Text != "" && NameText_f11.Text != "" && LastnameText_f11.Text != "" && EmailText_f11.Text != "" && PhoneText_f11.Text != "" && StatusText_f11.Text != "" && AddressText_f11.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show("คุณต้องการแก้ไขข้อมูลใช่หรือไม่", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);//เงื่อนไงปุ่มลบ
                if (dialogResult == DialogResult.Yes)
                {

                    int selectRow = DataEquipmentmember.CurrentCell.RowIndex;
                    int editId = Convert.ToInt32(DataEquipmentmember.Rows[selectRow].Cells["ID"].Value);

                    MySqlConnection conn = databaseConnection();

                    string sql = "UPDATE members SET member_user='" + UserText_f11.Text + "',member_password='" + PassText_f11.Text + "',member_name='" + NameText_f11.Text + "',member_lastname='" + LastnameText_f11.Text + "',member_email='" + EmailText_f11.Text + "',member_phone='" + PhoneText_f11.Text + "',member_address='" + AddressText_f11.Text + "',	member_status='" + StatusText_f11.Text + "' WHERE member_id ='" + editId + "'";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    conn.Open();

                    int rows = cmd.ExecuteNonQuery();
                    conn.Close();

                    if (rows > 0)
                    {
                        MessageBox.Show("แก้ไขข้อมูลสำเร็จ", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        showmember();
                        clear_f11();
                    }
                }
                else
                { }
            }
            else
            {
                MessageBox.Show("กรอกข้อมูลไม่ครบ ", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                clear_f11();
            }
        }

        private void Btn_Delete_f11_Click(object sender, EventArgs e)//ปุ่มลบ
        {
            if (UserText_f11.Text != "" && PassText_f11.Text != "" && NameText_f11.Text != "" && LastnameText_f11.Text != "" && EmailText_f11.Text != "" && PhoneText_f11.Text != "" && StatusText_f11.Text != "" && AddressText_f11.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show("คุณต้องการลบข้อมูลใช่หรือไม่", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);//เงื่อนไงปุ่มลบ
                if (dialogResult == DialogResult.Yes)
                {

                    int selectRow = DataEquipmentmember.CurrentCell.RowIndex;
                    int deleteId = Convert.ToInt32(DataEquipmentmember.Rows[selectRow].Cells["ID"].Value);

                    MySqlConnection conn = databaseConnection();

                    string sql = "DELETE FROM members WHERE member_id='" + deleteId + "'";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    conn.Open();

                    int rows = cmd.ExecuteNonQuery();
                    conn.Close();

                    if (rows > 0)
                    {
                        MessageBox.Show("ลบข้อมูลสำเร็จ", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        showmember();
                        clear_f11();
                    }
                }
                else
                { }
            }
            else
            {
                MessageBox.Show("กรอกข้อมูลไม่ครบ ", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                clear_f11();
            }
        }

        private void SearchMember_KeyUp(object sender, KeyEventArgs e)//ค้นหา
        {
            showmember();
        }
    }
}
