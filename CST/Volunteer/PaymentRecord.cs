using CST.Models;
using CST.Report;
using CST.Volunteer.Dialog;
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
    public partial class PaymentRecord : Form
    {
        BasicDetailsController basicDetailsController = new BasicDetailsController();
        PaymentController paymentController = new PaymentController();
        AuditTrailController auditTrail = new AuditTrailController();
     

        public PaymentRecord()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            paymentController.fillDataWithSumpayment(ref dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            paymentController.fillDataGridDetails(ref dataGridView1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MonthDiaglog form = new MonthDiaglog();
            form.ShowDialog();
          
            if (form.monthnum == 0)
                return;

          

            paymentController.fillDataNotPaidInMonth(form.monthnum, form.year, ref dataGridView1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MonthDiaglog form = new MonthDiaglog();
            form.ShowDialog();

            if (form.monthnum == 0)
                return;



            paymentController.fillDataPaidInMonth(form.monthnum, form.year, ref dataGridView1);
        }

        private void PaymentRecord_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click_1(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            //DataTable dt = new DataTable();

            ds = await paymentController.getPaymentSum();

            //ds.Tables.Add(dt);
            //dataGridView1.DataSource = null;
            //dataGridView1.DataSource = ds.Tables[0];
            //dataGridView1.AutoResizeColumns();
            //ds.WriteXmlSchema("C:\\xmlrep\\PrintContribution.xml");

            PaymentSumReport rep = new PaymentSumReport(ds);
            rep.ShowDialog();
        }
    }
}
