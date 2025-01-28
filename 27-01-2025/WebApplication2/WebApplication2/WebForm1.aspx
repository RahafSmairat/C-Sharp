<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="mb-3">
                <label for="" class="form-label">ID</label>
                <asp:TextBox runat="server" ID="bookID" aria-describedy="emailHelp" class="form-control"></asp:TextBox>
            </div>

            <asp:Button runat="server" ID="WriteToFile" Text="Write" OnClick="ButtonSubmit_Click" />
            <asp:Button ID="ButtonReadFile" runat="server" Text="Read File" OnClick="ButtonReadFile_Click" />
            <p id="FileContent" runat="server"></p>
        </div>
    </form>
</body>
</html>
