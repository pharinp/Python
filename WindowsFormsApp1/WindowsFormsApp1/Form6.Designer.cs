
namespace WindowsFormsApp1
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.DataEquipment_f6 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NameText_f6 = new System.Windows.Forms.TextBox();
            this.AmountText_f6 = new System.Windows.Forms.TextBox();
            this.PriceText_f6 = new System.Windows.Forms.TextBox();
            this.Btn_Submit_f6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.CommentText_f6 = new System.Windows.Forms.TextBox();
            this.Btn_Total_f6 = new System.Windows.Forms.Button();
            this.showtxt2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.UnitText = new System.Windows.Forms.TextBox();
            this.SelectUnit = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataEquipment_f6)).BeginInit();
            this.SuspendLayout();
            // 
            // DataEquipment_f6
            // 
            this.DataEquipment_f6.AllowUserToAddRows = false;
            this.DataEquipment_f6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DataEquipment_f6.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataEquipment_f6.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DataEquipment_f6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataEquipment_f6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataEquipment_f6.Location = new System.Drawing.Point(12, 12);
            this.DataEquipment_f6.Name = "DataEquipment_f6";
            this.DataEquipment_f6.RowHeadersWidth = 51;
            this.DataEquipment_f6.RowTemplate.Height = 24;
            this.DataEquipment_f6.Size = new System.Drawing.Size(888, 226);
            this.DataEquipment_f6.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("WR Tish Kid", 16.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(77, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "ชื่อสินค้า";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("WR Tish Kid", 16.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(25, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "จำนวนหน่วยขาย";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("WR Tish Kid", 16.2F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(45, 458);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "ราคา(บาท)";
            // 
            // NameText_f6
            // 
            this.NameText_f6.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold);
            this.NameText_f6.Location = new System.Drawing.Point(240, 260);
            this.NameText_f6.Name = "NameText_f6";
            this.NameText_f6.Size = new System.Drawing.Size(320, 36);
            this.NameText_f6.TabIndex = 1;
            // 
            // AmountText_f6
            // 
            this.AmountText_f6.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold);
            this.AmountText_f6.Location = new System.Drawing.Point(240, 385);
            this.AmountText_f6.Name = "AmountText_f6";
            this.AmountText_f6.Size = new System.Drawing.Size(320, 36);
            this.AmountText_f6.TabIndex = 4;
            this.AmountText_f6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AmountText_f6_KeyPress);
            // 
            // PriceText_f6
            // 
            this.PriceText_f6.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold);
            this.PriceText_f6.Location = new System.Drawing.Point(240, 453);
            this.PriceText_f6.Name = "PriceText_f6";
            this.PriceText_f6.ReadOnly = true;
            this.PriceText_f6.Size = new System.Drawing.Size(320, 36);
            this.PriceText_f6.TabIndex = 5;
            this.PriceText_f6.Click += new System.EventHandler(this.PriceText_f6_Click);
            this.PriceText_f6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PriceText_f6_KeyPress);
            // 
            // Btn_Submit_f6
            // 
            this.Btn_Submit_f6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Btn_Submit_f6.Font = new System.Drawing.Font("WR Tish Kid", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Submit_f6.ForeColor = System.Drawing.Color.White;
            this.Btn_Submit_f6.Location = new System.Drawing.Point(581, 523);
            this.Btn_Submit_f6.Name = "Btn_Submit_f6";
            this.Btn_Submit_f6.Size = new System.Drawing.Size(126, 81);
            this.Btn_Submit_f6.TabIndex = 8;
            this.Btn_Submit_f6.Text = "ยืนยัน";
            this.Btn_Submit_f6.UseVisualStyleBackColor = false;
            this.Btn_Submit_f6.Click += new System.EventHandler(this.Btn_Submit_f6_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.Font = new System.Drawing.Font("WR Tish Kid", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(750, 523);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 81);
            this.button1.TabIndex = 9;
            this.button1.Text = "กลับไป\r\nหน้าแรก";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("WR Tish Kid", 16.2F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(25, 523);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "หมายเหตุ(ถ้ามี)";
            // 
            // CommentText_f6
            // 
            this.CommentText_f6.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold);
            this.CommentText_f6.Location = new System.Drawing.Point(240, 519);
            this.CommentText_f6.Name = "CommentText_f6";
            this.CommentText_f6.Size = new System.Drawing.Size(320, 36);
            this.CommentText_f6.TabIndex = 6;
            // 
            // Btn_Total_f6
            // 
            this.Btn_Total_f6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Btn_Total_f6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Btn_Total_f6.Font = new System.Drawing.Font("WR Tish Kid", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Total_f6.ForeColor = System.Drawing.Color.White;
            this.Btn_Total_f6.Location = new System.Drawing.Point(774, 308);
            this.Btn_Total_f6.Name = "Btn_Total_f6";
            this.Btn_Total_f6.Size = new System.Drawing.Size(98, 69);
            this.Btn_Total_f6.TabIndex = 7;
            this.Btn_Total_f6.Text = "กดเพื่อดู\r\nราคารวม";
            this.Btn_Total_f6.UseVisualStyleBackColor = false;
            this.Btn_Total_f6.Click += new System.EventHandler(this.Btn_Total_f6_Click);
            // 
            // showtxt2
            // 
            this.showtxt2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showtxt2.Location = new System.Drawing.Point(661, 262);
            this.showtxt2.Name = "showtxt2";
            this.showtxt2.ReadOnly = true;
            this.showtxt2.Size = new System.Drawing.Size(211, 32);
            this.showtxt2.TabIndex = 21;
            this.showtxt2.Text = "0";
            this.showtxt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("WR Tish Kid", 16.2F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(56, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 32);
            this.label6.TabIndex = 22;
            this.label6.Text = "ราคา/หน่วย";
            // 
            // UnitText
            // 
            this.UnitText.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold);
            this.UnitText.Location = new System.Drawing.Point(240, 321);
            this.UnitText.Name = "UnitText";
            this.UnitText.Size = new System.Drawing.Size(320, 36);
            this.UnitText.TabIndex = 2;
            this.UnitText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UnitText_KeyPress);
            // 
            // SelectUnit
            // 
            this.SelectUnit.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold);
            this.SelectUnit.FormattingEnabled = true;
            this.SelectUnit.Items.AddRange(new object[] {
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
            this.SelectUnit.Location = new System.Drawing.Point(572, 321);
            this.SelectUnit.Name = "SelectUnit";
            this.SelectUnit.Size = new System.Drawing.Size(166, 36);
            this.SelectUnit.TabIndex = 3;
            this.SelectUnit.Text = "หน่วย";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(912, 623);
            this.Controls.Add(this.SelectUnit);
            this.Controls.Add(this.UnitText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.showtxt2);
            this.Controls.Add(this.Btn_Total_f6);
            this.Controls.Add(this.CommentText_f6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Btn_Submit_f6);
            this.Controls.Add(this.PriceText_f6);
            this.Controls.Add(this.AmountText_f6);
            this.Controls.Add(this.NameText_f6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataEquipment_f6);
            this.Name = "Form6";
            this.Text = "Add";
            ((System.ComponentModel.ISupportInitialize)(this.DataEquipment_f6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataEquipment_f6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NameText_f6;
        private System.Windows.Forms.TextBox AmountText_f6;
        private System.Windows.Forms.TextBox PriceText_f6;
        private System.Windows.Forms.Button Btn_Submit_f6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CommentText_f6;
        private System.Windows.Forms.Button Btn_Total_f6;
        private System.Windows.Forms.TextBox showtxt2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox UnitText;
        private System.Windows.Forms.ComboBox SelectUnit;
    }
}