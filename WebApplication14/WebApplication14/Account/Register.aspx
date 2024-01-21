<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WebApplication14.Account.Register" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>Registreation</h1>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>Email:
                    </td>
                    <td>
                        <div>

                       <asp:TextBox ID="txtEmail" runat="server">
                       
                    </asp:TextBox>
                       <%--  <asp:RequiredFieldValidator runat="server" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator> --%> </div>

                       <%-- <asp:RequiredFieldValidator runat="server" ErrorMessage="RequiredFieldValidator">

                        </asp:RequiredFieldValidator>--%>

                    </td>
                </tr>
                  <tr>
                    <td>Password:</td>
                    <td>
                        <div>
                            <asp:TextBox ID="txtPassword" TextMode="Password" runat="server">
                                         </asp:TextBox>
                            <%-- <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>--%>
                        </div>

                
                       
                       <%-- <asp:RequiredFieldValidator ID="RequiredFieldValidator1"  runat="server" ErrorMessage="RequiredFieldValidator">

                        </asp:RequiredFieldValidator>--%>

                    </td>
                </tr>
                <tr>
                    <td>
                     <asp:Button runat="server" ID="btnRg" Text="Register" Height="29px" Width="136px" class="btn btn-success" OnClick="RegisterUser" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label runat="server" ID="LbMessage" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
    <br />
    <a href="Login.aspx">You already have an account!</a>
</body>
</html>
