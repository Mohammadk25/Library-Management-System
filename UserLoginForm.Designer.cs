namespace LMS
{
    partial class UserLoginForm
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
            LoginButton = new Button();
            UserNameBox = new TextBox();
            PasswordBox = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // LoginButton
            // 
            LoginButton.BackgroundImage = Properties.Resources.Login;
            LoginButton.BackgroundImageLayout = ImageLayout.Center;
            LoginButton.Image = Properties.Resources.Login3;
            LoginButton.Location = new Point(225, 336);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(143, 41);
            LoginButton.TabIndex = 0;
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += button1_Click;
            // 
            // UserNameBox
            // 
            UserNameBox.BorderStyle = BorderStyle.None;
            UserNameBox.Location = new Point(215, 185);
            UserNameBox.Name = "UserNameBox";
            UserNameBox.Size = new Size(177, 24);
            UserNameBox.TabIndex = 1;
            UserNameBox.TextChanged += UserNameBox_TextChanged;
            // 
            // PasswordBox
            // 
            PasswordBox.BorderStyle = BorderStyle.None;
            PasswordBox.Location = new Point(216, 238);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.Size = new Size(177, 24);
            PasswordBox.TabIndex = 2;
            PasswordBox.TextChanged += PasswordBox_TextChanged;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.SignUp1;
            button1.Location = new Point(225, 284);
            button1.Name = "button1";
            button1.Size = new Size(143, 33);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // UserLoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = Properties.Resources.LoginInterface;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(520, 416);
            Controls.Add(LoginButton);
            Controls.Add(button1);
            Controls.Add(PasswordBox);
            Controls.Add(UserNameBox);
            DoubleBuffered = true;
            Name = "UserLoginForm";
            Text = "UserLoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LoginButton;
        private TextBox UserNameBox;
        private TextBox PasswordBox;
        private Button button1;
    }
}