using System;
using System.IO;
using System.Linq;

namespace WebApplication1
{
    public partial class home : System.Web.UI.Page
    {
        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            string filePath = "C:\\Users\\Orange\\Desktop\\C-Sharp\\27-01-2025\\test.txt";
            string userInput = Email.Text;

            if (string.IsNullOrEmpty(userInput))
            {
                Response.Write("Email cannot be empty!");
                return;
            }

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);

                if (lines.Contains(userInput))
                { 
                    Response.Write("This email is already registered.");
                    return;
                }
            }

            using (StreamWriter sw = File.AppendText(filePath))
            {
                sw.WriteLine(userInput);
            }

            Response.Write("Email successfully registered!");
        }

        protected void ButtonReadFile_Click(object sender, EventArgs e)
        {
            string filePath = "C:\\Users\\Orange\\Desktop\\C-Sharp\\27-01-2025\\test.txt";

            if (File.Exists(filePath))
            {
                string content = File.ReadAllText(filePath);
                FileContent.InnerText = content;
            }
            else
            {
                Response.Write("File not found!");
            }
        }

        protected void redicrect(object sender, EventArgs e)
        {
            string filePath = "C:\\Users\\Orange\\Desktop\\C-Sharp\\27-01-2025\\test.txt";

            if (File.Exists(filePath))
            {
                Response.Redirect(filePath);
            }
            else
            {
                Response.Write("File not found!");
            }
        }


        protected void login(object sender, EventArgs e)
        {
            string filePath = "C:\\Users\\Orange\\Desktop\\C-Sharp\\27-01-2025\\test.txt";
            string userInput = Email.Text.Trim();

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);

                if (lines.Contains(userInput))
                {
                    Response.Write("Login successful!");
                }
                else
                {
                    Response.Write("Invalid email! Please register first.");
                }
            }
            else
            {
                Response.Write("File not found! No registered users.");
            }
        }


        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}
