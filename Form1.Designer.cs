namespace LMS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LibraryStaffButton = new Button();
            UserButton = new Button();
            SupplierButton = new Button();
            SuspendLayout();
            // 
            // LibraryStaffButton
            // 
            LibraryStaffButton.BackgroundImage = Properties.Resources.Background;
            LibraryStaffButton.FlatStyle = FlatStyle.Popup;
            LibraryStaffButton.ForeColor = SystemColors.ButtonFace;
            LibraryStaffButton.Location = new Point(171, 283);
            LibraryStaffButton.Name = "LibraryStaffButton";
            LibraryStaffButton.Size = new Size(132, 52);
            LibraryStaffButton.TabIndex = 0;
            LibraryStaffButton.Text = "Library Staff";
            LibraryStaffButton.UseVisualStyleBackColor = true;
            LibraryStaffButton.Click += LibraryStaffButton_Click;
            // 
            // UserButton
            // 
            UserButton.BackgroundImage = Properties.Resources.Background;
            UserButton.FlatStyle = FlatStyle.Popup;
            UserButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            UserButton.ForeColor = SystemColors.ButtonFace;
            UserButton.Location = new Point(87, 202);
            UserButton.Name = "UserButton";
            UserButton.Size = new Size(132, 52);
            UserButton.TabIndex = 1;
            UserButton.Text = "User";
            UserButton.UseVisualStyleBackColor = true;
            UserButton.Click += UserButton_Click;
            // 
            // SupplierButton
            // 
            SupplierButton.BackgroundImage = Properties.Resources.Background;
            SupplierButton.FlatStyle = FlatStyle.Popup;
            SupplierButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            SupplierButton.ForeColor = SystemColors.ButtonFace;
            SupplierButton.Location = new Point(265, 202);
            SupplierButton.Name = "SupplierButton";
            SupplierButton.Size = new Size(132, 52);
            SupplierButton.TabIndex = 2;
            SupplierButton.Text = "Supplier";
            SupplierButton.UseVisualStyleBackColor = true;
            SupplierButton.Click += SupplierButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            BackgroundImage = Properties.Resources._66982lms;
            ClientSize = new Size(593, 397);
            Controls.Add(SupplierButton);
            Controls.Add(UserButton);
            Controls.Add(LibraryStaffButton);
            Name = "Form1";
            Text = "Login Page";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button LibraryStaffButton;
        private Button UserButton;
        private Button SupplierButton;
    }
}