namespace Shoprite_inventory_system
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label_user = new System.Windows.Forms.Label();
            this.label_Uname = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.comboBox_user = new System.Windows.Forms.ComboBox();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.textBox_pass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_clear = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_exit = new System.Windows.Forms.Label();
            this.Button_login = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_user
            // 
            this.label_user.AutoSize = true;
            this.label_user.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_user.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_user.Location = new System.Drawing.Point(129, 230);
            this.label_user.Name = "label_user";
            this.label_user.Size = new System.Drawing.Size(40, 17);
            this.label_user.TabIndex = 0;
            this.label_user.Text = "User";
            // 
            // label_Uname
            // 
            this.label_Uname.AutoSize = true;
            this.label_Uname.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Uname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_Uname.Location = new System.Drawing.Point(95, 279);
            this.label_Uname.Name = "label_Uname";
            this.label_Uname.Size = new System.Drawing.Size(78, 17);
            this.label_Uname.TabIndex = 1;
            this.label_Uname.Text = "UserName";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_password.Location = new System.Drawing.Point(102, 327);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(70, 17);
            this.label_password.TabIndex = 2;
            this.label_password.Text = "Password";
            this.label_password.Click += new System.EventHandler(this.label_password_Click);
            // 
            // comboBox_user
            // 
            this.comboBox_user.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_user.ForeColor = System.Drawing.SystemColors.InfoText;
            this.comboBox_user.FormattingEnabled = true;
            this.comboBox_user.Items.AddRange(new object[] {
            "Admin",
            "Manager",
            "Cashier"});
            this.comboBox_user.Location = new System.Drawing.Point(176, 227);
            this.comboBox_user.Name = "comboBox_user";
            this.comboBox_user.Size = new System.Drawing.Size(121, 22);
            this.comboBox_user.TabIndex = 3;
            this.comboBox_user.Text = "Choose--";
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new System.Drawing.Point(176, 277);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(130, 20);
            this.textBox_username.TabIndex = 4;
            // 
            // textBox_pass
            // 
            this.textBox_pass.Location = new System.Drawing.Point(176, 326);
            this.textBox_pass.Name = "textBox_pass";
            this.textBox_pass.Size = new System.Drawing.Size(130, 20);
            this.textBox_pass.TabIndex = 5;
            this.textBox_pass.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(191, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "LOGIN";
            // 
            // label_clear
            // 
            this.label_clear.AutoSize = true;
            this.label_clear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_clear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_clear.Location = new System.Drawing.Point(197, 452);
            this.label_clear.Name = "label_clear";
            this.label_clear.Size = new System.Drawing.Size(46, 19);
            this.label_clear.TabIndex = 8;
            this.label_clear.Text = "Clear";
            this.label_clear.Click += new System.EventHandler(this.label_clear_Click);
            this.label_clear.MouseEnter += new System.EventHandler(this.label_clear_MouseEnter);
            this.label_clear.MouseLeave += new System.EventHandler(this.label_clear_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-22, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(464, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label_exit
            // 
            this.label_exit.AutoSize = true;
            this.label_exit.BackColor = System.Drawing.Color.Firebrick;
            this.label_exit.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_exit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label_exit.Location = new System.Drawing.Point(408, 0);
            this.label_exit.Name = "label_exit";
            this.label_exit.Size = new System.Drawing.Size(34, 33);
            this.label_exit.TabIndex = 10;
            this.label_exit.Text = "X";
            this.label_exit.Click += new System.EventHandler(this.label_exit_Click);
            this.label_exit.MouseEnter += new System.EventHandler(this.label_exit_MouseEnter);
            this.label_exit.MouseLeave += new System.EventHandler(this.label_exit_MouseLeave);
            // 
            // Button_login
            // 
            this.Button_login.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_login.FillColor = System.Drawing.Color.Firebrick;
            this.Button_login.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_login.ForeColor = System.Drawing.Color.White;
            this.Button_login.Location = new System.Drawing.Point(176, 408);
            this.Button_login.Name = "Button_login";
            this.Button_login.Size = new System.Drawing.Size(93, 31);
            this.Button_login.TabIndex = 11;
            this.Button_login.Text = "Login";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 580);
            this.Controls.Add(this.Button_login);
            this.Controls.Add(this.label_exit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_clear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_pass);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.comboBox_user);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_Uname);
            this.Controls.Add(this.label_user);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_user;
        private System.Windows.Forms.Label label_Uname;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.ComboBox comboBox_user;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.TextBox textBox_pass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_clear;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_exit;
        private Guna.UI2.WinForms.Guna2Button Button_login;
    }
}

