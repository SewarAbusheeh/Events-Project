<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication14.Account.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
       <div class="form-horizontal">

            <div style="margin-top:150px;">   <h1 Style="margin-top:100px;"></h1>
     
        <%----%>
       <%--      <asp:ValidationSummary runat="server" CssClass="text-danger" />--%>
        <div >
            <asp:Label runat="server" AssociatedControlID="EmailTxt" >Email</asp:Label>
            <div >
                <asp:TextBox runat="server" ID="EmailTxt"  TextMode="Email" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="EmailTxt"
                    CssClass="text-danger" ErrorMessage="The email field is required." />
            </div>
        </div>
        <div >
            <asp:Label runat="server" AssociatedControlID="PasswordTxt"  >Password</asp:Label>
            <div  >
                <asp:TextBox runat="server" ID="PasswordTxt" TextMode="Password"   />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="PasswordTxt"
                    CssClass="text-danger" ErrorMessage="The password field is required." />
            </div>
        </div>
         
               <div >
                
               
                  <asp:Label runat="server" ID="MessageError" width="200px" ForeColor="Red"></asp:Label>

               </div>
    
     
               
                   <asp:Button runat="server" Text="Login"  OnClick="login"   Height="40px" Width="143px" CssClass="btn btn-success" style="margin-left:0px;"  ForeColor="Black" />
         
    
     </div>
        
    </div>
</asp:Content>
