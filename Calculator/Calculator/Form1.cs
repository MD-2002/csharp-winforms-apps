namespace Calculator
{
    public partial class Form1 : Form
    {
        string firstOperand = "";      // Number before operator
        string currentOperand = "";    // The operator (+, -, *, /)
        bool isOperatorPressed = false; // Flag to know when operator was clicked
        double num1 = 0, num2 = 0, result = 0; // Variables to hold numbers and result

        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isOperatorPressed)
            {
                textBox1.Text = "0";
                isOperatorPressed = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
            clear.Text = "CE";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (isOperatorPressed)
            {
                textBox1.Text = "1";
                isOperatorPressed = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
            clear.Text = "CE";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (isOperatorPressed)
            {
                textBox1.Text = "2";
                isOperatorPressed = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
            clear.Text = "CE";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (isOperatorPressed)
            {
                textBox1.Text = "3";
                isOperatorPressed = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
            clear.Text = "CE";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (isOperatorPressed)
            {
                textBox1.Text = "4";
                isOperatorPressed = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
            clear.Text = "CE";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (isOperatorPressed)
            {
                textBox1.Text = "5";
                isOperatorPressed = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
            clear.Text = "CE";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (isOperatorPressed)
            {
                textBox1.Text = "6";
                isOperatorPressed = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
            clear.Text = "CE";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (isOperatorPressed)
            {
                textBox1.Text = "7";
                isOperatorPressed = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
            clear.Text = "CE";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (isOperatorPressed)
            {
                textBox1.Text = "8";
                isOperatorPressed = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
            clear.Text = "CE";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (isOperatorPressed)
            {
                textBox1.Text = "9";
                isOperatorPressed = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
            clear.Text = "CE";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Decimal point
            if (textBox1.Text != null)
            {
                if (!textBox1.Text.Contains(","))
                {
                    textBox1.Text = textBox1.Text + ",";
                }
            }
            clear.Text = "CE";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Plus operator
            if (!isOperatorPressed)
            {
                firstOperand = textBox1.Text;
                currentOperand = "+";
                isOperatorPressed = true;
            }
            clear.Text = "CE";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Minus operator
            if (!isOperatorPressed)
            {
                firstOperand = textBox1.Text;
                currentOperand = "-";
                isOperatorPressed = true;
                clear.Text = "CE";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            // Multiply operator
            if (!isOperatorPressed)
            {
                firstOperand = textBox1.Text;
                currentOperand = "*";
                isOperatorPressed = true;
                clear.Text = "CE";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            // Divide operator
            if (!isOperatorPressed)
            {
                firstOperand = textBox1.Text;
                currentOperand = "/";
                isOperatorPressed = true;
                clear.Text = "CE";
            }
        }
        private void button18_Click(object sender, EventArgs e)
        {
            clear.Text = "C";
            firstOperand = "";
            currentOperand = "";
            textBox1.Text = "";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (firstOperand != null && textBox1.Text != null)
            {
                if (currentOperand == "+")
                {
                    num1 = Convert.ToDouble(firstOperand);
                    num2 = Convert.ToDouble(textBox1.Text);
                    result = num1 + num2;
                    textBox1.Text = result.ToString();
                    num1 = 0;
                    num2 = 0;
                }
                else if (currentOperand == "-")
                {
                    num1 = Convert.ToDouble(firstOperand);
                    num2 = Convert.ToDouble(textBox1.Text);
                    result = num1 - num2;
                    textBox1.Text = result.ToString();
                    num1 = 0;
                    num2 = 0;
                }
                else if (currentOperand == "*")
                {
                    num1 = Convert.ToDouble(firstOperand);
                    num2 = Convert.ToDouble(textBox1.Text);
                    result = num1 * num2;
                    textBox1.Text = result.ToString();
                    num1 = 0;
                    num2 = 0;
                }
                else if (currentOperand == "/")
                {
                    num1 = Convert.ToDouble(firstOperand);
                    num2 = Convert.ToDouble(textBox1.Text);
                    result = num1 / num2;
                    textBox1.Text = result.ToString();
                    num1 = 0;
                    num2 = 0;

                }
                else if (currentOperand == "%")
                {
                    num1 = Convert.ToDouble(firstOperand);
                    num2 = Convert.ToDouble(textBox1.Text);
                    result = num1 % num2;
                    textBox1.Text = result.ToString();
                    num1 = 0; 
                    num2 = 0;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double signtoggle = (-1) * Convert.ToDouble(textBox1.Text);
            textBox1.Text = signtoggle.ToString();
        }

        private void backspace_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!=null) {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }

        private void modulus_Click(object sender, EventArgs e)
        {
            // Modulus operator
            if (!isOperatorPressed)
            {
                firstOperand = textBox1.Text;
                currentOperand = "%";
                isOperatorPressed = true;
            }
            clear.Text = "CE";
        }

    }
}
