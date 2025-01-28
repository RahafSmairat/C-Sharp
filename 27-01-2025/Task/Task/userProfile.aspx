<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="userProfile.aspx.cs" Inherits="Task.userProfile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>User Profile</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous" />
</head>
<body>
    <form id="form1" runat="server">
        <h1 style="text-align:center; margin:50px;">User Profile</h1>
            <div class="row row-cols-md-4 justify-content-center">
                <div class="col-4">
                    <div class="card">
                        <img src="images\img2.jpg" class="card-img-top" alt="..." />
                        <div class="card-body">
                            <h5 class="card-title">See All Books</h5>
                            <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                            <asp:Button runat="server" class="btn btn-primary" Text="See All Books" ID="books" OnClick="books_Click"/>
                        </div>
                    </div>
                </div>
                <div class="col-4">
                    <div class="card">
                        <img src="images\img3.jpg" class="card-img-top" alt="..." />
                        <div class="card-body">
                            <h5 class="card-title">See All Meetings</h5>
                            <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                            <asp:Button runat="server" class="btn btn-primary" Text="See All Meetings" ID="meetings" OnClick="meetings_Click"/>
                        </div>
                    </div>
                </div>
            </div>

    </form>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>

</body>
</html>
