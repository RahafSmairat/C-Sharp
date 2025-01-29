using System;
using System.IO;

namespace Task
{
    public partial class adminDashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void books_Click(object sender, EventArgs e)
        {
            Response.Redirect("addBooks.aspx");
        }

        protected void meetings_Click(object sender, EventArgs e)
        {
            Response.Redirect("addMeetings.aspx");
        }

        protected void editBooks_Click(object sender, EventArgs e)
        {
            Response.Redirect("editBooks.aspx");
        }

        protected void library_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminDashboard.aspx");
        }

        protected void logout_Click(object sender, EventArgs e)
        {
            string file = Server.MapPath("files/rigestered_users.txt");
            string[] users = File.ReadAllLines(file);

            for (int i = 0; i < users.Length; i++)
            {
                string[] loggedUser = users[i].Split(' ');
                if (loggedUser[3] == "true")
                {
                    loggedUser[3] = "false";
                    users[i] = $"{loggedUser[0]} {loggedUser[1]} {loggedUser[2]} {loggedUser[3]}";
                    File.WriteAllLines(file, users);
                    Response.Redirect("home.aspx");
                }
            }
        }
    }
}