namespace LMS
{
    partial class LibraryStaffFunction
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox7 = new TextBox();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(50, 42);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(166, 31);
            textBox1.TabIndex = 0;
            textBox1.Text = "Add a book";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(53, 94);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(163, 31);
            textBox2.TabIndex = 1;
            textBox2.Text = "Search for a book";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(53, 152);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(163, 31);
            textBox3.TabIndex = 2;
            textBox3.Text = "Reserve Book";
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(405, 44);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 31);
            textBox4.TabIndex = 3;
            textBox4.Text = "Old Name";
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(53, 223);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(163, 31);
            textBox5.TabIndex = 4;
            textBox5.Text = "Username";
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(392, 155);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(150, 31);
            textBox6.TabIndex = 5;
            textBox6.Text = "Lend Book";
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(244, 42);
            button1.Name = "button1";
            button1.Size = new Size(86, 34);
            button1.TabIndex = 6;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(244, 94);
            button2.Name = "button2";
            button2.Size = new Size(86, 34);
            button2.TabIndex = 7;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 5F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(244, 152);
            button3.Name = "button3";
            button3.Size = new Size(86, 34);
            button3.TabIndex = 8;
            button3.Text = "Unreserve/Reserve";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(595, 45);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(150, 31);
            textBox7.TabIndex = 9;
            textBox7.Text = "New Name";
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // button4
            // 
            button4.Location = new Point(516, 94);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 10;
            button4.Text = "Change";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(171, 272);
            button5.Name = "button5";
            button5.Size = new Size(86, 34);
            button5.TabIndex = 11;
            button5.Text = "Add";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(516, 205);
            button6.Name = "button6";
            button6.Size = new Size(128, 34);
            button6.TabIndex = 12;
            button6.Text = "Lend";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(595, 155);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(150, 31);
            textBox8.TabIndex = 13;
            textBox8.Text = "To Member";
            textBox8.TextChanged += textBox8_TextChanged;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(244, 223);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(91, 31);
            textBox9.TabIndex = 14;
            textBox9.Text = "Password";
            textBox9.TextChanged += textBox9_TextChanged;
            // 
            // LibraryStaffFunction
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Backnumber21;
            ClientSize = new Size(746, 351);
            Controls.Add(textBox9);
            Controls.Add(textBox8);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(textBox7);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "LibraryStaffFunction";
            Text = "LibraryStaffFunction";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox7;
        private Button button4;
        private Button button5;
        private Button button6;
        private TextBox textBox8;
        private TextBox textBox9;
    }
}