using CST.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST.Volunteer
{
    public partial class editOtherSkill : Form
    {
        string sno;
        OtherDetailsController editOtherController = new OtherDetailsController();
        public editOtherSkill(string EduAt,
                                        string Occ,
                                        string annu,
                                        string otskill,
                                        string DiaSpoken,
                                        string Predict,
                                        string Eaddress,
                                        string sno)
        {
            InitializeComponent();
            txtC1Fullname.Text = EduAt;
            txtOcc.Text = Occ;
            txtAnn.Text = annu;
            txtOther.Text = otskill;
            txtDialect.Text = DiaSpoken;
            txtPrecinct.Text = Predict;
            txtEmail.Text = Eaddress;

            this.sno = sno;
        }

        private bool validationTab2()
        {
            bool isValid = true;

            isValid = !(txtC1Fullname.Text == "") && isValid;

            isValid = !(txtOcc.Text == "") && isValid;

            isValid = !(txtAnn.Text == "") && isValid;

            isValid = !(txtOther.Text == "") && isValid;

            isValid = !(txtDialect.Text == "") && isValid;

            isValid = !(txtPrecinct.Text == "") && isValid;

            isValid = !(txtEmail.Text == "") && isValid;

            return isValid;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isValid = validationTab2();

            if (isValid)
            {
                editOtherController.updateOtherDetail(txtC1Fullname.Text.Trim(), txtOcc.Text.Trim(), txtAnn.Text.Trim(), txtOther.Text.Trim(),
                                                        txtDialect.Text.Trim(), txtPrecinct.Text.Trim(), txtEmail.Text.Trim(), sno);

                MessageBox.Show("Succesfully Updated an Other Details");
                this.Hide();
            }
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtOther_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAnn_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
