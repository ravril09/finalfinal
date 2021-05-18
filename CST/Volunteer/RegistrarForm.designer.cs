namespace CST
{
    partial class RegistrarForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogout = new FontAwesome.Sharp.IconButton();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnNationalD = new FontAwesome.Sharp.IconButton();
            this.btnNationalIdRecord = new FontAwesome.Sharp.IconButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.txtRequetMedical = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnEnroll = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(404, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 36);
            this.label1.TabIndex = 214;
            this.label1.Text = "User Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Firebrick;
            this.label5.Location = new System.Drawing.Point(40, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 36);
            this.label5.TabIndex = 211;
            this.label5.Text = "Username";
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Firebrick;
            this.label7.Location = new System.Drawing.Point(627, 390);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 26);
            this.label7.TabIndex = 216;
            this.label7.Text = "Date & Time";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(930, 166);
            this.panel1.TabIndex = 225;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(214, 166);
            this.panel3.TabIndex = 222;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::CST.Properties.Resources.download_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(3, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.Controls.Add(this.label2);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Location = new System.Drawing.Point(189, 5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(575, 156);
            this.panel7.TabIndex = 223;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Firebrick;
            this.label3.Location = new System.Drawing.Point(47, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(478, 42);
            this.label3.TabIndex = 227;
            this.label3.Text = "Senior Citizens Organization ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Controls.Add(this.btnLogout);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(930, 437);
            this.panel2.TabIndex = 226;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnLogout.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Firebrick;
            this.btnLogout.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.btnLogout.IconColor = System.Drawing.Color.Firebrick;
            this.btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogout.IconSize = 30;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(42, 383);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLogout.Rotation = 0D;
            this.btnLogout.Size = new System.Drawing.Size(172, 40);
            this.btnLogout.TabIndex = 217;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Gold;
            this.panel9.Controls.Add(this.panel5);
            this.panel9.Controls.Add(this.panel6);
            this.panel9.Controls.Add(this.panel4);
            this.panel9.Location = new System.Drawing.Point(8, 172);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(910, 197);
            this.panel9.TabIndex = 236;
            this.panel9.Paint += new System.Windows.Forms.PaintEventHandler(this.panel9_Paint);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.btnNationalD);
            this.panel5.Controls.Add(this.btnNationalIdRecord);
            this.panel5.Location = new System.Drawing.Point(297, 32);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(310, 115);
            this.panel5.TabIndex = 234;
            // 
            // btnNationalD
            // 
            this.btnNationalD.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNationalD.FlatAppearance.BorderSize = 0;
            this.btnNationalD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNationalD.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnNationalD.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNationalD.ForeColor = System.Drawing.Color.Firebrick;
            this.btnNationalD.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnNationalD.IconColor = System.Drawing.Color.Firebrick;
            this.btnNationalD.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNationalD.IconSize = 30;
            this.btnNationalD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNationalD.Location = new System.Drawing.Point(0, 0);
            this.btnNationalD.Name = "btnNationalD";
            this.btnNationalD.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnNationalD.Rotation = 0D;
            this.btnNationalD.Size = new System.Drawing.Size(310, 56);
            this.btnNationalD.TabIndex = 229;
            this.btnNationalD.Text = "Appication for National ID";
            this.btnNationalD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNationalD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNationalD.UseVisualStyleBackColor = false;
            this.btnNationalD.Click += new System.EventHandler(this.btnNationalD_Click);
            // 
            // btnNationalIdRecord
            // 
            this.btnNationalIdRecord.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnNationalIdRecord.FlatAppearance.BorderSize = 0;
            this.btnNationalIdRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNationalIdRecord.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnNationalIdRecord.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNationalIdRecord.ForeColor = System.Drawing.Color.Firebrick;
            this.btnNationalIdRecord.IconChar = FontAwesome.Sharp.IconChar.Wpforms;
            this.btnNationalIdRecord.IconColor = System.Drawing.Color.Firebrick;
            this.btnNationalIdRecord.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNationalIdRecord.IconSize = 30;
            this.btnNationalIdRecord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNationalIdRecord.Location = new System.Drawing.Point(0, 55);
            this.btnNationalIdRecord.Name = "btnNationalIdRecord";
            this.btnNationalIdRecord.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnNationalIdRecord.Rotation = 0D;
            this.btnNationalIdRecord.Size = new System.Drawing.Size(310, 60);
            this.btnNationalIdRecord.TabIndex = 230;
            this.btnNationalIdRecord.Text = "National ID Record";
            this.btnNationalIdRecord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNationalIdRecord.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNationalIdRecord.UseVisualStyleBackColor = false;
            this.btnNationalIdRecord.Click += new System.EventHandler(this.btnNationalIdRecord_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Controls.Add(this.iconButton3);
            this.panel6.Controls.Add(this.iconButton1);
            this.panel6.Controls.Add(this.txtRequetMedical);
            this.panel6.Location = new System.Drawing.Point(601, 32);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(293, 128);
            this.panel6.TabIndex = 235;
            // 
            // iconButton3
            // 
            this.iconButton3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton3.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.ForeColor = System.Drawing.Color.Firebrick;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.PollH;
            this.iconButton3.IconColor = System.Drawing.Color.Firebrick;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton3.IconSize = 30;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(0, 88);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconButton3.Rotation = 0D;
            this.iconButton3.Size = new System.Drawing.Size(293, 40);
            this.iconButton3.TabIndex = 232;
            this.iconButton3.Text = "Request Record";
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = true;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.Firebrick;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.PeopleArrows;
            this.iconButton1.IconColor = System.Drawing.Color.Firebrick;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 40);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(293, 40);
            this.iconButton1.TabIndex = 227;
            this.iconButton1.Text = "Request Free Eyeglasses";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // txtRequetMedical
            // 
            this.txtRequetMedical.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtRequetMedical.FlatAppearance.BorderSize = 0;
            this.txtRequetMedical.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtRequetMedical.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.txtRequetMedical.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRequetMedical.ForeColor = System.Drawing.Color.Firebrick;
            this.txtRequetMedical.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.txtRequetMedical.IconColor = System.Drawing.Color.Firebrick;
            this.txtRequetMedical.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.txtRequetMedical.IconSize = 30;
            this.txtRequetMedical.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtRequetMedical.Location = new System.Drawing.Point(0, 0);
            this.txtRequetMedical.Name = "txtRequetMedical";
            this.txtRequetMedical.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.txtRequetMedical.Rotation = 0D;
            this.txtRequetMedical.Size = new System.Drawing.Size(293, 40);
            this.txtRequetMedical.TabIndex = 231;
            this.txtRequetMedical.Text = "Request Free Medical";
            this.txtRequetMedical.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtRequetMedical.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.txtRequetMedical.UseVisualStyleBackColor = true;
            this.txtRequetMedical.Click += new System.EventHandler(this.txtRequetMedical_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnEnroll);
            this.panel4.Controls.Add(this.iconButton2);
            this.panel4.Location = new System.Drawing.Point(4, 32);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(287, 108);
            this.panel4.TabIndex = 233;
            // 
            // btnEnroll
            // 
            this.btnEnroll.BackColor = System.Drawing.Color.Transparent;
            this.btnEnroll.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEnroll.FlatAppearance.BorderSize = 0;
            this.btnEnroll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnroll.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnEnroll.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnroll.ForeColor = System.Drawing.Color.Firebrick;
            this.btnEnroll.IconChar = FontAwesome.Sharp.IconChar.StickyNote;
            this.btnEnroll.IconColor = System.Drawing.Color.Firebrick;
            this.btnEnroll.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEnroll.IconSize = 30;
            this.btnEnroll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnroll.Location = new System.Drawing.Point(0, 0);
            this.btnEnroll.Name = "btnEnroll";
            this.btnEnroll.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEnroll.Rotation = 0D;
            this.btnEnroll.Size = new System.Drawing.Size(287, 63);
            this.btnEnroll.TabIndex = 217;
            this.btnEnroll.Text = "Membership Registration";
            this.btnEnroll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnroll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEnroll.UseVisualStyleBackColor = false;
            this.btnEnroll.Click += new System.EventHandler(this.btnEnroll_Click_1);
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.Transparent;
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton2.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.Firebrick;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Tasks;
            this.iconButton2.IconColor = System.Drawing.Color.Firebrick;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 30;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(0, 55);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconButton2.Rotation = 0D;
            this.iconButton2.Size = new System.Drawing.Size(287, 53);
            this.iconButton2.TabIndex = 228;
            this.iconButton2.Text = "Membership Record";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::CST.Properties.Resources.mislogo1;
            this.pictureBox2.Location = new System.Drawing.Point(773, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(127, 144);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(172, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 42);
            this.label2.TabIndex = 228;
            this.label2.Text = "Of Molino VI";
            // 
            // RegistrarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CST.Properties.Resources.cool_white_background_free_download_desktop_white_background_hd;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(930, 437);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrarForm";
            this.Load += new System.EventHandler(this.RegistrarForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnEnroll;
        private FontAwesome.Sharp.IconButton btnLogout;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton btnNationalD;
        private FontAwesome.Sharp.IconButton btnNationalIdRecord;
        private FontAwesome.Sharp.IconButton txtRequetMedical;
        private FontAwesome.Sharp.IconButton iconButton3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
    }
}