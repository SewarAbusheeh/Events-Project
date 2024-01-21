<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RoleDisplay.aspx.cs" Inherits="WebApplication14.RoleDisplay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
             <h3>Roles</h3>
    
          <div>
              <asp:GridView runat="server" ID="Roles" AutoGenerateColumns="false" Width="279px"  >
                  <Columns>
                      <asp:BoundField DataField="RoleName" HeaderText="Role Name"  />
                      
                      
                  </Columns>
              </asp:GridView>

          </div>
    
        
<asp:Button ID="Button2" runat="server"  CssClass="btn btn-success" Text="Add" />
        <asp:Button ID="Button3" CssClass="btn btn-priamary" runat="server" Text="Update" />
        <asp:Button ID="Button4" CssClass="btn btn-danger" runat="server" Text="Delete" />
        
   
</asp:Content>
