using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using CST.Models;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;
using CST.System_Admin;
using CST.Volunteer;

namespace CST {  
    public partial class Admin : Form

    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChild;


        AuditTrailControl auditTrailControl = new AuditTrailControl();
        loginController control = new loginController();
        public Admin()

        {
            InitializeComponent();

            this.label4.Text = UserLog.getUserName();
            this.label2.Text = UserLog.getRole();

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);

        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(95, 77, 221);
            public static Color color4 = Color.FromArgb(249, 88, 155);
            public static Color color5 = Color.FromArgb(24, 161, 251);
            public static Color color6 = Color.FromArgb(23, 192, 44);
        }

        private void ActivateButton(
            object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();

                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(254, 251, 244);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //left
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //// Icon Current Child Form
                //CurrentChildForm.IconChar = currentBtn.IconChar;
                //CurrentChildForm.IconColor = color;
            }
        }

      


        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(226, 220, 220);
                currentBtn.ForeColor = Color.Firebrick;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Firebrick;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChild != null)
            {
                //
                currentChild.Close();
            }
            currentChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }




     

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult form1 = MessageBox.Show("Do you really want to Logout",
                                 "Exit", MessageBoxButtons.YesNo);


            if (form1 == DialogResult.Yes)
            {

                auditTrailControl.addAudit(label7.Text, UserLog.getUserName() + "Has Logged-out");
                control.setOffline(UserLog.getUserId());
                Login f = new Login();
                f.Show();
                this.Hide();
                
            }
        }

     
        public void label5_Click(object sender, EventArgs e)
        {
            
            
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            timer1.Start();
           

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void label7_Click(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            DateTime my = DateTimeOffset.Now.DateTime.ToLocalTime().ToUniversalTime();


            DateTime mys = DateTimeOffset.Now.UtcDateTime.ToLocalTime();

           
            label7.Text = my.ToString("MM/dd/yyyy  hh:mm:ss tt");

            timer1.Enabled = true;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new UserAccount(label4.Text, label2.Text));
        }

        private void BtnAudit_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new AuditTrailController(label4.Text, label2.Text));
         
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            OpenChildForm(new SmsNotification());
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            Reset();
        }

      
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
        }

        // Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wParam, int lParam);

        private void btnBio_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new Biometric());
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new PaymentRecord());
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            DialogResult form1 = MessageBox.Show("Do you really want to Log-out?",
                              "Exit", MessageBoxButtons.YesNo);


            if (form1 == DialogResult.Yes)
            {

                auditTrailControl.addAudit(label7.Text, UserLog.getUserName() + "Has Logged-out");
                control.setOffline(UserLog.getUserId());
                Login f = new Login();
                f.Show();
                this.Hide();

            }
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }


}
