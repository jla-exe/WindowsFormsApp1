using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string first = "";
        string second = "";
        char function;
        double result = 0.0;
        string userInput = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "0";
            calculatorDisplay.Text += userInput;
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "1";
            calculatorDisplay.Text += userInput;
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "2";
            calculatorDisplay.Text += userInput;
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "3";
            calculatorDisplay.Text += userInput;
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "4";
            calculatorDisplay.Text += userInput;
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "5";
            calculatorDisplay.Text += userInput;
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "6";
            calculatorDisplay.Text += userInput;
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "7";
            calculatorDisplay.Text += userInput;
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "8";
            calculatorDisplay.Text += userInput;
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "9";
            calculatorDisplay.Text += userInput;
        }

        private void decimalButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += ".";
            calculatorDisplay.Text += userInput;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            first = "";
            second = "";
            userInput = "";
            result = 0.0;
            calculatorDisplay.Text = "0";
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            second = userInput;

            if((first == "" || second == "") && userInput == "")
            {
                calculatorDisplay.Text = "0";
                first = "";
                second = "";
                userInput = "";
            }
            else if(first == "" || second == "")
            {
                calculatorDisplay.Text = userInput;
                first = "";
                second = "";
                userInput = "";
            }
            else
            {
                double firstNum, secondNum;
                firstNum = Convert.ToDouble(first);
                secondNum = Convert.ToDouble(second);

                //multiplication
                if (function == '*')
                {
                    result = firstNum * secondNum;
                    calculatorDisplay.Text = result.ToString();
                }
                //division
                else if (function == '/')
                {
                    if (secondNum == 0)
                    {
                        calculatorDisplay.Text = "Math Error";
                    }
                    else
                    {
                        result = firstNum / secondNum;
                        calculatorDisplay.Text = result.ToString();
                    }
                }
                //addition
                else if (function == '+')
                {
                    result = firstNum + secondNum;
                    calculatorDisplay.Text = result.ToString();
                }
                //subtraction
                else if (function == '-')
                {
                    result = firstNum - secondNum;
                    calculatorDisplay.Text = result.ToString();
                }

                first = "";
                second = "";
                userInput = "";
                Console.WriteLine(result.ToString());
                Console.WriteLine(first);
                Console.WriteLine(second);
                Console.WriteLine(userInput);
            }
        }

        private void multiplicationButton_Click(object sender, EventArgs e)
        {
            function = '*';
            if (result.ToString() != "" && userInput == "")
            {
                first = result.ToString();
            }
            else
            {
                first = userInput;
            }
            userInput = "";
        }

        private void divisionButton_Click(object sender, EventArgs e)
        {
            function = '/';
            if (result.ToString() != "" && userInput == "")
            {
                first = result.ToString();
            }
            else
            {
                first = userInput;
            }
            userInput = "";
        }

        private void additionButton_Click(object sender, EventArgs e)
        {
            function = '+';
            if (result.ToString() != "" && userInput == "")
            {
                first = result.ToString();
            }
            else
            {
                first = userInput;
            }
            userInput = "";
        }

        private void subtractionButton_Click(object sender, EventArgs e)
        {
            function = '-';
            if (result.ToString() != "" && userInput == "")
            {
                first = result.ToString();
            }
            else
            {
                first = userInput;
            }
            userInput = "";
        }
    }
}
