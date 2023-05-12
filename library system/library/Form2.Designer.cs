namespace library
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            panel1 = new Panel();
            returnBook1 = new ReturnBook();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            button5 = new Button();
            logout = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            issueBook1 = new IssueBook();
            returnBook2 = new ReturnBook();
            bookreg1 = new Bookreg();
            searchBook1 = new SearchBook();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(returnBook1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1078, 128);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // returnBook1
            // 
            returnBook1.BackColor = SystemColors.ControlDarkDark;
            returnBook1.Location = new Point(160, 127);
            returnBook1.Margin = new Padding(3, 4, 3, 4);
            returnBook1.Name = "returnBook1";
            returnBook1.Size = new Size(755, 627);
            returnBook1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(42, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(78, 83);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Highlight;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(290, 36);
            label1.Name = "label1";
            label1.Size = new Size(510, 45);
            label1.TabIndex = 2;
            label1.Text = "Library management system";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDarkDark;
            panel2.Controls.Add(button5);
            panel2.Controls.Add(logout);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 128);
            panel2.Name = "panel2";
            panel2.Size = new Size(160, 682);
            panel2.TabIndex = 1;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.Highlight;
            button5.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(11, 205);
            button5.Name = "button5";
            button5.Size = new Size(143, 44);
            button5.TabIndex = 9;
            button5.Text = "view";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // logout
            // 
            logout.BackColor = SystemColors.HotTrack;
            logout.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            logout.ForeColor = SystemColors.Control;
            logout.Location = new Point(9, 255);
            logout.Name = "logout";
            logout.Size = new Size(143, 39);
            logout.TabIndex = 8;
            logout.Text = "logout";
            logout.UseVisualStyleBackColor = false;
            logout.Click += Logout_click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.HotTrack;
            button4.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.Control;
            button4.Location = new Point(11, 115);
            button4.Name = "button4";
            button4.Size = new Size(143, 39);
            button4.TabIndex = 7;
            button4.Text = "book res";
            button4.UseVisualStyleBackColor = false;
            button4.Click += Book_res_click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.HotTrack;
            button3.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(11, 69);
            button3.Name = "button3";
            button3.Size = new Size(143, 39);
            button3.TabIndex = 6;
            button3.Text = "return book";
            button3.UseVisualStyleBackColor = false;
            button3.Click += Return_Book_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.HotTrack;
            button2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(11, 160);
            button2.Name = "button2";
            button2.Size = new Size(143, 39);
            button2.TabIndex = 5;
            button2.Text = "search book";
            button2.UseVisualStyleBackColor = false;
            button2.Click += Search_Book_click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(11, 25);
            button1.Name = "button1";
            button1.Size = new Size(143, 39);
            button1.TabIndex = 4;
            button1.Text = "issue book";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Issue_Book_click;
            // 
            // issueBook1
            // 
            issueBook1.BackColor = SystemColors.ControlDarkDark;
            issueBook1.Location = new Point(158, 127);
            issueBook1.Margin = new Padding(3, 4, 3, 4);
            issueBook1.Name = "issueBook1";
            issueBook1.Size = new Size(755, 640);
            issueBook1.TabIndex = 4;
            issueBook1.Load += issueBook1_Load;
            // 
            // returnBook2
            // 
            returnBook2.BackColor = SystemColors.ControlDarkDark;
            returnBook2.Location = new Point(158, 127);
            returnBook2.Margin = new Padding(3, 4, 3, 4);
            returnBook2.Name = "returnBook2";
            returnBook2.Size = new Size(755, 620);
            returnBook2.TabIndex = 5;
            // 
            // bookreg1
            // 
            bookreg1.BackColor = SystemColors.ControlDarkDark;
            bookreg1.Location = new Point(158, 127);
            bookreg1.Margin = new Padding(3, 4, 3, 4);
            bookreg1.Name = "bookreg1";
            bookreg1.Size = new Size(1071, 866);
            bookreg1.TabIndex = 6;
            // 
            // searchBook1
            // 
            searchBook1.BackColor = SystemColors.ControlDarkDark;
            searchBook1.Location = new Point(158, 127);
            searchBook1.Margin = new Padding(3, 4, 3, 4);
            searchBook1.Name = "searchBook1";
            searchBook1.Size = new Size(1141, 866);
            searchBook1.TabIndex = 7;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1078, 810);
            Controls.Add(searchBook1);
            Controls.Add(bookreg1);
            Controls.Add(returnBook2);
            Controls.Add(issueBook1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private IssueBook issueBook1;
        private ReturnBook returnBook1;
        private ReturnBook returnBook2;
        private Bookreg bookreg1;
        private SearchBook searchBook1;
        private Button logout;
        private Button button5;
    }
}