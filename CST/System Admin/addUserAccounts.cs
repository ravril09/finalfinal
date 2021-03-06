using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CST.Models;

namespace CST.System_Admin
{
    public partial class addUserAccounts : Form
    {
        bool isEdited = false;
        UserController userController = new UserController();
        AuditTrailControl auditTrail = new AuditTrailControl();
        public addUserAccounts()
        {
            InitializeComponent();
        }

        public addUserAccounts(string user,string fn, string ln, string mn, string role,
                              string accountid)
        {
            InitializeComponent();
            txtFirstname.Text = fn;
            txtLastname.Text = ln;
            txtMiddlename.Text = mn;
           // cbUsertype.Text = ;
            textBox3.Text = accountid;
            txtUsername.Text = user;
            isEdited = true;
            textBox3.Visible = true;
            label6.Visible = true;
            int count = 0;

            if (role == "President")
            {
                count = 0;
            }

            else if (role == "Volunteer")
            {
                count = 1;
            }


               cbUsertype.SelectedIndex = count;
        }

        private void addUserAccounts_Load(object sender, EventArgs e)
        {
            label7.Hide();
            timer1.Start();
            DateTime my = DateTimeOffset.Now.DateTime.ToLocalTime().ToUniversalTime();


            DateTime mys = DateTimeOffset.Now.UtcDateTime.ToLocalTime();

        

            label7.Text = my.ToString("MM/dd/yyyy  hh:mm:ss tt");

            timer1.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool valid = checkValidation();
            Random random = new Random();
            int value = random.Next(1000000);
            //   txtPassword.Text = value.ToString();


            Random randomen = new Random();
            int values = random.Next(10000);
            //textBox3.Text = "CST-2013-" + values.ToString();

            string userId = "SCO-"+values.ToString();


            //string newString = txtFirstname.Text.Substring(0, 1);
            //string newStrings = txtPassword.Text.Substring(0, 4);
            //txtUsername.Text = newString + txtLastname.Text + newStrings;

            if (valid)
            {


                DialogResult form2 = MessageBox.Show("Do you really want to Save ?",
                      "Add", MessageBoxButtons.YesNo);

                if (form2 == DialogResult.Yes)
                {

                    if (isEdited)
                    {

                        userController.updateUser(textBox3.Text.Trim(), txtUsername.Text.Trim(), txtFirstname.Text.Trim(),
                                      txtLastname.Text.Trim(), txtMiddlename.Text.Trim(), cbUsertype.SelectedItem.ToString());
                        MessageBox.Show("Succesfully Updated");
                        auditTrail.addAudit(label7.Text, "Updated data User Accounts");
                        this.Hide();
                    }
                    else
                    {
                        string username = txtUsername.Text.Trim();

                        if (userController.isSameUser(username))
                        {
                            username += values.ToString();
                        }
                        

                        userController.addUser(userId, username, txtFirstname.Text.Trim(),
                                       txtLastname.Text.Trim(), txtMiddlename.Text.Trim(), cbUsertype.SelectedItem.ToString(),
                                       label7.Text);
                        MessageBox.Show("Succesfully Added");
                        auditTrail.addAudit(label7.Text, "Addded new User Accounts");
                        this.Hide();

                    }

                }
            }
        }

        private bool checkValidation()
        {
            bool isValid = true;
          
            isValid = !(txtFirstname.Text.Trim() == "") && isValid;

            isValid = !(txtLastname.Text.Trim() == "") && isValid;

            isValid = !(txtUsername.Text.Trim() == "") && isValid;

            isValid = cbUsertype.SelectedIndex > -1 && isValid;


            if (!isValid)
            {
                MessageBox.Show("Please Complete required Data", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

         

            return isValid;          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void txtLastname_TextChanged(object sender, EventArgs e)
        {
            if (txtLastname.Text.Length > 0)
            {
                txtUsername.Text = txtLastname.Text[0] + "." + txtFirstname.Text;
            }
            else
            {
                txtUsername.Text = "";
            }
          
        }

        private void gbUserForm_Enter(object sender, EventArgs e)
        {

        }

        private void txtFirstname_TextChanged(object sender, EventArgs e)
        {
            if (txtLastname.Text.Length > 0)
            {
                txtUsername.Text = txtLastname.Text[0] + "." + txtFirstname.Text;
            }
            else
            {
                txtUsername.Text = "";
            }
        }

        private void txtMiddlename_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbUsertype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
