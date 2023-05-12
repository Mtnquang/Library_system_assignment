using System;
using System.Collections;
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
    public partial class SearchBook : UserControl
    {
        public SearchBook()
        {
            InitializeComponent();
        }

        
        

        

    private void search(object sender, EventArgs e)
        {
            StreamReader book_search = new StreamReader("BookRec.txt");
            book_search.ReadLine();

            string book = book_search.ReadLine();
            string[] words = book.Split("/");

            {

                Book_ID.Text = words[0];
                Book_name.Text = words[1];
                Book_Author.Text = words[2];
                Book_Publisher.Text = words[3];
                Book_Publishing_Year.Text = words[4];
                Book_Category.Text = words[5];
            }
            book_search.Close();

            Console.ReadLine();


        }
    }
}

