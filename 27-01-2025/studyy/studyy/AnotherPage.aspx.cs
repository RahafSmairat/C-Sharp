using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace studyy
{
    public partial class AnotherPage : System.Web.UI.Page
    {

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            string filePath = "~\\tt.txt";
            string userInput = bookID.Text;

            if (!File.Exists(filePath))
            {
                using (StreamWriter sw = File.CreateText(filePath))
                {
                    sw.WriteLine(userInput);
                }
            }
            else
            {
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    sw.WriteLine(userInput);
                }
            }
        }

        protected void ButtonReadFile_Click(object sender, EventArgs e)
        {
            string filePath = "~\\tt.txt";


            StreamReader sr = new StreamReader(filePath);
            string content = sr.ReadToEnd();
            FileContent.InnerText = content;


        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}