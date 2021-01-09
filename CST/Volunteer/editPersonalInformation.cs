using CST.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST.Volunteer
{
    public partial class editPersonalInformation : Form
    {
        PersonalDetailsController updatePersonalInformation = new PersonalDetailsController();
        string gender = "";
        string civilstatus = "";
        public editPersonalInformation(string sur, string fn, string mn, string dob, string birt,
                                    int age, string sex, string cis, string nat, string
                                    rel, string add, string cn, string sno)
        {
            InitializeComponent();
            txtId.Text = sno;
            txtLastname.Text = sur;
            txtFirstname.Text = fn;
            txtMiddlename.Text = mn;
            txtPOB.Text = birt;
            textBox19.Text = age + "";
            txtNationality.Text = nat;
            txtReligion.Text = rel;
            txtAddress.Text = add;
            txtContact.Text = cn;

            gender = sex;
            civilstatus = cis;
            if (sex == "Male")
            {
                radioButton12.Checked = true;
            }
            else
            {
                radioButton13.Checked = true;
            }

            if (cis == "Single")
            {
                radioButton1.Checked = true;

            }
            else if (cis == "Married")
            {
                radioButton2.Checked = true;
            }
            else
            {
                radioButton14.Checked = true;
            }

        }

        private bool validationTab1()
        {
            bool isValid = true;

            isValid = !(txtFirstname.Text == "") && isValid;

            isValid = !(txtLastname.Text == "") && isValid;

            isValid = !(txtNationality.Text == "") && isValid;

            isValid = !(txtAddress.Text == "") && isValid;

            isValid = !(txtPOB.Text == "") && isValid;

            isValid = !(txtReligion.Text == "") && isValid;

            isValid = !(txtNationality.Text == "") && isValid;

            isValid = !(txtAddress.Text == "") && isValid;



            return isValid;
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isValid = validationTab1();

            if (isValid)
            {
                updatePersonalInformation.updatePersonalInfo(txtLastname.Text.Trim(), txtFirstname.Text.Trim(), txtMiddlename.Text.Trim(), dateTimePicker1.Value.ToShortDateString(),
                                                            txtPOB.Text.Trim(), int.Parse(textBox19.Text.Trim()), gender, civilstatus, txtNationality.Text.Trim(),
                                                            txtReligion.Text.Trim(), txtAddress.Text.Trim(), txtContact.Text.Trim(), txtId.Text.Trim());
                MessageBox.Show("Succesfully Updated Student Personal Info");
                this.Hide();
            }
        }
    }
}
