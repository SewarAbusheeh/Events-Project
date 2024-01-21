<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddUserCo.aspx.cs" Inherits="WebApplication14.UserOP.AddUserCo" %>
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
                <asp:TextBox runat="server" ID="txtPassword" TextMode="Password"   />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtPassword"
                    CssClass="text-danger" ErrorMessage="The password field is required." />
                  <asp:ValidationSummary runat="server" CssClass="text-danger" />
            </div>
        </div>
              <%-- <asp:ValidationSummary runat="server" CssClass="text-danger" />--%>
      <div>
          <asp:ValidationSummary runat="server" CssClass="text-danger" />
      </div>
        
               
                 <asp:Button runat="server"  ID="btnRg"  Text="Register"  Width="200px"  BackColor="White" BorderColor="#0066FF" CssClass="alert-success" Height="40px" ForeColor="Black" OnClick="RegisterUser"  />
           
       
    </div>
</asp:Content>
