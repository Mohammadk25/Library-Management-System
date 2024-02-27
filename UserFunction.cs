using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LMS
{
    public partial class UserFunction : Form
    {
        private const string connectionString = @"Data Source=mohammads-lenov\sqlexpress;Initial Catalog=lms;Integrated Security=True";
        private string currentUser;

        public UserFunction(string username)
        {
            InitializeComponent();
            currentUser = username;
        }

        private void SearchBook1(string bookName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT DISTINCT Title FROM Book WHERE Title LIKE @BookName";
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


        private void BorrowBook(string bookName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Check if the book is available and not reserved
                    string query = "SELECT Quantity, Reserved FROM Book WHERE Title = @BookName";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BookName", bookName);
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            int quantity = reader.GetInt32(reader.GetOrdinal("Quantity"));
                            bool reserved = reader.GetBoolean(reader.GetOrdinal("Reserved"));

                            reader.Close();

                            if (quantity > 0 && !reserved)
                            {
                                // Book is available and not reserved, proceed with the borrow process

                                // Update the user's BooksBorrowed
                                query = "UPDATE Users SET BooksBorrowed = ISNULL(BooksBorrowed, 0) + 1 WHERE Username = @Username";
                                using (SqlCommand updateCommand = new SqlCommand(query, connection))
                                {
                                    updateCommand.Parameters.AddWithValue("@Username", currentUser);
                                    int rowsAffected = updateCommand.ExecuteNonQuery();

                                    if (rowsAffected > 0)
                                    {
                                        // Update the Reserved status of the book to indicate it has been borrowed
                                        query = "UPDATE Book SET Reserved = 1 WHERE Title = @BookName";
                                        using (SqlCommand reserveCommand = new SqlCommand(query, connection))
                                        {
                                            reserveCommand.Parameters.AddWithValue("@BookName", bookName);
                                            int rowsUpdated = reserveCommand.ExecuteNonQuery();

                                            if (rowsUpdated > 0)
                                            {
                                                MessageBox.Show("Book borrowed successfully!");
                                            }
                                            else
                                            {
                                                MessageBox.Show("Failed to borrow the book. Please try again.");
                                            }
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Failed to borrow the book. Please try again.");
                                    }
                                }
                            }
                            else if (quantity == 0)
                            {
                                MessageBox.Show("Book not available. It is out of stock.");
                            }
                            else if (reserved)
                            {
                                MessageBox.Show("Book is currently reserved and cannot be borrowed.");
                            }
                        }
                        else
                        {
                            // Book not found in the database
                            MessageBox.Show("Book not found.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while borrowing the book. Error details: " + ex.Message);
                }
            }
        }



        private void ReturnBook(string bookName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Check if the user has borrowed any books
                    string query = "SELECT BooksBorrowed FROM Users WHERE username = @Username";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", currentUser);
                        object result = command.ExecuteScalar();

                        if (result != DBNull.Value)
                        {
                            int booksBorrowed = Convert.ToInt32(result);

                            if (booksBorrowed > 0)
                            {
                                // Update the user's BooksBorrowed
                                query = "UPDATE Users SET BooksBorrowed = BooksBorrowed - 1 WHERE username = @Username";
                                using (SqlCommand updateCommand = new SqlCommand(query, connection))
                                {
                                    updateCommand.Parameters.AddWithValue("@Username", currentUser);
                                    int rowsAffected = updateCommand.ExecuteNonQuery();
                                    if (rowsAffected > 0)
                                    {
                                        MessageBox.Show("Book returned successfully!");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Failed to return the book. Please try again.");
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("User has not borrowed any books.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("User has not borrowed any books.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while returning the book. Error details: " + ex.Message);
                }
            }
        }
        private void ApplyMembership()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Insert the membership record for the user
                    string insertMemberQuery = "INSERT INTO Member (Name) VALUES (@Username); SELECT CAST(SCOPE_IDENTITY() AS INT)";
                    using (SqlCommand insertMemberCommand = new SqlCommand(insertMemberQuery, connection))
                    {
                        insertMemberCommand.Parameters.AddWithValue("@Username", currentUser);
                        object result = insertMemberCommand.ExecuteScalar();

                        int newMemberId = Convert.IsDBNull(result) ? -1 : Convert.ToInt32(result);
                        MemberText.Text = newMemberId.ToString();

                        if (newMemberId > 0)
                        {
                            MessageBox.Show("Membership applied successfully! Your Membership ID: " + newMemberId);
                        }
                        else
                        {
                            MessageBox.Show("Failed to apply membership. Please try again.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while applying for membership. Error details: " + ex.Message);
                }
            }
        }



        private void MembershipBtn_Click(object sender, EventArgs e)
        {
            ApplyMembership();
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            string returnBookName = ReturnText.Text;
            ReturnBook(returnBookName);
        }

        private void BorrowBtn_Click(object sender, EventArgs e)
        {
            string borrowBookName = BorrowText.Text;
            BorrowBook(borrowBookName);
        }

        private void SearchBtn1_Click(object sender, EventArgs e)
        {
            string searchBookName = SearchText.Text;
            SearchBook1(searchBookName);
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
