namespace CST
{
    partial class Admin
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
            this.label7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btnLogout = new FontAwesome.Sharp.IconButton();
            this.btnReport = new FontAwesome.Sharp.IconButton();
            this.btnBio = new FontAwesome.Sharp.IconButton();
            this.BtnAudit = new FontAwesome.Sharp.IconButton();
            this.btnUsercontrol = new FontAwesome.Sharp.IconButton();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.mySqlTransactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mySqlTransactionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Firebrick;
            this.label7.Location = new System.Drawing.Point(8, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 24);
            this.label7.TabIndex = 173;
            this.label7.Text = "Date & Time";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(244)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1043, 130);
            this.panel1.TabIndex = 185;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(608, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 26);
            this.label2.TabIndex = 216;
            this.label2.Text = "User Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Firebrick;
            this.label4.Location = new System.Drawing.Point(267, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 26);
            this.label4.TabIndex = 215;
            this.label4.Text = "Username";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnHome);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(244, 130);
            this.panel2.TabIndex = 184;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.Image = global::CST.Properties.Resources.download_removebg_preview;
            this.btnHome.Location = new System.Drawing.Point(70, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(156, 127);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 184;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.pbLogo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Firebrick;
            this.label3.Location = new System.Drawing.Point(270, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(478, 84);
            this.label3.TabIndex = 182;
            this.label3.Text = "Senior Citizens Organization \r\n            Of Molino VI";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.White;
            this.panelMenu.Controls.Add(this.iconButton1);
            this.panelMenu.Controls.Add(this.btnLogout);
            this.panelMenu.Controls.Add(this.label7);
            this.panelMenu.Controls.Add(this.btnReport);
            this.panelMenu.Controls.Add(this.btnBio);
            this.panelMenu.Controls.Add(this.BtnAudit);
            this.panelMenu.Controls.Add(this.btnUsercontrol);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.ForeColor = System.Drawing.Color.White;
            this.panelMenu.Location = new System.Drawing.Point(0, 130);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(244, 416);
            this.panelMenu.TabIndex = 186;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(244)))));
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.Firebrick;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.iconButton1.IconColor = System.Drawing.Color.Firebrick;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 200);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(244, 40);
            this.iconButton1.TabIndex = 174;
            this.iconButton1.Text = "Log Out";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(244)))));
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnLogout.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Firebrick;
            this.btnLogout.IconChar = FontAwesome.Sharp.IconChar.CommentDots;
            this.btnLogout.IconColor = System.Drawing.Color.Firebrick;
            this.btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogout.IconSize = 30;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 160);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLogout.Rotation = 0D;
            this.btnLogout.Size = new System.Drawing.Size(244, 40);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "SMS Notification";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click_1);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(244)))));
            this.btnReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnReport.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.Firebrick;
            this.btnReport.IconChar = FontAwesome.Sharp.IconChar.Tasks;
            this.btnReport.IconColor = System.Drawing.Color.Firebrick;
            this.btnReport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReport.IconSize = 30;
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(0, 120);
            this.btnReport.Name = "btnReport";
            this.btnReport.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnReport.Rotation = 0D;
            this.btnReport.Size = new System.Drawing.Size(244, 40);
            this.btnReport.TabIndex = 6;
            this.btnReport.Text = "Reports";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnBio
            // 
            this.btnBio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(244)))));
            this.btnBio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBio.FlatAppearance.BorderSize = 0;
            this.btnBio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBio.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnBio.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBio.ForeColor = System.Drawing.Color.Firebrick;
            this.btnBio.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.btnBio.IconColor = System.Drawing.Color.Firebrick;
            this.btnBio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBio.IconSize = 30;
            this.btnBio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBio.Location = new System.Drawing.Point(0, 80);
            this.btnBio.Name = "btnBio";
            this.btnBio.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnBio.Rotation = 0D;
            this.btnBio.Size = new System.Drawing.Size(244, 40);
            this.btnBio.TabIndex = 5;
            this.btnBio.Text = "Biometric";
            this.btnBio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBio.UseVisualStyleBackColor = false;
            this.btnBio.Click += new System.EventHandler(this.btnBio_Click);
            // 
            // BtnAudit
            // 
            this.BtnAudit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(244)))));
            this.BtnAudit.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAudit.FlatAppearance.BorderSize = 0;
            this.BtnAudit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAudit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnAudit.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAudit.ForeColor = System.Drawing.Color.Firebrick;
            this.BtnAudit.IconChar = FontAwesome.Sharp.IconChar.Perbyte;
            this.BtnAudit.IconColor = System.Drawing.Color.Firebrick;
            this.BtnAudit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAudit.IconSize = 30;
            this.BtnAudit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAudit.Location = new System.Drawing.Point(0, 40);
            this.BtnAudit.Name = "BtnAudit";
            this.BtnAudit.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnAudit.Rotation = 0D;
            this.BtnAudit.Size = new System.Drawing.Size(244, 40);
            this.BtnAudit.TabIndex = 3;
            this.BtnAudit.Text = "Audit Trail";
            this.BtnAudit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAudit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAudit.UseVisualStyleBackColor = false;
            this.BtnAudit.Click += new System.EventHandler(this.BtnAudit_Click);
            // 
            // btnUsercontrol
            // 
            this.btnUsercontrol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(244)))));
            this.btnUsercontrol.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsercontrol.FlatAppearance.BorderSize = 0;
            this.btnUsercontrol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsercontrol.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnUsercontrol.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsercontrol.ForeColor = System.Drawing.Color.Firebrick;
            this.btnUsercontrol.IconChar = FontAwesome.Sharp.IconChar.LaptopHouse;
            this.btnUsercontrol.IconColor = System.Drawing.Color.Firebrick;
            this.btnUsercontrol.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUsercontrol.IconSize = 30;
            this.btnUsercontrol.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsercontrol.Location = new System.Drawing.Point(0, 0);
            this.btnUsercontrol.Name = "btnUsercontrol";
            this.btnUsercontrol.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnUsercontrol.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnUsercontrol.Rotation = 0D;
            this.btnUsercontrol.Size = new System.Drawing.Size(244, 40);
            this.btnUsercontrol.TabIndex = 1;
            this.btnUsercontrol.Text = "Usercontrol";
            this.btnUsercontrol.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsercontrol.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsercontrol.UseVisualStyleBackColor = false;
            this.btnUsercontrol.Click += new System.EventHandler(this.btnRegistration_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.White;
            this.panelDesktop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(244, 130);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(799, 416);
            this.panelDesktop.TabIndex = 187;
            this.panelDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktop_Paint);
            // 
            // mySqlTransactionBindingSource
            // 
            this.mySqlTransactionBindingSource.DataSource = typeof(MySql.Data.MySqlClient.MySqlTransaction);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::CST.Properties.Resources.mislogo1;
            this.pictureBox1.Location = new System.Drawing.Point(775, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 185;
            this.pictureBox1.TabStop = false;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1043, 546);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mySqlTransactionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource mySqlTransactionBindingSource;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnLogout;
        private FontAwesome.Sharp.IconButton btnReport;
        private FontAwesome.Sharp.IconButton btnBio;
        private FontAwesome.Sharp.IconButton BtnAudit;
        private FontAwesome.Sharp.IconButton btnUsercontrol;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}