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
    public partial class Bookreg : UserControl
    {
        public Bookreg()
        {
            InitializeComponent();
        }

        private void save_book_click(object sender, EventArgs e)
        {
            string bookData = Book_ID.Text + "/" +  Book_name.Text + "/" + Book_Author.Text + "/" + Book_Publisher.Text + "/" + Book_Publishing_Year.Text + "/" + Book_Category.Text;
            StreamWriter Bookdetail = new StreamWriter("BookRec.txt", append: true );
            Bookdetail.WriteLine(bookData);
            MessageBox.Show("successfuly save new book");
            Book_name.Clear();
            Book_ID.Clear();
            Book_Author.Clear();
            Book_Publisher.Clear();
            Book_Publishing_Year.Clear();
            Book_Category.Clear();
            Bookdetail.Close();
        }
    }
}
