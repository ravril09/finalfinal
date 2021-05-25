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
using ZKFPEngXControl;

namespace CST.System_Admin
{
    public partial class Biometric : Form
    {
        FpController fpController = new FpController();
        BasicDetailsController basicDetailsController = new BasicDetailsController();
        MembershipfeeController membershipfeeController = new MembershipfeeController();
        PaymentController paymentController = new PaymentController();
        ZKFPEngX fp = new ZKFPEngX();

        string fpTemp = "";
        
        public static string SetValueForText1 = "";

        public Biometric()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Biometric_Load(object sender, EventArgs e)
        {
            int i = fp.InitEngine();

            fp.SensorIndex = 0;
          //  fp.OnImageReceived += new IZKFPEngXEvents_OnImageReceivedEventHandler(fp_OnImageReceived);
        }


        private void Biometric_FormClosing(object sender, FormClosingEventArgs e)
        {
            fp.EndEngine();
        }

        private async void button1_Click(object sender, EventArgs e)
        {

            string foundsno = "";
            bool ARegFeatureChanged = true;
           
           
            string strtemp =  fp.GetTemplateAsString();
           

            Dictionary<string, string> data = await fpController.getDataTempStr();

            foreach(KeyValuePair<string,string> kp in data)
            {
                bool result = fp.VerFingerFromStr(kp.Value, strtemp, false, ARegFeatureChanged);

                if (result)
                {
                    foundsno = kp.Key;
                    break;
                }
            }

            if (!string.IsNullOrEmpty(foundsno))
            {
                SeniorBasicDetail seniorBasicDetail = await basicDetailsController.getModel(foundsno);
                MembershipFeeModel membershipFeeModel = await paymentController.getModel(foundsno);

                lbnSno.Text = seniorBasicDetail.sno;
                lbnFullname.Text = seniorBasicDetail.fullName;
                lbnBD.Text = seniorBasicDetail.birthdate;
                label12.Text = membershipFeeModel.TotalCont.ToString();
                lbnCs.Text = seniorBasicDetail.civilstatus;
                lbnGender.Text = seniorBasicDetail.gender;
                lbnNatio.Text = seniorBasicDetail.nat;
                lbnAdd.Text = seniorBasicDetail.address;
                lbnRel.Text = seniorBasicDetail.religion;
                lbnPOB.Text = seniorBasicDetail.pob;
                pix1.ImageLocation = seniorBasicDetail.imgPath;


                //label12.Text = seniorPayment.Payment.ToString();
            }


            //Console.WriteLine(regTemplate);
            //if (!result)
            //{
            //    MessageBox.Show("No Data");
            //    return;
            //}

            //SeniorBasicDetail seniorBasicDetail = await fpController.getData(strtemp);

            //label11.Text = seniorBasicDetail.sno;
         
            //    label9.Text = seniorBasicDetail.fullName;



            Image img = pictureBox1.Image;
            

            pictureBox1.Image = img;
            fpTemp = fp.GetTemplateAsString();


        }

        private void fp_OnImageReceived(ref bool AImageValid)
        {
            object imgdata = new object();
            bool b = fp.GetFingerImage(ref imgdata);

            Image x = (Bitmap)((new ImageConverter()).ConvertFrom(imgdata));
            pictureBox1.Image = x;
        }

    }
}
