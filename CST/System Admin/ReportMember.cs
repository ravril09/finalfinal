using CST.Models;
using CST.Report;
using CST.Volunteer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST.System_Admin
{
    public partial class ReportMember : Form
    {
        BasicDetailsController basicDetailsController = new BasicDetailsController();
        RequestEyeglassController requestEyeglassController = new RequestEyeglassController();
        RequestMedicalController medicalController = new RequestMedicalController();
        PersonalDetailsController personalDetailsController = new PersonalDetailsController();
        public ReportMember()
        {
            InitializeComponent();
        }

        private async void button13_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            DataTable dt = new DataTable();

            ds = await basicDetailsController.getActiveMember();

            //ds.Tables.Add(dt);
            //dataGridView1.DataSource = null;
            //dataGridView1.DataSource = ds.Tables[0];
            //dataGridView1.AutoResizeColumns();

            PrintActiveMember rep = new PrintActiveMember(ds);
            rep.ShowDialog();
        }

        private async void button14_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            DataTable dt = new DataTable();

            ds = await basicDetailsController.getInactiveActiveMember();

            //ds.Tables.Add(dt);
            //dataGridView1.DataSource = null;
            //dataGridView1.DataSource = ds.Tables[0];
            //dataGridView1.AutoResizeColumns();

            //ds.WriteXmlSchema("C:\\xmlrep\\PrintInactiveMember.xml");

            PrintInactive rep = new PrintInactive(ds);
            rep.ShowDialog();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();


            DataTable dt = new DataTable();

            ds = await basicDetailsController.getDs();

            // dt.Columns.Add("try", typeof(string));


            //   for (int i = 0; i < dataGridView1.Rows.Count; i++)
            //{

            //   dt.Rows.Add(dataGridView1.Rows[i].Cells[0].Value.ToString());
            //    }

            //ds.Tables.Add(dt);
            //dataGridView1.DataSource = null;
            //dataGridView1.DataSource = ds.Tables[0];
            //dataGridView1.AutoResizeColumns();

            //ds.WriteXmlSchema("C:\\xmlrep\\PrintMasterlist.xml");




            RecordsRep rep = new RecordsRep(ds);
            rep.ShowDialog();

        }

        private async void button9_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            ds = await requestEyeglassController.getRequestEyeglasses();

            //ds.Tables.Add(dt);
            //dataGridView1.DataSource = null;
            //dataGridView1.DataSource = ds.Tables[0];
            //dataGridView1.AutoResizeColumns();
            //ds.WriteXmlSchema("C:\\xmlrep\\PrintMedicalRecord.xml");

            RecordRequestEyeglasses rep = new RecordRequestEyeglasses(ds);
            rep.ShowDialog();

        }

        private async void button10_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();

            ds = await medicalController.getMedicalRecord();

            //ds.Tables.Add(dt);
            //dataGridView1.DataSource = null;
            //dataGridView1.DataSource = ds.Tables[0];
            //dataGridView1.AutoResizeColumns();
            //ds.WriteXmlSchema("C:\\xmlrep\\RecordMedical.xml");



            RecordRequestMedical rep = new RecordRequestMedical(ds);
            rep.ShowDialog();
        }

        private async void button6_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            ds = await personalDetailsController.getDs();

            //ds.Tables.Add(dt);
            //dataGridView1.DataSource = null;
            //dataGridView1.DataSource = ds.Tables[0];
            //dataGridView1.AutoResizeColumns();
            //ds.WriteXmlSchema("C:\\xmlrep\\PrintNationalID2.xml");

            ApplicationforNationalIDReport rep = new ApplicationforNationalIDReport(ds);
            rep.ShowDialog();
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
          
            this.Hide();
        }
    }
}
