using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chapter3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            bool flag;
            float Operand1;
            float Operand2;
            float answer;

            flag = float.TryParse(txtOperand1.Text, out Operand1);
            if (flag == false)
            { MessageBox.Show("Enter a whole number","Input Error");
                txtOperand1.Focus();
                return;
            }


            flag = float.TryParse(txtOperand2.Text, out Operand2);
            if (flag == false)
            {
                MessageBox.Show("Enter a whole number", "Input Error");
                txtOperand2.Focus();
                return;
            }
            answer = Operand1 / Operand2;
            txtResult.Text = Operand1.ToString() + "devided by" + Operand2.ToString() + "equal" + answer.ToString();
            txtResult.Visible = true;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Operand1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Operand2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Answer_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
