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
    public partial class RecordsRep : Form
    {
        DataSet ds = new DataSet();
        public RecordsRep(DataSet ds)
        {
            InitializeComponent();
            this.ds = ds;
        }

        private void RecordsRep_Load(object sender, EventArgs e)
        {
            memberReport cs = new memberReport();
            cs.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cs;

        }
    }
}
