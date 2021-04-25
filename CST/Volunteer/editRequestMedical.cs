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
    
    public partial class editRequestMedical : Form
    {
        RequestMedicalController requestMedicalController = new RequestMedicalController();
        string sno = "";
        public editRequestMedical(string fn,
                                         string cn,
                                         string add,
                                         string rm,
                                         string sno)
        {
            InitializeComponent();
            txtFullname.Text = fn;
            txtContactNumber.Text = cn;
            txtAddress.Text = add;
            txtRemarks.Text = rm;

            this.sno = sno;
        }

        private bool validationTab1()
        {
            bool isValid = true;

            isValid = !(txtRemarks.Text == "") && isValid;

            return isValid;
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            RegistrarForm reg = new RegistrarForm();
            reg.Show();
            this.Hide();
        }

        private void editRequestMedical_Load(object sender, EventArgs e)
        {
            txtFullname.Enabled = false;
            txtAddress.Enabled = false;
            txtContactNumber.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool isValid = validationTab1();

            if (isValid)
            {
                requestMedicalController.updateRequestMedical(txtFullname.Text.Trim(), txtContactNumber.Text.Trim(), txtAddress.Text.Trim(),
                                                            txtRemarks.Text.Trim(), sno);
                MessageBox.Show("Succesfully Updated Request Eyeglasses Info");
                this.Hide();
            }
        }
    }
}
