<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="booksView.aspx.cs" Inherits="Task.booksView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Books</title>
    <style>
        .inline{
            display: flex;
            flex-direction:row;
            justify-content: space-evenly;
        }
        .inline p{
            width: 100px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div runat="server" id="booksData">
            <div class="inline" style="background-color:lightpink; font-weight:700; border: 3px solid black">
                <p>Book ID</p>
                <p>Book Name</p>
                <p>Book Type</p>
                <p>Book Level</p>
            </div>
            <hr />
            </div>
        </div>
    </form>
</body>
</html>
