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

namespace CST.Registrar
{
    public partial class editStudentForm : Form
    {
        BasicDetailsController basicDetailsController = new BasicDetailsController();
        string gender = "";
        string civilstatus = "";
        string eduattain = "";
        string Status = "";


        public editStudentForm(string fn, string ln, string mn, string gen,
                                int age, string civil, string bd, string pob, string cn, string nat, string rel, string EducAt, string add, string status, string remark, string sno )
        {
            InitializeComponent();
            txtStudentID.Text = sno;
            txtFirstname.Text = fn;
            txtLastname.Text = ln;
            txtMiddlename.Text = mn;
            txtNationality.Text = nat;
            txtAddress.Text = add;
            txtPOB.Text = pob;
            txtReligion.Text = rel;
            textBox24.Text = cn;
            textBox19.Text = age + "";
            cbRemarks.Text = remark;

            gender = gen;
            civilstatus = civil;
            eduattain = EducAt;
            Status = status;

            int count = 0;

            if (remark == "Deceased")
            {
                count = 0;
            }

            else if (remark == "Transfered")
            {
                count = 1;
            }
            else if (remark == "Others")
            {
                count = 2;
            }

            cbRemarks.SelectedIndex = count;

            if (status == "Active")
            {
                radioButton9.Checked = true;
            }
            else
            {
                radioButton8.Checked = true;
            }

            if (gen == "Male")
            {
                radioButton12.Checked = true;
            }
            else
            {
                radioButton13.Checked = true;
            }
            
            if (civil == "Single")
            {
               
                radioButton1.Checked = true;

            }
            else if (civil == "Married")
            {
                radioButton2.Checked = true;
            }
            else
            {
                radioButton14.Checked = true;
            }

            if (EducAt == "Elementary")
            {
                radioButton5.Checked = true;
            }
            else if (EducAt == "Highschool")
            {
                radioButton4.Checked = true;
            }
            else if (EducAt == "Under Graduate")
            {
                radioButton3.Checked = true;
            }
            else
            {
                radioButton6.Checked = true;
            }

           
        }

        private void editStudentForm_Load(object sender, EventArgs e)
        {
            if (radioButton9.Checked)
            {
                cbRemarks.Enabled = false;
            }
            else if (radioButton8.Checked)
            {
                cbRemarks.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
                basicDetailsController.basicDetailsUpdate(txtFirstname.Text.Trim(), txtLastname.Text.Trim(), txtMiddlename.Text.Trim(), gender,
                                                            int.Parse(textBox19.Text.Trim()), civilstatus, dateTimePicker1.Value.ToShortDateString(), txtPOB.Text.Trim(),
                                                            textBox24.Text.Trim(), txtNationality.Text.Trim(), txtReligion.Text.Trim(), eduattain ,txtAddress.Text.Trim(), Status,cbRemarks.SelectedItem.ToString(), txtStudentID.Text.Trim());
                MessageBox.Show("Succesfully Updated Student Personal Info");
                this.Hide();
           
            
        }

       

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtLastname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {
           
        }

        //cs
        private void radioButton1_Click(object sender, EventArgs e)
        {
            civilstatus = "Single";
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            civilstatus = "Married";
        }

        private void radioButton14_Click(object sender, EventArgs e)
        {
            civilstatus = "Divorced";
        }

        private void radioButton9_Click(object sender, EventArgs e)
        {
            Status = "Active"; 
        }

        private void radioButton8_Click(object sender, EventArgs e)
        {
            Status = "Inactive";
        }

        private void radioButton12_Click(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void radioButton13_Click(object sender, EventArgs e)
        {
            gender = "Female";
        }

        private void radioButton5_Click(object sender, EventArgs e)
        {
            eduattain = "Elementary";
        }

        private void radioButton4_Click(object sender, EventArgs e)
        {
            eduattain = "Highschool";
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            eduattain = "Under Graduate";
        }

        private void radioButton6_Click(object sender, EventArgs e)
        {
            eduattain = "College Graduate";
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
