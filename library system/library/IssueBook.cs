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
    public partial class IssueBook : UserControl
    {
        public IssueBook()
        {
            InitializeComponent();
        }

        private void issue_book(object sender, EventArgs e)
        {
            string issue_book = Borrow_ID.Text + "/" + Borrow_Name.Text + "/" + Book_ID.Text + "/" + Book_Name.Text + "/" + Issue_Day.Text;
            StreamWriter book_issuedetial = new StreamWriter("BookIssueRec.txt", append: true);
            book_issuedetial.WriteLine(issue_book);
            MessageBox.Show("Successfully issue book");
            Borrow_Name.Clear();
            Borrow_ID.Clear();
            Book_ID.Clear();
            Book_Name.Clear();
            Issue_Day.Clear();
            book_issuedetial.Close();
        }
    }
}
