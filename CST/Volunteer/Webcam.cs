using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Drawing.Imaging;
using CST.Models;

namespace CST.Volunteer
{
    public partial class Webcam : Form
    {

        
        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice videoSource;
        string sno = "";
        BasicDetailsController detailsController = new BasicDetailsController();
        public Webcam(string sno)
        {
            InitializeComponent();
            getallcameralist();
            this.sno = sno;
        }

        void getallcameralist()
        {
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Devices in CaptureDevice)
            {
                comboBox1.Items.Add(Devices.Name);

            }
        }
        private void Webcam_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            try
            {
                videoSource = new VideoCaptureDevice(CaptureDevice[comboBox1.SelectedIndex].MonikerString);
                videoSource.NewFrame += new NewFrameEventHandler(VideoSource_NewFrame);
                videoSource.Start();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            videoSource.Stop();
            pictureBox1.Image = null;
            pictureBox1.Invalidate();
            pictureBox2.Image = null;
            pictureBox2.Invalidate();
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Save Image As";
            sfd.Filter = "Image files(*.jpg, *.png) | *.jpg, *.png";
            ImageFormat imagefrmt = ImageFormat.Png;
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(sfd.FileName);
                switch (ext)
                {
                    case ".jpg":
                        imagefrmt = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        imagefrmt = ImageFormat.Bmp;
                        break;
                }
                pictureBox2.Image.Save(sfd.FileName, imagefrmt);

               await detailsController.updateImgPath(sfd.FileName, sno);


             
                this.Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = (Bitmap)pictureBox1.Image.Clone();
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
