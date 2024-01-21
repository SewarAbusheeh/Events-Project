<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditEvent.aspx.cs" Inherits="WebApplication14.EventOP.EditEvent" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <br />

    <br />

    <br />


    <div aria-required="True" class="form-control">
        <asp:Label ID="Label1" runat="server" Text="EventName" Height="20px" Width="100px"></asp:Label>
        <asp:TextBox ID="EventNameTxt" runat="server" Width="400px"></asp:TextBox>
        <br />



       <%-- <asp:TextBox ID="Name" runat="server" TextMode="DateTime" Width="400px"></asp:TextBox>--%>
         <asp:Label ID="Label2" runat="server" Text="EventName" Height="20px" Width="100px"></asp:Label>
        <asp:Calendar ID="Calendar1" runat="server" Height="10px" Width="50px" ></asp:Calendar>

         <asp:Label ID="Label3" runat="server" Text="EventName" Height="20px" Width="100px"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server" DataValueField="Id" DataTextField="Name">
            <asp:ListItem>Select Provider : </asp:ListItem>
        </asp:DropDownList>

        <br />

        <asp:Button ID="EditBtn" OnClick="EditEventM" runat="server" Text="Edit"  BackColor="White" BorderColor="#0066FF" CssClass="alert-success" Height="40px" ForeColor="Black" />
    </div>
</asp:Content>
