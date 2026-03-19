using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Usersignup_withSQL
{
    public partial class Form1 : Form
    {
        string connectionString = "Server=localhost;Port=xxxx;Database=xxxx;Uid=xxxx;Pwd=xxxx;";
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (textBox8.Text !="" || textBox7.Text !="" || textBox6.Text !="")
            {
                if (textBox7.Text.Equals(textBox6.Text))
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        try
                        {
                            connection.Open();
                            MySqlCommand cmd = new MySqlCommand("UserAdd", connection);
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("p_FirstName", textBox1.Text.Trim());
                            cmd.Parameters.AddWithValue("p_LastName", textBox2.Text.Trim());
                            cmd.Parameters.AddWithValue("p_Contact", textBox3.Text.Trim());
                            cmd.Parameters.AddWithValue("p_Address", textBox4.Text.Trim());
                            cmd.Parameters.AddWithValue("p_Username", textBox8.Text.Trim());
                            cmd.Parameters.AddWithValue("p_Password", textBox7.Text.Trim());

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("User added successfully!");
                            clear();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Password and Confirm Password do not match.");
                }
            }
            else
            {
                MessageBox.Show("Please fill in the Username and Password fields.");
            }
        }
        void clear()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox8.Text = "";
            textBox7.Text = "";
            textBox6.Text = "";
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
