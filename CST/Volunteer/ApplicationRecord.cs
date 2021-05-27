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
using CST.Models.Student;
namespace CST.Volunteer
{
    public partial class ApplicationRecord : Form
    {
        PersonalDetailsController personaldetailcontroller = new PersonalDetailsController();
        OtherDetailsController otherdetailcontroller = new OtherDetailsController();
        FamilyDetailController familydetailcontroller = new FamilyDetailController();

        string clickedBut = "";
        public ApplicationRecord()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime my = DateTimeOffset.Now.DateTime.ToLocalTime().ToUniversalTime();


            DateTime mys = DateTimeOffset.Now.UtcDateTime.ToLocalTime();



            label1.Text = my.ToString("MM/dd/yyyy  hh:mm:ss tt");

            timer1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            personaldetailcontroller.fillDataPersonalDetails(ref dataGridView1);
            clickedBut = "Personal";


        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegistrarForm reg = new RegistrarForm();
            reg.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {

                if (clickedBut == "Personal")
                {

                    editPersonalInformation frm = new editPersonalInformation(dataGridView1.SelectedRows[0].Cells[1].Value.ToString(),
                                                              dataGridView1.SelectedRows[0].Cells[2].Value.ToString(),
                                                              dataGridView1.SelectedRows[0].Cells[3].Value.ToString(),
                                                              dataGridView1.SelectedRows[0].Cells[4].Value.ToString(),
                                                              dataGridView1.SelectedRows[0].Cells[5].Value.ToString(),
                                                              int.Parse(dataGridView1.SelectedRows[0].Cells[6].Value.ToString()),
                                                              dataGridView1.SelectedRows[0].Cells[7].Value.ToString(),
                                                              dataGridView1.SelectedRows[0].Cells[8].Value.ToString(),
                                                              dataGridView1.SelectedRows[0].Cells[9].Value.ToString(),
                                                              dataGridView1.SelectedRows[0].Cells[10].Value.ToString(),
                                                              dataGridView1.SelectedRows[0].Cells[11].Value.ToString(),
                                                              dataGridView1.SelectedRows[0].Cells[12].Value.ToString(),
                                                              dataGridView1.SelectedRows[0].Cells[0].Value.ToString()
                                                              );
                    frm.ShowDialog();
                    personaldetailcontroller.fillDataPersonalDetails(ref dataGridView1);

                }
                else if (clickedBut == "Other")
                {
                    editOtherSkill frm = new editOtherSkill(dataGridView1.SelectedRows[0].Cells[1].Value.ToString(),
                                                            dataGridView1.SelectedRows[0].Cells[2].Value.ToString(),
                                                            dataGridView1.SelectedRows[0].Cells[3].Value.ToString(),
                                                            dataGridView1.SelectedRows[0].Cells[4].Value.ToString(),
                                                            dataGridView1.SelectedRows[0].Cells[5].Value.ToString(),
                                                            dataGridView1.SelectedRows[0].Cells[6].Value.ToString(),
                                                            dataGridView1.SelectedRows[0].Cells[7].Value.ToString(),
                                                            dataGridView1.SelectedRows[0].Cells[0].Value.ToString()
                                                            );
                    frm.ShowDialog();
                    otherdetailcontroller.fillOtherDetail(ref dataGridView1);
                }
                else if(clickedBut == "Family")
                {
                    editFamilyDetails frm = new editFamilyDetails(dataGridView1.SelectedRows[0].Cells[1].Value.ToString(),
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
                                                                  dataGridView1.SelectedRows[0].Cells[14].Value.ToString(),
                                                                  dataGridView1.SelectedRows[0].Cells[15].Value.ToString(),
                                                                  dataGridView1.SelectedRows[0].Cells[16].Value.ToString(),
                                                                  dataGridView1.SelectedRows[0].Cells[17].Value.ToString(),
                                                                  dataGridView1.SelectedRows[0].Cells[18].Value.ToString(),
                                                                  dataGridView1.SelectedRows[0].Cells[19].Value.ToString(),
                                                                  dataGridView1.SelectedRows[0].Cells[20].Value.ToString(),
                                                                  dataGridView1.SelectedRows[0].Cells[21].Value.ToString(),
                                                                  dataGridView1.SelectedRows[0].Cells[22].Value.ToString(),
                                                                  dataGridView1.SelectedRows[0].Cells[23].Value.ToString(),
                                                                  dataGridView1.SelectedRows[0].Cells[24].Value.ToString(),
                                                                  dataGridView1.SelectedRows[0].Cells[25].Value.ToString(),
                                                                  dataGridView1.SelectedRows[0].Cells[0].Value.ToString()
                                                                  );
                    frm.ShowDialog();
                    familydetailcontroller.fillFamilyDetails(ref dataGridView1);
                }
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            otherdetailcontroller.fillOtherDetail(ref dataGridView1);
            clickedBut = "Other";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            familydetailcontroller.fillFamilyDetails(ref dataGridView1);
            clickedBut = "Family";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void button6_Click_1(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            ds = await personaldetailcontroller.getDs();

            ds.Tables.Add(dt);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.AutoResizeColumns();
            ds.WriteXmlSchema("C:\\xmlrep\\PrintNationalID2.xml");
        }
    }
}
