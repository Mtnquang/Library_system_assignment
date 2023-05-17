namespace library
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void textbox1_mousehover(object sender, EventArgs e)
        {
            if (textBox1.Text == "User")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Silver;
            }
        }

        private void textbox1_leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "User";
                textBox1.ForeColor = Color.Silver;
            }
        }

        private void textbox2_mousehover(object sender, EventArgs e)
        {
            if (textBox1.Text == "Pass")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Silver;
            }
        }

        private void textbox2_leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Pass";
                textBox1.ForeColor = Color.Silver;
            }
        }

        private void button_click(object sender, EventArgs e)
        {
            Hide();
            if (textBox1.Text == "USER" && textBox2.Text == "1234")
            {
                Form2 f = new Form2();
                f.Show();
            }
            else
            {
                MessageBox.Show("wrong password or username");
            }
        }
    }
}
