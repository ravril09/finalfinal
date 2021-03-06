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
using CST.Models.Student;
using CST.Volunteer;
using CST.Report;

namespace CST.Volunteer
{
    public partial class Payment : Form
    {
        MembershipfeeController membershipfeeController = new MembershipfeeController();
        BasicDetailsController basicDetailsController = new BasicDetailsController();
        PaymentController paymentController = new PaymentController();
        AuditTrailController auditTrail = new AuditTrailController();
        

        bool isValid = false;
        string sno = "";
        string name = "";
        string name1 = "";
        
        public Payment(string sno , string name)
        {
            InitializeComponent();

            fullName.Text = UserLog.getFullName();
            
            label2.Text = label2.Text + " \t" + name;
            label1.Text = label1.Text + " \t" + sno;
            name1 = fullName.Text;
            this.sno = sno;
            this.name = name;
            
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void Payment_Load(object sender, EventArgs e)
        {
   
            label44.Hide();
            fullName.Hide();
            label1.Hide();
        }   

        private async void btnSave_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            float payment = float.Parse(txtMembship.Text.Trim());

            paymentController.addPayment(sno, float.Parse(txtMembship.Text.Trim()), float.Parse(txtGSIS.Text.Trim()));

            membershipfeeController.addMembershipfee(sno,payment);

            MessageBox.Show("Successfully Added Payment fee");

           

            Receipt rec = new Receipt();
            //ReceiptReport rep = new ReceiptReport(sno);

            rec.SetParameterValue("payername", name);
            rec.SetParameterValue("totalAmt", payment);
            int no = await membershipfeeController.getLatestNo();
            rec.SetParameterValue("noParam", no);
            rec.SetParameterValue("preparedBy", name1);


            //rep.ShowDialog();

            rec.PrintToPrinter(1, false, 0, 0);

            this.Hide();


            RegistrarForm registrarForm = new RegistrarForm();
            registrarForm.Show();
            this.Hide();

            //Webcam frm = new Webcam(sno);

            //frm.Show();

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
           
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void label47_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
