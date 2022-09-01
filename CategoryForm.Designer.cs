namespace Shoprite_inventory_system
{
    partial class CategoryForm
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
            this.label_heading = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label_exit = new System.Windows.Forms.Label();
            this.CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.button_refresh = new System.Windows.Forms.Button();
            this.comboBox_Cat = new System.Windows.Forms.ComboBox();
            this.Panel_product = new Guna.UI2.WinForms.Guna2Panel();
            this.TextBox_des = new Guna.UI2.WinForms.Guna2TextBox();
            this.Label_S_id = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.TextBox_catname = new Guna.UI2.WinForms.Guna2TextBox();
            this.Label_name = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TextBox_catid = new Guna.UI2.WinForms.Guna2TextBox();
            this.Label_id = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Button_logout = new Guna.UI2.WinForms.Guna2Button();
            this.CustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_heading
            // 
            this.label_heading.BackColor = System.Drawing.Color.Transparent;
            this.label_heading.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_heading.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label_heading.Location = new System.Drawing.Point(184, 28);
            this.label_heading.Name = "label_heading";
            this.label_heading.Size = new System.Drawing.Size(253, 28);
            this.label_heading.TabIndex = 23;
            this.label_heading.Text = "MANAGE CATEGORY";
            this.label_heading.Click += new System.EventHandler(this.label_heading_Click);
            // 
            // label_exit
            // 
            this.label_exit.AutoSize = true;
            this.label_exit.BackColor = System.Drawing.Color.Firebrick;
            this.label_exit.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_exit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label_exit.Location = new System.Drawing.Point(562, 9);
            this.label_exit.Name = "label_exit";
            this.label_exit.Size = new System.Drawing.Size(34, 33);
            this.label_exit.TabIndex = 22;
            this.label_exit.Text = "X";
            // 
            // CustomGradientPanel1
            // 
            this.CustomGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CustomGradientPanel1.Controls.Add(this.button_refresh);
            this.CustomGradientPanel1.Controls.Add(this.comboBox_Cat);
            this.CustomGradientPanel1.Controls.Add(this.Panel_product);
            this.CustomGradientPanel1.Controls.Add(this.TextBox_des);
            this.CustomGradientPanel1.Controls.Add(this.Label_S_id);
            this.CustomGradientPanel1.Controls.Add(this.button3);
            this.CustomGradientPanel1.Controls.Add(this.button2);
            this.CustomGradientPanel1.Controls.Add(this.button_add);
            this.CustomGradientPanel1.Controls.Add(this.TextBox_catname);
            this.CustomGradientPanel1.Controls.Add(this.Label_name);
            this.CustomGradientPanel1.Controls.Add(this.TextBox_catid);
            this.CustomGradientPanel1.Controls.Add(this.Label_id);
            this.CustomGradientPanel1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomGradientPanel1.Location = new System.Drawing.Point(96, 103);
            this.CustomGradientPanel1.Name = "CustomGradientPanel1";
            this.CustomGradientPanel1.Size = new System.Drawing.Size(515, 468);
            this.CustomGradientPanel1.TabIndex = 21;
            // 
            // button_refresh
            // 
            this.button_refresh.BackColor = System.Drawing.Color.White;
            this.button_refresh.FlatAppearance.BorderSize = 0;
            this.button_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_refresh.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_refresh.Location = new System.Drawing.Point(287, 223);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(75, 23);
            this.button_refresh.TabIndex = 19;
            this.button_refresh.Text = "Refresh";
            this.button_refresh.UseVisualStyleBackColor = false;
            // 
            // comboBox_Cat
            // 
            this.comboBox_Cat.FormattingEnabled = true;
            this.comboBox_Cat.Location = new System.Drawing.Point(147, 223);
            this.comboBox_Cat.Name = "comboBox_Cat";
            this.comboBox_Cat.Size = new System.Drawing.Size(134, 23);
            this.comboBox_Cat.TabIndex = 18;
            // 
            // Panel_product
            // 
            this.Panel_product.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Panel_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Panel_product.Location = new System.Drawing.Point(45, 263);
            this.Panel_product.Name = "Panel_product";
            this.Panel_product.Size = new System.Drawing.Size(426, 316);
            this.Panel_product.TabIndex = 17;
            // 
            // TextBox_des
            // 
            this.TextBox_des.BackColor = System.Drawing.Color.White;
            this.TextBox_des.BorderColor = System.Drawing.Color.Black;
            this.TextBox_des.BorderRadius = 3;
            this.TextBox_des.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_des.DefaultText = "";
            this.TextBox_des.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_des.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_des.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_des.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_des.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_des.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_des.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextBox_des.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_des.Location = new System.Drawing.Point(121, 128);
            this.TextBox_des.Name = "TextBox_des";
            this.TextBox_des.PasswordChar = '\0';
            this.TextBox_des.PlaceholderText = "";
            this.TextBox_des.SelectedText = "";
            this.TextBox_des.Size = new System.Drawing.Size(134, 20);
            this.TextBox_des.TabIndex = 16;
            // 
            // Label_S_id
            // 
            this.Label_S_id.BackColor = System.Drawing.Color.Transparent;
            this.Label_S_id.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_S_id.ForeColor = System.Drawing.Color.Black;
            this.Label_S_id.Location = new System.Drawing.Point(36, 128);
            this.Label_S_id.Name = "Label_S_id";
            this.Label_S_id.Size = new System.Drawing.Size(79, 19);
            this.Label_S_id.TabIndex = 15;
            this.Label_S_id.Text = "Description";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(296, 167);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(180, 167);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.White;
            this.button_add.FlatAppearance.BorderSize = 0;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.Location = new System.Drawing.Point(74, 167);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 12;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // TextBox_catname
            // 
            this.TextBox_catname.BackColor = System.Drawing.Color.White;
            this.TextBox_catname.BorderColor = System.Drawing.Color.Black;
            this.TextBox_catname.BorderRadius = 3;
            this.TextBox_catname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_catname.DefaultText = "";
            this.TextBox_catname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_catname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_catname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_catname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_catname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_catname.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_catname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextBox_catname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_catname.Location = new System.Drawing.Point(121, 81);
            this.TextBox_catname.Name = "TextBox_catname";
            this.TextBox_catname.PasswordChar = '\0';
            this.TextBox_catname.PlaceholderText = "";
            this.TextBox_catname.SelectedText = "";
            this.TextBox_catname.Size = new System.Drawing.Size(134, 20);
            this.TextBox_catname.TabIndex = 7;
            // 
            // Label_name
            // 
            this.Label_name.BackColor = System.Drawing.Color.Transparent;
            this.Label_name.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_name.ForeColor = System.Drawing.Color.Black;
            this.Label_name.Location = new System.Drawing.Point(74, 82);
            this.Label_name.Name = "Label_name";
            this.Label_name.Size = new System.Drawing.Size(41, 19);
            this.Label_name.TabIndex = 2;
            this.Label_name.Text = "Name";
            // 
            // TextBox_catid
            // 
            this.TextBox_catid.BackColor = System.Drawing.Color.White;
            this.TextBox_catid.BorderColor = System.Drawing.Color.Black;
            this.TextBox_catid.BorderRadius = 3;
            this.TextBox_catid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_catid.DefaultText = "";
            this.TextBox_catid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_catid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_catid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_catid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_catid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_catid.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_catid.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextBox_catid.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_catid.Location = new System.Drawing.Point(121, 35);
            this.TextBox_catid.Name = "TextBox_catid";
            this.TextBox_catid.PasswordChar = '\0';
            this.TextBox_catid.PlaceholderText = "";
            this.TextBox_catid.SelectedText = "";
            this.TextBox_catid.Size = new System.Drawing.Size(134, 20);
            this.TextBox_catid.TabIndex = 1;
            // 
            // Label_id
            // 
            this.Label_id.BackColor = System.Drawing.Color.Transparent;
            this.Label_id.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_id.ForeColor = System.Drawing.Color.Black;
            this.Label_id.Location = new System.Drawing.Point(74, 36);
            this.Label_id.Name = "Label_id";
            this.Label_id.Size = new System.Drawing.Size(20, 19);
            this.Label_id.TabIndex = 0;
            this.Label_id.Text = "ID";
            // 
            // Button_logout
            // 
            this.Button_logout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_logout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_logout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_logout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_logout.FillColor = System.Drawing.Color.Firebrick;
            this.Button_logout.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_logout.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Button_logout.Location = new System.Drawing.Point(-1, 538);
            this.Button_logout.Name = "Button_logout";
            this.Button_logout.Size = new System.Drawing.Size(98, 30);
            this.Button_logout.TabIndex = 24;
            this.Button_logout.Text = "LogOut";
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(608, 571);
            this.Controls.Add(this.Button_logout);
            this.Controls.Add(this.label_heading);
            this.Controls.Add(this.label_exit);
            this.Controls.Add(this.CustomGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CategoryForm";
            this.Text = "CategoryForm";
            this.CustomGradientPanel1.ResumeLayout(false);
            this.CustomGradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel label_heading;
        private System.Windows.Forms.Label label_exit;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel CustomGradientPanel1;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.ComboBox comboBox_Cat;
        private Guna.UI2.WinForms.Guna2Panel Panel_product;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_des;
        private Guna.UI2.WinForms.Guna2HtmlLabel Label_S_id;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_add;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_catname;
        private Guna.UI2.WinForms.Guna2HtmlLabel Label_name;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_catid;
        private Guna.UI2.WinForms.Guna2HtmlLabel Label_id;
        private Guna.UI2.WinForms.Guna2Button Button_logout;
    }
}