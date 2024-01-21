<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditProvider.aspx.cs" Inherits="WebApplication14.ProviderOP.EditProvider1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <br />

    <br />

    <br />
    <br />


    <div aria-required="True">
        <asp:Label ID="Label1" runat="server" Text="Name" Height="20px" Width="100px"></asp:Label>
        <asp:TextBox ID="txtName" runat="server" Width="400px" ClientIDMode="Static"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Email" Height="20px" Width="100px"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server" Width="400px" ClientIDMode="Static"></asp:TextBox>
        <br />

        <asp:Button ID="EditBtn" OnClick="EditBtn_Click" runat="server" Text="Edit"  Width="200px"  BackColor="White" BorderColor="#0066FF" CssClass="alert-success" Height="40px" ForeColor="Black" />
    </div>
</asp:Content>
