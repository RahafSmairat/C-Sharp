using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Task
{
    public partial class addMeetings : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addMeeting_Click(object sender, EventArgs e)
        {
            string file = Server.MapPath("files\\meetings.txt");

            if (!File.Exists(file))
            {
                File.CreateText(file);
            }

            if (string.IsNullOrEmpty(roomId.Text) || string.IsNullOrEmpty(roomName.Text) ||
                string.IsNullOrEmpty(roomLocation.Text) || string.IsNullOrEmpty(roomCapacity.Text))
            {
                msg.Text = "Please Fill All Feilds!";
                msg.Visible = true;
                return;
            }

            using (StreamWriter sw = new StreamWriter(file, true))
            {
                sw.WriteLine($"\n{roomId.Text} {roomName.Text} {roomLocation.Text} {roomCapacity.Text}");
            }

            successMsg.Text = "Meeting Was Schedualed Successfully!";
            successMsg.Visible = true;
        }
    }
}