using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS
{
    public partial class LibraryStaffFunction : Form
    {
        private const string connectionString = @"Data Source=mohammads-lenov\sqlexpress;Initial Catalog=lms;Integrated Security=True";

        public LibraryStaffFunction()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)//add a book textbox
        {
            //TextBox containing the book name to be added
        }

        private void AddBook(string bookName, int quantity)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO Book (Title, Quantity) VALUES (@BookName, @Quantity)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BookName", bookName);
                        command.Parameters.AddWithValue("@Quantity", quantity);
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            // Book added successfully
                            MessageBox.Show("Book added successfully!");
                        }
                        else
                        {
                            // Failed to add book
                            MessageBox.Show("Failed to add book. Please try again.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while adding the book. Error details: " + ex.Message);
                }
            }
        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            // New name of the book
        }

        private void SearchBook(string bookName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM Book WHERE Title LIKE @BookName";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BookName", "%" + bookName + "%");
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            // Book(s) found
                            while (reader.Read())
                            {
                                string title = reader.GetString(reader.GetOrdinal("Title"));
                                MessageBox.Show("Book Found: " + title);
                            }
                        }
                        else
                        {
                            // No book found
                            MessageBox.Show("No book found.");
                        }
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while searching for the book. Error details: " + ex.Message);
                }
            }
        }

        private void ReserveBook(string bookName, bool reserved)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE Book SET Reserved = @Reserved WHERE Title = @BookName";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Reserved", reserved);
                        command.Parameters.AddWithValue("@BookName", bookName);
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            // Book reservation status updated successfully
                            MessageBox.Show("Book reservation status updated successfully!");
                        }
                        else
                        {
                            // Failed to update book reservation status
                            MessageBox.Show("Failed to update book reservation status. Please try again.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while updating book reservation status. Error details: " + ex.Message);
                }
            }
        }

        private void UpdateBook(string oldBookName, string newBookName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE Book SET Title = @NewBookName WHERE Title = @OldBookName";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NewBookName", newBookName);
                        command.Parameters.AddWithValue("@OldBookName", oldBookName);
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            // Book updated successfully
                            MessageBox.Show("Book updated successfully!");
                        }
                        else
                        {
                            // Failed to update book
                            MessageBox.Show("Failed to update book. Please try again.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while updating the book. Error details: " + ex.Message);
                }
            }
        }

        private void LendBook(string bookName, string username)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE Book SET Reserved = 1, Quantity = Quantity - 1 WHERE Title = @BookName";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BookName", bookName);
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            // Book lent successfully
                            MessageBox.Show("Book lent successfully!");

                            // Update the user's borrowed book count
                            query = "UPDATE Users SET BooksBorrowed = BooksBorrowed + 1 WHERE Username = @Username";
                            using (SqlCommand updateUserCommand = new SqlCommand(query, connection))
                            {
                                updateUserCommand.Parameters.AddWithValue("@Username", username);
                                updateUserCommand.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            // Failed to lend book
                            MessageBox.Show("Failed to lend book. Please try again.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while lending the book. Error details: " + ex.Message);
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // Text where the book to be reserved will be written
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Add button to add a book to the database
            string bookName = textBox1.Text;
            AddBook(bookName, 1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Reserve button to mark the book as reserved or not reserved
            string bookName = textBox3.Text;
            bool reserved = true; // Set it to false if the book is not reserved
            ReserveBook(bookName, reserved);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Search for a book text
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            // Lend book to someone
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string searchBookName = textBox2.Text;
            SearchBook(searchBookName);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            // Old name of the book to be updated
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Button that will check if the old name and new name are available in the textboxes.
            // If the old name is present in the database, it will update it to the new name.
            string oldBookName = textBox4.Text;
            string newBookName = textBox7.Text;
            UpdateBook(oldBookName, newBookName);
        }



        private bool AddMember(string username, string password)
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

        private void button5_Click(object sender, EventArgs e)
        {
            string username = textBox5.Text;
            string password = textBox9.Text;

            if (AddMember(username, password))
            {
                // User creation successful
                MessageBox.Show("Account created successfully!");
            }
            else
            {
                // User creation failed
                MessageBox.Show("Failed to create an account. Please try again.");
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            // The person to whom the book will be lent
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // The button to perform the lending function
            string bookName = textBox6.Text;
            string username = textBox8.Text;
            LendBook(bookName, username);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            // Add a member textbox where the member will be given a username.
            //textbox9 is where the password will be set
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            //Password
        }
    }
}
