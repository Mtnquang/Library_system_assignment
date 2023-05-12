using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace library
{
    public partial class ReturnBook : UserControl
    {
        public ReturnBook()
        {
            InitializeComponent();
        }

        private void book_return(object sender, EventArgs e)
        {
            //string filepath = @"D:\1651\library system\library\bin\Debug\net6.0 - windows\BookIssueRec.TxT";
            //List<string> lines = File.ReadAllLines(filepath).ToList();
            // foreach (string line in lines)
            //{
            //    Console.WriteLine(line);
            //}
            //streamReader = new StreamReader(@"D:\1651\library system\library\bin\Debug\net6.0 - windows\BookIssueRec.TxT");
            StreamReader book_return = new StreamReader("BookReturnRec.txt");

            book_return.ReadLine();
            
            string return_book = Borrow_ID.Text + "," + Borrow_Name.Text + "," + Book_ID.Text + "," + Book_Name.Text + "," + Issue_Day.Text;
            if (return_book.Equals (book_return) )
            {
                MessageBox.Show("retrun book successfull");
                Borrow_Name.Clear();
                Borrow_ID.Clear();
                Book_ID.Clear();
                Book_Name.Clear();
                Issue_Day.Clear(); 
                book_return.Close();
            }
            else
            {
                MessageBox.Show("fail to retrun book");
                Borrow_Name.Clear();
                Borrow_ID.Clear();
                Book_ID.Clear();
                Book_Name.Clear();
                Issue_Day.Clear();
                book_return.Close();
            }
        }
    }
}
