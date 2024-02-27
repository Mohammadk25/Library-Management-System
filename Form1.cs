using System;
using System.Windows.Forms;

namespace LMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            

            // Set the minimum and maximum size of the form to the desired size
            this.MinimumSize = new Size(650, 450); // Replace with your desired width and height
            this.MaximumSize = new Size(650, 450); // Replace with your desired width and height

            // Set the initial size of the form to the desired size
            this.Size = new Size(650, 450); // Replace with your desired width and height

            // Set the form's "FormBorderStyle" property to prevent resizing using the window border
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void LibraryStaffButton_Click(object sender, EventArgs e)
        {
            // Open the Library Staff login form
            LibraryStaffLogin libraryStaffLoginForm = new LibraryStaffLogin();
            libraryStaffLoginForm.ShowDialog();
        }

        private void UserButton_Click(object sender, EventArgs e)
        {
            // Open the User login form
            UserLoginForm userLoginForm = new UserLoginForm();
            userLoginForm.ShowDialog();
        }

        private void SupplierButton_Click(object sender, EventArgs e)
        {
            // Open the Supplier login form
            SupplierLogin supplierLoginForm = new SupplierLogin();
            supplierLoginForm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
