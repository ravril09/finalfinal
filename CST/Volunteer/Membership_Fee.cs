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
    public partial class Membership_Fee : Form
    {
        PaymentController paymentController = new PaymentController();
        BasicDetailsController basicDetailsController = new BasicDetailsController();
        MembershipfeeController membershipfeeController = new MembershipfeeController();
        AuditTrailController auditTrail = new AuditTrailController();

        string sno = "";
        float monthlyPayment = 0;

        public Membership_Fee(string sno, string name)
        {
            InitializeComponent();


            label2.Text = label2.Text + " \t" + name;
            label1.Text = label1.Text + " \t" + sno;

            this.sno = sno;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isValidNumber = float.TryParse(textBox1.Text.Trim(), out _);



            if (!isValidNumber)
                return;


            float payment = float.Parse(textBox1.Text.Trim());


            if (monthlyPayment > payment)
            {
                MessageBox.Show("Monthly payment is greater than the payment", "validation", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            membershipfeeController.addMembershipfee(sno, payment);

            MessageBox.Show("Successfully Added Payment fee");
 
            this.Hide();
        }

        private async void Membership_Fee_Load(object sender, EventArgs e)
        {
            label44.Hide();
            monthlyPayment = await paymentController.getPayment(sno);

            DateTime my = DateTimeOffset.Now.DateTime.ToLocalTime().ToUniversalTime();


            DateTime mys = DateTimeOffset.Now.UtcDateTime.ToLocalTime();

            label44.Text = my.ToString("MM/dd/yyyy  hh:mm:ss tt");

            label5.Text = $"Monthly Payment: {monthlyPayment}";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
