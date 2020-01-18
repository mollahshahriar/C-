using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UpdateTimeInfo();
        }

        private void UpdateTimeInfo()
        {
            int days;
            DateTime myTime = new DateTime();
            myTime = DateTime.Now;
            DateTime newYears = new DateTime(myTime.Year, 12, 31);

            txtCompleteDateAndTime.Text = myTime.ToString("f");
            txtLongDate.Text = myTime.ToString("D");
            txtShortDate.Text = myTime.ToString("d");
            txtGeneralDateAndTime.Text = myTime.ToString("g");
            txtLongTime.Text = myTime.ToString("T");
            txtShortTime.Text = myTime.ToString("t");

            days = newYears.DayOfYear  - myTime.DayOfYear;
            txtDaysToNewYears.Text = days.ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            UpdateTimeInfo();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
