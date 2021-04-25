using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CST.Models;
using CST.Models.Member;
using CST.Registrar;

namespace CST.Volunteer
{
    public partial class ApplicationForm : Form
    {
        PersonalDetailsController personaldetail = new PersonalDetailsController();
        OtherDetailsController otherdetails = new OtherDetailsController();
        FamilyDetailController familydetail = new FamilyDetailController();
        AuditTrailControl auditTrail = new AuditTrailControl();

        bool inValid2 = false;
        int currentTab = 0;
        bool inValid = false;
        string gender = "";
        string civil = "";
        public ApplicationForm()
        {
            InitializeComponent();
            dateTimePicker1.MaxDate = DateTime.Now;
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void ApplicationForm_Load(object sender, EventArgs e)
        {
            label44.Hide();


            txtId.Text = generateSNO();
            txtId.Enabled = false;
            ApplicationNationalIDModel.setSno(generateSNO());
            dateTimePicker1.MaxDate = DateTime.Now;
            inValid = true;
            inValid2 = true;


            radioButton1.Checked = true;
            radioButton12.Checked = true;


            ApplicationNationalIDModel.setBd(dateTimePicker1.Value.ToString().Split()[0]);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            RegistrarForm frm = new RegistrarForm();
            frm.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime my = DateTimeOffset.Now.DateTime.ToLocalTime().ToUniversalTime();


            DateTime mys = DateTimeOffset.Now.UtcDateTime.ToLocalTime();



            label44.Text = my.ToString("MM/dd/yyyy  hh:mm:ss tt");

            timer1.Enabled = true;
        }
        private string generateSNO()
        {
            Random random = new Random();
            int values = random.Next(10000);
            
            string sno = "SCO-" + values.ToString();

            return sno;
        }

        private void txtFirstname_TextChanged(object sender, EventArgs e)
        {
            ApplicationNationalIDModel.setFn(txtFirstname.Text.Trim());
        }

        private void txtLastname_TextChanged(object sender, EventArgs e)
        {
            ApplicationNationalIDModel.setSn(txtLastname.Text.Trim());
        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {
            ApplicationNationalIDModel.setCn(txtContact.Text.Trim());
        }

        private void txtMiddlename_TextChanged(object sender, EventArgs e)
        {
            ApplicationNationalIDModel.setMn(txtMiddlename.Text.Trim());
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            ApplicationNationalIDModel.setGender(radioButton12.Text.Trim());
            if (radioButton12.Checked)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            ApplicationNationalIDModel.setBd(dateTimePicker1.Value.ToString("MM/dd/yyyy"));
            int yrNow = DateTime.Now.Year;
            int bdate = dateTimePicker1.Value.Year;
            int age = yrNow - bdate;
            textBox19.Text = age.ToString();

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            if (textBox19.Text != "")
            {
                ApplicationNationalIDModel.setAge(int.Parse(textBox19.Text.Trim()));
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ApplicationNationalIDModel.setCivil(radioButton1.Text.Trim());
            if (radioButton1.Checked)
            {
                civil = "Single";
            }
            else if (radioButton2.Checked)
            {
                civil = "Married";
            }
            else
            {
                civil = "Divorced";
            }
        }

        private void txtNationality_TextChanged(object sender, EventArgs e)
        {
            ApplicationNationalIDModel.setNat(txtNationality.Text.Trim());
        }

        private void txtReligion_TextChanged(object sender, EventArgs e)
        {
            ApplicationNationalIDModel.setRel(txtReligion.Text.Trim());
        }

        private void txtPOB_TextChanged(object sender, EventArgs e)
        {
            ApplicationNationalIDModel.setPlaceofbirth(txtPOB.Text.Trim());
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            ApplicationNationalIDModel.setAddress(txtAddress.Text.Trim());
        }

        private void txtC1Fullname_TextChanged(object sender, EventArgs e)
        {
            ApplicationNationalIDModel.setEdu(txtC1Fullname.Text.Trim());
        }

        private void txtOcc_TextChanged(object sender, EventArgs e)
        {
            ApplicationNationalIDModel.setOcc(txtOcc.Text.Trim());
        }

        private void txtAnn_TextChanged(object sender, EventArgs e)
        {
            ApplicationNationalIDModel.setAnn(txtAnn.Text.Trim());
        }

        private void txtOther_TextChanged(object sender, EventArgs e)
        {
            ApplicationNationalIDModel.setOtskill(txtOther.Text.Trim());
        }

        private void txtDialect_TextChanged(object sender, EventArgs e)
        {
            ApplicationNationalIDModel.setDspoken(txtDialect.Text.Trim());
        }

        private void txtPrecinct_TextChanged(object sender, EventArgs e)
        {
            ApplicationNationalIDModel.setPreno(txtPrecinct.Text.Trim());
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            ApplicationNationalIDModel.setEmail(txtEmail.Text.Trim());
        }

        private void txtf1name_TextChanged(object sender, EventArgs e)
        {
            ApplicationNationalIDModel.setF1fn(txtf1name.Text.Trim());
        }

        private void txtf1rel_TextChanged(object sender, EventArgs e)
        {
            ApplicationNationalIDModel.setF1rel(txtf1rel.Text.Trim());
        }

        private void txtf1Age_TextChanged(object sender, EventArgs e)
        {
            ApplicationNationalIDModel.setF1age(txtf1Age.Text.Trim());
        }

        private void txtf1Occ_TextChanged(object sender, EventArgs e)
        {
            ApplicationNationalIDModel.setF1occ(txtf1Occ.Text.Trim());
        }

        private void txtf1Income_TextChanged(object sender, EventArgs e)
        {
            ApplicationNationalIDModel.setF1income(txtf1Income.Text.Trim());
        }

        private void txtf2name_TextChanged(object sender, EventArgs e)
        {
            ApplicationNationalIDModel.setF2fn(txtf2name.Text.Trim());
        }

        private void txtf2rel_TextChanged(object sender, EventArgs e)
        {
            ApplicationNationalIDModel.setF2rel(txtf2rel.Text.Trim());
        }

        private void txtf2Age_TextChanged(object sender, EventArgs e)
        {
            ApplicationNationalIDModel.setF2age(txtf2Age.Text.Trim());
        }

        private void txtf2Occ_TextChanged(object sender, EventArgs e)
        {
            ApplicationNationalIDModel.setF2occ(txtf2Occ.Text.Trim());
        }

        private void txtf2Income_TextChanged(object sender, EventArgs e)
        {
            ApplicationNationalIDModel.setF2income(txtf2Income.Text.Trim());
        }

        private void txtf3name_TextChanged(object sender, EventArgs e)
        {
            ApplicationNationalIDModel.setF3fn(txtf3name.Text.Trim());
        }

        private void txtf3rel_TextChanged(object sender, EventArgs e)
        {
            ApplicationNationalIDModel.setF3rel(txtf3rel.Text.Trim());
        }

        private void txtf3Age_TextChanged(object sender, EventArgs e)
        {
            ApplicationNationalIDModel.setF3age(txtf3Age.Text.Trim());
        }

        private void txtf3Occ_TextChanged(object sender, EventArgs e)
        {
            ApplicationNationalIDModel.setF3occ(txtf3Occ.Text.Trim());
        }

        private void txtf3Income_TextChanged(object sender, EventArgs e)
        {
            ApplicationNationalIDModel.setF3income(txtf3Income.Text.Trim());
        }

        private void txtf4name_TextChanged(object sender, EventArgs e)
        {
            ApplicationNationalIDModel.setF4fn(txtf4name.Text.Trim());
        }

        private void txtf4rel_TextChanged(object sender, EventArgs e)
        {
            ApplicationNationalIDModel.setF4rel(txtf4rel.Text.Trim());
        }

        private void txtf4Age_TextChanged(object sender, EventArgs e)
        {
            ApplicationNationalIDModel.setF4age(txtf4Age.Text.Trim());
        }

        private void txtf4Occ_TextChanged(object sender, EventArgs e)
        {
            ApplicationNationalIDModel.setF4occ(txtf4Occ.Text.Trim());
        }

        private void txtf4Income_TextChanged(object sender, EventArgs e)
        {
            ApplicationNationalIDModel.setF4income(txtf4Income.Text.Trim());
        }

        private void txtf5name_TextChanged(object sender, EventArgs e)
        {
            ApplicationNationalIDModel.setF5fn(txtf5name.Text.Trim());
        }

        private void txtf5rel_TextChanged(object sender, EventArgs e)
        {
            ApplicationNationalIDModel.setF5rel(txtf5rel.Text.Trim());
        }

        private void txtf5Age_TextChanged(object sender, EventArgs e)
        {
            ApplicationNationalIDModel.setF5age(txtf5Age.Text.Trim());
        }

        private void txtf5Occ_TextChanged(object sender, EventArgs e)
        {
            ApplicationNationalIDModel.setF5occ(txtf5Occ.Text.Trim());
        }

        private void txtf5Income_TextChanged(object sender, EventArgs e)
        {
            ApplicationNationalIDModel.setF5income(txtf5Income.Text.Trim());
        }

        private bool validationTab1()
        {
            bool isValid = true;

            isValid = !(ApplicationNationalIDModel.getFn() == "") && isValid;

            isValid = !(ApplicationNationalIDModel.getSn() == "") && isValid;

            isValid = !(ApplicationNationalIDModel.getMn() == "") && isValid;

            isValid = !(ApplicationNationalIDModel.getGen() == "") && isValid;

            isValid = !(ApplicationNationalIDModel.getbirthdate() == "") && isValid;

            isValid = !(ApplicationNationalIDModel.getAge() == 0) && isValid;

            isValid = !(ApplicationNationalIDModel.getCivil() == "") && isValid;

            isValid = !(ApplicationNationalIDModel.getNat() == "") && isValid;

            isValid = !(ApplicationNationalIDModel.getRel() == "") && isValid;

            isValid = !(ApplicationNationalIDModel.getPob() == "") && isValid;

            isValid = !(ApplicationNationalIDModel.getAddress() == "") && isValid;


            return isValid;
        }


        private bool validationTab2()
        {
            bool isValid = true;

            isValid = !(ApplicationNationalIDModel.getEduc() == "") && isValid;

            isValid = !(ApplicationNationalIDModel.getOcc() == "") && isValid;

            isValid = !(ApplicationNationalIDModel.getAnnu() == "") && isValid;

            isValid = !(ApplicationNationalIDModel.getOther() == "") && isValid;

            isValid = !(ApplicationNationalIDModel.getSpoken() == "") && isValid;

            isValid = !(ApplicationNationalIDModel.getPre() == "") && isValid;

            isValid = !(ApplicationNationalIDModel.getEmail() == "") && isValid;

            return isValid;
        }

        private void errorHandlingIsEmpty(ref TextBox tb, string message)
        {
            if (tb.Text == string.Empty)
            {
                errorProvider1.SetError(tb, message);
            }

        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (currentTab == 0)
            {
                if (int.Parse(textBox19.Text.Trim()) < 50)
                {
                    MessageBox.Show("Invalid!");
                }

                int changedPage = tabControl1.SelectedIndex;
                bool isValidToNextPage = validationTab1();
                if (isValidToNextPage)
                {

                    currentTab = changedPage;
                    tabControl1.SelectedIndex = changedPage;
                    errorProvider1.Clear();

                }
                else
                {
                    e.Cancel = true;
                    MessageBox.Show("Please Complete Information for the Personal Details", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    errorHandlingIsEmpty(ref txtAddress, "Enter Address");
                    errorHandlingIsEmpty(ref txtLastname, "Enter Lastname");
                    errorHandlingIsEmpty(ref txtMiddlename, "Enter Middlename");
                    errorHandlingIsEmpty(ref txtFirstname, "Enter Firstname");
                    errorHandlingIsEmpty(ref txtContact, "Enter ContactNo");
                    errorHandlingIsEmpty(ref textBox19, "Enter Age");
                    errorHandlingIsEmpty(ref txtNationality, "Enter Nationality");
                    errorHandlingIsEmpty(ref txtReligion, "Enter Religion");
                    errorHandlingIsEmpty(ref txtPOB, "Enter Place of birth");



                }
            }
            else if (currentTab == 1)
            {

                int changedPage = tabControl1.SelectedIndex;

                bool isValidToNextPage = validationTab2();
                if (isValidToNextPage)
                {

                    currentTab = changedPage;
                    tabControl1.SelectedIndex = changedPage;
                    errorProvider1.Clear();
                }
                else
                {
                    e.Cancel = true;
                    errorHandlingIsEmpty(ref txtC1Fullname, "Enter Educational Attaintment");
                    errorHandlingIsEmpty(ref txtOcc, "Enter Occupation");
                    errorHandlingIsEmpty(ref txtAnn, "Enter Annual Income");
                    errorHandlingIsEmpty(ref txtDialect, "Enter Dialect Spoken");
                    errorHandlingIsEmpty(ref txtPrecinct, "Enter Precinct No.");
                    errorHandlingIsEmpty(ref txtEmail, "Enter Email Address");

                    MessageBox.Show("Please Complete Information for the Children Details", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (currentTab == 2)
            {


                int changedPage = tabControl1.SelectedIndex;

                currentTab = changedPage;
                tabControl1.SelectedIndex = changedPage;


            }

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 1; i <= 100; i++)
            {
                Thread.Sleep(10);
                backgroundWorker1.WorkerReportsProgress = true;
                backgroundWorker1.ReportProgress(i);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Succesfully Added Student Details");

            reqattachment rq = new reqattachment();
            rq.Show();
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool isvalid = true;
            isvalid = validationTab1() && isvalid;
            isvalid = validationTab2() && isvalid;
            if (isvalid)
            {
                isvalid = inValid && isvalid;
                isvalid = inValid2 && isvalid;
               
                backgroundWorker1.RunWorkerAsync();
                progressBar1.Show();
                tabControl1.Enabled = false;

                personaldetail.addPersonalDetail(txtId.Text.Trim(), txtFirstname.Text.Trim(), txtLastname.Text.Trim(), txtMiddlename.Text.Trim(), dateTimePicker1.Value.ToShortDateString(),
                                                            txtPOB.Text.Trim(), int.Parse(textBox19.Text.Trim()), gender, civil, txtNationality.Text.Trim(), txtReligion.Text.Trim(),
                                                            txtAddress.Text.Trim(), txtContact.Text.Trim());
                otherdetails.addOtherDetail(txtId.Text.Trim(), txtC1Fullname.Text.Trim(), txtOcc.Text.Trim(), txtAnn.Text.Trim(), txtOther.Text.Trim(), txtDialect.Text.Trim(),
                                             txtPrecinct.Text.Trim(), txtEmail.Text.Trim());

                familydetail.addFamilyDetails(txtId.Text.Trim(), txtf1name.Text.Trim(), txtf1rel.Text.Trim(), txtf1Age.Text.Trim(), txtf1Occ.Text.Trim(), txtf1Income.Text.Trim(),
                                               txtf2name.Text.Trim(), txtf2rel.Text.Trim(), txtf2Age.Text.Trim(), txtf2Occ.Text.Trim(), txtf2Income.Text.Trim(),
                                               txtf3name.Text.Trim(), txtf3rel.Text.Trim(), txtf3Age.Text.Trim(), txtf3Occ.Text.Trim(), txtf3Income.Text.Trim(),
                                               txtf4name.Text.Trim(), txtf4rel.Text.Trim(), txtf4Age.Text.Trim(), txtf4Occ.Text.Trim(), txtf4Income.Text.Trim(),
                                               txtf5name.Text.Trim(), txtf5rel.Text.Trim(), txtf5Age.Text.Trim(), txtf5Occ.Text.Trim(), txtf5Income.Text.Trim()
                                               );
            
                auditTrail.addAudit(label44.Text, "Add Senior Data " + txtId.Text.Trim());

             
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please Complete Information for the Details.. ", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }
    }
}
