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
    public partial class MonthDiaglog : Form
    {
        public int monthnum = 0;
        public int year = DateTime.Now.Year;
        bool isBtnClick = false;

        public MonthDiaglog()
        {
            InitializeComponent();
            isBtnClick = false;
            monthnum = 0;
            dateTimePicker1.MaxDate = DateTime.Now;


        }

        private void MonthDiaglog_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(StaticData.months);
        }

        private void MonthDiaglog_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(!isBtnClick)
                monthnum = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
                return;

            isBtnClick = true;

            monthnum = comboBox1.SelectedIndex + 1;

            year = dateTimePicker1.Value.Year;

            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
