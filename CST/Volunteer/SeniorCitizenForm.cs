using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using CST.Models;
using CST.Models.Student;
using CST.Volunteer;

namespace CST
{
    public partial class StudentForm : Form
    {
        public static string SetValueForText1 = "";

        BasicDetailsController basicdetailController = new BasicDetailsController();
        ChildrenDetailsController studFam = new ChildrenDetailsController();
        IDDetailsController studHis = new IDDetailsController();
        AuditTrailControl auditTrail = new AuditTrailControl();
        // StudentEnrolledController studentEnrolledController = new StudentEnrolledController();

        bool inValid2 = false;
        int currentTab = 0;
        bool inValid = false;
        string gender = "";
        string civil = "";
        public StudentForm()
        {
            InitializeComponent();
            dateTimePicker1.MaxDate = DateTime.Now;


        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            label44.Hide();
            SetValueForText1 = txtStudentID.Text;
           
            txtStudentID.Text = generateSNO();
            txtStudentID.Enabled = false;
            SeniorModel.setSno(generateSNO());
            dateTimePicker1.MaxDate = DateTime.Now;
            inValid = true;
            inValid2 = true;


            radioButton1.Checked = true;
            radioButton12.Checked = true;


            SeniorModel.setBd(dateTimePicker1.Value.ToString().Split()[0]);

        }

        private void button3_Click(object sender, EventArgs e)
        {



        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime my = DateTimeOffset.Now.DateTime.ToLocalTime().ToUniversalTime();


            DateTime mys = DateTimeOffset.Now.UtcDateTime.ToLocalTime();



            label44.Text = my.ToString("MM/dd/yyyy  hh:mm:ss tt");

            timer1.Enabled = true;
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            RegistrarForm frm = new RegistrarForm();
            frm.Show();
            this.Hide();
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
            MessageBox.Show("Succesfully Added Senior Citizen Details");

            Membership_Fee frm = new Membership_Fee(txtStudentID.Text.Trim(), txtFirstname.Text.Trim() + " " + txtLastname.Text.Trim());
            frm.Show();

        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            //Save!!
            //executes query 
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


                basicdetailController.addStudDetails(txtStudentID.Text.Trim(), txtFirstname.Text.Trim(), txtLastname.Text.Trim(), txtMiddlename.Text.Trim(), gender,
                                                            int.Parse(textBox19.Text.Trim()), civil, dateTimePicker1.Value.ToShortDateString(), txtPOB.Text.Trim(),
                                                            txtContact.Text.Trim(), txtNationality.Text.Trim(), txtReligion.Text.Trim(), txtAddress.Text.Trim());
                studFam.addFamDetails(txtStudentID.Text.Trim(), txtC1Fullname.Text.Trim(), txtC1Mobile.Text.Trim(), txtC1Address.Text.Trim(), txtC2Fullname.Text.Trim(),
                                        txtC2Mobile.Text.Trim(), txtC2Address.Text.Trim(), txtC3Fullname.Text.Trim(), txtC3Mobile.Text.Trim(), txtC3Address.Text.Trim(), txtEfullName.Text.Trim(),
                                         txtEAddress.Text.Trim(), txtERelation.Text.Trim(), txtEContactNo.Text.Trim());
                studHis.addIDDetails(txtStudentID.Text.Trim(), txtOSCA.Text.Trim(), txtTin.Text.Trim(), txtPhilHealth.Text.Trim(), txtGSIS.Text.Trim(),
                                       txtSSS.Text.Trim());


                auditTrail.addAudit(label44.Text, "Add Senior Data " + txtStudentID.Text.Trim());

               
                this.Hide();


            }
            else
            {
                MessageBox.Show("Please Complete Information for the Details.. ", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }



        //private void getAllChildDetails()
        //{
        //    famDetails[0] = SeniorModel.getChildren1_name();
        //    famDetails[1] = SeniorModel.getChildren1_no();
        //    famDetails[2] = SeniorModel.getChildren1_add();

        //    famDetails[3] = SeniorModel.getChildren2_name();
        //    famDetails[4] = SeniorModel.getChildren2_no();
        //    famDetails[5] = SeniorModel.getChildren2_add();

        //    famDetails[6] = SeniorModel.getChildren3_name();
        //    famDetails[7] = SeniorModel.getChildren3_no();
        //    famDetails[8] = SeniorModel.getChildren3_add();

        //    famDetails[9] = SeniorModel.getEmer_name();
        //    famDetails[10] = SeniorModel.getEmer_add();
        //    famDetails[11] = SeniorModel.getEmer_rel();
        //    famDetails[12] = SeniorModel.getEmer_no();

        //}

        //private void getAllIdDetail()
        //{
        //    IdDetails[0] = SeniorModel.getOSCA();
        //    IdDetails[1] = SeniorModel.getTin();
        //    IdDetails[2] = SeniorModel.getPhil();
        //    IdDetails[3] = SeniorModel.getGSIS();
        //    IdDetails[4] = SeniorModel.getSSS();
        //    IdDetails[5] = SeniorModel.getMemship();
        //    IdDetails[6] = SeniorModel.getMonthly();
        //}

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {




        }

        private bool validationTab2()
        {
            bool isValid = true;

            isValid = !(SeniorModel.getEmer_name() == "") && isValid;

            isValid = !(SeniorModel.getEmer_add() == "") && isValid;

            isValid = !(SeniorModel.getEmer_rel() == "") && isValid;

            isValid = !(SeniorModel.getEmer_no() == "") && isValid;

            return isValid;
        }



        private bool validationTab1()
        {
            bool isValid = true;

            isValid = !(SeniorModel.getFn() == "") && isValid;

            isValid = !(SeniorModel.getLn() == "") && isValid;

            isValid = !(SeniorModel.getGen() == "") && isValid;

            isValid = !(SeniorModel.getCn() == "") && isValid;

            isValid = !(SeniorModel.getAge() == 0) && isValid;

            isValid = !(SeniorModel.getCivil() == "") && isValid;

            isValid = !(SeniorModel.getbirthdate() == "") && isValid;

            isValid = !(SeniorModel.getPob() == "") && isValid;

            isValid = !(SeniorModel.getNat() == "") && isValid;

            isValid = !(SeniorModel.getRel() == "") && isValid;

            isValid = !(SeniorModel.getAddress() == "") && isValid;



            return isValid;
        }



        private string generateSNO()
        {
            Random random = new Random();
            int values = random.Next(10000);
            //textBox3.Text = "CST-2013-" + values.ToString();

            string sno = "SCO-" + values.ToString();

            return sno;
        }

        //private string fixID(int lastid)
        //{
        //    string id = "";
        //    if(lastid < 10)
        //    {
        //        id = "000" + lastid;
        //    }else if(lastid>= 10 && lastid< 100)
        //    {
        //        id = "00" + lastid;
        //    }else if(lastid>100 && lastid< 1000)
        //    {
        //        id = "0" + lastid;
        //    }else if (lastid > 999)
        //    {
        //        id = lastid + "";
        //    }
        //    return id;
        //}


        private void txtLastname_TextChanged(object sender, EventArgs e)
        {
            SeniorModel.setLn(txtLastname.Text.Trim());
        }

        private void txtFirstname_TextChanged(object sender, EventArgs e)
        {
            SeniorModel.setFn(txtFirstname.Text.Trim());

        }

        private void txtMiddlename_TextChanged(object sender, EventArgs e)
        {
            SeniorModel.setMn(txtMiddlename.Text.Trim());
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            if (textBox19.Text != "")
            {
                SeniorModel.setAge(int.Parse(textBox19.Text.Trim()));
            }

        }

        private void textBox19_KeyPress(object sender, KeyPressEventArgs e)
        {
            string validKeys = "0123456789";
            if (validKeys.IndexOf(e.KeyChar) < 0 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            SeniorModel.setBd(dateTimePicker1.Value.ToString("MM/dd/yyyy"));
            int yrNow = DateTime.Now.Year;
            int bdate = dateTimePicker1.Value.Year;
            int age = yrNow - bdate;
            textBox19.Text = age.ToString();
        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {
            SeniorModel.setCn(txtContact.Text.Trim());
        }

        private void textBox24_KeyPress(object sender, KeyPressEventArgs e)
        {
            string validKeys = "0123456789+";
            if (validKeys.IndexOf(e.KeyChar) < 0 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNationality_TextChanged(object sender, EventArgs e)
        {
            SeniorModel.setNat(txtNationality.Text.Trim());
        }

        private void txtReligion_TextChanged(object sender, EventArgs e)
        {
            SeniorModel.setRel(txtReligion.Text.Trim());
        }

        private void txtPOB_TextChanged(object sender, EventArgs e)
        {
            SeniorModel.setPlaceofbirth(txtPOB.Text.Trim());
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            SeniorModel.setAddress(txtAddress.Text.Trim());
        } 

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            SeniorModel.setGender(radioButton12.Text.Trim());
            if (radioButton12.Checked)
            {
                gender = "Male";
            }
            else
            {
               gender = "Female";
            }
        }

        private void errorHandlingIsEmpty(ref TextBox tb,string message)
        {
            if(tb.Text == string.Empty)
            {
                errorProvider1.SetError(tb, message);
            }
          
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
        
            if (currentTab == 0)
            {

              
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
            }else if(currentTab == 1)
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
                    errorHandlingIsEmpty(ref txtEfullName, "Enter Contact name");
                    errorHandlingIsEmpty(ref txtEAddress, "Enter Contact Address");
                    errorHandlingIsEmpty(ref txtERelation, "Enter Contact Relation");
                    errorHandlingIsEmpty(ref txtEContactNo, "Enter Contact Number");
                 
                    MessageBox.Show("Please Complete Information for the Children Details", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(currentTab == 2)
            {
            
               
                int changedPage = tabControl1.SelectedIndex;

                currentTab = changedPage;
                tabControl1.SelectedIndex = changedPage;
             

            }

        }

        private void txtFLast_TextChanged(object sender, EventArgs e)
        {
            //father
            SeniorModel.setChildren1_name(txtC1Fullname.Text.Trim());
        }

        private void txtFFirst_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFMiddle_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFMobile_TextChanged(object sender, EventArgs e)
        {
            SeniorModel.setChildren1_no(txtC1Mobile.Text.Trim());
        }

        private void txtFOccupation_TextChanged(object sender, EventArgs e)
        {
            SeniorModel.setChildren1_add(txtC1Address.Text.Trim());
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            //mother
            SeniorModel.setChildren2_name(txtC2Fullname.Text.Trim());
        }

       
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            SeniorModel.setChildren2_no(txtC2Mobile.Text.Trim());

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            SeniorModel.setChildren2_add(txtC2Address.Text.Trim());
        }


        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            SeniorModel.setEmer_name(txtEfullName.Text.Trim());
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            SeniorModel.setEmer_add(txtEAddress.Text.Trim());
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            SeniorModel.setEmer_rel(txtERelation.Text.Trim());
    
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            SeniorModel.setEmer_no(txtEContactNo.Text.Trim());
        }

      
        private void txtFMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            string validKeys = "0123456789";
            if (validKeys.IndexOf(e.KeyChar) < 0 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtFCompanyMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            string validKeys = "0123456789";
            if (validKeys.IndexOf(e.KeyChar) < 0 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            string validKeys = "0123456789";
            if (validKeys.IndexOf(e.KeyChar) < 0 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            string validKeys = "0123456789";
            if (validKeys.IndexOf(e.KeyChar) < 0 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox15_KeyPress(object sender, KeyPressEventArgs e)
        {
            string validKeys = "0123456789";
            if (validKeys.IndexOf(e.KeyChar) < 0 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

       

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

       
        private void txtStudentID_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox10_Enter(object sender, EventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            SeniorModel.setCivil(radioButton1.Text.Trim());
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label52_Click(object sender, EventArgs e)
        {

        }

        private void label51_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtC3Fullname_TextChanged(object sender, EventArgs e)
        {
            SeniorModel.setChildren3_name(txtC3Fullname.Text.Trim());
        }

        private void txtC3Mobile_TextChanged(object sender, EventArgs e)
        {
            SeniorModel.setChildren2_no(txtC3Mobile.Text.Trim());
        }

        private void txtC3Address_TextChanged(object sender, EventArgs e)
        {
            SeniorModel.setChildren3_add(txtC3Address.Text.Trim());
        }

        private void txtOSCA_TextChanged(object sender, EventArgs e)
        {
            SeniorModel.setOSCA(txtOSCA.Text.Trim());
        }

        private void txtTin_TextChanged(object sender, EventArgs e)
        {
            SeniorModel.setTin(txtTin.Text.Trim());
        }

        private void txtPhilHealth_TextChanged(object sender, EventArgs e)
        {
            SeniorModel.setPhil(txtPhilHealth.Text.Trim());
        }

        private void txtGSIS_TextChanged(object sender, EventArgs e)
        {
            SeniorModel.setGSIS(txtGSIS.Text.Trim());
        }

        private void txtSSS_TextChanged(object sender, EventArgs e)
        {
            SeniorModel.setSSS(txtSSS.Text.Trim());
        }

      

        private void label44_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
