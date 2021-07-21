
namespace WindowsFormsApp1
{
    partial class Form10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form10));
            this.Btn_Show = new System.Windows.Forms.Button();
            this.Btn_Home = new System.Windows.Forms.Button();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Show
            // 
            this.Btn_Show.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Btn_Show.Font = new System.Drawing.Font("WR Tish Kid", 16.2F, System.Drawing.FontStyle.Bold);
            this.Btn_Show.Location = new System.Drawing.Point(122, 298);
            this.Btn_Show.Name = "Btn_Show";
            this.Btn_Show.Size = new System.Drawing.Size(136, 86);
            this.Btn_Show.TabIndex = 2;
            this.Btn_Show.Text = "แสดงรายการขาย";
            this.Btn_Show.UseVisualStyleBackColor = false;
            this.Btn_Show.Click += new System.EventHandler(this.Btn_Show_Click);
            // 
            // Btn_Home
            // 
            this.Btn_Home.BackColor = System.Drawing.Color.Aqua;
            this.Btn_Home.Font = new System.Drawing.Font("WR Tish Kid", 16.2F, System.Drawing.FontStyle.Bold);
            this.Btn_Home.Location = new System.Drawing.Point(390, 298);
            this.Btn_Home.Name = "Btn_Home";
            this.Btn_Home.Size = new System.Drawing.Size(136, 86);
            this.Btn_Home.TabIndex = 3;
            this.Btn_Home.Text = "ขายสินค้า";
            this.Btn_Home.UseVisualStyleBackColor = false;
            this.Btn_Home.Click += new System.EventHandler(this.Btn_Home_Click);
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.BackColor = System.Drawing.Color.Red;
            this.Btn_Exit.Font = new System.Drawing.Font("WR Tish Kid", 16.2F, System.Drawing.FontStyle.Bold);
            this.Btn_Exit.Location = new System.Drawing.Point(656, 296);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(136, 88);
            this.Btn_Exit.TabIndex = 5;
            this.Btn_Exit.Text = "ออกจากโปรแกรม";
            this.Btn_Exit.UseVisualStyleBackColor = false;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(912, 623);
            this.Controls.Add(this.Btn_Exit);
            this.Controls.Add(this.Btn_Home);
            this.Controls.Add(this.Btn_Show);
            this.DoubleBuffered = true;
            this.Name = "Form10";
            this.Text = "Form10";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Show;
        private System.Windows.Forms.Button Btn_Home;
        private System.Windows.Forms.Button Btn_Exit;
    }
}