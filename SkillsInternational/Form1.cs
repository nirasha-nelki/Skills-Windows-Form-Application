using System;
using System.Data.SqlClient;

namespace SkillsInternational
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        public Form1()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=NELKI\SQLEXPRESS;Initial Catalog=Student;Integrated Security=True;Encrypt=False"); // Initialize the SqlConnection field in the constructor

        }




        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            String username, password;
            username = txt_username.Text;
            password = txt_password.Text;

            // Print username and password to console
            Console.WriteLine("Username: " + username);
            Console.WriteLine("Password: " + password);

            try
            {
                con.Open();
                // Construct SQL query with parameters to prevent SQL injection
                string query = "SELECT COUNT(*) FROM [Logins] WHERE username = @username AND password = @password";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                int count = (int)cmd.ExecuteScalar();

                if (count > 0)
                {
  

                    Form2 form2 = new Form2();
                    this.Hide();
                    form2.Show();
                }
                else
                {
                    // Invalid credentials
                    MessageBox.Show("Invalid login credentials. Please check the Username and Password and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL Exception occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_username.Clear();
            txt_password.Clear();

            txt_username.Focus();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure, Do you really want to Exit...?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check the user's response
            if (result == DialogResult.Yes)
            {
                // User clicked Yes, so exit the application
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
