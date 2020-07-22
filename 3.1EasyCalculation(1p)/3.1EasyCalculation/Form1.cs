using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3._1EasyCalculation
{
    public partial class Form1 : Form
    {



        /// <summary>
        /// https://www.youtube.com/watch?v=iJqB6UsM-hs   athor: programming knowledge will give you a walkthrough how to make calculator in a way.
        /// </summary>
        Double resultValue;
        string operationPerformed = "";
        bool Operation_perform;
        string operand1;
        string operand2;
        public Form1()
        {
            InitializeComponent();
        }
        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if ((Result.Text == "0") || (Operation_perform))                          // if any event starts i will clear the 0 number 
            {
                Result.Clear();
            }
            Operation_perform = false;       
            Result.Text = Result.Text + button.Text; 
        }
        private void Operation_Click(object sender, EventArgs e)                        // write out the string of operation performed and write out the string of button click
        {
            Button button = (Button)sender;
            if (resultValue != 0)
            {
                button18.PerformClick();  // recommend comment if memory is fuzzy
                operationPerformed = button.Text;
                if (Result.Text != "")
                {
                    resultValue = Double.Parse(Result.Text);
                }         // the id of button 18 is the operation Equal 
                Operation_perform = true;
                Equation.Text = resultValue + " " + operationPerformed;
            }
            else
            {
                operationPerformed = button.Text;
                if (Result.Text != "")
                {
                    resultValue = Double.Parse(Result.Text);
                }
                Equation.Text = resultValue +" "+ operationPerformed;
                Operation_perform = true;
            }
        }
        private void Operation_Clear(object sender, EventArgs e)
        {
            Result.Text = "";
        }
        private void Operation_Clear_Value(object sender, EventArgs e)
        {
            Result.Text = "0";
            resultValue = 0;
            Equation.Text = Result.Text;
        }
        private void Operation_Equal(object sender, EventArgs e)
        {
                switch (operationPerformed)
                {
                    case "+":
                        Result.Text = (resultValue + Double.Parse(Result.Text)).ToString();
                        break;
                    case "-":
                        Result.Text = (resultValue - Double.Parse(Result.Text)).ToString();
                        break;
                    case "*":
                        Result.Text = (resultValue * Double.Parse(Result.Text)).ToString();
                        break;
                    case "/":
                        Result.Text = (resultValue / Double.Parse(Result.Text)).ToString();
                        break;
                case "x^y":
                    double x = Convert.ToDouble(operand1);
                    double y = Convert.ToDouble(resultValue);
                    Result.Text = Math.Pow(x, y).ToString();
                    break;

                case "√":
                    double RootOf = Convert.ToDouble(operand1);
                    Result.Text = Math.Sqrt(RootOf).ToString();
                    break;
                    default:
                    //resultValue = double.Parse(Result.Text);
                    break;
                }
            Equation.Text = Result.Text;
        }
        private void Scientic_click(object sender, EventArgs e)
        {
            
            operationPerformed = "x^y";
            operand1 = Double.Parse(Result.Text).ToString();
            Operation_perform = false;
            resultValue = Double.Parse(Result.Text);
            //Result.Text = "square("+Result.Text+")";
            Result.Text = Result.Text + "^";
            Equation.Text = Result.Text;
        }

        private void Scientic_SquareRoot_Click(object sender, EventArgs e)
        {
            operationPerformed = "√";
            operand1 = Double.Parse(Result.Text).ToString();
            Operation_perform = false;
            Result.Text = "square("+Result.Text+")";
        }

        private void Pi_Click(object sender, EventArgs e)
        {
            operationPerformed = "π";

            resultValue = 3.14;
            Result.Text = resultValue.ToString();
            Operation_perform = false;
        }
    }
    }

