﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="signIn.aspx.cs" Inherits="Task.signIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sign In</title>
    <style>
        .divider:after,
        .divider:before {
            content: "";
            flex: 1;
            height: 1px;
            background: #eee;
        }
    </style>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous" />

</head>

<body>
    <div>
        <section class="vh-100">
            <div class="container py-5 h-100">
                <h1 style="text-align: center">Sign In</h1>

                <div class="row d-flex align-items-center justify-content-center h-100">
                    <div class="col-md-8 col-lg-7 col-xl-6">
                        <img src="https://mdbcdn.b-cdn.net/img/Photos/new-templates/bootstrap-login-form/draw2.svg"
                            class="img-fluid" alt="Phone image" />
                    </div>
                    <div class="col-md-7 col-lg-5 col-xl-5 offset-xl-1">
                        <form runat="server" class="form1">
                            <!-- Email input -->
                            <div data-mdb-input-init class="form-outline mb-4">
                                <label class="form-label" for="email">Email address</label>
                                <asp:TextBox type="email" ID="email" class="form-control form-control-lg" runat="server"></asp:TextBox>
                            </div>

                            <!-- Password input -->
                            <div data-mdb-input-init class="form-outline mb-4">
                                <label class="form-label" for="password">Password</label>
                                <asp:TextBox type="password" ID="password" class="form-control form-control-lg" runat="server"></asp:TextBox>
                            </div>
                            <asp:Label runat="server" ID="msg" Visible="false" Style="color: red;"></asp:Label><br />
                            <br />
                            <div class="d-flex justify-content-around align-items-center mb-4">
                                <!-- Checkbox -->
                                <div class="form-check">
                                    <input class="form-check-input" type="checkbox" value="" id="form1Example3" checked />
                                    <label class="form-check-label" for="form1Example3">Remember me </label>
                                </div>
                                <a href="#!">Forgot password?</a>
                            </div>

                            <!-- Submit button -->
                            <asp:Button runat="server" ID="signInBtn" type="submit" data-mdb-button-init data-mdb-ripple-init class="btn btn-primary btn-lg btn-block" Text="Sign In" OnClick="signInBtn_Click" />

                            <div class="divider d-flex align-items-center my-4">
                                <p class="text-center fw-bold mx-3 mb-0 text-muted">OR</p>
                            </div>

                            <a data-mdb-ripple-init class="btn btn-primary btn-lg btn-block" style="background-color: #3b5998" href="#!"
                                role="button">
                                <i class="fab fa-facebook-f me-2"></i>Continue with Facebook
                            </a>
                            <a data-mdb-ripple-init class="btn btn-primary btn-lg btn-block" style="background-color: #55acee" href="#!"
                                role="button">
                                <i class="fab fa-twitter me-2"></i>Continue with Twitter</a>
                        </form>
                    </div>
                </div>
            </div>
        </section>
    </div>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>

</body>
</html>
