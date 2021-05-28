﻿using System;
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
    public partial class ApplicationforNationalIDReport : Form
    {
        DataSet ds = new DataSet();
        public ApplicationforNationalIDReport(DataSet ds)
        {
            InitializeComponent();
            this.ds = ds;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            PrintNational cs = new PrintNational();
            cs.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cs;
        }
    }
}
