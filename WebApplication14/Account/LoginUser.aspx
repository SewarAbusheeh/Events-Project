<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginUser.aspx.cs" Inherits="WebApplication14.Account.LoginUser" %>

<%@ Register src="~/Account/LoginU.ascx" tagname="LoginU" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">



<body>
    <form id="form1" runat="server" >
        <uc1:LoginU ID="LoginU1" runat="server" />
    </form>
</body>


</html>
