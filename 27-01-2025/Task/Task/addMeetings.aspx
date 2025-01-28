<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addMeetings.aspx.cs" Inherits="Task.addMeetings" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Modify Meetings</title>
    <style>
        label {
            margin-right: 50px;
        }

        .input {
            width: 500px;
        }
    </style>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous" />

</head>
<body>

    <form id="form1" runat="server">
        <div>
            <section class="vh-100" style="background-color: #2779e2;">
                <div class="container h-100">
                    <div class="row d-flex justify-content-center align-items-center h-100">
                        <div class="col-xl-9">

                            <h1 class="text-white mb-4">Schedual A Meeting</h1>

                            <div class="card" style="border-radius: 15px;">
                                <div class="card-body">

                                    <div class="row align-items-center pt-4 pb-1">
                                        <div class="col-md-3 ps-5">

                                            <h6 class="mb-0">Room ID</h6>

                                        </div>
                                        <div class="col-md-9 pe-5">
                                            <asp:TextBox runat="server" ID="roomId" class="input form-control form-control-lg"></asp:TextBox><br />

                                        </div>
                                    </div>

                                    <hr class="mx-n3">

                                    <div class="row align-items-center py-1">
                                        <div class="col-md-3 ps-5">

                                            <h6 class="mb-0">Room Name</h6>

                                        </div>
                                        <div class="col-md-9 pe-5">
                                            <asp:TextBox runat="server" ID="roomName" class="input form-control form-control-lg"></asp:TextBox><br />
                                        </div>
                                    </div>

                                    <hr class="mx-n3">

                                    <div class="row align-items-center py-1">
                                        <div class="col-md-3 ps-5">

                                            <h6 class="mb-0">Room Location</h6>

                                        </div>
                                        <div class="col-md-9 pe-5 ">
                                            <asp:TextBox runat="server" ID="roomLocation" class="input form-control form-control-lg"></asp:TextBox><br />
                                        </div>
                                    </div>

                                    <hr class="mx-n3">

                                    <div class="row align-items-center py-1">
                                        <div class="col-md-3 ps-5">

                                            <h6 class="mb-0">Room Capacity</h6>

                                        </div>
                                        <div class="col-md-9 pe-5">
                                            <asp:TextBox runat="server" ID="roomCapacity" class="input form-control form-control-lg"></asp:TextBox><br />

                                        </div>
                                    </div>

                                    <hr class="mx-n3">

                                    <div class="px-5 py-4">
                                        <asp:Button runat="server" ID="addMeeting" data-mdb-button-init data-mdb-ripple-init class="btn btn-primary btn-lg" Text="Schedual A Meeting" OnClick="addMeeting_Click" />

                                    </div>
                                    <asp:Label runat="server" ID="successMsg" Visible="false" Style="color: green;"></asp:Label>
                                    <asp:Label runat="server" ID="msg" Style="color: red;" Visible="false"></asp:Label>
                                </div>
                            </div>

                        </div>
                    </div>
                </div>
            </section>

        </div>
    </form>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>
</body>
</html>
