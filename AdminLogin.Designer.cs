namespace InventoryApp
{
    partial class AdminLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.UnameTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PassTxtBox = new System.Windows.Forms.TextBox();
            this.adminBox = new System.Windows.Forms.CheckBox();
            this.attendantBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(611, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumBlue;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(585, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "LOGIN\r\n";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Blue;
            this.checkBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(585, 258);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(123, 20);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // UnameTxtBox
            // 
            this.UnameTxtBox.Location = new System.Drawing.Point(488, 183);
            this.UnameTxtBox.Name = "UnameTxtBox";
            this.UnameTxtBox.PlaceholderText = "Username";
            this.UnameTxtBox.Size = new System.Drawing.Size(272, 23);
            this.UnameTxtBox.TabIndex = 6;
            this.UnameTxtBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(547, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 41);
            this.label4.TabIndex = 2;
            this.label4.Text = "SHOPRITE";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = global::InventoryApp.Properties.Resources.undraw_shopping_app_flsj;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 532);
            this.panel1.TabIndex = 8;
            // 
            // PassTxtBox
            // 
            this.PassTxtBox.Location = new System.Drawing.Point(488, 229);
            this.PassTxtBox.Name = "PassTxtBox";
            this.PassTxtBox.PlaceholderText = "Password";
            this.PassTxtBox.Size = new System.Drawing.Size(272, 23);
            this.PassTxtBox.TabIndex = 7;
            this.PassTxtBox.UseSystemPasswordChar = true;
            this.PassTxtBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // adminBox
            // 
            this.adminBox.AutoSize = true;
            this.adminBox.BackColor = System.Drawing.Color.Blue;
            this.adminBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.adminBox.ForeColor = System.Drawing.Color.White;
            this.adminBox.Location = new System.Drawing.Point(502, 319);
            this.adminBox.Name = "adminBox";
            this.adminBox.Size = new System.Drawing.Size(108, 20);
            this.adminBox.TabIndex = 9;
            this.adminBox.Text = "Admin Login";
            this.adminBox.UseVisualStyleBackColor = false;
            // 
            // attendantBox
            // 
            this.attendantBox.AutoSize = true;
            this.attendantBox.BackColor = System.Drawing.Color.Blue;
            this.attendantBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.attendantBox.ForeColor = System.Drawing.Color.White;
            this.attendantBox.Location = new System.Drawing.Point(677, 319);
            this.attendantBox.Name = "attendantBox";
            this.attendantBox.Size = new System.Drawing.Size(129, 20);
            this.attendantBox.TabIndex = 10;
            this.attendantBox.Text = "Attendant Login";
            this.attendantBox.UseVisualStyleBackColor = false;
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(878, 532);
            this.Controls.Add(this.attendantBox);
            this.Controls.Add(this.adminBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PassTxtBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.UnameTxtBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminLogin";
            this.Text = "Login";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        //private MaskedTextBox maskedTextBox1;
        //private MaskedTextBox maskedTextBox2;
        private Label label1;
        private Button button1;
        private CheckBox checkBox1;
        private TextBox UnameTxtBox;
        private Label label4;
        private Panel panel1;
        private TextBox PassTxtBox;
        private CheckBox adminBox;
        private CheckBox attendantBox;
    }
}