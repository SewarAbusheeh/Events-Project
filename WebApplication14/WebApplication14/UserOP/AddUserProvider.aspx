<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddUserProvider.aspx.cs" Inherits="WebApplication14.UserOP.AddUserProvider" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
         <div style="margin-top:150px;">
       
       
      
        <div >
            <asp:Label runat="server" AssociatedControlID="txtEmail">Email</asp:Label>
            <div >
                <asp:TextBox runat="server" ID="txtEmail"  TextMode="Email"  />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtPassword"
                    CssClass="text-danger" ErrorMessage="The email field is required." />
            </div>
        </div>
        <div >
            <div >
            <asp:Label runat="server" AssociatedControlID="txtPassword" >Password</asp:Label>
                <asp:TextBox runat="server" ID="txtPassword" TextMode="Password" CssClass="form-control"  />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtPassword"
                    CssClass="text-danger" ErrorMessage="The password field is required." />
                  <asp:ValidationSummary runat="server" CssClass="text-danger" />
            </div>
        </div>
             <div>
                  <asp:DropDownList ID="DropDownList1" runat="server" DataValueField="Id" DataTextField="Name">
            <asp:ListItem>Select Provider : </asp:ListItem>
              
           
        </asp:DropDownList>
             </div>
              <%-- <asp:ValidationSummary runat="server" CssClass="text-danger" />--%>
      <div>
          <asp:ValidationSummary runat="server" CssClass="text-danger" />
      </div>
        
               
                 <asp:Button runat="server"  ID="btnRg"  Text="RegisterProviderAccount"  Width="200px"  BackColor="White" BorderColor="#0066FF" CssClass="alert-success" Height="40px" ForeColor="Black"  OnClick="RegisterUserProvider"  />
           
       
    </div>
</asp:Content>
