<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Events.aspx.cs" Inherits="WebApplication14.Events" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Events</h1>
   <%-- <script src="jquery-3.6.3.slim.min.js"></script>--%>

    <br />
<%--    <script>
        $(document).ready(function(){

        });
    </script>--%>
    <div>
        <asp:Button runat="server" PostBackUrl="~/EventOP/AddEvent" OnClick="AddEventBtn" Text="AddEvent" ID="AddB1" Width="200px" BackColor="White" BorderColor="#0066FF" CssClass="alert-success" Height="40px" ForeColor="Black" />
    </div>

    <br />
    <a href="Dashboard/Dashboard.aspx" width="250px" backcolor="White" bordercolor="#0066FF" cssclass="alert-success" height="40px" forecolor="Black">Back To home</a>

    <div>
        <asp:GridView runat="server" ID="MyGridView" DataKeyNames="Id" AutoGenerateColumns="False" CellPadding="4" CssClass="alert-info" OnRowDeleting="DeleteEventgid" OnRowUpdated="UpdateEventgrid" OnRowUpdating="UpdateEventgrid" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" Height="201px" OnSelectedIndexChanged="MyGridView_SelectedIndexChanged" Width="612px">
            <Columns>

                <asp:TemplateField HeaderText="EventName">
                    <ItemTemplate>
                        <%# Eval("EventName") %>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="CreationDate">
                    <ItemTemplate>
                        <%# Eval("CreationDate") %>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="ProviderName">
                    <ItemTemplate>
                        <%# Eval("ProviderName") %>
                    </ItemTemplate>
                </asp:TemplateField>


                <asp:TemplateField HeaderText="Edit Action">
                    <ItemTemplate>
                        <%-- <a href="About.aspx?Id="<%#Eval("Id") %>">Update</a>--%>
                        <a href='EventOP/EditEvent.aspx?Id=<%#Eval("Id") %>'>Edit </a>
                        <%-- <a  href='ProviderOP/EditProvider.aspx?id=<%#Eval("Id") %>'>Update</a>--%>
                    </ItemTemplate>
                </asp:TemplateField>





                <asp:CommandField ButtonType="Button" HeaderText="Delete" ShowDeleteButton="True" />




            </Columns>

            <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
            <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
            <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
            <RowStyle BackColor="White" ForeColor="#003399" />
            <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
            <SortedAscendingCellStyle BackColor="#EDF6F6" />
            <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
            <SortedDescendingCellStyle BackColor="#D6DFDF" />
            <SortedDescendingHeaderStyle BackColor="#002876" />

        </asp:GridView>
        <%--  <asp:Button runat="server" Text="Add" Height="45px" Width="154px" BackColor="Yellow" OnClick="AddUser"/>--%>
    </div>


    <%--    </form>--%>
    <%--  <asp:Button ID="Button2" runat="server"  CssClass="btn btn-success" Text="Add" />
        <asp:Button ID="Button3" CssClass="btn btn-priamary" runat="server" Text="Update" />
        <asp:Button ID="Button4" CssClass="btn btn-danger" runat="server" Text="Delete" />--%>
    <%--   </body>--%>

    <%-- Height="124px" Width="370px"--%>
</asp:Content>
