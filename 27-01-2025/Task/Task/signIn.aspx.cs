using System;
using System.IO;

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

            for(int i = 0; i < registeredUsers.Length; i++)  
            {
                string[] user = registeredUsers[i].Split(' ');
                if (user[1] == email.Text && user[1] == "admin@gmail.com" &&  user[2] == password.Text)
                {
                    user[3] = "true";
                    registeredUsers[i] = $"{user[0]} {user[1]} {user[2]} {user[3]}";
                    File.WriteAllLines(file, registeredUsers);
                    Response.Redirect("adminDashboard.aspx");
                    return;
                }
                    if (user[1] == email.Text && user[2] == password.Text)
                {
                    user[3] = "true";
                    registeredUsers[i] = $"{user[0]} {user[1]} {user[2]} {user[3]}";
                    File.WriteAllLines(file, registeredUsers);
                    Response.Redirect("userProfile.aspx");
                    return;
                }
            }

            msg.Text = "Wrong Email or Password.";
            msg.Visible = true;
        }
    }
}