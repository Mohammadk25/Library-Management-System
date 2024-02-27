using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LMS
{
    public partial class SupplierLogin : Form
    {
        private const string connectionString = @"Data Source=mohammads-lenov\sqlexpress;Initial Catalog=lms;Integrated Security=True";

        public SupplierLogin()
        {
            InitializeComponent();
            this.MinimumSize = new Size(550, 500); // Replace with your desired width and height
            this.MaximumSize = new Size(550, 500); // Replace with your desired width and height

            // Set the initial size of the form to the desired size
            this.Size = new Size(550, 500); // Replace with your desired width and height

            // Set the form's "FormBorderStyle" property to prevent resizing using the window border
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void textBox1_TextChanged(object sender, EventArgs e) // Username text box where the email will be entered
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e) // Password textBox where the password will be entered 
        {

        }
        private bool CreateUser(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO Supplier (supplierusername, supplierpassword) VALUES (@Username, @Password)";
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

            if (ValidateSupplier(username, password))
            {
                // Supplier authentication successful
                MessageBox.Show("Login Successful!");

                // Open the next form (SupplierFunctionForm)
                SupplierFunction supplierFunctionForm = new SupplierFunction();
                supplierFunctionForm.Show();

                // Close the current form (SupplierLogin)
                this.Hide();
            }
            else
            {
                // Supplier authentication failed
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }

        private bool ValidateSupplier(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM Supplier WHERE SupplierUsername = @Username AND SupplierPassword = @Password";
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
                    MessageBox.Show("An error occurred while validating the supplier. Error details: " + ex.Message);
                    return false;
                }
            }
        }

    }
}
