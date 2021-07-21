
namespace WindowsFormsApp1
{
    partial class Form8
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
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txtVerCode_f7 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_Code_f8 = new System.Windows.Forms.Button();
            this.Btn_Send_f8 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Email
            // 
            this.txt_Email.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.Location = new System.Drawing.Point(159, 109);
            this.txt_Email.MaxLength = 35;
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(369, 36);
            this.txt_Email.TabIndex = 2;
            this.txt_Email.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Email_KeyPress);
            // 
            // txtVerCode_f7
            // 
            this.txtVerCode_f7.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold);
            this.txtVerCode_f7.Location = new System.Drawing.Point(264, 240);
            this.txtVerCode_f7.Name = "txtVerCode_f7";
            this.txtVerCode_f7.Size = new System.Drawing.Size(264, 36);
            this.txtVerCode_f7.TabIndex = 5;
            this.txtVerCode_f7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVerCode_f7_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(152, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 35);
            this.label1.TabIndex = 6;
            this.label1.Text = "OTP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 35);
            this.label3.TabIndex = 7;
            this.label3.Text = "Email";
            // 
            // Btn_Code_f8
            // 
            this.Btn_Code_f8.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Btn_Code_f8.Font = new System.Drawing.Font("WR Tish Kid", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Code_f8.ForeColor = System.Drawing.Color.White;
            this.Btn_Code_f8.Location = new System.Drawing.Point(371, 151);
            this.Btn_Code_f8.Name = "Btn_Code_f8";
            this.Btn_Code_f8.Size = new System.Drawing.Size(157, 39);
            this.Btn_Code_f8.TabIndex = 8;
            this.Btn_Code_f8.Text = "รับรหัส OTP";
            this.Btn_Code_f8.UseVisualStyleBackColor = false;
            this.Btn_Code_f8.Click += new System.EventHandler(this.Btn_Code_f8_Click);
            // 
            // Btn_Send_f8
            // 
            this.Btn_Send_f8.BackColor = System.Drawing.Color.Orange;
            this.Btn_Send_f8.Font = new System.Drawing.Font("WR Tish Kid", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Send_f8.ForeColor = System.Drawing.Color.White;
            this.Btn_Send_f8.Location = new System.Drawing.Point(411, 282);
            this.Btn_Send_f8.Name = "Btn_Send_f8";
            this.Btn_Send_f8.Size = new System.Drawing.Size(117, 39);
            this.Btn_Send_f8.TabIndex = 9;
            this.Btn_Send_f8.Text = "ตรวจสอบ";
            this.Btn_Send_f8.UseVisualStyleBackColor = false;
            this.Btn_Send_f8.Click += new System.EventHandler(this.Btn_Send_f8_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("WR Tish Kid", 16.2F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(35, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(606, 370);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ลืมรหัสผ่าน";
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(676, 423);
            this.Controls.Add(this.Btn_Send_f8);
            this.Controls.Add(this.Btn_Code_f8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtVerCode_f7);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form8";
            this.Text = "Form8";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txtVerCode_f7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_Code_f8;
        private System.Windows.Forms.Button Btn_Send_f8;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}