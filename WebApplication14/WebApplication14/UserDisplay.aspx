<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UserDisplay.aspx.cs" Inherits="WebApplication14.UserDisplay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

                 <h3>Users</h3>
   <br />
    <br />
    <br />
    <br />
     <div>
            <asp:Button runat="server" PostBackUrl="~/UserOP/AddUserProvider.aspx" OnClick="RegisterUserProvider" Width="250px" Text="AddProviderAccount" ID="Button2"      BackColor="White" BorderColor="#0066FF" CssClass="alert-success" Height="40px" ForeColor="Black" />
     </div>
 <div>
      <asp:Button runat="server" PostBackUrl="~/UserOP/AddUserCo.aspx" OnClick="AddUser" Width="250px" Text="AddUser" ID="AddB1"      BackColor="White" BorderColor="#0066FF" CssClass="alert-success" Height="40px" ForeColor="Black" />
 </div>
     

   
          <div>
              <asp:GridView runat="server" ID="MyGridView" AutoGenerateColumns="False" Width="896px" Height="376px" BackColor="White" BorderColor="#999999" CellPadding="10"  DataKeyNames="Id"   OnRowDeleting="DeleteUserfrom"   >
                  <AlternatingRowStyle BackColor="#DCDCDC" />
                  <Columns >
           
                     <asp:TemplateField HeaderText="Email">
                        <ItemTemplate>
                            <%# Eval("Email") %>
                        </ItemTemplate>
                     </asp:TemplateField>
                      
                        <asp:TemplateField HeaderText="UserName">
                        <ItemTemplate>
                            <%# Eval("UserName") %>
                        </ItemTemplate>
                     </asp:TemplateField>
                        <asp:TemplateField HeaderText="RoleName">
                        <ItemTemplate>
                            <%# Eval("RoleName") %>
                        </ItemTemplate>
                     </asp:TemplateField>
                         <asp:TemplateField HeaderText="ProviderName">
                        <ItemTemplate>
                            <%# Eval("ProviderName") %>
                        </ItemTemplate>
                     </asp:TemplateField>
                      <asp:TemplateField HeaderText="UserType">
                          <ItemTemplate>
                               <%# Eval("UserType") %>
                          </ItemTemplate>
                      </asp:TemplateField>
                       <asp:TemplateField HeaderText="Actions">
                           <ItemTemplate>
                               <a href="About.aspx?Id="<%#Eval("Id") %>">Update</a>
                               
                            
                           </ItemTemplate>  
                      </asp:TemplateField>
                     
                     
                      
                      
                      <asp:CommandField ButtonType="Button" HeaderText="Action" ShowDeleteButton="True" />
                     
                     
                      
                      
                  </Columns>
                  <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                  <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                  <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                  <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                  <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                  <SortedAscendingCellStyle BackColor="#F1F1F1" />
                  <SortedAscendingHeaderStyle BackColor="#0000A9" />
                  <SortedDescendingCellStyle BackColor="#CAC9C9" />
                  <SortedDescendingHeaderStyle BackColor="#000065" />
              </asp:GridView>
            <%--  <asp:Button runat="server" Text="Add" Height="45px" Width="154px" BackColor="Yellow" OnClick="AddUser"/>--%>
          </div>
     
        

    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />  
    
</asp:Content>
