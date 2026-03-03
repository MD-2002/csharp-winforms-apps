using System;
using System.Windows.Forms;

namespace Simple_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Do not reference controls during field initialization.
        // Initialize to empty strings and read control values at runtime instead.
        string valueStr1 = "";
        string valueStr2 = "";

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Read the current text values from the controls at the time of the button click.
            valueStr1 = textBox1.Text;
            valueStr2 = textBox2.Text;

            // Validate and parse using TryParse to avoid exceptions.
            if (double.TryParse(valueStr1, out double value1) && double.TryParse(valueStr2, out double value2))
            {
                double operation = value1 + value2;
                textBox3.Text = operation.ToString();
            }
            else
            {
                MessageBox.Show("Please enter valid numbers in both text boxes.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Read the current text values from the controls at the time of the button click.
            valueStr1 = textBox1.Text;
            valueStr2 = textBox2.Text;

            // Validate and parse using TryParse to avoid exceptions.
            if (double.TryParse(valueStr1, out double value1) && double.TryParse(valueStr2, out double value2))
            {
                double operation = value1 - value2;
                textBox3.Text = operation.ToString();
            }
            else
            {
                MessageBox.Show("Please enter valid numbers in both text boxes.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Read the current text values from the controls at the time of the button click.
            valueStr1 = textBox1.Text;
            valueStr2 = textBox2.Text;

            // Validate and parse using TryParse to avoid exceptions.
            if (double.TryParse(valueStr1, out double value1) && double.TryParse(valueStr2, out double value2))
            {
                double operation = value1 * value2;
                textBox3.Text = operation.ToString();
            }
            else
            {
                MessageBox.Show("Please enter valid numbers in both text boxes.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Read the current text values from the controls at the time of the button click.
            valueStr1 = textBox1.Text;
            valueStr2 = textBox2.Text;

            // Validate and parse using TryParse to avoid exceptions.
            if (double.TryParse(valueStr1, out double value1) && double.TryParse(valueStr2, out double value2))
            {
                double operation = value1 / value2;
                textBox3.Text = operation.ToString();
            }
            else
            {
                MessageBox.Show("Please enter valid numbers in both text boxes.");
            }
        }
    }
}