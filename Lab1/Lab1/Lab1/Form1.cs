using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        string input = string.Empty;
        string Op1 = string.Empty;
        string Op2 = string.Empty;
        double res = 0.0;
        string Operator;
        public Form1()
        {
            InitializeComponent();
              
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonDec_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + ".";
            this.textBox1.Text += input;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "0";
            this.textBox1.Text += input;
        }

        private void buttonEq_Click(object sender, EventArgs e)
        {
            {
                Op2 = input;
                double num1, num2;
                double.TryParse(Op1, out num1);
                double.TryParse(Op2, out num2);
                if (Operator.Equals("+"))
                {
                    res = num1 + num2;
                    this.textBox1.Text = res.ToString();
                }
                else if (Operator.Equals("-"))
                {
                    res = num1 - num2;
                    textBox1.Text = res.ToString();
                }
                else if (Operator.Equals("*"))
                {
                    res = num1 * num2;
                    textBox1.Text = res.ToString();
                }
                else if (Operator.Equals("*"))
                {
                    if (num2 != 0)
                    {
                        res = num1 / num2;
                        textBox1.Text = res.ToString();
                    }
                    else
                    {
                        textBox1.Text = "DIV/Zero!";
                    }
                }
                else if (Operator.Equals("log"))
                {
                    res = Math.Log10(num1);
                    textBox1.Text = res.ToString();
                }
                else if (Operator.Equals("ln"))
                {
                    res = Math.Log(num1);
                    textBox1.Text = res.ToString();
                }
                else if (Operator.Equals("sin"))
                {
                    res = Math.Sin(num1);
                    textBox1.Text = res.ToString();
                }
                else if (Operator.Equals("cos"))
                {
                    res = Math.Cos(num1);
                    textBox1.Text = res.ToString();
                }
                else if (Operator.Equals("tan"))
                {
                    res = Math.Tan(num1);
                    textBox1.Text = res.ToString();
                }
                else if (Operator.Equals("^2"))
                {
                    res = num1 * num1;
                    textBox1.Text = res.ToString();
                }
                else if (Operator.Equals("^3"))
                {
                    res = num1 * num1 *num1;
                    textBox1.Text = res.ToString();
                }
                else if (Operator.Equals("sqrt"))
                {
                    res = Math.Sqrt(num1);
                    textBox1.Text = res.ToString();
                }
                else if (Operator.Equals("!"))
                {
                    res = 1;
                    for (int i = 1; i <= num1; i++)
                        res *= i;
                    textBox1.Text = res.ToString();
                }
                input = string.Empty;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "1";
            this.textBox1.Text += input;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "2";
            this.textBox1.Text += input;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "3";
            this.textBox1.Text += input;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "4";
            this.textBox1.Text += input;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "5";
            this.textBox1.Text += input;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "6";
            this.textBox1.Text += input;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "7";
            this.textBox1.Text += input;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "8";
            this.textBox1.Text += input;
        }
        
        private void button9_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "9";
            this.textBox1.Text += input;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e) //AddButton
        {
            Op1 = input;
            Operator = "+";
            input = string.Empty;
        }

        private void button11_Click(object sender, EventArgs e) //SubtractButton
        {
            Op1 = input;
            Operator = "-";
            input = string.Empty;
        }

        private void button12_Click(object sender, EventArgs e) //MultiplyButton
        {
            Op1 = input;
            Operator = "*";
            input = string.Empty;
        }

        private void button13_Click(object sender, EventArgs e) //DivideButton
        {
            Op1 = input;
            Operator = "/";
            input = string.Empty;
        }

        private void buttonSqr_Click(object sender, EventArgs e)
        {
            Op1 = input;
            Operator = "^2";
            input = string.Empty;
        }

        private void buttonCube_Click(object sender, EventArgs e)
        {
            Op1 = input;
            Operator = "^3";
            input = string.Empty;
        }

        private void buttonSqrt_Click(object sender, EventArgs e)
        {
            Op1 = input;
            Operator = "sqrt";
            input = string.Empty;
        }

        private void buttonFact_Click(object sender, EventArgs e)
        {
            Op1 = input;
            Operator = "!";
            input = string.Empty;
        }

        private void buttonLog_Click(object sender, EventArgs e)
        {
            Op1 = input;
            Operator = "log";
            input = string.Empty;
        }

        private void buttonCos_Click(object sender, EventArgs e)
        {
            Op1 = input;
            Operator = "cos";
            input = string.Empty;
        }

        private void buttonSin_Click(object sender, EventArgs e)
        {
            Op1 = input;
            Operator = "sin";
            input = string.Empty;
        }

        private void buttonTan_Click(object sender, EventArgs e)
        {
            Op1 = input;
            Operator = "tan";
            input = string.Empty;
        }

        private void buttonLn_Click(object sender, EventArgs e)
        {
            Op1 = input;
            Operator = "ln";
            input = string.Empty;
        }

        
    }
}
