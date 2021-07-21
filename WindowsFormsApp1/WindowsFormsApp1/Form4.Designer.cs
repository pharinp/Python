
namespace WindowsFormsApp1
{
    partial class Form4
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
            this.NameText = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AmountText = new System.Windows.Forms.TextBox();
            this.Btn_submit = new System.Windows.Forms.Button();
            this.DataEquipment_f6 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.Btn_Total_f4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.CommentText_f4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.showtxt = new System.Windows.Forms.TextBox();
            this.Price_Text_f4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.UnitText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataEquipment_f6)).BeginInit();
            this.SuspendLayout();
            // 
            // NameText
            // 
            this.NameText.Font = new System.Drawing.Font("WR Tish Kid", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameText.FormattingEnabled = true;
            this.NameText.Items.AddRange(new object[] {
            "เห็ดขอนขาว",
            "เห็ดนางฟ้า",
            "เห็ดบด",
            "เห็ดฟาง"});
            this.NameText.Location = new System.Drawing.Point(234, 242);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(371, 39);
            this.NameText.TabIndex = 1;
            this.NameText.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("WR Tish Kid", 16.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(80, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "ชื่อสินค้า";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("WR Tish Kid", 16.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(80, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "จำนวน";
            // 
            // AmountText
            // 
            this.AmountText.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountText.Location = new System.Drawing.Point(234, 366);
            this.AmountText.Name = "AmountText";
            this.AmountText.Size = new System.Drawing.Size(371, 36);
            this.AmountText.TabIndex = 3;
            this.AmountText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AmountText_KeyPress);
            // 
            // Btn_submit
            // 
            this.Btn_submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Btn_submit.Font = new System.Drawing.Font("WR Tish Kid", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_submit.ForeColor = System.Drawing.Color.White;
            this.Btn_submit.Location = new System.Drawing.Point(398, 541);
            this.Btn_submit.Name = "Btn_submit";
            this.Btn_submit.Size = new System.Drawing.Size(123, 70);
            this.Btn_submit.TabIndex = 6;
            this.Btn_submit.Text = "ยืนยัน";
            this.Btn_submit.UseVisualStyleBackColor = false;
            this.Btn_submit.Click += new System.EventHandler(this.Btn_submit_Click);
            // 
            // DataEquipment_f6
            // 
            this.DataEquipment_f6.AllowUserToAddRows = false;
            this.DataEquipment_f6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DataEquipment_f6.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataEquipment_f6.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DataEquipment_f6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataEquipment_f6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataEquipment_f6.Location = new System.Drawing.Point(32, 12);
            this.DataEquipment_f6.Name = "DataEquipment_f6";
            this.DataEquipment_f6.RowHeadersWidth = 51;
            this.DataEquipment_f6.RowTemplate.Height = 24;
            this.DataEquipment_f6.Size = new System.Drawing.Size(850, 202);
            this.DataEquipment_f6.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("WR Tish Kid", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(731, 541);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 70);
            this.button1.TabIndex = 9;
            this.button1.Text = "กลับไป\r\nหน้าแรก";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_Total_f4
            // 
            this.Btn_Total_f4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Btn_Total_f4.Font = new System.Drawing.Font("WR Tish Kid", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Total_f4.ForeColor = System.Drawing.Color.White;
            this.Btn_Total_f4.Location = new System.Drawing.Point(741, 331);
            this.Btn_Total_f4.Name = "Btn_Total_f4";
            this.Btn_Total_f4.Size = new System.Drawing.Size(100, 72);
            this.Btn_Total_f4.TabIndex = 7;
            this.Btn_Total_f4.Text = "กดเพื่อดู\r\nราคารวม";
            this.Btn_Total_f4.UseVisualStyleBackColor = false;
            this.Btn_Total_f4.Click += new System.EventHandler(this.Btn_Total_f4_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Blue;
            this.button2.Font = new System.Drawing.Font("WR Tish Kid", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(568, 541);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 70);
            this.button2.TabIndex = 8;
            this.button2.Text = "อื่นๆ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CommentText_f4
            // 
            this.CommentText_f4.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommentText_f4.Location = new System.Drawing.Point(234, 494);
            this.CommentText_f4.Name = "CommentText_f4";
            this.CommentText_f4.Size = new System.Drawing.Size(371, 36);
            this.CommentText_f4.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("WR Tish Kid", 16.2F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(39, 499);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 32);
            this.label4.TabIndex = 12;
            this.label4.Text = "หมายเหตุ(ถ้ามี)";
            // 
            // showtxt
            // 
            this.showtxt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showtxt.Location = new System.Drawing.Point(664, 293);
            this.showtxt.Name = "showtxt";
            this.showtxt.ReadOnly = true;
            this.showtxt.Size = new System.Drawing.Size(236, 32);
            this.showtxt.TabIndex = 13;
            this.showtxt.Text = "0";
            this.showtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Price_Text_f4
            // 
            this.Price_Text_f4.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price_Text_f4.Location = new System.Drawing.Point(234, 429);
            this.Price_Text_f4.Name = "Price_Text_f4";
            this.Price_Text_f4.ReadOnly = true;
            this.Price_Text_f4.Size = new System.Drawing.Size(371, 36);
            this.Price_Text_f4.TabIndex = 4;
            this.Price_Text_f4.Click += new System.EventHandler(this.Price_Text_f4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("WR Tish Kid", 16.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(66, 434);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 32);
            this.label3.TabIndex = 15;
            this.label3.Text = "ราคา(บาท)";
            // 
            // UnitText
            // 
            this.UnitText.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitText.Location = new System.Drawing.Point(234, 304);
            this.UnitText.Name = "UnitText";
            this.UnitText.Size = new System.Drawing.Size(371, 36);
            this.UnitText.TabIndex = 2;
            this.UnitText.Click += new System.EventHandler(this.UnitText_Click);
            this.UnitText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UnitText_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("WR Tish Kid", 16.2F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(57, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 32);
            this.label5.TabIndex = 17;
            this.label5.Text = "ราคา/หน่วย";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Wallpaper_3840x2160;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(912, 623);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.UnitText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Price_Text_f4);
            this.Controls.Add(this.showtxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CommentText_f4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Btn_Total_f4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DataEquipment_f6);
            this.Controls.Add(this.Btn_submit);
            this.Controls.Add(this.AmountText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameText);
            this.Name = "Form4";
            this.Text = "Add";
            ((System.ComponentModel.ISupportInitialize)(this.DataEquipment_f6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox NameText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AmountText;
        private System.Windows.Forms.Button Btn_submit;
        private System.Windows.Forms.DataGridView DataEquipment_f6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Btn_Total_f4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox CommentText_f4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox showtxt;
        private System.Windows.Forms.TextBox Price_Text_f4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UnitText;
        private System.Windows.Forms.Label label5;
    }
}