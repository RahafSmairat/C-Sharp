using System;
using System.IO;
namespace Task
{
    public partial class signUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void signUpBtn_Click(object sender, EventArgs e)
        {
            string file = Server.MapPath("files\\rigestered_users.txt");

            if (!File.Exists(file))
            {
                File.CreateText(file);
            }

            if(string.IsNullOrEmpty(name.Text) || string.IsNullOrEmpty(email.Text) || string.IsNullOrEmpty(password.Text))
            {
                warningMessage.Text = "Please Fill All Feilds!";
                warningMessage.Visible = true;
                return;
            }

            string[] registeredUsers = File.ReadAllLines(file);
            foreach (string registeredUser in registeredUsers) 
            {
                string[] user = registeredUser.Split(' ');
                if (user[1] == email.Text)
                {
                    warningMessage.Text = "User Exist Already!";
                    warningMessage.Visible = true;
                    return;
                }
            }
            using (StreamWriter sw = new StreamWriter(file,true)) {
                sw.WriteLine($"{name.Text} {email.Text} {password.Text} false");
            }

            warningMessage.Text = "Rigestered Successfully!";
            Response.Redirect("signIn.aspx");
        }
    }
}