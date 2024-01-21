<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditUser.aspx.cs" Inherits="WebApplication14.UserOP.EditUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <br />
    <br />
    <br />
    <br />
    <br />

    <asp:Label runat="server" >Email</asp:Label>
    <asp:TextBox runat="server" ID="T1"></asp:TextBox>


      <asp:Label runat="server" >Password</asp:Label>
     <asp:TextBox runat="server" ID="T2"></asp:TextBox>
    <asp:Label runat="server" >ProviderName</asp:Label>
    <asp:DropDownList runat="server" ID="Dropdownl1" DataTextField="ProviderName" DataValueField="ProviderId">
        <asp:ListItem>Select Provider : </asp:ListItem>
    </asp:DropDownList>
                                                                    
     <asp:Label runat="server" >RoleName</asp:Label>
    <asp:DropDownList runat="server" ID="DropDownList1" DataTextField="RoleName" DataValueField="RoleId">
        <asp:ListItem>Select Role : </asp:ListItem>
    </asp:DropDownList>

    <asp:Button runat="server" OnClick="Edit_User" name="Edit"  />
</asp:Content>
