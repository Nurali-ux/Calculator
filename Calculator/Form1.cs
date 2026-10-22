using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double firstNumber = 0;
        string operation = "";
        bool newNumber = true;
        public Form1()
        {
            InitializeComponent();

          
        }



        private void Number_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string number = btn.Text;

            if (newNumber || txtDisplay.Text == "0")
            {
                txtDisplay.Text = number;
                newNumber = false;
            }
            else
            {
                txtDisplay.Text += number;
            }
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            Number_Click(btn1, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "4";
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Number_Click(btn5, e);
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Number_Click(btn6, e);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "0";
        }

        private void txtDisplay_MaskInputRejected(
    object sender,
    MaskInputRejectedEventArgs e)
        {
        }




        private void Operation_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtDisplay.Text, out firstNumber))
                return;

            Button btn = (Button)sender;
            operation = btn.Text;
            newNumber = true;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(operation))
                return;

            if (!double.TryParse(txtDisplay.Text, out double secondNumber))
                return;

            double result = 0;

            switch (operation)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;

                case "-":
                    result = firstNumber - secondNumber;
                    break;

                case "×":
                case "*":
                    result = firstNumber * secondNumber;
                    break;

                case "÷":
                case "/":
                    if (secondNumber == 0)
                    {
                        MessageBox.Show("0-д хувааж болохгүй!");
                        return;
                    }

                    result = firstNumber / secondNumber;
                    break;

                default:
                    return;
            }

            txtDisplay.Text = result.ToString();
            firstNumber = result;
            operation = "";
            newNumber = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            firstNumber = 0;
            operation = "";
            newNumber = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Number_Click(btn1, e);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Number_Click(btn6, e);
        }

        private void btn5_Click(object sender, EventArgs e)
        {

        }
    }

}
