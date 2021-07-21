
namespace WindowsFormsApp1
{
    partial class Form11
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SearchBtn = new System.Windows.Forms.Button();
            this.SearchMember = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DataEquipmentmember = new System.Windows.Forms.DataGridView();
            this.UserText_f11 = new System.Windows.Forms.TextBox();
            this.PassText_f11 = new System.Windows.Forms.TextBox();
            this.NameText_f11 = new System.Windows.Forms.TextBox();
            this.LastnameText_f11 = new System.Windows.Forms.TextBox();
            this.EmailText_f11 = new System.Windows.Forms.TextBox();
            this.PhoneText_f11 = new System.Windows.Forms.TextBox();
            this.StatusText_f11 = new System.Windows.Forms.TextBox();
            this.AddressText_f11 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Btn_Delete_f11 = new System.Windows.Forms.Button();
            this.Btn_Edit_f11 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataEquipmentmember)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.Color.Cyan;
            this.SearchBtn.Font = new System.Drawing.Font("WR Tish Kid", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.ForeColor = System.Drawing.Color.Black;
            this.SearchBtn.Location = new System.Drawing.Point(334, 45);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(76, 39);
            this.SearchBtn.TabIndex = 14;
            this.SearchBtn.Text = "ค้นหา";
            this.SearchBtn.UseVisualStyleBackColor = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // SearchMember
            // 
            this.SearchMember.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold);
            this.SearchMember.Location = new System.Drawing.Point(26, 48);
            this.SearchMember.Name = "SearchMember";
            this.SearchMember.Size = new System.Drawing.Size(302, 36);
            this.SearchMember.TabIndex = 13;
            this.SearchMember.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SearchMember_KeyUp);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.Font = new System.Drawing.Font("WR Tish Kid", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(931, 532);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 66);
            this.button1.TabIndex = 12;
            this.button1.Text = "กลับไป\r\nหน้าแรก";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("WR Tish Kid", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(416, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 54);
            this.label1.TabIndex = 10;
            this.label1.Text = "แก้ไขข้อมูลสมาชิก";
            // 
            // DataEquipmentmember
            // 
            this.DataEquipmentmember.AllowUserToAddRows = false;
            this.DataEquipmentmember.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataEquipmentmember.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DataEquipmentmember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataEquipmentmember.Location = new System.Drawing.Point(26, 86);
            this.DataEquipmentmember.Name = "DataEquipmentmember";
            this.DataEquipmentmember.RowHeadersWidth = 51;
            this.DataEquipmentmember.RowTemplate.Height = 24;
            this.DataEquipmentmember.Size = new System.Drawing.Size(1006, 147);
            this.DataEquipmentmember.TabIndex = 11;
            this.DataEquipmentmember.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataEquipmentmember_CellClick);
            // 
            // UserText_f11
            // 
            this.UserText_f11.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold);
            this.UserText_f11.Location = new System.Drawing.Point(151, 269);
            this.UserText_f11.MaxLength = 35;
            this.UserText_f11.Multiline = true;
            this.UserText_f11.Name = "UserText_f11";
            this.UserText_f11.Size = new System.Drawing.Size(369, 36);
            this.UserText_f11.TabIndex = 15;
            this.UserText_f11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PassText_f11
            // 
            this.PassText_f11.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold);
            this.PassText_f11.Location = new System.Drawing.Point(151, 335);
            this.PassText_f11.MaxLength = 15;
            this.PassText_f11.Multiline = true;
            this.PassText_f11.Name = "PassText_f11";
            this.PassText_f11.Size = new System.Drawing.Size(369, 36);
            this.PassText_f11.TabIndex = 16;
            this.PassText_f11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NameText_f11
            // 
            this.NameText_f11.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold);
            this.NameText_f11.Location = new System.Drawing.Point(151, 403);
            this.NameText_f11.Multiline = true;
            this.NameText_f11.Name = "NameText_f11";
            this.NameText_f11.Size = new System.Drawing.Size(369, 36);
            this.NameText_f11.TabIndex = 17;
            this.NameText_f11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LastnameText_f11
            // 
            this.LastnameText_f11.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold);
            this.LastnameText_f11.Location = new System.Drawing.Point(151, 472);
            this.LastnameText_f11.Multiline = true;
            this.LastnameText_f11.Name = "LastnameText_f11";
            this.LastnameText_f11.Size = new System.Drawing.Size(369, 36);
            this.LastnameText_f11.TabIndex = 18;
            this.LastnameText_f11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EmailText_f11
            // 
            this.EmailText_f11.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold);
            this.EmailText_f11.Location = new System.Drawing.Point(643, 269);
            this.EmailText_f11.Multiline = true;
            this.EmailText_f11.Name = "EmailText_f11";
            this.EmailText_f11.Size = new System.Drawing.Size(369, 36);
            this.EmailText_f11.TabIndex = 19;
            this.EmailText_f11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PhoneText_f11
            // 
            this.PhoneText_f11.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold);
            this.PhoneText_f11.Location = new System.Drawing.Point(643, 335);
            this.PhoneText_f11.MaxLength = 10;
            this.PhoneText_f11.Multiline = true;
            this.PhoneText_f11.Name = "PhoneText_f11";
            this.PhoneText_f11.Size = new System.Drawing.Size(369, 36);
            this.PhoneText_f11.TabIndex = 20;
            this.PhoneText_f11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StatusText_f11
            // 
            this.StatusText_f11.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold);
            this.StatusText_f11.Location = new System.Drawing.Point(643, 472);
            this.StatusText_f11.Multiline = true;
            this.StatusText_f11.Name = "StatusText_f11";
            this.StatusText_f11.Size = new System.Drawing.Size(369, 36);
            this.StatusText_f11.TabIndex = 21;
            this.StatusText_f11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddressText_f11
            // 
            this.AddressText_f11.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold);
            this.AddressText_f11.Location = new System.Drawing.Point(643, 403);
            this.AddressText_f11.Multiline = true;
            this.AddressText_f11.Name = "AddressText_f11";
            this.AddressText_f11.Size = new System.Drawing.Size(369, 36);
            this.AddressText_f11.TabIndex = 22;
            this.AddressText_f11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(21, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 29);
            this.label3.TabIndex = 23;
            this.label3.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(20, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 29);
            this.label2.TabIndex = 24;
            this.label2.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(37, 406);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 29);
            this.label4.TabIndex = 25;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(21, 477);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 29);
            this.label5.TabIndex = 26;
            this.label5.Text = "Lastname";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(548, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 29);
            this.label6.TabIndex = 27;
            this.label6.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(548, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 29);
            this.label7.TabIndex = 28;
            this.label7.Text = "Phone";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(548, 406);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 29);
            this.label8.TabIndex = 29;
            this.label8.Text = "Address";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(548, 477);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 29);
            this.label9.TabIndex = 30;
            this.label9.Text = "Status";
            // 
            // Btn_Delete_f11
            // 
            this.Btn_Delete_f11.BackColor = System.Drawing.Color.Red;
            this.Btn_Delete_f11.Font = new System.Drawing.Font("WR Tish Kid", 13.8F, System.Drawing.FontStyle.Bold);
            this.Btn_Delete_f11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Delete_f11.Location = new System.Drawing.Point(585, 532);
            this.Btn_Delete_f11.Name = "Btn_Delete_f11";
            this.Btn_Delete_f11.Size = new System.Drawing.Size(110, 66);
            this.Btn_Delete_f11.TabIndex = 31;
            this.Btn_Delete_f11.Text = "ลบข้อมูล";
            this.Btn_Delete_f11.UseVisualStyleBackColor = false;
            this.Btn_Delete_f11.Click += new System.EventHandler(this.Btn_Delete_f11_Click);
            // 
            // Btn_Edit_f11
            // 
            this.Btn_Edit_f11.BackColor = System.Drawing.Color.Green;
            this.Btn_Edit_f11.Font = new System.Drawing.Font("WR Tish Kid", 13.8F, System.Drawing.FontStyle.Bold);
            this.Btn_Edit_f11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Edit_f11.Location = new System.Drawing.Point(448, 532);
            this.Btn_Edit_f11.Name = "Btn_Edit_f11";
            this.Btn_Edit_f11.Size = new System.Drawing.Size(110, 66);
            this.Btn_Edit_f11.TabIndex = 32;
            this.Btn_Edit_f11.Text = "แก้ไขข้อมูล";
            this.Btn_Edit_f11.UseVisualStyleBackColor = false;
            this.Btn_Edit_f11.Click += new System.EventHandler(this.Btn_Edit_f11_Click_1);
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1062, 623);
            this.Controls.Add(this.Btn_Edit_f11);
            this.Controls.Add(this.Btn_Delete_f11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddressText_f11);
            this.Controls.Add(this.StatusText_f11);
            this.Controls.Add(this.PhoneText_f11);
            this.Controls.Add(this.EmailText_f11);
            this.Controls.Add(this.LastnameText_f11);
            this.Controls.Add(this.NameText_f11);
            this.Controls.Add(this.PassText_f11);
            this.Controls.Add(this.UserText_f11);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.SearchMember);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataEquipmentmember);
            this.Controls.Add(this.label8);
            this.Name = "Form11";
            this.Text = "Form11";
            ((System.ComponentModel.ISupportInitialize)(this.DataEquipmentmember)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox SearchMember;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DataEquipmentmember;
        private System.Windows.Forms.TextBox UserText_f11;
        private System.Windows.Forms.TextBox PassText_f11;
        private System.Windows.Forms.TextBox NameText_f11;
        private System.Windows.Forms.TextBox LastnameText_f11;
        private System.Windows.Forms.TextBox EmailText_f11;
        private System.Windows.Forms.TextBox PhoneText_f11;
        private System.Windows.Forms.TextBox StatusText_f11;
        private System.Windows.Forms.TextBox AddressText_f11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Btn_Delete_f11;
        private System.Windows.Forms.Button Btn_Edit_f11;
    }
}