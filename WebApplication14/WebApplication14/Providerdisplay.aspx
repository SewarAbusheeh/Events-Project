<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Providerdisplay.aspx.cs" Inherits="WebApplication14.Providerdisplay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <h1>Providers</h1>

         
    <br />

 <asp:Button runat="server" PostBackUrl="~/ProviderOP/AddProvider" Text="AddProvider" ID="AddB1" Width="200px"  BackColor="White" BorderColor="#0066FF" CssClass="alert-success" Height="40px" ForeColor="Black"/>
    


          <div>
              <asp:GridView runat="server" DataKeyNames="Id" ID="MyGridView" AutoGenerateColumns="False" Width="978px" Height="364px" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="100" GridLines="Vertical" OnRowDeleting="deletformgrid" OnRowEditing="editprovidergrid"   >
                  <AlternatingRowStyle BackColor="#DCDCDC" />
                  <Columns >
           
                     <asp:TemplateField HeaderText="Email">
                        <ItemTemplate>
                            <%# Eval("Email") %>
                        </ItemTemplate>
                     </asp:TemplateField>
                      
                        <asp:TemplateField HeaderText="Name">
                        <ItemTemplate>
                            <%# Eval("Name") %>
                        </ItemTemplate>
                     </asp:TemplateField>
                  
         
                      <asp:TemplateField HeaderText="Actions">
                         <%-- <EditItemTemplate>
                                <asp:Label runat="server" Text='<%#Eval("Id") %>'></asp:Label>
                          </EditItemTemplate>--%>
                          <ItemTemplate>
                            
                            
                             <%--  <asp:Label runat="server" Text='<%#Eval("Id") %>' Enabled="False" Visible="false" ID="LablID"></asp:Label>--%>
                              
                               <%-- <asp:LinkButton runat="server" Text="Edit" Onclick="EditProvider" ID="LBEPRO" PostBackUrl="~/ProviderOP/EditProvider"    --%>
                                
                               <%-- </asp:LinkButton>--%>
                            
                                 <a  href='ProviderOP/EditProvider.aspx?id=<%#Eval("Id") %>'>Update</a>
                                <%-- <a href="About.aspx?Id="<%#Eval("Id") %>">Update</a>
                               
                               <a href="~/ProviderOP/DeleteProvider.aspx?Id="<%#Eval("Id") %>"    id="Delete">Delete</a>--%>
                             
                           </ItemTemplate>  
                        
                      </asp:TemplateField>
                     
                     
                      
                      
                      <asp:CommandField ButtonType="Button" ShowDeleteButton="True" HeaderText="Action"  />
                    
                     
                      
                   
                     
                    
                     
                      
                      
                    <%--  <asp:CommandField ButtonType="Button" HeaderText="Action" InsertVisible="False" ShowCancelButton="False" ShowEditButton="True" ShowHeader="True" />--%>
                    
                     
                      
                   
                     
                    
                     
                      
                      
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
     
          </div>
    
</asp:Content>
