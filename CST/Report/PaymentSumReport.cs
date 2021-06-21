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
    public partial class PaymentSumReport : Form
    {
        DataSet ds = new DataSet();
        SeniorBasicDetail seniorBasicDetail = new SeniorBasicDetail();
        public PaymentSumReport(DataSet ds)
        {
            InitializeComponent();
            

            this.ds = ds;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            PrintSum cs = new PrintSum();
            cs.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cs;

           
        }
    }
}
