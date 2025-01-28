<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="WebApplication1.home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="mb-3">
                <label for="" class="form-label">Email</label>
                <asp:TextBox runat="server" ID="Email" aria-describedy="emailHelp" class="form-control"></asp:TextBox>
            </div>

            <div class="mb-3">
                <label for="" class="form-label">Passowrd</label>
                <asp:TextBox runat="server" ID="passowrd" aria-describedy="emailHelp" class="form-control"></asp:TextBox>
            </div>

            <asp:Button runat="server" ID="WriteToFile" Text="Register" OnClick="ButtonSubmit_Click" />
            <asp:Button ID="ButtonReadFile" runat="server" Text="Read File" OnClick="ButtonReadFile_Click" />
            <asp:Button ID="Button1" runat="server" Text="Redirect to another page" OnClick="redicrect" />

            <asp:Button ID="Button2" runat="server" Text="Login" OnClick="login" />


            <p id="FileContent" runat="server"></p>

        </div>
    </form>
</body>
</html>