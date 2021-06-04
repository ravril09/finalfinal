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
        AuditTrailControl auditTrailControl = new AuditTrailControl();

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
            label13.Hide();

            int i = fp.InitEngine();

            fp.SensorIndex = 0;

            DateTime my = DateTimeOffset.Now.DateTime.ToLocalTime().ToUniversalTime();


            DateTime mys = DateTimeOffset.Now.UtcDateTime.ToLocalTime();



            label13.Text = my.ToString("MM/dd/yyyy  hh:mm:ss tt");
        }


        private void Biometric_FormClosing(object sender, FormClosingEventArgs e)
        {
            fp.EndEngine();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string Fullname = "";
            string foundsno = "";
            bool ARegFeatureChanged = true;

            string strtemp =  fp.GetTemplateAsString();


            List<FpModels> listFpmodels = await fpController.getDataTempStr();

            foreach(FpModels fps in listFpmodels)
            {
                bool result = fp.VerFingerFromStr(fps.fp1, strtemp, false, ARegFeatureChanged);
                bool result2 = fp.VerFingerFromStr(fps.fp2, strtemp, false, ARegFeatureChanged);
                bool result3 = fp.VerFingerFromStr(fps.fp3, strtemp, false, ARegFeatureChanged);


                if(result || result2 || result3)
                {
                    foundsno = fps.sno;
                    
                    break;
                }
            }



            if (!string.IsNullOrEmpty(foundsno))
            {
                SeniorBasicDetail seniorBasicDetail = await basicDetailsController.getModel(foundsno);
                float totalPayment = await membershipfeeController.getTotalPayment(foundsno);
          
                lbnSno.Text = seniorBasicDetail.sno;
                lbnFullname.Text = seniorBasicDetail.fullName;
                lbnBD.Text = seniorBasicDetail.birthdate;
                label12.Text = totalPayment.ToString();
                lbnCs.Text = seniorBasicDetail.civilstatus;
                lbnGender.Text = seniorBasicDetail.gender;
                lbnNatio.Text = seniorBasicDetail.nat;
                lbnAdd.Text = seniorBasicDetail.address;
                lbnRel.Text = seniorBasicDetail.religion;
                lbnPOB.Text = seniorBasicDetail.pob;
                pix1.ImageLocation = seniorBasicDetail.imgPath;                
            }

            auditTrailControl.addAudit(label13.Text, "View Senior Record " + foundsno);
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
