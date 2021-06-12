using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using CST.Registrar;
using CST.Models;
using CST.Report;
using CST.Models.Student;
using CST.Volunteer;

namespace CST
{
    public partial class RegistrarRecord : Form
    {
        
        BasicDetailsController basicDetailsController = new BasicDetailsController();
        ChildrenDetailsController childrenDetailsController = new ChildrenDetailsController();
        IDDetailsController iDDetailsController = new IDDetailsController();

        AuditTrailControl auditTrail = new AuditTrailControl();

       
        string clickedBut = "";
        public RegistrarRecord()
        {
            InitializeComponent();
            timer1.Start();

           
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            basicDetailsController.fillDataGridDetails(ref dataGridView1);
            clickedBut = "Personal";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegistrarForm reg = new RegistrarForm();
            reg.Show();
            this.Hide();
        }

        private void RegistrarRecord_Load(object sender, EventArgs e)
        {
            
            basicDetailsController.fillDataGridDetails(ref dataGridView1);
            clickedBut = "Personal";

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            DateTime my = DateTimeOffset.Now.DateTime.ToLocalTime().ToUniversalTime();


            DateTime mys = DateTimeOffset.Now.UtcDateTime.ToLocalTime();



            label7.Text = my.ToString("MM/dd/yyyy  hh:mm:ss tt");

            timer1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                if (dataGridView1.Rows.Count > 0)
                {

                    if (clickedBut == "Personal")
                    {

                        editStudentForm frm = new editStudentForm(dataGridView1.SelectedRows[0].Cells[1].Value.ToString(),
                                                                  dataGridView1.SelectedRows[0].Cells[2].Value.ToString(),
                                                                  dataGridView1.SelectedRows[0].Cells[3].Value.ToString(),
                                                                  dataGridView1.SelectedRows[0].Cells[4].Value.ToString(),
                                                                  int.Parse(dataGridView1.SelectedRows[0].Cells[5].Value.ToString()),
                                                                  dataGridView1.SelectedRows[0].Cells[6].Value.ToString(),
                                                                  dataGridView1.SelectedRows[0].Cells[7].Value.ToString(),
                                                                  dataGridView1.SelectedRows[0].Cells[8].Value.ToString(),
                                                                  dataGridView1.SelectedRows[0].Cells[9].Value.ToString(),
                                                                  dataGridView1.SelectedRows[0].Cells[10].Value.ToString(),
                                                                  dataGridView1.SelectedRows[0].Cells[11].Value.ToString(),
                                                                  dataGridView1.SelectedRows[0].Cells[12].Value.ToString(),
                                                                  dataGridView1.SelectedRows[0].Cells[13].Value.ToString(),
                                                                  dataGridView1.SelectedRows[0].Cells[14].Value.ToString(),
                                                                  dataGridView1.SelectedRows[0].Cells[0].Value.ToString()
                                                                  );
                        frm.ShowDialog();
                     basicDetailsController.fillDataGridDetails(ref dataGridView1);

                    }
                    else if (clickedBut == "Children")
                    {
                        editStudFam frm = new editStudFam(dataGridView1.SelectedRows[0].Cells[1].Value.ToString(),
                                                          dataGridView1.SelectedRows[0].Cells[2].Value.ToString(),
                                                          dataGridView1.SelectedRows[0].Cells[3].Value.ToString(),
                                                          dataGridView1.SelectedRows[0].Cells[4].Value.ToString(),
                                                          dataGridView1.SelectedRows[0].Cells[5].Value.ToString(),
                                                          dataGridView1.SelectedRows[0].Cells[6].Value.ToString(),
                                                          dataGridView1.SelectedRows[0].Cells[7].Value.ToString(),
                                                          dataGridView1.SelectedRows[0].Cells[8].Value.ToString(),
                                                          dataGridView1.SelectedRows[0].Cells[9].Value.ToString(),
                                                          dataGridView1.SelectedRows[0].Cells[10].Value.ToString(),
                                                          dataGridView1.SelectedRows[0].Cells[11].Value.ToString(),
                                                          dataGridView1.SelectedRows[0].Cells[12].Value.ToString(),
                                                          dataGridView1.SelectedRows[0].Cells[13].Value.ToString(),
                                                          dataGridView1.SelectedRows[0].Cells[0].Value.ToString()

                            );

                        frm.ShowDialog();
                        childrenDetailsController.filldataGridFam(ref dataGridView1);


                    }
                    else if (clickedBut == "ID")
                    {
                        editStudHist frm = new editStudHist(dataGridView1.SelectedRows[0].Cells[1].Value.ToString(),
                                                            dataGridView1.SelectedRows[0].Cells[2].Value.ToString(),
                                                            dataGridView1.SelectedRows[0].Cells[3].Value.ToString(),
                                                            dataGridView1.SelectedRows[0].Cells[4].Value.ToString(),
                                                            dataGridView1.SelectedRows[0].Cells[5].Value.ToString(),
                                                            dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                        frm.ShowDialog();


                    }


                }

          
            
        }
    

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            iDDetailsController.fillDataHist(ref dataGridView1);
            clickedBut = "ID";
          
        }

        private void button5_Click(object sender, EventArgs e)
        {
            childrenDetailsController.filldataGridFam(ref dataGridView1);
            clickedBut = "Children";
          
        }




        private void button8_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim() == "")
            {
                basicDetailsController.fillDataGridDetails(ref dataGridView1);
            }
             else
            {
                string condition = "";
                if (comboBox1.SelectedItem.ToString() == "ID")
                {
                    condition = "sno";
                }
                else
                {
                    condition = comboBox1.SelectedItem.ToString();
                }
                basicDetailsController.searchGid(condition, txtUsername.Text.Trim(),ref dataGridView1);             
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private async  void button6_Click(object sender, EventArgs e)
        {
            //if(dataGridView1.Rows.Count > 0)
            //{
                DataSet ds = new DataSet();


            //DataTable dt = new DataTable();

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

            //ds.WriteXmlSchema("C:\\xmlrep\\PrintSummaryRecordtry.xml");




            RecordsRep rep = new RecordsRep(ds);
            rep.ShowDialog();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;


            if (clickedBut != "Personal")
                return;



            MembershipReportDiag membershipReportDiag = new MembershipReportDiag(
                                    dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            membershipReportDiag.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;


            if (clickedBut != "Personal")
                return;


            Webcam form = new Webcam(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            form.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;


            if (clickedBut != "Personal")
                return;



            SignatureForm signatureForm = new SignatureForm(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            signatureForm.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count == 0)
                return;


            if (clickedBut != "Personal")
                return;

            //firstname,lastname,middlename
            string fullname = $"{dataGridView1.SelectedRows[0].Cells[1].Value.ToString()} {dataGridView1.SelectedRows[0].Cells[3].Value.ToString()}  {dataGridView1.SelectedRows[0].Cells[2].Value.ToString()}";

            Membership_Fee form = new Membership_Fee(dataGridView1.SelectedRows[0].Cells[0].Value.ToString(),fullname);
            form.ShowDialog();

        }

        private void button12_Click_1(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int currentMouseOverRow = dataGridView1.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow >= 0)
                {


                    if (clickedBut == "Personal")
                    {

                        editStudentForm frm = new editStudentForm(dataGridView1.SelectedRows[0].Cells[1].Value.ToString(),
                                                                    dataGridView1.SelectedRows[0].Cells[2].Value.ToString(),
                                                                    dataGridView1.SelectedRows[0].Cells[3].Value.ToString(),
                                                                    dataGridView1.SelectedRows[0].Cells[4].Value.ToString(),
                                                                    int.Parse(dataGridView1.SelectedRows[0].Cells[5].Value.ToString()),
                                                                    dataGridView1.SelectedRows[0].Cells[6].Value.ToString(),
                                                                    dataGridView1.SelectedRows[0].Cells[7].Value.ToString(),
                                                                    dataGridView1.SelectedRows[0].Cells[8].Value.ToString(),
                                                                    dataGridView1.SelectedRows[0].Cells[9].Value.ToString(),
                                                                    dataGridView1.SelectedRows[0].Cells[10].Value.ToString(),
                                                                    dataGridView1.SelectedRows[0].Cells[11].Value.ToString(),
                                                                    dataGridView1.SelectedRows[0].Cells[12].Value.ToString(),
                                                                    dataGridView1.SelectedRows[0].Cells[13].Value.ToString(),
                                                                    dataGridView1.SelectedRows[0].Cells[14].Value.ToString(),
                                                                    dataGridView1.SelectedRows[0].Cells[0].Value.ToString()
                                                                    );
                        frm.ShowDialog();
                        basicDetailsController.fillDataGridDetails(ref dataGridView1);

                    }
                    else if (clickedBut == "Children")
                    {
                        editStudFam frm = new editStudFam(dataGridView1.SelectedRows[0].Cells[1].Value.ToString(),
                                                            dataGridView1.SelectedRows[0].Cells[2].Value.ToString(),
                                                            dataGridView1.SelectedRows[0].Cells[3].Value.ToString(),
                                                            dataGridView1.SelectedRows[0].Cells[4].Value.ToString(),
                                                            dataGridView1.SelectedRows[0].Cells[5].Value.ToString(),
                                                            dataGridView1.SelectedRows[0].Cells[6].Value.ToString(),
                                                            dataGridView1.SelectedRows[0].Cells[7].Value.ToString(),
                                                            dataGridView1.SelectedRows[0].Cells[8].Value.ToString(),
                                                            dataGridView1.SelectedRows[0].Cells[9].Value.ToString(),
                                                            dataGridView1.SelectedRows[0].Cells[10].Value.ToString(),
                                                            dataGridView1.SelectedRows[0].Cells[11].Value.ToString(),
                                                            dataGridView1.SelectedRows[0].Cells[12].Value.ToString(),
                                                            dataGridView1.SelectedRows[0].Cells[13].Value.ToString(),
                                                            dataGridView1.SelectedRows[0].Cells[0].Value.ToString()

                            );

                        frm.ShowDialog();
                        childrenDetailsController.filldataGridFam(ref dataGridView1);


                    }
                    else if (clickedBut == "ID")
                    {
                        editStudHist frm = new editStudHist(dataGridView1.SelectedRows[0].Cells[1].Value.ToString(),
                                                            dataGridView1.SelectedRows[0].Cells[2].Value.ToString(),
                                                            dataGridView1.SelectedRows[0].Cells[3].Value.ToString(),
                                                            dataGridView1.SelectedRows[0].Cells[4].Value.ToString(),
                                                            dataGridView1.SelectedRows[0].Cells[5].Value.ToString(),
                                                            dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                        frm.ShowDialog();

                        iDDetailsController.fillDataHist(ref dataGridView1);
                    }



                }
            }
        }

        private void button12_Click_2(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                if (clickedBut == "Personal")
                {
                   
                    DialogResult form1 = MessageBox.Show("Do you really want to Remove?",
                       "Exit", MessageBoxButtons.YesNo);
                   
                    if (form1 == DialogResult.Yes)
                    {
                        basicDetailsController.deleteBasicDetails(int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
                        auditTrail.addAudit(label7.Text, "Delete a Senior Record");
                        MessageBox.Show("Succesfully Remove Data");
                        basicDetailsController.fillDataGridDetails(ref dataGridView1);
                    }
                }
                else if (clickedBut == "Children")
                {
                    childrenDetailsController.deleteChildren(int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
                    auditTrail.addAudit(label7.Text, "Delete a Children Record");
                    MessageBox.Show("Succesfully Remove Data");
                    childrenDetailsController.filldataGridFam(ref dataGridView1);
                }
                else
                {
                    iDDetailsController.deleteIdDetails(int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
                    auditTrail.addAudit(label7.Text, "Delete a ID Details");
                    MessageBox.Show("Succesfully Remove Data");
                    iDDetailsController.fillDataHist(ref dataGridView1);
                }
            }


        }
    }
}
