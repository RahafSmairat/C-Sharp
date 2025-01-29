using System;
using System.IO;

namespace Task
{
    public partial class profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string file = Server.MapPath("files/rigestered_users.txt");
                string[] users = File.ReadAllLines(file);

                foreach (string user in users)
                {
                    string[] loggedUser = user.Split(' ');
                    if (loggedUser[3] == "true")
                    {
                        name.Text = loggedUser[0];
                        email.Text = loggedUser[1];
                        password.Text = loggedUser[2];
                        confirmPassword.Text = loggedUser[2];
                        return;
                    }
                }
            }
        }

        protected void save_Click(object sender, EventArgs e)
        {
            confirm.Visible = false;
            msg.Visible = false;

            string file = Server.MapPath("files/rigestered_users.txt");
            string[] users = File.ReadAllLines(file);

            if (string.IsNullOrEmpty(name.Text) || string.IsNullOrEmpty(email.Text) || string.IsNullOrEmpty(password.Text) || string.IsNullOrEmpty(confirmPassword.Text)) 
            {
                msg.Text = "Please Fill The Feilds!";
                msg.Visible = true;
                msg.CssClass = "red";
                return;
            }

            if(confirmPassword.Text != password.Text)
            {
                confirm.Text = "Password Does Not Match!";
                confirm.Visible = true;
                return;
            }

            for (int i = 0; i < users.Length; i++)
            {
                string[] loggedUser = users[i].Split(' ');
                if (loggedUser[3] == "true")
                {
                    loggedUser[0] = name.Text;
                    loggedUser[1] = email.Text;
                    loggedUser[2] = password.Text;

                    users[i] = $"{loggedUser[0]} {loggedUser[1]} {loggedUser[2]} true";

                    File.WriteAllLines(file, users);
                    msg.Text = "Saved Successfully";
                    msg.Visible = true;
                    msg.CssClass = "green";
                    return;
                }
            }
        }

        protected void nameEdit_Click(object sender, EventArgs e)
        {
            name.CssClass = "form-control";
            name.ReadOnly = false;
        }

        protected void emailEdit_Click(object sender, EventArgs e)
        {
            email.CssClass = "form-control";
            email.ReadOnly = false;
        }

        protected void passEdit_Click(object sender, EventArgs e)
        {
            password.CssClass = "form-control";
            password.ReadOnly = false;
            confirmPassword.CssClass = "form-control";
            confirmPassword.ReadOnly = false;
        }

        protected void library_Click(object sender, EventArgs e)
        {
            Response.Redirect("userProfile.aspx");
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