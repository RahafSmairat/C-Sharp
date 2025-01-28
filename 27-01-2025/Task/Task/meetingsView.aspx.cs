using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Task
{
    public partial class meetingsView : System.Web.UI.Page
    {
        protected void ViewMeetings()
        {
            string file = Server.MapPath("files\\meetings.txt");
            string[] meetings = File.ReadAllLines(file);
            foreach (string meeting in meetings)
            {
                string[] meetingData = meeting.Split(' ');
                meetingsData.InnerHtml += $"<div class=\"inline\">\r\n<p>{meetingData[0]}</p>\r\n<p>{meetingData[1]}</p>\r\n<p>{meetingData[2]}</p>\r\n" +
                $"<p>{meetingData[3]}</p>\r\n</div>\r\n<hr />";
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            ViewMeetings();
        }
    }
}