using System.Security.Cryptography.X509Certificates;

namespace Age_Calculator
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        public string dateOfBirth;
        public string currentDate;

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateOfBirth = dateTimePicker1.Value.ToString("yyyy");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int Dobv1 = int.Parse(dateOfBirth);
                int Dobv2 = int.Parse(currentDate);
                int result1 = Dobv2 - Dobv1;
                if (result1 < 0)
                {
                    MessageBox.Show("Please enter a valid year of birth.");
                }
                else if (result1 == 0)
                {
                    MessageBox.Show("You are a newborn ");
                }
                else
                {
                    textBox1.Text = Convert.ToString($"{result1}");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please select valid dates.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            currentDate = dateTimePicker2.Value.ToString("yyyy");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }
    }
}
