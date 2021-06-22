using CST.Models;
using CST.Models.Member;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST.System_Admin
{
    public partial class SmsNotification : Form
    {       
        SeniorBasicDetail seniorBasicDetail = new SeniorBasicDetail();
        BasicDetailsController basicDetailsController = new BasicDetailsController();

        string sno = "";
        string snoValue = "";
        string template = "";

        public SmsNotification()
        {
            InitializeComponent();
            timer1.Start();
        }
        public object itexmo(string Number, string Message, string ApiCode, string ApiPassword)
        {
            object functionReturnValue = null;
            using (System.Net.WebClient client = new System.Net.WebClient())
            {
                System.Collections.Specialized.NameValueCollection parameter = new System.Collections.Specialized.NameValueCollection();
                string url = "https://www.itexmo.com/php_api/api.php";
                parameter.Add("1", Number);
                parameter.Add("2", Message);
                parameter.Add("3", ApiCode);
                parameter.Add("passwd", ApiPassword);
                dynamic rpb = client.UploadValues(url, "POST", parameter);
                functionReturnValue = (new System.Text.UTF8Encoding()).GetString(rpb);
            }
            return functionReturnValue;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string number = txtPhoneNumber.Text.Trim();
            string message = txtMessage.Text.Trim();
            string api = "TR-INTIA543288_V2QMF";
            string password = "1}$]la8us$";

            dynamic result = itexmo(number, message, api, password);
            if (result == "0")
            {
                MessageBox.Show("Message Sent");
            }
            else
            {
                MessageBox.Show("Error num " + result + " was encountered");
            }

        }

        private async void SmsNotification_Load(object sender, EventArgs e)
        {
            List<ComboBoxItem> datas = await basicDetailsController.getComboDatas();
            cbox1.Items.AddRange(datas.ToArray());

            label7.Hide();

            textBox1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime my = DateTimeOffset.Now.DateTime.ToLocalTime().ToUniversalTime();


            DateTime mys = DateTimeOffset.Now.UtcDateTime.ToLocalTime();



            label7.Text = my.ToString("MM/dd/yyyy  hh:mm:ss tt");

            timer1.Enabled = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void pbClose_Click(object sender, EventArgs e)
        {
            SeniorBasicDetail seniorBasicDetail = await basicDetailsController.getModel(snoValue);

            if (seniorBasicDetail.sno == "")
            {
                MessageBox.Show("No SCO Exits");
                sno = "";
            }
            else
            {
                textBox1.Text = seniorBasicDetail.fullName;
                txtPhoneNumber.Text = seniorBasicDetail.cno;                
                sno = "SCO-" + snoValue;                
            }

        }

        private void cbox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            snoValue = (cbox1.SelectedItem as ComboBoxItem).Value.ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            template = "Magandang Umaga po! Ito po ang SCOM - 6 para iupdate kayo sa mga sumusunod na paalala:";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            template = "Magandang Tanghali po! Ito po ang SCOM - 6 para iupdate kayo sa mga sumusunod na paalala:";
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            template = "Magandang Gabi po! Ito po ang SCOM - 6 para iupdate kayo sa mga sumusunod na paalala:";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                txtMessage.ResetText();
                txtMessage.AppendText("Magandang araw po. Ito po ang SCOM-VI para ipaalala ang mga sumusunod tungkol sa FINANCIAL ASSISTANCE");
            }
            else if (radioButton2.Checked)
            {
                txtMessage.ResetText();
                txtMessage.AppendText("Magandang araw po. Ito po ang SCOM-VI para ipaalala ang mga sumusunod tungkol sa BENEFITS ASSISTANCE");
            }
            else if (radioButton14.Checked)
            {
                txtMessage.ResetText();
                txtMessage.AppendText("Magandang araw po. Ito po ang SCOM-VI para ipaalala ang mga sumusunod tungkol sa mga darating na EVENT");
            }
        }
    }
}
