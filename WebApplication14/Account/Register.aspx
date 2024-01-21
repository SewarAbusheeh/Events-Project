<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WebApplication14.Account.Register" %>

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
                        <h3>Get more things done with Loggin platform.</h3>
                        <p>Access to the most powerfull tool in the entire design and web industry.</p>
                        <div class="page-links">
                            <a href="LoginUser.aspx">Login</a><a href="Register.aspx" class="active">Register</a>
                        </div>
                        <form runat="server">
                            <div>
                                <asp:TextBox runat="server" ID="TextBox1" class="form-control" placeholder="E-mail Address" />


                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="TextBox1" runat="server" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
                            </div>



                            <asp:TextBox runat="server" ID="TextBox2" placeholder="Password" TextMode="Password" class="form-control" />
                            <asp:RequiredFieldValidator ControlToValidate="TextBox2" ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>

                            <div class="form-button">

                                <asp:Button runat="server" ID="Button1" Text="Register" OnClick="RegisterUser" class="ibtn" />
                            </div>
                        </form>
                        <div class="other-links">
                            <span>Or register with</span><a href="#"><i class="fab fa-facebook-f"></i></a><a href="#"><i class="fab fa-google"></i></a><a href="#"><i class="fab fa-linkedin-in"></i></a>
                        </div>
                    </div>
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
