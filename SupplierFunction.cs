using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LMS
{
    public partial class SupplierFunction : Form
    {
        private const string connectionString = @"Data Source=mohammads-lenov\sqlexpress;Initial Catalog=lms;Integrated Security=True";

        public SupplierFunction()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // Search button
        {
            string searchBookName = textBox1.Text;
            SearchBook(searchBookName);
        }

        private void textBox1_TextChanged(object sender, EventArgs e) // Search a book textbox where the name of the book to be searched will be entered 
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e) // Sell a book textbox where the name of the book to be sold will be entered
        {

        }

        private void button2_Click(object sender, EventArgs e) // Sell button
        {
            string sellBookName = textBox2.Text;
            int sellBookQuantity = (int)numericUpDown1.Value;
            SellBook(sellBookName, sellBookQuantity);
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

        private void SellBook(string bookName, int quantity)
        {
            if (quantity <= 0)
            {
                MessageBox.Show("Quantity must be greater than zero.");
                return;
            }

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
                            // Book sold successfully
                            MessageBox.Show("Book sold successfully!");
                        }
                        else
                        {
                            // Failed to sell book
                            MessageBox.Show("Failed to sell book. Please try again.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while selling the book. Error details: " + ex.Message);
                }
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
