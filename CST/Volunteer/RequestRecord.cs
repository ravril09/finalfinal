using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CST.Models;
using CST.Report;

namespace CST.Volunteer
{
    public partial class RequestRecord : Form
    {

        RequestEyeglassController requesteyecontroller = new RequestEyeglassController();
        RequestMedicalController requestMedicalController = new RequestMedicalController();
        RequestMedicalController requestmedicalcontroller = new RequestMedicalController();
        AuditTrailControl auditTrail = new AuditTrailControl();
        string clickedBut = "";
        string clickdel = "";
        public RequestRecord()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                if (clickedBut == "Medical")
                {
                    editRequestMedical frm = new editRequestMedical(dataGridView1.SelectedRows[0].Cells[2].Value.ToString(),
                                                                    dataGridView1.SelectedRows[0].Cells[3].Value.ToString(),
                                                                    dataGridView1.SelectedRows[0].Cells[4].Value.ToString(),
                                                                    dataGridView1.SelectedRows[0].Cells[5].Value.ToString(),
                                                                    dataGridView1.SelectedRows[0].Cells[1].Value.ToString()
                                                                );
                    frm.ShowDialog();
                    requestmedicalcontroller.fillRequetMedical(ref dataGridView1);

                }
                else
                {
                    editRequesEyeglasses frm = new editRequesEyeglasses(dataGridView1.SelectedRows[0].Cells[2].Value.ToString(),
                                                                        dataGridView1.SelectedRows[0].Cells[3].Value.ToString(),
                                                                        dataGridView1.SelectedRows[0].Cells[4].Value.ToString(),
                                                                        dataGridView1.SelectedRows[0].Cells[5].Value.ToString(),
                                                                        dataGridView1.SelectedRows[0].Cells[6].Value.ToString(),
                                                                        dataGridView1.SelectedRows[0].Cells[7].Value.ToString(),
                                                                        dataGridView1.SelectedRows[0].Cells[1].Value.ToString()
                                                                        );
                    frm.ShowDialog();
                    requesteyecontroller.fillRequestEyeglass(ref dataGridView1);
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            RegistrarForm frm = new RegistrarForm();
            frm.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            requesteyecontroller.fillRequestEyeglass(ref dataGridView1);
            clickedBut = "Eyeglasses";
         
        }

        private void button4_Click(object sender, EventArgs e)
        {
            requestmedicalcontroller.fillRequetMedical(ref dataGridView1);
            clickedBut = "Medical";
          
        }

        private void button6_Click(object sender, EventArgs e)
        {

            DialogResult form1 = MessageBox.Show("Do you really want to Remove?",
                   "Exit", MessageBoxButtons.YesNo);


            if (form1 == DialogResult.Yes)
            {
                requestmedicalcontroller.deleteRequestmedical(int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
                auditTrail.addAudit(label7.Text, "Delete a Medical Request");
                MessageBox.Show("Succesfully Remove Data");
                requestmedicalcontroller.fillRequetMedical(ref dataGridView1);


            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
         
                requesteyecontroller.deleteRequestEyeglasses(int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
                auditTrail.addAudit(label1.Text, "Delete a Eyeglasses Request");
                MessageBox.Show("Succesfully Remove Data");
                requesteyecontroller.fillRequestEyeglass(ref dataGridView1);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime my = DateTimeOffset.Now.DateTime.ToLocalTime().ToUniversalTime();


            DateTime mys = DateTimeOffset.Now.UtcDateTime.ToLocalTime();



            label1.Text = my.ToString("MM/dd/yyyy  hh:mm:ss tt");

            timer1.Enabled = true;
        }

        private  void label1_Click(object sender, EventArgs e)
        {

        }

        private async void button9_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            //DataTable dt = new DataTable();

            ds = await requesteyecontroller.getRequestEyeglasses();

            //ds.Tables.Add(dt);
            //dataGridView1.DataSource = null;
            //dataGridView1.DataSource = ds.Tables[0];
            //dataGridView1.AutoResizeColumns();
            //ds.WriteXmlSchema("C:\\xmlrep PrintMedicalRecord.xml");
            RecordRequestEyeglasses rep = new RecordRequestEyeglasses(ds);
            rep.ShowDialog();

        }

        private async void button10_ClickAsync(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            //ds = await requestMedicalController.getMedicalRecord();

            ds.Tables.Add(dt);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.AutoResizeColumns();
            ds.WriteXmlSchema("C:\\xmlrep PrintEyeglasslRecord.xml");
            RecordRequestEyeglasses rep = new RecordRequestEyeglasses(ds);
            rep.ShowDialog();
        }
    }
}
