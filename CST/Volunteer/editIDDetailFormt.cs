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

namespace CST.Registrar
{
    public partial class editStudHist : Form
    {
        string isVacine = "";
        string sno = "";
        IDDetailsController studHist = new IDDetailsController();
        public editStudHist(string osca,string tin,string phil,string gsis,string sss,string mem,string month,string sno)
        {
            InitializeComponent();
            txtOSCA.Text = osca;
            txtTin.Text = tin;
            txtPhilHealth.Text = phil;
            txtGSIS.Text = gsis;
            txtSSS.Text = sss;
            txtMemberFee.Text = mem;
            txtMonthDues.Text = month;

            this.sno = sno;
        }

        private bool validationTab3()
        {
            bool isValid = true;

            isValid = !(txtOSCA.Text.Trim() == "") && isValid;

            isValid = !(txtTin.Text.Trim() == "") && isValid;

            isValid = !(txtPhilHealth.Text.Trim() == "") && isValid;

            isValid = !(txtGSIS.Text.Trim() == "") && isValid;

            isValid = !(txtSSS.Text.Trim() == "") && isValid;

            isValid = !(txtMemberFee.Text.Trim() == "") && isValid;

            isValid = !(txtMonthDues.Text.Trim() == "") && isValid;


            return isValid;

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validationTab3())
            {
                studHist.updateHisDetails(sno, txtOSCA.Text.Trim(), txtTin.Text.Trim(), txtPhilHealth.Text.Trim(),txtGSIS.Text.Trim(),
                                        txtSSS.Text.Trim(), txtMemberFee.Text.Trim(), txtMonthDues.Text.Trim());
                MessageBox.Show("Succesfully Updated");
                this.Hide();
            }
        }

        private void txtMonthDues_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMemberFee_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOSCA_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSSS_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGSIS_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhilHealth_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
