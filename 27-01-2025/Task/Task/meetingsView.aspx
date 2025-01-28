<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="meetingsView.aspx.cs" Inherits="Task.meetingsView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Meetings</title>
    <style>
        .inline {
            display: flex;
            flex-direction: row;
            justify-content: space-evenly;
        }

            .inline p {
                width: 150px;
            }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <div runat="server" id="meetingsData">

                <div class="inline" style="background-color: lightpink; font-weight: 700; border: 3px solid black">
                    <p>Room ID</p>
                    <p>Room Name</p>
                    <p>Room Location</p>
                    <p>Room Capacity</p>
                </div>
                <hr />
            </div>

        </div>
    </form>
</body>
</html>
