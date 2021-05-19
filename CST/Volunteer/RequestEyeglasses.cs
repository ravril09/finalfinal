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
    public partial class RequestEyeglasses : Form
    {
        BasicDetailsController basicDetailsController = new BasicDetailsController();
        RequestEyeglassController requestEyeglass = new RequestEyeglassController();
        bool isValid = false;
        string sno = "";
        public RequestEyeglasses()
        {
            InitializeComponent();
        }

        private void RequestEyeglasses_Load(object sender, EventArgs e)
        {
            txtFullname.Enabled = false;
            txtContactNumber.Enabled = false;
            txtAddress.Enabled = false;
            txtAge.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string[] details = basicDetailsController.searchAllDetails(textBox1.Text.Trim());

            if (details[0] == "" || details[0] == null)
            {
                MessageBox.Show("No SCO Exits");
                sno = "";
            }
            else
            {
                txtFullname.Text = details[0] + " " + details[2] + " " + details[1];
                txtContactNumber.Text = details[8];
                txtAddress.Text = details[11];
                txtAge.Text = details[4];
                sno = "SCO-" + textBox1.Text.Trim();
                isValid = true;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            RegistrarForm frm = new RegistrarForm();
            frm.Show();
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            requestEyeglass.addRequestEyeglass(textBox1.Text.Trim(), txtFullname.Text.Trim(), txtContactNumber.Text.Trim(), 
                                                txtAddress.Text.Trim(),txtAge.Text.Trim(),txtEyegrade.Text.Trim(),txtRemarks.Text.Trim());
            MessageBox.Show("Successfully Added");
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
