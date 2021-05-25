using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CST.Models.Student;
using CST.Models;

namespace CST.Registrar
{
    public partial class editStudFam : Form
    {
        string sno = "";
        ChildrenDetailsController studFamDetailsController = new ChildrenDetailsController();
        public editStudFam(string c1na, string c1n, string c1ad, string c2na, string c2n,
                                    string c2ad, string c3na, string c3n, string c3ad, string en, string ead, string erl, string econ, string sno)
        {
            InitializeComponent();

            txtC1Fullname.Text = c1na;
            txtC1Mobile.Text = c1n;
            txtC1Address.Text = c1ad;
            txtC2Fullname.Text = c2na;
            txtC2Mobile.Text = c2n;
            txtC2Address.Text = c2ad;
            txtC3Fullname.Text = c3na;
            txtC3Mobile.Text = c3n;
            txtC3Address.Text = c3ad;
            txtEfullName.Text = en;
            txtEAddress.Text = ead;
            txtERelation.Text = erl;
            txtEContactNo.Text = econ;

            this.sno = sno;
        }

       

        private void editStudFam_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            bool isValid = validationTab2();

            if (isValid)
            {
                
                studFamDetailsController.updateFamDetails(sno,txtC1Fullname.Text.Trim(), txtC1Mobile.Text.Trim(), txtC1Address.Text.Trim(), txtC2Fullname.Text.Trim(),
                                        txtC2Mobile.Text.Trim(), txtC2Address.Text.Trim(), txtC3Fullname.Text.Trim(), txtC3Mobile.Text.Trim(), txtC3Address.Text.Trim(), txtEfullName.Text.Trim(),
                                         txtEAddress.Text.Trim(), txtERelation.Text.Trim(), txtEContactNo.Text.Trim());
              
                MessageBox.Show("Succesfully Updated an Family Details");
                this.Hide();
            }
       
        }

        private bool validationTab2()
        {
            bool isValid = true;

            isValid = !(txtEfullName.Text == "") && isValid;

            isValid = !(txtEAddress.Text == "") && isValid;

            isValid = !(txtERelation.Text == "") && isValid;

            isValid = !(txtEContactNo.Text == "") && isValid;

            return isValid;
        }

      
        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            SeniorModel.clearAll(); 
        }

        private void txtC3Mobile_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtC3Address_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtC3Fullname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void label42_Click(object sender, EventArgs e)
        {

        }

        private void label40_Click(object sender, EventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
    
}
