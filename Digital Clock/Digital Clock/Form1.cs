namespace Digital_Clock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // timer1.Start();
            timer1.Enabled = true;
        }

        private void label4_DayOfWeek_Click(object sender, EventArgs e)
        {
           
        }

        private void label3_Date_Click(object sender, EventArgs e)
        {

        }

        private void label2_Seconds_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            //label2_Seconds.Text = DateTime.Now.ToString("ss");
            label1_Time.Text = DateTime.Now.ToString("hh:mm:ss tt");
            label3_Date.Text = DateTime.Now.ToString("dd MMMM yyyy");
            label4_DayOfWeek.Text = DateTime.Now.DayOfWeek.ToString();
        }
    }
}
