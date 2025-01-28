using System;
using System.IO;


namespace Task
{
    public partial class addBooks : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addBook_Click(object sender, EventArgs e)
        {
            string file = Server.MapPath("files\\books.txt");

            if (!File.Exists(file))
            {
                File.CreateText(file);
            }

            if (string.IsNullOrEmpty(bookId.Text) || string.IsNullOrEmpty(bookName.Text) || 
                string.IsNullOrEmpty(bookType.Text) || string.IsNullOrEmpty(bookLevel.Text))
            {
                msg.Text = "Please Fill All Feilds!";
                msg.Visible = true;
                return;
            }

            using (StreamWriter sw = new StreamWriter(file, true))
            {
                sw.WriteLine($"\n{bookId.Text} {bookName.Text} {bookType.Text} {bookLevel.Text}");
            }

            successMsg.Text = "Book Was Added Successfully!";
            successMsg.Visible = true;
        }
    }
}