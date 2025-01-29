using System;
using System.IO;

namespace Task
{
    public partial class editBooks : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void search_Click(object sender, EventArgs e)
        {
            msg.Visible = false;
            successMsg.Visible = false;

            if (string.IsNullOrEmpty(bookIdSearch.Text))
            {
                msg.Text = "Please Enter A Book ID";
                msg.Visible = true;
                return;
            }

            string file = Server.MapPath("files\\books.txt");
            string[] books = File.ReadAllLines(file);
            foreach (string book in books)
            {
                string[] bookDetails = book.Split(' ');
                if (bookDetails[0] == bookIdSearch.Text)
                {

                    id.Visible = true;
                    name.Visible = true;
                    type.Visible = true;
                    level.Visible = true;

                    bookId.Text = bookDetails[0];
                    bookId.Visible = true;

                    bookName.Text = bookDetails[1];
                    bookName.Visible = true;

                    bookType.Text = bookDetails[2];
                    bookType.Visible = true;

                    bookLevel.Text = bookDetails[3];
                    bookLevel.Visible = true;

                    save.Visible = true;

                }
                else{
                    msg.Text = "ID Does Not Exist!";
                    msg.Visible = true;
                    return;
                }
            }
        }

        protected void save_Click(object sender, EventArgs e)
        {
            msg.Visible = false;
            successMsg.Visible = false;

            string file = Server.MapPath("files\\books.txt");
            string[] books = File.ReadAllLines(file);
            for (int i = 0; i < books.Length; i++)
            {
                string[] bookDetails = books[i].Split(' ');
                if (bookDetails[0] == bookIdSearch.Text)
                {
                    if (string.IsNullOrEmpty(bookId.Text) || string.IsNullOrEmpty(bookName.Text) || string.IsNullOrEmpty(bookType.Text) ||
                        string.IsNullOrEmpty(bookLevel.Text))
                    {
                        msg.Text = "Please Fill The Feilds.";
                        msg.Visible = true;
                        return;
                    }

                    bookDetails[0] = bookId.Text;

                    bookDetails[1] = bookName.Text;

                    bookDetails[2] = bookType.Text;

                    bookDetails[3] = bookLevel.Text;

                    books[i] = $"{bookDetails[0]} {bookDetails[1]} {bookDetails[2]} {bookDetails[3]}";

                    File.WriteAllLines(file, books);

                    successMsg.Text = "Saved! :)";
                    successMsg.Visible = true;

                    bookId.Text = "";
                    bookName.Text = "";
                    bookType.Text = "";
                    bookLevel.Text = "";
                    bookIdSearch.Text = "";
                }
            }
        }
    }
}