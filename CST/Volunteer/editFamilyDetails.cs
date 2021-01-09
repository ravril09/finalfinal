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
    public partial class editFamilyDetails : Form
    {
        string sno;
        FamilyDetailController familyDetailController = new FamilyDetailController();
        public editFamilyDetails(string f1fn,
                                        string f1rs,
                                        string f1age,
                                        string f1occ,
                                        string inc,
                                        string f2fn,
                                        string f2rs,
                                        string f2age,
                                        string f2occ,
                                        string f2inc,
                                        string f3fn,
                                        string f3rs,
                                        string f3age,
                                        string f3occ,
                                        string f3inc,
                                        string f4fn,
                                        string f4rs,
                                        string f4age,
                                        string f4occ,
                                        string f4inc,
                                        string f5fn,
                                        string f5rs,
                                        string f5age,
                                        string f5occ,
                                        string f5inc,
                                        string sno)
        {
            InitializeComponent();
            txtf1name.Text = f1fn;
            txtf1rel.Text = f1rs;
            txtf1Age.Text = f1age;
            txtf1Occ.Text = f1occ;
            txtf1Income.Text = inc;
            txtf2name.Text = f2fn;
            txtf2rel.Text = f2rs;
            txtf2Age.Text = f2age;
            txtf2Occ.Text = f2occ;
            txtf2Income.Text = f2inc;
            txtf3name.Text = f3fn;
            txtf3rel.Text = f3rs;
            txtf3Age.Text = f3age;
            txtf3Occ.Text = f3occ;
            txtf3Income.Text = f3inc;
            txtf4name.Text = f4fn;
            txtf4rel.Text = f4rs;
            txtf4Age.Text = f4age;
            txtf4Occ.Text = f4occ;
            txtf4Income.Text = f4inc;
            txtf5name.Text = f5fn;
            txtf5rel.Text = f5rs;
            txtf5Age.Text = f5age;
            txtf5Occ.Text = f5occ;
            txtf5Income.Text = f5inc;

            this.sno = sno;
        }

        private bool validationTab1()
        {
            bool isValid = true;

            isValid = !(txtf1name.Text == "") && isValid;

            isValid = !(txtf1rel.Text == "") && isValid;

            isValid = !(txtf1Age.Text == "") && isValid;

            isValid = !(txtf1Occ.Text == "") && isValid;

            isValid = !(txtf1Income.Text == "") && isValid;

            isValid = !(txtf2name.Text == "") && isValid;

            isValid = !(txtf2rel.Text == "") && isValid;

            isValid = !(txtf2Age.Text == "") && isValid;

            isValid = !(txtf2Occ.Text == "") && isValid;

            isValid = !(txtf2Income.Text == "") && isValid;

            isValid = !(txtf3name.Text == "") && isValid;

            isValid = !(txtf3rel.Text == "") && isValid;

            isValid = !(txtf3Age.Text == "") && isValid;

            isValid = !(txtf3Occ.Text == "") && isValid;

            isValid = !(txtf3Income.Text == "") && isValid;

            isValid = !(txtf4name.Text == "") && isValid;

            isValid = !(txtf4rel.Text == "") && isValid;

            isValid = !(txtf4Age.Text == "") && isValid;

            isValid = !(txtf4Occ.Text == "") && isValid;

            isValid = !(txtf4Income.Text == "") && isValid;

            isValid = !(txtf5name.Text == "") && isValid;

            isValid = !(txtf5rel.Text == "") && isValid;

            isValid = !(txtf5Age.Text == "") && isValid;

            isValid = !(txtf5Occ.Text == "") && isValid;

            isValid = !(txtf5Income.Text == "") && isValid;

            return isValid;
        }

        private void txtf5Income_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtf5Occ_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtf5Age_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtf5rel_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtf5name_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtf4Income_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtf4Occ_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtf4Age_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtf4rel_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtf4name_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtf3Income_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtf3Occ_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtf3Age_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtf3rel_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtf3name_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtf2Income_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtf2Occ_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtf2Age_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtf2rel_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtf2name_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtf1Income_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtf1Occ_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtf1Age_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtf1rel_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtf1name_TextChanged(object sender, EventArgs e)
        {

        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isValid = validationTab1();

            if (isValid)
            {
                familyDetailController.updateFamilyDetail(txtf1name.Text.Trim(), txtf1rel.Text.Trim(), txtf1Age.Text.Trim(), txtf1Occ.Text.Trim(), txtf1Income.Text.Trim(),
                                                           txtf2name.Text.Trim(), txtf2rel.Text.Trim(), txtf2Age.Text.Trim(), txtf2Occ.Text.Trim(), txtf2Income.Text.Trim(),
                                                           txtf3name.Text.Trim(), txtf3rel.Text.Trim(), txtf3Age.Text.Trim(), txtf3Occ.Text.Trim(), txtf3Income.Text.Trim(),
                                                           txtf4name.Text.Trim(), txtf4rel.Text.Trim(), txtf4Age.Text.Trim(), txtf4Occ.Text.Trim(), txtf4Income.Text.Trim(),
                                                           txtf5name.Text.Trim(), txtf5rel.Text.Trim(), txtf5Age.Text.Trim(), txtf5Occ.Text.Trim(), txtf5Income.Text.Trim(),sno);

                MessageBox.Show("Succesfully Updated Family Details");
                this.Hide();
            }
        }
    }
}
