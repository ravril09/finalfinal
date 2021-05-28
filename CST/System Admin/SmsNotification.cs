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
        //public string apiKey { get; set; }
        //public string numbers { get; set; }
        //public string message { get; set; }
        //public string sender { get; set; }
        //public string result;

        //AuditTrailControl auditTrail = new AuditTrailControl();

        SeniorBasicDetail seniorBasicDetail = new SeniorBasicDetail();
        BasicDetailsController basicDetailsController = new BasicDetailsController();

        string sno = "";
        string snoValue = "";


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
            string api = "TR-AFRIL915016_RFHGQ";
            string password = "b{$&u$x}y9";

            dynamic result = itexmo(number, message, api, password);
            if (result == "0")
            {
                MessageBox.Show("Message Sent");
            }
            else
            {
                MessageBox.Show("Error num " + result + " was encountered");
            }

            //apiKey = txtAPI.Text;
            //numbers = txtPhoneNumber.Text;
            //message = txtMessage.Text;
            //sender = txtPassword.Text;

            //string url = "https://api.txtlocal.com/send/?apikey=" + apiKey + "&numbers=" + numbers + "&message=" + message + "&sender=" + sender;
            //StreamWriter myWriter = null;
            //HttpWebRequest objRequest = (HttpWebRequest)WebRequest.Create(url);

            //objRequest.Method = "POST";
            //objRequest.ContentLength = Encoding.UTF8.GetByteCount(url);
            //objRequest.ContentType = "application/x-www-form-urlencoded";
            //try
            //{
            //    myWriter = new StreamWriter(objRequest.GetRequestStream());
            //    myWriter.Write(url);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(null, "the error is" + ex, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}

            //finally
            //{
            //    myWriter.Close();
            //}

            //HttpWebResponse objResponse = (HttpWebResponse)objRequest.GetResponse();
            //using (StreamReader sr = new StreamReader(objResponse.GetResponseStream()))
            //{
            //    result = sr.ReadToEnd();
            //    sr.Close();
            //}
            //MessageBox.Show(this, "Successfully Sent!", "Message has been Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //txtAPI.Text = String.Empty;
            //txtPassword.Text = String.Empty;
            //txtPhoneNumber.Text = String.Empty;
            //txtMessage.Text = String.Empty;

            //auditTrail.addAudit(label7.Text, "Addded new User Accounts");

            //using (System.Net.WebClient client = new System.Net.WebClient()) 
            //{
            //    try
            //    {
            //        string url = "http://smsc.vianett.no/v3/send.ashx?" +
            //            "src="+txtPhoneNumber.Text+"&"+
            //            "dst"+txtPhoneNumber.Text+"&" +
            //            "msg="+System.Web.HttpUtility.UrlEncode(txtMessage.Text , System.Text.Encoding.GetEncoding("ISO-8859-1"))+""+
            //            "username="+System.Web.HttpUtility.UrlEncode(txtUsername.Text)+"&"+
            //            "password="+System.Web.HttpUtility.UrlEncode(txtPassword.Text);

            //        string result = client.DownloadString(url);
            //        if (result.Contains("OK"))
            //            MessageBox.Show("Your message has been successfully send", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        else
            //            MessageBox.Show("Message send failure.","Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //    catch(Exception ex)
            //    {
            //        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //    }
            //}
            //{
            //    String result;
            //    string apiKey = txtAPI.Text;
            //    string numbers = txtPhoneNumber.Text; // in a comma seperated list
            //    string message = txtMessage.Text;
            //    string send = txtPassword.Text;

            //    String url = "https://api.txtlocal.com/send/?apikey=" + apiKey + "&numbers=" + numbers + "&message=" + message + "&sender=" + send;
            //    //refer to parameters to complete correct url string

            //    StreamWriter myWriter = null;
            //    HttpWebRequest objRequest = (HttpWebRequest)WebRequest.Create(url);

            //    objRequest.Method = "POST";
            //    objRequest.ContentLength = Encoding.UTF8.GetByteCount(url);
            //    objRequest.ContentType = "application/x-www-form-urlencoded";
            //    try
            //    {
            //        myWriter = new StreamWriter(objRequest.GetRequestStream());
            //        myWriter.Write(url);
            //    }
            //    catch (Exception ex)
            //    {
            //        //return e.Message;
            //        MessageBox.Show(null, "The error is" + ex, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //    finally
            //    {
            //        myWriter.Close();
            //    }

            //    HttpWebResponse objResponse = (HttpWebResponse)objRequest.GetResponse();
            //    using (StreamReader sr = new StreamReader(objResponse.GetResponseStream()))
            //    {
            //        result = sr.ReadToEnd();
            //        // Close and clean up the StreamReader
            //        sr.Close();
            //    }
            //    //return result;
            //    MessageBox.Show(result);

            //}

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
                //txtAddress.Text = seniorBasicDetail.address;
                sno = "SCO-" + snoValue;
                //isValid = true;
            }

        }

        private void cbox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            snoValue = (cbox1.SelectedItem as ComboBoxItem).Value.ToString();
        }
    }
}
