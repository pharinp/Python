
namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.user = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.Btn_Login = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Show_pass = new System.Windows.Forms.Button();
            this.Hide_pass = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // user
            // 
            this.user.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.user.BackColor = System.Drawing.SystemColors.Control;
            this.user.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.user.Font = new System.Drawing.Font("Calibri", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.Location = new System.Drawing.Point(278, 310);
            this.user.MaxLength = 20;
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(369, 35);
            this.user.TabIndex = 1;
            this.user.Tag = "";
            this.user.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.user.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.user_KeyPress);
            // 
            // pass
            // 
            this.pass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pass.BackColor = System.Drawing.SystemColors.Control;
            this.pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pass.Font = new System.Drawing.Font("Calibri", 16.8F, System.Drawing.FontStyle.Bold);
            this.pass.Location = new System.Drawing.Point(278, 432);
            this.pass.MaxLength = 15;
            this.pass.Name = "pass";
            this.pass.PasswordChar = '•';
            this.pass.Size = new System.Drawing.Size(369, 35);
            this.pass.TabIndex = 2;
            this.pass.Tag = "";
            this.pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pass_KeyPress);
            // 
            // Btn_Login
            // 
            this.Btn_Login.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_Login.BackColor = System.Drawing.Color.ForestGreen;
            this.Btn_Login.Font = new System.Drawing.Font("WR Tish Kid", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Login.ForeColor = System.Drawing.SystemColors.Window;
            this.Btn_Login.Location = new System.Drawing.Point(331, 509);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(100, 60);
            this.Btn_Login.TabIndex = 3;
            this.Btn_Login.Text = "Login";
            this.Btn_Login.UseVisualStyleBackColor = false;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // Exit
            // 
            this.Exit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Exit.BackColor = System.Drawing.Color.Crimson;
            this.Exit.Font = new System.Drawing.Font("WR Tish Kid", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.SystemColors.Window;
            this.Exit.Location = new System.Drawing.Point(485, 509);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(100, 60);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Font = new System.Drawing.Font("CS ChatThai", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(413, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Font = new System.Drawing.Font("CS ChatThai", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(410, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 36);
            this.label4.TabIndex = 6;
            this.label4.Text = "Username";
            // 
            // Show_pass
            // 
            this.Show_pass.BackColor = System.Drawing.SystemColors.Control;
            this.Show_pass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Show_pass.Image = ((System.Drawing.Image)(resources.GetObject("Show_pass.Image")));
            this.Show_pass.Location = new System.Drawing.Point(607, 432);
            this.Show_pass.Name = "Show_pass";
            this.Show_pass.Size = new System.Drawing.Size(40, 35);
            this.Show_pass.TabIndex = 8;
            this.Show_pass.UseVisualStyleBackColor = false;
            this.Show_pass.Click += new System.EventHandler(this.Show_pass_Click);
            // 
            // Hide_pass
            // 
            this.Hide_pass.BackColor = System.Drawing.Color.White;
            this.Hide_pass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Hide_pass.Image = ((System.Drawing.Image)(resources.GetObject("Hide_pass.Image")));
            this.Hide_pass.Location = new System.Drawing.Point(607, 432);
            this.Hide_pass.Name = "Hide_pass";
            this.Hide_pass.Size = new System.Drawing.Size(40, 35);
            this.Hide_pass.TabIndex = 9;
            this.Hide_pass.UseVisualStyleBackColor = false;
            this.Hide_pass.Click += new System.EventHandler(this.Hide_pass_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("TH SarabunPSK", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(595, 473);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 30);
            this.button1.TabIndex = 10;
            this.button1.Text = "สมัครสมาชิก";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkOrange;
            this.label1.Font = new System.Drawing.Font("TH SarabunPSK", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(613, 509);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 27);
            this.label1.TabIndex = 11;
            this.label1.Text = "ลืมรหัสผ่าน";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(912, 623);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Show_pass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Btn_Login);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.user);
            this.Controls.Add(this.Hide_pass);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Button Btn_Login;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Show_pass;
        private System.Windows.Forms.Button Hide_pass;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

