using CST.Models;
using CST.Models.Member;
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
        string snoValue = "";
        string sno = "";
        public RequestEyeglasses()
        {
            InitializeComponent();
        }

        private async void RequestEyeglasses_Load(object sender, EventArgs e)
        {
            List<ComboBoxItem> datas = await basicDetailsController.getComboDatas();
            cbox1.Items.AddRange(datas.ToArray());
            txtFullname.Enabled = false;
            txtContactNumber.Enabled = false;
            txtAddress.Enabled = false;
            txtAge.Enabled = false;
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            SeniorBasicDetail seniorBasicDetail = await basicDetailsController.getModel(snoValue);

            if (seniorBasicDetail.sno == "")
             {
                MessageBox.Show("No SCO Exits");
                sno = "";
            }
            else
            {
                txtFullname.Text = seniorBasicDetail.fullName;
                txtContactNumber.Text = seniorBasicDetail.cno;
                txtAddress.Text = seniorBasicDetail.address;
                txtAge.Text = seniorBasicDetail.age.ToString();
                sno = "SCO-" + snoValue;
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
            bool valid = checkValidation();
            if (valid)
            {


                DialogResult form2 = MessageBox.Show("Do you really want to Save ?",
                      "Add", MessageBoxButtons.YesNo);

                if (form2 == DialogResult.Yes)
                {

                    requestEyeglass.addRequestEyeglass(snoValue, txtFullname.Text.Trim(), txtContactNumber.Text.Trim(),
                                                txtAddress.Text.Trim(), txtAge.Text.Trim(), txtEyegrade.Text.Trim(), txtRemarks.Text.Trim());
                    MessageBox.Show("Successfully Added");
                }
            }
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

        private bool checkValidation()
        {
            bool isValid = true;

            isValid = !(snoValue == "") && isValid;

            isValid = !(txtEyegrade.Text.Trim() == "") && isValid;

            isValid = !(txtEyegrade.Text.Trim() == "") && isValid;


            if (!isValid)
            {
                MessageBox.Show("Please Complete required Data", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



            return isValid;
        }

        private void cbox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            snoValue = (cbox1.SelectedItem as ComboBoxItem).Value.ToString();
        }
    }
}
