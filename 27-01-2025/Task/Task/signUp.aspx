<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="signUp.aspx.cs" Inherits="Task.signUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sign Up</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous" />

</head>
<body>
    <div>
        <!-- Section: Design Block -->
        <section>
            <!-- Jumbotron -->
            <div class="px-4 py-5 px-md-5 text-center text-lg-start" style="background-color: hsl(0, 0%, 96%); height:100vh">
                <div class="container">
                    <div class="row gx-lg-5 align-items-center">
                        <div class="col-lg-6 mb-5 mb-lg-0">
                            <h1>Sign Up</h1>
                            <h1 class="my-5 display-3 fw-bold ls-tight">The best offer
                                <br />
                                <span class="text-primary">for your business</span>
                            </h1>
                            <p style="color: hsl(217, 10%, 50.8%)">
                                Lorem ipsum dolor sit amet consectetur adipisicing elit.
            Eveniet, itaque accusantium odio, soluta, corrupti aliquam
            quibusdam tempora at cupiditate quis eum maiores libero
            veritatis? Dicta facilis sint aliquid ipsum atque?
                            </p>
                        </div>

                        <div class="col-lg-6 mb-5 mb-lg-0">
                            <div class="card">
                                <div class="card-body py-5 px-md-5">
                                    <form runat="server">

                                        <div data-mdb-input-init class="form-outline mb-4">
                                            <label class="form-label" for="name">Name</label>
                                            <asp:TextBox type="text" ID="name" class="form-control" runat="server"></asp:TextBox>
                                        </div>

                                        <!-- Email input -->
                                        <div data-mdb-input-init class="form-outline mb-4">
                                            <label class="form-label" for="email">Email address</label>
                                            <asp:TextBox type="email" ID="email" class="form-control" runat="server"></asp:TextBox>
                                        </div>

                                        <!-- Password input -->
                                        <div data-mdb-input-init class="form-outline mb-4">
                                            <label class="form-label" for="password">Password</label>
                                            <asp:TextBox type="password" ID="password" class="form-control" runat="server"></asp:TextBox>
                                        </div>

                                        <!-- Checkbox -->
                                        <div class="form-check d-flex justify-content-center mb-4">
                                            <input class="form-check-input me-2" type="checkbox" value="" id="form2Example33" checked />
                                            <label class="form-check-label" for="form2Example33">
                                                Subscribe to our newsletter
                                            </label>
                                        </div>
                                        <!-- Submit button -->
                                        <asp:Button runat="server" ID="signUpBtn" type="submit" data-mdb-button-init data-mdb-ripple-init class="btn btn-primary btn-block mb-4" Text="Sign Up" OnClick="signUpBtn_Click" />
                                       <br />
                                        <asp:Label runat="server" ID="warningMessage" Visible="false" style="color:red;"></asp:Label>

                                        <!-- Register buttons -->
                                        <div class="text-center">
                                            <p>or sign up with:</p>
                                            <button type="button" data-mdb-button-init data-mdb-ripple-init class="btn btn-link btn-floating mx-1">
                                                <i class="fab fa-facebook-f"></i>
                                            </button>

                                            <button type="button" data-mdb-button-init data-mdb-ripple-init class="btn btn-link btn-floating mx-1">
                                                <i class="fab fa-google"></i>
                                            </button>

                                            <button type="button" data-mdb-button-init data-mdb-ripple-init class="btn btn-link btn-floating mx-1">
                                                <i class="fab fa-twitter"></i>
                                            </button>

                                            <button type="button" data-mdb-button-init data-mdb-ripple-init class="btn btn-link btn-floating mx-1">
                                                <i class="fab fa-github"></i>
                                            </button>
                                        </div>
                                    </form>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <!-- Jumbotron -->
        </section>
        <!-- Section: Design Block -->
    </div>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>
</body>
</html>
