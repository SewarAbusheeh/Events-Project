<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SubscribeDisplay.aspx.cs" Inherits="WebApplication14.SubscribeDisplay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


             <h1>Subscribe</h1>
 
          <div>
              <asp:GridView runat="server" ID="MyGridView" AutoGenerateColumns="False" Width="896px" Height="376px" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical"   >
                  <AlternatingRowStyle BackColor="#DCDCDC" />
                  <Columns >
           
                     <asp:TemplateField HeaderText="Email">
                        <ItemTemplate>
                            <%# Eval("Email") %>
                        </ItemTemplate>
                     </asp:TemplateField>
                      
                        <asp:TemplateField HeaderText="EventName">
                        <ItemTemplate>
                            <%# Eval("EventName") %>
                        </ItemTemplate>
                     </asp:TemplateField>
                  
                              <asp:TemplateField HeaderText="Likes">
                        <ItemTemplate>
                            <%# Eval("Is_Like") %>
                        </ItemTemplate>
                     </asp:TemplateField>
                
                  
         
                     
                     
                      
                      
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

</asp:Content>
