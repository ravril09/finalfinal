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
    }
}
