using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void button_click(object sender, EventArgs e)
        {
            issueBook1.Hide();
            returnBook1.Hide();
            bookreg1.Hide();
            searchBook1.Hide();
        }

        private void issueBook1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void Issue_Book_click(object sender, EventArgs e)
        {
            issueBook1.Show();
            issueBook1.BringToFront();
            returnBook1.Hide();
            bookreg1.Hide();
            searchBook1.Hide();
        }

        private void Return_Book_Click(object sender, EventArgs e)
        {
            returnBook1.Show();
            returnBook1.BringToFront();
            issueBook1.Hide();
            bookreg1.Hide();
            searchBook1.Hide();
        }


        private void Book_res_click(object sender, EventArgs e)
        {
            bookreg1.Show();
            bookreg1.BringToFront();
            returnBook1.Hide();
            issueBook1.Hide();
            searchBook1.Hide();
        }

        private void Search_Book_click(object sender, EventArgs e)
        {
            searchBook1.Show();
            searchBook1.BringToFront();
            returnBook1.Hide();
            bookreg1.Hide();
            issueBook1.Hide();
        }

        private void Logout_click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }


        private void Form2_load(object sender, EventArgs e)
        {
            issueBook1.Hide();
            returnBook1.Hide();
            bookreg1.Hide();
            searchBook1.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
        }
    }
}
