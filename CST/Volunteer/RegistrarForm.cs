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
using CST.Volunteer;

namespace  CST 
{
    public partial class RegistrarForm : Form
    {
    
        AuditTrailControl auditTrailControl = new AuditTrailControl();
        loginController controller = new loginController();
      
        string sno = "";
        
        public RegistrarForm()
        {
            InitializeComponent();
            label5.Text = UserLog.getUserName();
            label1.Text = UserLog.getRole();
            timer1.Start();

           

        }

        private void RegistrarForm_Load(object sender, EventArgs e)
        {

        }

       
    
        private void timer1_Tick(object sender, EventArgs e)
        {

            DateTime my = DateTimeOffset.Now.DateTime.ToLocalTime().ToUniversalTime();


            DateTime mys = DateTimeOffset.Now.UtcDateTime.ToLocalTime();


            label7.Text = my.ToString("MM/dd/yyyy  hh:mm:ss tt");

            timer1.Enabled = true;
        }

      

     
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEnroll_Click_1(object sender, EventArgs e)
        {

            StudentForm a = new StudentForm(sno);
            a.Show();
            this.Hide();


        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult form1 = MessageBox.Show("Do you really want to Logout",
                               "Exit", MessageBoxButtons.YesNo);


            if (form1 == DialogResult.Yes)
            {
                auditTrailControl.addAudit(label7.Text, UserLog.getUserName() + "Has Logged-out");
                controller.setOffline(UserLog.getUserId());
                Login frm = new Login();
                this.Hide();
                frm.Show();

            }
        }

     
    

        private void iconButton2_Click(object sender, EventArgs e)
        {
            RegistrarRecord frm = new RegistrarRecord();

            frm.Show();

            this.Hide();
        }

        private void btnNationalD_Click(object sender, EventArgs e)
        {
            ApplicationForm frm = new ApplicationForm();
            frm.Show();
            this.Hide();
        }

        private void btnNationalIdRecord_Click(object sender, EventArgs e)
        {
            ApplicationRecord frm = new ApplicationRecord();
            frm.Show();
            this.Hide();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            RequestEyeglasses frm = new RequestEyeglasses();
            frm.Show();
            this.Hide();
        }

        private void txtRequetMedical_Click(object sender, EventArgs e)
        {
            RequestMedical frm = new RequestMedical();
            frm.Show();
            this.Hide();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            RequestRecord frm = new RequestRecord();
            frm.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
           
        }

        private void iconButton4_Click_1(object sender, EventArgs e)
        {
            PaymentRecord payment = new PaymentRecord();

            payment.Show();
            this.Hide();
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
