using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Task
{
    public partial class signIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void signInBtn_Click(object sender, EventArgs e)
        {
            string file = Server.MapPath("files\\rigestered_users.txt");

            if(String.IsNullOrEmpty(email.Text) || String.IsNullOrEmpty(password.Text))
            {
                msg.Text = "Please Fill All The Feilds!";
                msg.Visible = true;
                return;
            }

            string[] registeredUsers = File.ReadAllLines(file);

            foreach (string registeredUser in registeredUsers) 
            {
                string[] user = registeredUser.Split(' ');
                if (user[1] == email.Text && user[1] == "admin@gmail.com" &&  user[2] == password.Text)
                {
                    Response.Redirect("adminDashboard.aspx");
                    return;
                }
                    if (user[1] == email.Text && user[2] == password.Text)
                {
                    Response.Redirect("userProfile.aspx");
                    return;
                }
            }

            msg.Text = "Wrong Email or Password.";
            msg.Visible = true;
        }
    }
}