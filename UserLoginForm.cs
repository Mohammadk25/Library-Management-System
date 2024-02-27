using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LMS
{
    public partial class UserLoginForm : Form
    {
        private const string connectionString = @"Data Source=mohammads-lenov\sqlexpress;Initial Catalog=lms;Integrated Security=True";

        public UserLoginForm()
        {
            InitializeComponent();
            this.MinimumSize = new Size(650, 450); // Replace with your desired width and height
            this.MaximumSize = new Size(650, 450); // Replace with your desired width and height

            // Set the initial size of the form to the desired size
            this.Size = new Size(650, 450); // Replace with your desired width and height

            // Set the form's "FormBorderStyle" property to prevent resizing using the window border
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

        }

        private void button1_Click(object sender, EventArgs e) // Login button
        {
            string username = UserNameBox.Text;
            string password = PasswordBox.Text;

            if (ValidateUser(username, password))
            {
                // User authentication successful
                MessageBox.Show("Login Successful!");

                // Open the next form (UserFunctionForm) and pass the username
                UserFunction userFunctionForm = new UserFunction(username);
                userFunctionForm.Show();

                // Close the current form (UserLoginForm)
                this.Hide();
            }
            else
            {
                // User authentication failed
                MessageBox.Show("Invalid username or password. Please try again.");
            }

        }

        private void button1_Click_1(object sender, EventArgs e)  // Sign up button
        {
            string username = UserNameBox.Text;
            string password = PasswordBox.Text;

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

        private bool ValidateUser(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND Password = @Password";
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
                    MessageBox.Show("An error occurred while validating the user. Error details: " + ex.Message);
                    return false;
                }
            }
        }

        private bool CreateUser(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO Users (Username, Password) VALUES (@Username, @Password)";
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

        private void UserNameBox_TextChanged(object sender, EventArgs e) // Username textbox where the user will enter email
        {

        }

        private void PasswordBox_TextChanged(object sender, EventArgs e) // Password textbox where the user will enter password
        {

        }
        private void SearchText_TextChanged(object sender, EventArgs e)
        {
            // New name of the book
        }
        private void MemberText_TextChanged(object sender, EventArgs e)
        {
            // New name of the book
        }
        private void ReturnText_TextChanged(object sender, EventArgs e)
        {
            // New name of the book
        }
        private void BorrowText_TextChanged(object sender, EventArgs e)
        {
            // New name of the book
        }




    }
}
