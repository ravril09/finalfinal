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
    public partial class PermissionDelete : Form
    {
        public int monthnum = 0;
        BasicDetailsController basicDetailsController = new BasicDetailsController();

        string clickedBut = "";
    
        public PermissionDelete()
        {
            InitializeComponent();
            monthnum = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //RegistrarRecord registrarRecord = new RegistrarRecord();
            //string pass;
            //pass = txtPass.Text;
            //if (pass == "admin")
            //{
            //    registrarRecord.ShowDialog();
            //}
        }
        

        private void PermissionDelete_Load(object sender, EventArgs e)
        {
           
        }
    }
}