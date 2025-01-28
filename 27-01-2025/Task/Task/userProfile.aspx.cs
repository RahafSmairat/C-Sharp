using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Task
{
    public partial class userProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void books_Click(object sender, EventArgs e)
        {
            Response.Redirect("booksView.aspx");
        }

        protected void meetings_Click(object sender, EventArgs e)
        {
            Response.Redirect("meetingsView.aspx");
        }
    }
}