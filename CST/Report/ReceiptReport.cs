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

namespace CST.Report
{
    public partial class ReceiptReport : Form
    {
        // Control
        BasicDetailsController basicDetailsController = new BasicDetailsController();

        private string sno = "";
        public ReceiptReport(string sno)
        {
            InitializeComponent();
            this.sno = sno;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void ReceiptReport_Load(object sender, EventArgs e)
        {

        }
    }
}
