<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Reg.aspx.cs" Inherits="WebApplication14.Account.Reg" %>
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
              <%-- <asp:ValidationSummary runat="server" CssClass="text-danger" />--%>
      <div>
          <asp:ValidationSummary runat="server" CssClass="text-danger" />
      </div>
        
               
                 <asp:Button runat="server" ID="btnRg" Text="Register" Height="40px" Width="143px" CssClass="btn btn-success" style="margin-left:0px;"  OnClick="RegisterUser" ForeColor="Black" />
           
       
    </div>
</asp:Content>
