<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddProvider.aspx.cs" Inherits="WebApplication14.ProviderOP.EditProvider" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <br />
     <br />

     <br />

     <br />
 <br />


    <div aria-required="True">
        <asp:Label ID="Label1" runat="server" Text="UserName" Height="20px" Width="100px"></asp:Label>
           <asp:TextBox ID="UserNameTX" runat="server" Width="400px"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Email" Height="20px" Width="100px"></asp:Label>

     <asp:TextBox ID="EmailTx" runat="server" Width="400px"></asp:TextBox>
        <br />

    <asp:Button ID="AddBtn" OnClick="AddProvider" runat="server" Text="Add"  Width="200px"  BackColor="White" BorderColor="#0066FF" CssClass="alert-success" Height="40px" ForeColor="Black"/>
    </div>
  
</asp:Content>
