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
using CST.Models.Student;

namespace CST
{
    public partial class RegistrarRecord : Form
    {


        BasicDetailsController studentsDetailsController = new BasicDetailsController();
        ChildrenDetailsController studFamDetailsController = new ChildrenDetailsController();
        IDDetailsController StudHistDetailsController = new IDDetailsController();

       
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
            studentsDetailsController.fillDataGridDetails(ref dataGridView1);
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
            studentsDetailsController.fillDataGridDetails(ref dataGridView1);
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
                                                                  dataGridView1.SelectedRows[0].Cells[0].Value.ToString()
                                                                  );
                        frm.ShowDialog();
                        StudHistDetailsController.fillDataHist(ref dataGridView1);

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
                        studFamDetailsController.filldataGridFam(ref dataGridView1);


                    }
                    else if (clickedBut == "ID")
                    {
                        editStudHist frm = new editStudHist(dataGridView1.SelectedRows[0].Cells[1].Value.ToString(),
                                                            dataGridView1.SelectedRows[0].Cells[2].Value.ToString(),
                                                            dataGridView1.SelectedRows[0].Cells[3].Value.ToString(),
                                                            dataGridView1.SelectedRows[0].Cells[4].Value.ToString(),
                                                            dataGridView1.SelectedRows[0].Cells[5].Value.ToString(),
                                                            dataGridView1.SelectedRows[0].Cells[6].Value.ToString(),
                                                            dataGridView1.SelectedRows[0].Cells[7].Value.ToString(),
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
            StudHistDetailsController.fillDataHist(ref dataGridView1);
            clickedBut = "ID";
          
        }

        private void button5_Click(object sender, EventArgs e)
        {
            studFamDetailsController.filldataGridFam(ref dataGridView1);
            clickedBut = "Children";
          
        }

      

     
        private void button8_Click(object sender, EventArgs e)
        {
         
     
        }

    

        private void button12_Click(object sender, EventArgs e)
        {

        }
    }
}
