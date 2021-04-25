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

namespace CST.Volunteer
{
    public partial class Payment : Form
    {
        BasicDetailsController basicDetailsController = new BasicDetailsController();
        PaymentController paymentController = new PaymentController();
        AuditTrailController auditTrail = new AuditTrailController();
        

        bool isValid = false;
        string sno = "";
        public Payment(string sno , string name)
        {
            InitializeComponent();

            label2.Text = label2.Text + " \t" + name;
            label1.Text = label1.Text + " \t" + sno;
            this.sno = sno;
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void Payment_Load(object sender, EventArgs e)
        {
   
            label44.Hide();
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            paymentController.addPayment(sno, int.Parse(txtOSCA.Text.Trim()), int.Parse(txtGSIS.Text.Trim()));

            MessageBox.Show("Successfully Added Payment fee");

            this.Hide();

            Webcam frm = new Webcam();

            frm.Show();
           
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
    }
}
