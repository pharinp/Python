
namespace WindowsFormsApp1
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.Btn_Del_f5 = new System.Windows.Forms.Button();
            this.DataEquipment = new System.Windows.Forms.DataGridView();
            this.AmountText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.CommentText = new System.Windows.Forms.TextBox();
            this.Btn_Edit_f5 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.PriceText = new System.Windows.Forms.TextBox();
            this.UnitText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NameText = new System.Windows.Forms.TextBox();
            this.SelectUnit_f5 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataEquipment)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Del_f5
            // 
            this.Btn_Del_f5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Btn_Del_f5.Font = new System.Drawing.Font("WR Tish Kid", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Del_f5.ForeColor = System.Drawing.Color.White;
            this.Btn_Del_f5.Location = new System.Drawing.Point(738, 389);
            this.Btn_Del_f5.Name = "Btn_Del_f5";
            this.Btn_Del_f5.Size = new System.Drawing.Size(136, 86);
            this.Btn_Del_f5.TabIndex = 8;
            this.Btn_Del_f5.Text = "กดยืนยัน\r\nเพื่อลบ";
            this.Btn_Del_f5.UseVisualStyleBackColor = false;
            this.Btn_Del_f5.Click += new System.EventHandler(this.Btn_Del_f5_Click);
            // 
            // DataEquipment
            // 
            this.DataEquipment.AllowUserToAddRows = false;
            this.DataEquipment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataEquipment.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DataEquipment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataEquipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataEquipment.Location = new System.Drawing.Point(12, 12);
            this.DataEquipment.Name = "DataEquipment";
            this.DataEquipment.RowHeadersWidth = 51;
            this.DataEquipment.RowTemplate.Height = 24;
            this.DataEquipment.Size = new System.Drawing.Size(888, 202);
            this.DataEquipment.TabIndex = 0;
            this.DataEquipment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataEquipment_CellContentClick);
            // 
            // AmountText
            // 
            this.AmountText.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold);
            this.AmountText.Location = new System.Drawing.Point(195, 391);
            this.AmountText.Multiline = true;
            this.AmountText.Name = "AmountText";
            this.AmountText.Size = new System.Drawing.Size(371, 39);
            this.AmountText.TabIndex = 4;
            this.AmountText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AmountText_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("WR Tish Kid", 16.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(49, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "จำนวน";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("WR Tish Kid", 16.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(36, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "ชื่อสินค้า";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("WR Tish Kid", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(738, 504);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 86);
            this.button2.TabIndex = 9;
            this.button2.Text = "กลับไป\r\nหน้าแรก";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("WR Tish Kid", 16.2F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(26, 531);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "หมายเหตุ(ถ้ามี)";
            // 
            // CommentText
            // 
            this.CommentText.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold);
            this.CommentText.Location = new System.Drawing.Point(195, 526);
            this.CommentText.Multiline = true;
            this.CommentText.Name = "CommentText";
            this.CommentText.Size = new System.Drawing.Size(371, 39);
            this.CommentText.TabIndex = 6;
            // 
            // Btn_Edit_f5
            // 
            this.Btn_Edit_f5.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Btn_Edit_f5.Font = new System.Drawing.Font("WR Tish Kid", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Edit_f5.ForeColor = System.Drawing.Color.White;
            this.Btn_Edit_f5.Location = new System.Drawing.Point(738, 272);
            this.Btn_Edit_f5.Name = "Btn_Edit_f5";
            this.Btn_Edit_f5.Size = new System.Drawing.Size(136, 86);
            this.Btn_Edit_f5.TabIndex = 7;
            this.Btn_Edit_f5.Text = "กดเพื่อแก้ไข";
            this.Btn_Edit_f5.UseVisualStyleBackColor = false;
            this.Btn_Edit_f5.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("WR Tish Kid", 16.2F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(35, 460);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "ราคา(บาท)";
            // 
            // PriceText
            // 
            this.PriceText.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold);
            this.PriceText.Location = new System.Drawing.Point(195, 455);
            this.PriceText.Multiline = true;
            this.PriceText.Name = "PriceText";
            this.PriceText.Size = new System.Drawing.Size(371, 39);
            this.PriceText.TabIndex = 5;
            this.PriceText.Click += new System.EventHandler(this.PriceText_Click);
            this.PriceText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PriceText_KeyPress);
            // 
            // UnitText
            // 
            this.UnitText.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold);
            this.UnitText.Location = new System.Drawing.Point(195, 322);
            this.UnitText.Multiline = true;
            this.UnitText.Name = "UnitText";
            this.UnitText.Size = new System.Drawing.Size(371, 39);
            this.UnitText.TabIndex = 2;
            this.UnitText.Click += new System.EventHandler(this.Unit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("WR Tish Kid", 16.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(26, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 32);
            this.label3.TabIndex = 10;
            this.label3.Text = "ราคา/หน่วย";
            // 
            // NameText
            // 
            this.NameText.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold);
            this.NameText.Location = new System.Drawing.Point(195, 253);
            this.NameText.Multiline = true;
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(371, 39);
            this.NameText.TabIndex = 1;
            // 
            // SelectUnit_f5
            // 
            this.SelectUnit_f5.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold);
            this.SelectUnit_f5.FormattingEnabled = true;
            this.SelectUnit_f5.Items.AddRange(new object[] {
            "กิโลกรัม",
            "อัน",
            "ลิตร",
            "ถุง",
            "มัด",
            "ก้อน",
            "ลูก",
            "กล่อง",
            "โหล",
            "แพ็ค",
            "หวี",
            "ฟอง",
            "กระสอบ"});
            this.SelectUnit_f5.Location = new System.Drawing.Point(572, 325);
            this.SelectUnit_f5.Name = "SelectUnit_f5";
            this.SelectUnit_f5.Size = new System.Drawing.Size(120, 36);
            this.SelectUnit_f5.TabIndex = 3;
            this.SelectUnit_f5.Text = "หน่วย";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(912, 623);
            this.Controls.Add(this.SelectUnit_f5);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UnitText);
            this.Controls.Add(this.PriceText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Btn_Edit_f5);
            this.Controls.Add(this.CommentText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Btn_Del_f5);
            this.Controls.Add(this.DataEquipment);
            this.Controls.Add(this.AmountText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Edit";
            ((System.ComponentModel.ISupportInitialize)(this.DataEquipment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Del_f5;
        private System.Windows.Forms.DataGridView DataEquipment;
        private System.Windows.Forms.TextBox AmountText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CommentText;
        private System.Windows.Forms.Button Btn_Edit_f5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PriceText;
        private System.Windows.Forms.TextBox UnitText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.ComboBox SelectUnit_f5;
    }
}