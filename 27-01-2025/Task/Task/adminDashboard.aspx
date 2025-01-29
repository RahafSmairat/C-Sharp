<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adminDashboard.aspx.cs" Inherits="Task.adminDashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin Dashboard</title>
        <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous" />
        <style>
        .card {
            height: 70vh;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
                <nav class="navbar navbar-expand-lg navbar-light bg-light">
    <div class="container-fluid">
        <a class="navbar-brand" href="#">Navbar</a>
        <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
        </button>
        <div class="collapse navbar-collapse" id="navbarSupportedContent">
            <ul class="navbar-nav me-auto mb-2 mb-lg-0">
                <li class="nav-item">
                    <a class="nav-link active" aria-current="page" href="#">Home</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="#">Link</a>
                </li>
                <li class="nav-item dropdown">
                    <a class="nav-link dropdown-toggle" href="#" id="navbarDropdown" role="button" data-bs-toggle="dropdown" aria-expanded="false">Dropdown
                    </a>
                    <ul class="dropdown-menu" aria-labelledby="navbarDropdown">
                        <li><a class="dropdown-item" href="#">Action</a></li>
                        <li><a class="dropdown-item" href="#">Another action</a></li>
                        <li>
                            <hr class="dropdown-divider"/>
                        </li>
                        <li><a class="dropdown-item" href="#">Something else here</a></li>
                    </ul>
                </li>
                <li class="nav-item">
                    <a class="nav-link disabled" href="#" tabindex="-1" aria-disabled="true">Disabled</a>
                </li>
            </ul>
            <div class="d-flex">
                <asp:Button  ID="library" class="btn btn-outline-success" Text="Library" runat="server" OnClick="library_Click" />
                <asp:Button  ID="logout" class="btn btn-outline-success" Text="Logout" runat="server" OnClick="logout_Click"/>
            </div>
        </div>
    </div>
</nav>
        <h1 style="text-align:center; margin:50px;">Admin Dashboard</h1>
    <div class="row row-cols-md-4 justify-content-center">
        <div class="col-4">
            <div class="card">
                <div style="height:500px"><img src="https://i.etsystatic.com/16895790/r/il/35fd84/4829165436/il_570xN.4829165436_anmw.jpg" class="card-img-top" alt="..." /></div>
                <div class="card-body">
                    <h5 class="card-title">Add Books</h5>
                    <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                    <asp:Button runat="server" class="btn btn-primary" Text="Add Books" ID="books" OnClick="books_Click"/>
                </div>
            </div>
        </div>
                <div class="col-4">
            <div class="card">
                <div style="height:500px"><img src="https://i.etsystatic.com/16895790/r/il/35fd84/4829165436/il_570xN.4829165436_anmw.jpg" class="card-img-top" alt="..." /></div>
                <div class="card-body">
                    <h5 class="card-title">Edit Books</h5>
                    <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                    <asp:Button runat="server" class="btn btn-primary" Text="Edit Books" ID="editBooks" OnClick="editBooks_Click" />
                </div>
            </div>
        </div>
        <div class="col-4">
            <div class="card">
                <div style="height:500px"><img src="https://cdn.prod.website-files.com/62196607bf1b46c300301846/6568ae33daf5cb0b75e26ee6_frsoeroe7prviafnog2q.webp" class="card-img-top" alt="..." /></div>
                <div class="card-body">
                    <h5 class="card-title">Schedual Meetings</h5>
                    <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                    <asp:Button runat="server" class="btn btn-primary" Text="Schedual Meetings" ID="meetings" OnClick="meetings_Click"/>
                </div>
            </div>
        </div>

    </div>
    </form>
        <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>

</body>
</html>
