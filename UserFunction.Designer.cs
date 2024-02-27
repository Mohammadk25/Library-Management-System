namespace LMS
{
    partial class UserFunction
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SearchBtn1 = new Button();
            SearchText = new TextBox();
            MembershipBtn = new Button();
            ReturnBtn = new Button();
            BorrowBtn = new Button();
            ReturnText = new TextBox();
            BorrowText = new TextBox();
            MemberText = new TextBox();
            SuspendLayout();
            // 
            // SearchBtn1
            // 
            SearchBtn1.Location = new Point(100, 149);
            SearchBtn1.Name = "SearchBtn1";
            SearchBtn1.Size = new Size(112, 34);
            SearchBtn1.TabIndex = 0;
            SearchBtn1.Text = "Search";
            SearchBtn1.UseVisualStyleBackColor = true;
            SearchBtn1.Click += SearchBtn1_Click;
            // 
            // SearchText
            // 
            SearchText.Location = new Point(65, 101);
            SearchText.Name = "SearchText";
            SearchText.Size = new Size(212, 31);
            SearchText.TabIndex = 1;
            SearchText.Text = "Search Book";
            SearchText.TextChanged += SearchText_TextChanged;
            // 
            // MembershipBtn
            // 
            MembershipBtn.Location = new Point(65, 296);
            MembershipBtn.Name = "MembershipBtn";
            MembershipBtn.Size = new Size(167, 59);
            MembershipBtn.TabIndex = 2;
            MembershipBtn.Text = "Apply Membership";
            MembershipBtn.UseVisualStyleBackColor = true;
            MembershipBtn.Click += MembershipBtn_Click;
            // 
            // ReturnBtn
            // 
            ReturnBtn.Location = new Point(571, 296);
            ReturnBtn.Name = "ReturnBtn";
            ReturnBtn.Size = new Size(112, 34);
            ReturnBtn.TabIndex = 3;
            ReturnBtn.Text = "Return Book";
            ReturnBtn.UseVisualStyleBackColor = true;
            ReturnBtn.Click += ReturnBtn_Click;
            // 
            // BorrowBtn
            // 
            BorrowBtn.Location = new Point(571, 149);
            BorrowBtn.Name = "BorrowBtn";
            BorrowBtn.Size = new Size(112, 34);
            BorrowBtn.TabIndex = 4;
            BorrowBtn.Text = "Borrow";
            BorrowBtn.UseVisualStyleBackColor = true;
            BorrowBtn.Click += BorrowBtn_Click;
            // 
            // ReturnText
            // 
            ReturnText.Location = new Point(530, 242);
            ReturnText.Name = "ReturnText";
            ReturnText.Size = new Size(211, 31);
            ReturnText.TabIndex = 5;
            ReturnText.Text = "Return Book";
            ReturnText.TextChanged += ReturnText_TextChanged;
            // 
            // BorrowText
            // 
            BorrowText.Location = new Point(530, 101);
            BorrowText.Name = "BorrowText";
            BorrowText.Size = new Size(211, 31);
            BorrowText.TabIndex = 6;
            BorrowText.Text = "Borrow Book";
            BorrowText.TextChanged += BorrowText_TextChanged;
            // 
            // MemberText
            // 
            MemberText.Location = new Point(42, 242);
            MemberText.Name = "MemberText";
            MemberText.Size = new Size(212, 31);
            MemberText.TabIndex = 7;
            MemberText.Text = "Membership ID";
            MemberText.TextChanged += MemberText_TextChanged;
            // 
            // UserFunction
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Backnumber21;
            ClientSize = new Size(745, 394);
            Controls.Add(MemberText);
            Controls.Add(BorrowText);
            Controls.Add(ReturnText);
            Controls.Add(BorrowBtn);
            Controls.Add(ReturnBtn);
            Controls.Add(MembershipBtn);
            Controls.Add(SearchText);
            Controls.Add(SearchBtn1);
            Name = "UserFunction";
            Text = "UserFunction";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SearchBtn1;
        private TextBox SearchText;
        private Button MembershipBtn;
        private Button ReturnBtn;
        private Button BorrowBtn;
        private TextBox ReturnText;
        private TextBox BorrowText;
        private TextBox MemberText;
    }
}