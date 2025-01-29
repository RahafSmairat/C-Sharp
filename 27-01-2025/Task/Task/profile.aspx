<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="profile.aspx.cs" Inherits="Task.profile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body {
            margin-top: 20px;
            background-color: #f2f6fc;
            color: #69707a;
        }

        .img-account-profile {
            height: 10rem;
        }

        .rounded-circle {
            border-radius: 50% !important;
        }

        .card {
            box-shadow: 0 0.15rem 1.75rem 0 rgb(33 40 50 / 15%);
        }

            .card .card-header {
                font-weight: 500;
            }

        .card-header:first-child {
            border-radius: 0.35rem 0.35rem 0 0;
        }

        .card-header {
            padding: 1rem 1.35rem;
            margin-bottom: 0;
            background-color: rgba(33, 40, 50, 0.03);
            border-bottom: 1px solid rgba(33, 40, 50, 0.125);
        }

        .form-control, .dataTable-input {
            display: block;
            width: 100%;
            padding: 0.875rem 1.125rem;
            font-size: 0.875rem;
            font-weight: 400;
            line-height: 1;
            color: #69707a;
            background-color: #fff;
            background-clip: padding-box;
            border: 1px solid #c5ccd6;
            -webkit-appearance: none;
            -moz-appearance: none;
            appearance: none;
            border-radius: 0.35rem;
            transition: border-color 0.15s ease-in-out, box-shadow 0.15s ease-in-out;
        }

        .nav-borders .nav-link.active {
            color: #0061f2;
            border-bottom-color: #0061f2;
        }

        .nav-borders .nav-link {
            color: #69707a;
            border-bottom-width: 0.125rem;
            border-bottom-style: solid;
            border-bottom-color: transparent;
            padding-top: 0.5rem;
            padding-bottom: 0.5rem;
            padding-left: 0;
            padding-right: 0;
            margin-left: 1rem;
            margin-right: 1rem;
        }

        .diabled {
            display: block;
            width: 100%;
            padding: 0.6rem 1.125rem;
            font-size: 0.875rem;
            font-weight: 400;
            line-height: 1;
            color: #292929;
            background-clip: padding-box;
            border: 1px solid #c5ccd6;
            -webkit-appearance: none;
            -moz-appearance: none;
            appearance: none;
            border-radius: 0.35rem;
            transition: border-color 0.15s ease-in-out, box-shadow 0.15s ease-in-out;
            background-color: #acacac;
        }

        .green {
            color: green;
            font-weight: bold;
        }

        .red {
            color: red;
            font-weight: bold;
        }
    </style>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">
</head>
<body>
    <form runat="server">

        <div>
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
                                        <hr class="dropdown-divider" />
                                    </li>
                                    <li><a class="dropdown-item" href="#">Something else here</a></li>
                                </ul>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link disabled" href="#" tabindex="-1" aria-disabled="true">Disabled</a>
                            </li>
                        </ul>
                        <div class="d-flex">
                            <asp:Button ID="library" class="btn btn-outline-success" Text="Library" runat="server" OnClick="library_Click" />
                            <asp:Button ID="logout" class="btn btn-outline-success" Text="Logout" runat="server" OnClick="logout_Click" />
                        </div>
                    </div>
                </div>
            </nav>
            <div class="container-xl px-4 mt-4">

                <hr class="mt-0 mb-4">
                <div class="row">
                    <div class="col-xl-4">
                        <!-- Profile picture card-->
                        <div class="card mb-4 mb-xl-0">
                            <div class="card-header">Profile Picture</div>
                            <div class="card-body text-center">
                                <!-- Profile picture image-->
                                <img class="img-account-profile rounded-circle mb-2" src="https://cdn1.iconfinder.com/data/icons/user-pictures/100/female1-512.png" alt="">
                                <!-- Profile picture help block-->
                                <div class="small font-italic text-muted mb-4">JPG or PNG no larger than 5 MB</div>
                                <!-- Profile picture upload button-->
                                <button class="btn btn-primary" type="button">Upload new image</button>
                            </div>
                        </div>
                    </div>
                    <div class="col-xl-8">
                        <!-- Account details card-->
                        <div class="card mb-4">
                            <div class="card-header">Account Details</div>
                            <div class="card-body">

                                <div class="row gx-3 mb-3">
                                    <!-- Form Group (first name)-->
                                    <div class="col-md-10">
                                        <label class="small mb-1" for="inputUsername">Name</label>
                                        <asp:TextBox ID="name" runat="server" ReadOnly="true" CssClass="diabled"></asp:TextBox>
                                    </div>
                                    <!-- Form Group (last name)-->
                                    <div class="col-md-2 mt-4">
                                        <asp:Button class="btn btn-primary" Text="Edit" runat="server" ID="nameEdit" OnClick="nameEdit_Click" />
                                    </div>
                                </div>
                                <!-- Form Row        -->
                                <div class="row gx-3 mb-3">
                                    <!-- Form Group (first name)-->
                                    <div class="col-md-10">
                                        <label class="small mb-1" for="inputUsername">Email</label>
                                        <asp:TextBox ID="email" runat="server" CssClass="diabled " ReadOnly="true"></asp:TextBox>
                                    </div>
                                    <!-- Form Group (last name)-->
                                    <div class="col-md-2 mt-4">
                                        <asp:Button class="btn btn-primary" Text="Edit" runat="server" ID="emailEdit" OnClick="emailEdit_Click" />
                                    </div>
                                </div>
                                <!-- Form Group (email address)-->
                                <div class="row gx-3 mb-3">
                                    <!-- Form Group (first name)-->
                                    <div class="col-md-10">
                                        <label class="small mb-1" for="inputUsername">Password</label>
                                        <asp:TextBox ID="password" runat="server" CssClass="diabled" ReadOnly="true" type="password"></asp:TextBox>
                                        <label class="small mb-1" for="confirmPassword">Confirm Password</label>

                                        <asp:TextBox ID="confirmPassword" runat="server" CssClass="diabled" ReadOnly="true" type="password"></asp:TextBox>
                                        <asp:Label runat="server" ID="confirm" Visible="false" CssClass="red"></asp:Label>
                                    </div>
                                    <!-- Form Group (last name)-->
                                    <div class="col-md-2 mt-4">
                                        <asp:Button class="btn btn-primary" Text="Edit" runat="server" ID="passEdit" OnClick="passEdit_Click" />
                                    </div>
                                </div>
                                <!-- Save changes button-->
                                <asp:Button runat="server" class="btn btn-primary" Text="Save Changes" ID="save" OnClick="save_Click" />
                                <asp:Label runat="server" ID="msg" Visible="false"></asp:Label>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>

    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>
</body>
</html>
