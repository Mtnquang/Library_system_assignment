namespace library
{
    partial class Bookreg
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bookreg));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            Book_name = new TextBox();
            groupBox2 = new GroupBox();
            Book_Author = new TextBox();
            groupBox3 = new GroupBox();
            Book_Publisher = new TextBox();
            groupBox4 = new GroupBox();
            Book_Publishing_Year = new TextBox();
            groupBox5 = new GroupBox();
            Book_Category = new TextBox();
            Save_book = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            label7 = new Label();
            groupBox6 = new GroupBox();
            Book_ID = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
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
            label1.Size = new Size(315, 45);
            label1.TabIndex = 2;
            label1.Text = "Book registration";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Book_name);
            groupBox1.Location = new Point(317, 212);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(263, 52);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // Book_name
            // 
            Book_name.Location = new Point(0, 16);
            Book_name.Name = "Book_name";
            Book_name.Size = new Size(262, 27);
            Book_name.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(Book_Author);
            groupBox2.Location = new Point(317, 288);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(263, 52);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            // 
            // Book_Author
            // 
            Book_Author.Location = new Point(0, 13);
            Book_Author.Name = "Book_Author";
            Book_Author.Size = new Size(262, 27);
            Book_Author.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(Book_Publisher);
            groupBox3.Location = new Point(317, 372);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(263, 52);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            // 
            // Book_Publisher
            // 
            Book_Publisher.Location = new Point(0, 13);
            Book_Publisher.Name = "Book_Publisher";
            Book_Publisher.Size = new Size(262, 27);
            Book_Publisher.TabIndex = 1;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(Book_Publishing_Year);
            groupBox4.Location = new Point(317, 461);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(263, 52);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            // 
            // Book_Publishing_Year
            // 
            Book_Publishing_Year.Location = new Point(0, 13);
            Book_Publishing_Year.Name = "Book_Publishing_Year";
            Book_Publishing_Year.Size = new Size(262, 27);
            Book_Publishing_Year.TabIndex = 1;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(Book_Category);
            groupBox5.Location = new Point(317, 543);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(263, 52);
            groupBox5.TabIndex = 5;
            groupBox5.TabStop = false;
            // 
            // Book_Category
            // 
            Book_Category.Location = new Point(0, 13);
            Book_Category.Name = "Book_Category";
            Book_Category.Size = new Size(262, 27);
            Book_Category.TabIndex = 1;
            // 
            // Save_book
            // 
            Save_book.BackColor = SystemColors.Highlight;
            Save_book.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            Save_book.ForeColor = SystemColors.ButtonHighlight;
            Save_book.Location = new Point(377, 621);
            Save_book.Name = "Save_book";
            Save_book.Size = new Size(94, 44);
            Save_book.TabIndex = 6;
            Save_book.Text = "Save";
            Save_book.UseVisualStyleBackColor = false;
            Save_book.Click += save_book_click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlDarkDark;
            label2.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(42, 227);
            label2.Name = "label2";
            label2.Size = new Size(157, 31);
            label2.TabIndex = 7;
            label2.Text = "Book  Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlDarkDark;
            label3.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(42, 301);
            label3.Name = "label3";
            label3.Size = new Size(165, 31);
            label3.TabIndex = 8;
            label3.Text = "Book Author";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlDarkDark;
            label4.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(42, 385);
            label4.Name = "label4";
            label4.Size = new Size(195, 31);
            label4.TabIndex = 9;
            label4.Text = "Book Publisher";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ControlDarkDark;
            label5.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(42, 475);
            label5.Name = "label5";
            label5.Size = new Size(268, 31);
            label5.TabIndex = 10;
            label5.Text = "Book Publishing Year";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ControlDarkDark;
            label6.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(42, 556);
            label6.Name = "label6";
            label6.Size = new Size(189, 31);
            label6.TabIndex = 11;
            label6.Text = "Book Category";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ControlDarkDark;
            label7.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(42, 164);
            label7.Name = "label7";
            label7.Size = new Size(119, 31);
            label7.TabIndex = 13;
            label7.Text = "Book  ID";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(Book_ID);
            groupBox6.Location = new Point(317, 144);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(263, 52);
            groupBox6.TabIndex = 5;
            groupBox6.TabStop = false;
            // 
            // Book_ID
            // 
            Book_ID.Location = new Point(0, 16);
            Book_ID.Name = "Book_ID";
            Book_ID.Size = new Size(262, 27);
            Book_ID.TabIndex = 1;
            // 
            // Bookreg
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            Controls.Add(groupBox6);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Save_book);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Bookreg";
            Size = new Size(857, 693);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox Book_name;
        private GroupBox groupBox2;
        private TextBox Book_Author;
        private GroupBox groupBox3;
        private TextBox Book_Publisher;
        private GroupBox groupBox4;
        private TextBox Book_Publishing_Year;
        private GroupBox groupBox5;
        private TextBox Book_Category;
        private Button Save_book;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ContextMenuStrip contextMenuStrip1;
        private Label label7;
        private GroupBox groupBox6;
        private TextBox Book_ID;
    }
}
