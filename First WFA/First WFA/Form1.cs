namespace First_WFA
{
    public partial class Form1 : Form
    {
        public string txt;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string date = DateTime.Today.ToString("dd/MM/yyyy:f");
            textBox1.Text = string.Concat("Hello Marcos ! ", date);
            string message = "Welcome to C# World !";
            MessageBox.Show($"{message}");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
