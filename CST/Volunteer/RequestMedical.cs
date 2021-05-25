using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CST.Models;
using CST.Models.Member;
using System.Windows.Forms;
using CST.Models.Student;
using MySql.Data.MySqlClient;

namespace CST.Volunteer
{
    public partial class RequestMedical : Form
    {
        BasicDetailsController basicDetailsController = new BasicDetailsController();
        RequestMedicalController requestMedical = new RequestMedicalController();
        AuditTrailControl auditTrail = new AuditTrailControl();

        bool isValid = false;
        string sno = "";
        public RequestMedical()
        {
            InitializeComponent();
         
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void RequestMedical_Load(object sender, EventArgs e)
        {
            label44.Hide();

            txtFullname.Enabled = false;
            txtContactNumber.Enabled = false;
            txtAddress.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string[] details = basicDetailsController.searchAllDetails(textBox1.Text.Trim());

            if (details[0] == "" || details[0] == null)
            {
                MessageBox.Show("No SCO Exits");
                sno = "";
            }
            else
            {
                txtFullname.Text = details[0] + " " + details[2] + " " + details[1];
                txtContactNumber.Text = details[8];
                txtAddress.Text = details[11];
                sno = "SCO-" + textBox1.Text.Trim();
                isValid = true;
            }

        }

            private void txtFullname_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            RegistrarForm frm = new RegistrarForm();
            frm.Show();
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool valid = checkValidation();
            if (valid)
            {


                DialogResult form2 = MessageBox.Show("Do you really want to Save ?",
                      "Add", MessageBoxButtons.YesNo);

                if (form2 == DialogResult.Yes)
                {

                    requestMedical.addRequestMedical(textBox1.Text.Trim(), txtFullname.Text.Trim(), txtContactNumber.Text.Trim(), txtAddress.Text.Trim(), txtRemarks.Text.Trim());


                    MessageBox.Show("Successfully Added");
                    auditTrail.addAudit(label44.Text.Trim(), " Request Medical Added " + textBox1.Text.Trim());
                    
                }
            }

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime my = DateTimeOffset.Now.DateTime.ToLocalTime().ToUniversalTime();


            DateTime mys = DateTimeOffset.Now.UtcDateTime.ToLocalTime();



            label44.Text = my.ToString("MM/dd/yyyy  hh:mm:ss tt");

            timer1.Enabled = true;
        }

        private void label44_Click(object sender, EventArgs e)
        {

        }

        private void txtRemarks_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private bool checkValidation()
        {
            bool isValid = true;

            isValid = !(textBox1.Text.Trim() == "") && isValid;

            isValid = !(txtRemarks.Text.Trim() == "") && isValid;


            if (!isValid)
            {
                MessageBox.Show("Please Complete required Data", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



            return isValid;
        }
    }
}
