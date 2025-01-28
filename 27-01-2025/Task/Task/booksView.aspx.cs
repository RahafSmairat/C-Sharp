using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Task
{
    public partial class booksView : System.Web.UI.Page
    {
        protected void ViewBooks()
        {
            string file = Server.MapPath("files\\books.txt");
            string[] books = File.ReadAllLines(file);
            foreach (string book in books) 
            {
                string[] bookData = book.Split(' ');
                booksData.InnerHtml += $"<div class=\"inline\">\r\n<p>{bookData[0]}</p>\r\n<p>{bookData[1]}</p>\r\n<p>{bookData[2]}</p>\r\n" +
                $"<p>{bookData[3]}</p>\r\n</div>\r\n<hr />";
            } 
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            ViewBooks();
        }
    }
}