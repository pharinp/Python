
namespace WindowsFormsApp1
{
    partial class Form9
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
            this.PassText_f9 = new System.Windows.Forms.TextBox();
            this.ConPassText_f9 = new System.Windows.Forms.TextBox();
            this.Btn_Changpass_f9 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PassText_f9
            // 
            this.PassText_f9.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassText_f9.Location = new System.Drawing.Point(278, 123);
            this.PassText_f9.MaxLength = 15;
            this.PassText_f9.Name = "PassText_f9";
            this.PassText_f9.PasswordChar = '•';
            this.PassText_f9.Size = new System.Drawing.Size(369, 36);
            this.PassText_f9.TabIndex = 3;
            this.PassText_f9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PassText_f9_KeyPress);
            // 
            // ConPassText_f9
            // 
            this.ConPassText_f9.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConPassText_f9.Location = new System.Drawing.Point(278, 186);
            this.ConPassText_f9.MaxLength = 15;
            this.ConPassText_f9.Name = "ConPassText_f9";
            this.ConPassText_f9.PasswordChar = '•';
            this.ConPassText_f9.Size = new System.Drawing.Size(369, 36);
            this.ConPassText_f9.TabIndex = 4;
            this.ConPassText_f9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ConPassText_f9_KeyPress);
            // 
            // Btn_Changpass_f9
            // 
            this.Btn_Changpass_f9.BackColor = System.Drawing.Color.Green;
            this.Btn_Changpass_f9.Font = new System.Drawing.Font("WR Tish Kid", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Changpass_f9.ForeColor = System.Drawing.Color.White;
            this.Btn_Changpass_f9.Location = new System.Drawing.Point(406, 249);
            this.Btn_Changpass_f9.Name = "Btn_Changpass_f9";
            this.Btn_Changpass_f9.Size = new System.Drawing.Size(117, 39);
            this.Btn_Changpass_f9.TabIndex = 10;
            this.Btn_Changpass_f9.Text = "เปลี่ยนรหัส";
            this.Btn_Changpass_f9.UseVisualStyleBackColor = false;
            this.Btn_Changpass_f9.Click += new System.EventHandler(this.Btn_Changpass_f9_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("WR Tish Kid", 16.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(23, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "กรอกรหัสผ่านใหม่อีกครั้ง";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("WR Tish Kid", 16.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(73, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 32);
            this.label2.TabIndex = 12;
            this.label2.Text = "กรอกรหัสผ่านใหม่";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("WR Tish Kid", 16.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(87, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 32);
            this.label3.TabIndex = 13;
            this.label3.Text = "ชื่อผู้ใช้ของคุณ คือ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(286, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 29);
            this.label4.TabIndex = 14;
            this.label4.Text = "??";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.Btn_Changpass_f9);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ConPassText_f9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.PassText_f9);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("WR Tish Kid", 16.2F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(34, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(684, 333);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "กรุณากรอกรหัสผ่านใหม่";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("WR Tish Kid", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(544, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 39);
            this.button1.TabIndex = 15;
            this.button1.Text = "ยกเลิก";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(750, 376);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form9";
            this.Text = "Form9";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox PassText_f9;
        private System.Windows.Forms.TextBox ConPassText_f9;
        private System.Windows.Forms.Button Btn_Changpass_f9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
    }
}