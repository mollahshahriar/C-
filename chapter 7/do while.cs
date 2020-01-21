using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace generat_random_number
{
    public partial class Form1 : Form
    {
        const int MAXITERATIONS = 200000;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            bool flag;
            int counter;
            int max;
            int last;
            int current;
            Random randomNumber = new Random();

            flag = int.TryParse(txtMax.Text, out max);
            if (flag == false)
            {
                MessageBox.Show("digit characters only.","input Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtMax.Focus();
                return;
            }

            counter = 0;
            last = (int)randomNumber.Next(max);
            do
            {
                current = randomNumber.Next(max);
                if (last == current)

                {
                    break;
                }

                last = current;
                counter++;
            }
            while (counter < MAXITERATIONS);

            if (counter < MAXITERATIONS)
            {
                lblAnswer.Text = "It took " + counter.ToString() + " passes to match";

            }
            else
            {
                lblAnswer.Text = "No back- to-back match";
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
