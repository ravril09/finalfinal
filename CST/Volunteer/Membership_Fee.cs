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
        BasicDetailsController basicDetailsController = new BasicDetailsController();
        MembershipfeeController membershipfeeController = new MembershipfeeController();
        AuditTrailController auditTrail = new AuditTrailController();

        string sno = "";

        public Membership_Fee(string sno, string name)
        {
            InitializeComponent();


            label2.Text = label2.Text + " \t" + name;
            label1.Text = label1.Text + " \t" + sno;

            this.sno = sno;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            membershipfeeController.addMembershipfee(sno, label44.Text.Trim(), int.Parse(textBox1.Text.Trim()));

            MessageBox.Show("Successfully Added Payment fee");

            RegistrarRecord registrarRecord = new RegistrarRecord();
            registrarRecord.Show();
            this.Hide();
        }

        private void Membership_Fee_Load(object sender, EventArgs e)
        {
            label44.Hide();

            DateTime my = DateTimeOffset.Now.DateTime.ToLocalTime().ToUniversalTime();


            DateTime mys = DateTimeOffset.Now.UtcDateTime.ToLocalTime();

            label44.Text = my.ToString("MM/dd/yyyy  hh:mm:ss tt");
        }
    }
}
