<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Def.aspx.cs" Inherits="WebApplication14.Def" %>

<!DOCTYPE html>
<html lang="en">

    <body>
          <%--  <table  ID="T1" >
        <thead>
            <tr>
                <td>Email</td>
                <td>RoleName</td>
                <td>ProviderName</td>
                
            </tr>
        </thead>
        <tbody>
            <tr>
                <td>  <%# Eval("Email") %></td>
            </tr>
             <tr>
                <td>  <%# Eval("RoleName") %></td>
            </tr>
             <tr>
                <td>  <%# Eval("ProviderName") %></td>
            </tr>
        </tbody>

    </table>--%>


 <%--   <table >
        <thead>
            <tr>
                <td>Email</td>
                <td>RoleName</td>
                <td>ProviderName</td>
                
            </tr>
        </thead>
        <tbody>
            <tr>
                <td>  <%# Eval("Email") %></td>
            </tr>
             <tr>
                <td>  <%# Eval("RoleName") %></td>
            </tr>
             <tr>
                <td>  <%# Eval("ProviderName") %></td>
            </tr>
        </tbody>

    </table>--%>
    <asp:TextBox runat="server" ID="T1"></asp:TextBox>
     <%--   <textbox ID="T1"></textbox>--%>
         <div>
              <asp:GridView runat="server" ID="MyGridView" AutoGenerateColumns="False"     >
                  
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
                      </Columns>
                  </asp:GridView>
                      </div>
  

</html>
