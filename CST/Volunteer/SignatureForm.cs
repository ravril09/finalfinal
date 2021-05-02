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

using System.Drawing.Imaging;

namespace CST.Volunteer
{
    public partial class SignatureForm : Form
    {
        string sno = "";
        BasicDetailsController detailsController = new BasicDetailsController();

        string imageLocation = ""; 

        public SignatureForm(string sno)
        {
            InitializeComponent();
            this.sno = sno;
        }

        private async void button1_Click(object sender, EventArgs e)
        {

            if (pix1.Image == null)
                return;

       
            await detailsController.updateImgPath2(imageLocation, sno);

            MessageBox.Show("Succesfully update signature", "Message",
                MessageBoxButtons.OK, MessageBoxIcon.Information);


            this.Hide();

            

        }


     

        private void btnupload_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                Image img = new Bitmap(open.FileName);
                imageLocation = open.FileName;
                pix1.Image = img;
            }
      
        }                 
    }
}

