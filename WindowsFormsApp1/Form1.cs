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
        //Define all variables
        string first = "";
        string second = "";
        char function;
        double result = 0.0;
        string userInput = "";

        public Form1()
        {
            InitializeComponent();
        }

        //When button is clicked, set screen to nothing, add number to userInput, add userInput to display
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
        
        //Clear all variables
        private void clearButton_Click(object sender, EventArgs e)
        {
            first = "";
            second = "";
            userInput = "";
            result = 0.0;
            calculatorDisplay.Text = "0";
        }

        //Function of equal button
        private void equalButton_Click(object sender, EventArgs e)
        {
            second = userInput;

            //If all variables are empty, set screen to display zero
            if((first == "" || second == "") && userInput == "")
            {
                calculatorDisplay.Text = "0";
                first = "";
                second = "";
                userInput = "";
            }
            //If the user has put in a number, set screen to display that number
            else if(first == "" || second == "")
            {
                calculatorDisplay.Text = userInput;
                first = "";
                second = "";
                userInput = "";
            }
            //Carry out an arithmic function
            else
            {
                //Declare two new variables, as to convert the input strings to a double
                double firstNum, secondNum;
                firstNum = Convert.ToDouble(first);
                secondNum = Convert.ToDouble(second);

                //Multiplication
                if (function == '*')
                {
                    result = firstNum * secondNum;
                    calculatorDisplay.Text = result.ToString(); 
                }
                //Division
                else if (function == '/')
                {
                    //Give an error when dividing by zero
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
                //Addition
                else if (function == '+')
                {
                    result = firstNum + secondNum;
                    calculatorDisplay.Text = result.ToString();
                }
                //Subtraction
                else if (function == '-')
                {
                    result = firstNum - secondNum;
                    calculatorDisplay.Text = result.ToString();
                }

                //Clear variables after displaying answer
                first = "";
                second = "";
                userInput = "";

                //Used to diagnose when developing program, not needed for program itself
                //Console.WriteLine(result.ToString());
                //Console.WriteLine(first);
                //Console.WriteLine(second);
                //Console.WriteLine(userInput);
            }
        }

        //Setting the function variable to descern which function should be used, so when the equal button is clicked, the program knows what to do
        private void multiplicationButton_Click(object sender, EventArgs e)
        {
            function = '*';
            //If there is a previous result and you have not typed in the first number, set the previous result as the first number
            if (result.ToString() != "" && userInput == "")
            {
                first = result.ToString();
            }
            //Set userInput as the first number
            else
            {
                first = userInput;
            }
            userInput = "";
        }

        //Division
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
        
        //Addition
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

        //Subtraction
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

        //When the sqrt button is pressed, check for a base value to put in the root
        private void sqrtButton_Click(object sender, EventArgs e)
        {
            if (userInput == "")
            {
                calculatorDisplay.Text = "Syntax Error";
            }
            else
            {
                userInput = Math.Sqrt(Convert.ToDouble(userInput)).ToString();
            }
        }

        //Squared
        private void sqButton_Click(object sender, EventArgs e)
        {
            if (userInput == "")
            {
                calculatorDisplay.Text = "Syntax Error";
            }
            else
            {
                userInput = Convert.ToString(Math.Pow(Convert.ToDouble(userInput), 2));
            }
        }

        //Sin
        private void sinButton_Click(object sender, EventArgs e)
        {
            if (userInput == "")
            {
                calculatorDisplay.Text = "Syntax Error";
            }
            else
            {
                userInput = Math.Sin(Convert.ToDouble(userInput)).ToString();
            }
        }

        //Cos
        private void cosButton_Click(object sender, EventArgs e)
        {
            if (userInput == "")
            {
                calculatorDisplay.Text = "Syntax Error";
            }
            else
            {
                userInput = Math.Cos(Convert.ToDouble(userInput)).ToString();
            }
        }

        //Tan
        private void tanButton_Click(object sender, EventArgs e)
        {
            if (userInput == "")
            {
                calculatorDisplay.Text = "Syntax Error";
            }
            else
            {
                userInput = Math.Tan(Convert.ToDouble(userInput)).ToString();
            }
        }

        //Asin
        private void aSinButton_Click(object sender, EventArgs e)
        {
            if (userInput == "")
            {
                calculatorDisplay.Text = "Syntax Error";
            }
            else
            {
                userInput = Math.Asin(Convert.ToDouble(userInput)).ToString();
            }
        }

        //Acos
        private void aCosButton_Click(object sender, EventArgs e)
        {
            if (userInput == "")
            {
                calculatorDisplay.Text = "Syntax Error";
            }
            else
            {
                userInput = Math.Acos(Convert.ToDouble(userInput)).ToString();
            }
        }

        //Atan
        private void aTanButton_Click(object sender, EventArgs e)
        {
            if (userInput == "")
            {
                calculatorDisplay.Text = "Syntax Error";
            }
            else
            {
                userInput = Math.Atan(Convert.ToDouble(userInput)).ToString();
            }
        }

        //Plus/minus button
        private void plusMinusButton_Click(object sender, EventArgs e)
        {
            if (userInput == "")
            {
                calculatorDisplay.Text = "Syntax Error";
            }
            else
            {
                //Convert current userInput to its inverse and update the display
                userInput = (Convert.ToDouble(userInput) * -1).ToString();
                calculatorDisplay.Text = userInput;
            }
        }
    }
}
