using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST.Volunteer.Dialog
{
    public partial class YearDialog : Form
    {
        public int monthnum = 0;
        public int year = DateTime.Now.Year;
        bool isBtnClick = false;

        public YearDialog()
        {
            InitializeComponent();
            isBtnClick = false;
            monthnum = 0;
            dateTimePicker1.MaxDate = DateTime.Now;
        }

        private void YearDialog_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            year = dateTimePicker1.Value.Year;

            this.Close();
        }
    }
}
