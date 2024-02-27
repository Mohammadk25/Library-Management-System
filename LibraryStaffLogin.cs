using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LMS
{
    public partial class LibraryStaffLogin : Form
    {
        private const string connectionString = @"Data Source=mohammads-lenov\sqlexpress;Initial Catalog=lms;Integrated Security=True";

        public LibraryStaffLogin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) // Username TextBox
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e) // Password TextBox
        {

        }

        private bool CreateUser(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO Staff (StaffUsername, StaffPassword) VALUES (@Username, @Password)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);
                        command.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while creating the user. Error details: " + ex.Message);
                    return false;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e) // Sign Up button
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if (CreateUser(username, password))
            {
                // User creation successful
                MessageBox.Show("Account created successfully!");
            }
            else
            {
                // User creation failed
                MessageBox.Show("Failed to create account. Please try again.");
            }
        }

        private void button2_Click(object sender, EventArgs e) // Login Button
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if (ValidateLibraryStaff(username, password))
            {
                // Library Staff authentication successful
                MessageBox.Show("Login Successful!");

                // Open the next form (LibraryStaffFunctionForm)
                LibraryStaffFunction libraryStaffFunctionForm = new LibraryStaffFunction();
                libraryStaffFunctionForm.Show();

                // Close the current form (LibraryStaffLogin)
                this.Hide();
            }
            else
            {
                // Library Staff authentication failed
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }

        private bool ValidateLibraryStaff(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM Staff WHERE StaffUsername = @Username AND StaffPassword = @Password";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        int count = (int)command.ExecuteScalar();
                        return count > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while validating the library staff. Error details: " + ex.Message);
                    return false;
                }
            }
        }


    }
}
