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
    public partial class MembershipReportDiag : Form
    {

        BasicDetailsController basicDetailsController = new BasicDetailsController();
        private string sno = "";
        public MembershipReportDiag(string sno)
        {
            InitializeComponent();
            this.sno = sno;
        }

        private async void MembershipReportDiag_Load(object sender, EventArgs e)
        {
            try_rpt try_Rpt = new try_rpt();

            string path = await basicDetailsController.getImgPath(sno);

            try_Rpt.SetParameterValue("imgPathParam", path);

            crystalReportViewer1.ReportSource = try_Rpt;
        }
    }
}
