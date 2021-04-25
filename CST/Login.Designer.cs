﻿namespace CST
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.DateTicks = new System.Windows.Forms.Timer(this.components);
            this.DateTime = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorNotification = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.customInstaller1 = new MySql.Data.MySqlClient.CustomInstaller();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pbMinimized = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUN = new System.Windows.Forms.Label();
            this.txtUT = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNotification)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimized)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // DateTicks
            // 
            this.DateTicks.Enabled = true;
            this.DateTicks.Interval = 1000;
            this.DateTicks.Tick += new System.EventHandler(this.DateTicks_Tick);
            // 
            // DateTime
            // 
            this.DateTime.AutoSize = true;
            this.DateTime.BackColor = System.Drawing.Color.Transparent;
            this.DateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.DateTime.ForeColor = System.Drawing.Color.DimGray;
            this.DateTime.Location = new System.Drawing.Point(17, 308);
            this.DateTime.Name = "DateTime";
            this.DateTime.Size = new System.Drawing.Size(0, 20);
            this.DateTime.TabIndex = 141;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorNotification
            // 
            this.errorNotification.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(2, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 181;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogin.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLogin.Enabled = false;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Firebrick;
            this.btnLogin.Location = new System.Drawing.Point(343, 241);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(152, 35);
            this.btnLogin.TabIndex = 142;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(244)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Firebrick;
            this.txtPassword.Location = new System.Drawing.Point(305, 187);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(233, 25);
            this.txtPassword.TabIndex = 139;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(233, 183);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(66, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 169;
            this.pictureBox2.TabStop = false;
            // 
            // pbClose
            // 
            this.pbClose.BackColor = System.Drawing.Color.Transparent;
            this.pbClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbClose.BackgroundImage")));
            this.pbClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbClose.Location = new System.Drawing.Point(563, 8);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(29, 23);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbClose.TabIndex = 168;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(27, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 19);
            this.label1.TabIndex = 170;
            this.label1.Text = "No Connection";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Firebrick;
            this.label7.Location = new System.Drawing.Point(28, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 19);
            this.label7.TabIndex = 166;
            this.label7.Text = "Date & Time";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // pbMinimized
            // 
            this.pbMinimized.BackColor = System.Drawing.Color.Transparent;
            this.pbMinimized.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbMinimized.BackgroundImage")));
            this.pbMinimized.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbMinimized.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMinimized.Location = new System.Drawing.Point(528, 8);
            this.pbMinimized.Name = "pbMinimized";
            this.pbMinimized.Size = new System.Drawing.Size(29, 23);
            this.pbMinimized.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMinimized.TabIndex = 169;
            this.pbMinimized.TabStop = false;
            this.pbMinimized.Click += new System.EventHandler(this.pbMinimized_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(233, 121);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 168;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Firebrick;
            this.label3.Location = new System.Drawing.Point(212, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(361, 32);
            this.label3.TabIndex = 187;
            this.label3.Text = "Senior Citizens of Molino VI";
            // 
            // txtUN
            // 
            this.txtUN.AutoSize = true;
            this.txtUN.BackColor = System.Drawing.Color.Transparent;
            this.txtUN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUN.ForeColor = System.Drawing.Color.Firebrick;
            this.txtUN.Location = new System.Drawing.Point(27, 225);
            this.txtUN.Name = "txtUN";
            this.txtUN.Size = new System.Drawing.Size(118, 25);
            this.txtUN.TabIndex = 171;
            this.txtUN.Text = "Username";
            // 
            // txtUT
            // 
            this.txtUT.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtUT.AutoSize = true;
            this.txtUT.BackColor = System.Drawing.Color.Transparent;
            this.txtUT.Enabled = false;
            this.txtUT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUT.ForeColor = System.Drawing.Color.Firebrick;
            this.txtUT.Location = new System.Drawing.Point(25, 191);
            this.txtUT.Name = "txtUT";
            this.txtUT.Size = new System.Drawing.Size(120, 25);
            this.txtUT.TabIndex = 180;
            this.txtUT.Text = "User Type";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = global::CST.Properties.Resources.mislogo1;
            this.pictureBox3.Location = new System.Drawing.Point(21, 15);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(175, 127);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 188;
            this.pictureBox3.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Firebrick;
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(305, 144);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(236, 5);
            this.panel4.TabIndex = 189;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel5.Location = new System.Drawing.Point(273, 192);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(236, 5);
            this.panel5.TabIndex = 144;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(305, 211);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 5);
            this.panel1.TabIndex = 190;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel2.Location = new System.Drawing.Point(273, 192);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 5);
            this.panel2.TabIndex = 144;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(244)))));
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Controls.Add(this.panel1);
            this.panel6.Controls.Add(this.panel4);
            this.panel6.Controls.Add(this.pictureBox3);
            this.panel6.Controls.Add(this.txtUsername);
            this.panel6.Controls.Add(this.txtUT);
            this.panel6.Controls.Add(this.txtUN);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.pictureBox1);
            this.panel6.Controls.Add(this.pbMinimized);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.pbClose);
            this.panel6.Controls.Add(this.pictureBox2);
            this.panel6.Controls.Add(this.txtPassword);
            this.panel6.Controls.Add(this.btnLogin);
            this.panel6.Controls.Add(this.panel3);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(605, 336);
            this.panel6.TabIndex = 182;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(244)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.Firebrick;
            this.txtUsername.Location = new System.Drawing.Point(305, 121);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(236, 25);
            this.txtUsername.TabIndex = 138;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Firebrick;
            this.panel3.Location = new System.Drawing.Point(19, 11);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(180, 134);
            this.panel3.TabIndex = 191;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Firebrick;
            this.panel7.Location = new System.Drawing.Point(341, 239);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(156, 39);
            this.panel7.TabIndex = 192;
            // 
            // Login
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::CST.Properties.Resources.cool_white_background_free_download_desktop_white_background_hd;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(605, 336);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DateTime);
            this.Controls.Add(this.panel6);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Login_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Login_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNotification)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimized)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer DateTicks;
        private System.Windows.Forms.Label DateTime;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorNotification;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private MySql.Data.MySqlClient.CustomInstaller customInstaller1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label txtUT;
        private System.Windows.Forms.Label txtUN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbMinimized;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel7;
    }
}

