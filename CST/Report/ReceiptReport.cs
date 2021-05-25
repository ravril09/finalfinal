using CST.Models;
using CST.Models.Member;
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
        PaymentController paymentController = new PaymentController();

        // Model
        MembershipFeeModel membershipFeeModel = new MembershipFeeModel();
        SeniorBasicDetail seniorBasicDetail = new SeniorBasicDetail();
        private string sno = "";
        public ReceiptReport(string sno)
        {
            InitializeComponent();
            this.sno = sno;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            Receipt receipt = new Receipt();

            Task<MembershipFeeModel> task1 = Task.Run(() => paymentController.getModel(sno));
            Task<SeniorBasicDetail> task2 = Task.Run(() => basicDetailsController.getModel(sno));



            membershipFeeModel = task1.Result;
            seniorBasicDetail = task2.Result;
            //seniorChildrenDetails = task3.Result;

            receipt.SetParameterValue("payername", seniorBasicDetail.fullName);
            receipt.SetParameterValue("totalAmt", membershipFeeModel.Payment);
            receipt.SetParameterValue("noParam", seniorBasicDetail.senior_id);

            crystalReportViewer1.ReportSource = receipt;
        }

        private void ReceiptReport_Load(object sender, EventArgs e)
        {

        }
    }
}
