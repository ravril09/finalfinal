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

namespace CST.Volunteer
{
    public partial class editRequesEyeglasses : Form
    {
        RequestEyeglassController requesteyecontroller = new RequestEyeglassController();
        string sno = "";
        string gender = "";
        public editRequesEyeglasses(string fn,
                                           string cn,
                                           string add,
                                           string age,
                                           string eye,
                                           string rm,
                                           string sno)
        {
            InitializeComponent();
            txtFullname.Text = fn;
            txtContactNumber.Text = cn;
            txtAddress.Text = add;
            txtAge.Text = age;
            txtEyegrade.Text = eye;
            txtRemarks.Text = rm;

            this.sno = sno;
        }

        private bool validationTab1()
        {
            bool isValid = true;

            isValid = !(txtEyegrade.Text == "") && isValid;

            isValid = !(txtRemarks.Text == "") && isValid;

            return isValid;
        }

        private void editRequesEyeglasses_Load(object sender, EventArgs e)
        {
            txtFullname.Enabled = false;
            txtContactNumber.Enabled = false;
            txtAddress.Enabled = false;
            txtAge.Enabled = false;
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            bool isValid = validationTab1();

            if (isValid)
            {
                requesteyecontroller.updateRequestEyeglass(txtFullname.Text.Trim(), txtContactNumber.Text.Trim(),txtAddress.Text.Trim(),txtAge.Text.Trim(), txtEyegrade.Text.Trim(),
                                                            txtRemarks.Text.Trim(), sno);
                MessageBox.Show("Succesfully Updated Request Eyeglasses Info");
                this.Hide();
            }
        }
    }
}
