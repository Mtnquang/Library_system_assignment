namespace library
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            label1 = new Label();
            userControl11 = new UserControl1();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuHighlight;
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(79, 23);
            button1.Name = "button1";
            button1.Size = new Size(142, 42);
            button1.TabIndex = 0;
            button1.Text = "Librarian";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Librarian_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Highlight;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(250, 23);
            label1.Name = "label1";
            label1.Size = new Size(510, 45);
            label1.TabIndex = 1;
            label1.Text = "Library management system";
            label1.Click += label1_Click;
            // 
            // userControl11
            // 
            userControl11.BackColor = SystemColors.ControlDarkDark;
            userControl11.Location = new Point(79, 81);
            userControl11.Margin = new Padding(4, 3, 4, 3);
            userControl11.Name = "userControl11";
            userControl11.Size = new Size(465, 360);
            userControl11.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(795, 481);
            Controls.Add(userControl11);
            Controls.Add(label1);
            Controls.Add(button1);
            Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private UserControl1 userControl11;
    }
}