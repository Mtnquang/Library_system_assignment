namespace library
{
    partial class IssueBook
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IssueBook));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            Issue_book = new Button();
            groupBox5 = new GroupBox();
            Issue_Day = new TextBox();
            groupBox4 = new GroupBox();
            Book_ID = new TextBox();
            groupBox3 = new GroupBox();
            Book_Name = new TextBox();
            groupBox2 = new GroupBox();
            Borrow_ID = new TextBox();
            groupBox1 = new GroupBox();
            Borrow_Name = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(857, 128);
            panel1.TabIndex = 1;
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
            label1.Size = new Size(205, 45);
            label1.TabIndex = 2;
            label1.Text = "Issue Book";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ControlDarkDark;
            label6.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(42, 456);
            label6.Name = "label6";
            label6.Size = new Size(127, 31);
            label6.TabIndex = 22;
            label6.Text = "Issue Day";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ControlDarkDark;
            label5.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(42, 383);
            label5.Name = "label5";
            label5.Size = new Size(112, 31);
            label5.TabIndex = 21;
            label5.Text = "Book ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlDarkDark;
            label4.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(42, 312);
            label4.Name = "label4";
            label4.Size = new Size(150, 31);
            label4.TabIndex = 20;
            label4.Text = "Book Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlDarkDark;
            label3.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(42, 255);
            label3.Name = "label3";
            label3.Size = new Size(164, 31);
            label3.TabIndex = 19;
            label3.Text = "Borrower ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlDarkDark;
            label2.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(42, 193);
            label2.Name = "label2";
            label2.Size = new Size(209, 31);
            label2.TabIndex = 18;
            label2.Text = "Borrower  Name";
            // 
            // Issue_book
            // 
            Issue_book.BackColor = SystemColors.Highlight;
            Issue_book.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            Issue_book.ForeColor = SystemColors.ButtonHighlight;
            Issue_book.Location = new Point(326, 567);
            Issue_book.Name = "Issue_book";
            Issue_book.Size = new Size(149, 44);
            Issue_book.TabIndex = 17;
            Issue_book.Text = "Issue book";
            Issue_book.UseVisualStyleBackColor = false;
            Issue_book.Click += issue_book;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(Issue_Day);
            groupBox5.Location = new Point(290, 444);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(263, 52);
            groupBox5.TabIndex = 13;
            groupBox5.TabStop = false;
            // 
            // Issue_Day
            // 
            Issue_Day.Location = new Point(0, 13);
            Issue_Day.Name = "Issue_Day";
            Issue_Day.Size = new Size(262, 27);
            Issue_Day.TabIndex = 1;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(Book_ID);
            groupBox4.Location = new Point(290, 369);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(263, 52);
            groupBox4.TabIndex = 14;
            groupBox4.TabStop = false;
            // 
            // Book_ID
            // 
            Book_ID.Location = new Point(0, 13);
            Book_ID.Name = "Book_ID";
            Book_ID.Size = new Size(262, 27);
            Book_ID.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(Book_Name);
            groupBox3.Location = new Point(290, 299);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(263, 52);
            groupBox3.TabIndex = 15;
            groupBox3.TabStop = false;
            // 
            // Book_Name
            // 
            Book_Name.Location = new Point(0, 13);
            Book_Name.Name = "Book_Name";
            Book_Name.Size = new Size(262, 27);
            Book_Name.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(Borrow_ID);
            groupBox2.Location = new Point(290, 241);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(263, 52);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            // 
            // Borrow_ID
            // 
            Borrow_ID.Location = new Point(0, 13);
            Borrow_ID.Name = "Borrow_ID";
            Borrow_ID.Size = new Size(262, 27);
            Borrow_ID.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Borrow_Name);
            groupBox1.Location = new Point(290, 177);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(263, 52);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            // 
            // Borrow_Name
            // 
            Borrow_Name.Location = new Point(0, 16);
            Borrow_Name.Name = "Borrow_Name";
            Borrow_Name.Size = new Size(262, 27);
            Borrow_Name.TabIndex = 1;
            // 
            // IssueBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Issue_book);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "IssueBook";
            Size = new Size(857, 693);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button Issue_book;
        private GroupBox groupBox5;
        private TextBox Issue_Day;
        private GroupBox groupBox4;
        private TextBox Book_ID;
        private GroupBox groupBox3;
        private TextBox Book_Name;
        private GroupBox groupBox2;
        private TextBox Borrow_ID;
        private GroupBox groupBox1;
        private TextBox Borrow_Name;
    }
}
