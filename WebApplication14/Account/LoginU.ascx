<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LoginU.ascx.cs" Inherits="WebApplication14.LoginU" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Event</title>
    <link rel="stylesheet" type="text/css" href="css/bootstrap.min.css" />
    <link rel="stylesheet" type="text/css" href="css/fontawesome-all.min.css" />
    <link rel="stylesheet" type="text/css" href="css/iofrm-style.css" />
    <link rel="stylesheet" type="text/css" href="css/iofrm-theme3.css" />
</head>
<body>
    <div class="form-body">
        <div class="website-logo">
            <a href="index.html">
                <div class="logo">
                    <img class="logo-size" src="images/logo-light.svg" alt="" />
                </div>
            </a>
        </div>
        <div class="row">
            <div class="img-holder">
                <div class="bg"></div>
                <div class="info-holder">
                </div>
            </div>
            <div class="form-holder">
                <div class="form-content">
                    <div class="form-items">
                        <h3>Get more things About Events</h3>
                        <p>Login</p>
                        <div class="page-links">
                       
                             <a href="LoginUser.aspx" class="active">Login</a><a href="Register.aspx">Register</a>
                        </div>


                        <asp:TextBox runat="server" ID="txtEmail" class="form-control" placeholder="Email" />

                        <asp:RequiredFieldValidator runat="server" ControlToValidate="txtEmail"
                            CssClass="text-danger" ErrorMessage="The email field is required." />





                        <asp:TextBox runat="server" ID="PasswordTxt" placeholder="Password" TextMode="Password" class="form-control" />
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="PasswordTxt"
                            CssClass="text-danger" ErrorMessage="The password field is required." />

                        <div class="form-button">


                            <asp:Button runat="server" Text="Login" OnClick="login" class="ibtn" />

                        </div>

                        <asp:Label BackColor="Red" Heigh="100px" ID="Labeltxt" runat="server"></asp:Label>




                    </div>

                    <%-- <div class="other-links">
                        <span>Or register with</span><a href="#"><i class="fab fa-facebook-f"></i></a><a href="#"><i class="fab fa-google"></i></a><a href="#"><i class="fab fa-linkedin-in"></i></a>
                    </div>--%>
                </div>
            </div>
        </div>
    </div>
    <script src="~/js/jquery.min.js"></script>
    <script src="~/js/popper.min.js"></script>
    <script src="~/js/bootstrap.min.js"></script>
    <script src="~/js/main.js"></script>
</body>
</html>
