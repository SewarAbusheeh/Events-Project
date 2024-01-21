<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Comment.aspx.cs" Inherits="WebApplication14.SubscribeFolder.Comment" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link rel="stylesheet" href="StyleSheet1.css" />


    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <div>

        <ul>

           <%-- <asp:Repeater ID="rptEvent" runat="server">
                <ItemTemplate>--%>
                    <li>

                        <div class="timeline-panel">
                            <div class="timeline-heading">
                                <h4>Event One</h4>
                            </div>
                            <div class="timeline-body">
                                <p class="timeline-desc col-md-6">Invitamus me testatur sed quod non dum animae tuae lacrimis ut libertatem deum rogus aegritudinis causet. Dicens hoc contra serpentibus isto.</p>
                                <p class="timeline-other col-md-6">

                                    <em class="timeline-item" >Name : <asp:label runat="server" ID="label1"> </asp:label></em>
                                      
                                    <em class="timeline-item">Provider :<asp:label runat="server" ID="label2"></asp:label>
                                     
                                    </em>
                                    <em class="timeline-item">Ticket: $35 
                                    </em>
                                    <em class="timeline-item">Date :<%--<asp:label runat="server" ID="label3"></asp:label>--%>
                                           <%--<asp:Calendar runat="server" ID="label3" ></asp:Calendar>--%>
                                    </em>
                                    <em class="timeline-item">Duration : 5days
					                	</em>
                                   


                                </p>

                            </div>

                        </div>

                    </li>
             <%--   </ItemTemplate>
            </asp:Repeater>--%>
        </ul>
    </div>
    <div class="timeline-panel">
        <div class="timeline-heading">

            <div class="container mt-5">
                <div class="d-flex justify-content-center row">
                    <div class="col-md-8">
                        <div class="d-flex flex-column comment-section">
                            <%--         <div class="bg-white p-2">
                    <div class="d-flex flex-row user-info"><img class="rounded-circle" src="https://i.imgur.com/RpzrMR2.jpg" width="40">
                        <div class="d-flex flex-column justify-content-start ml-2"><span class="d-block font-weight-bold name">  <%= HttpContext.Current.Session["Email"]%></span><span class="date text-black-50">Shared publicly - Jan 2023</span></div>
                    </div>
                    <div class="mt-2">
                        <p class="comment-text"> nvitamus me testatur sed quod non dum animae tuae lacrimis ut libertatem deum rogus aegritudinis cause<%# Eval("EventName") %></p>
                    </div>

                    <div class="mt-2">
                        <p class="comment-text"> nvitamus me testatur sed quod non dum animae tuae lacrimis ut libertatem deum rogus aegritudinis cause         <%# Eval("ProviderName") %></p>
                    </div>
           
                </div>--%>

                            <div class="bg-white">
                                <div class="d-flex flex-row fs-12">
                                    <%--   <div class="like p-2 cursor"><i class="fa fa-thumbs-o-up"></i><span class="ml-1">Like</span></div>--%>
                                    <%--<div class="like p-2 cursor"><i class="fa fa-commenting-o"></i><span class="ml-1">Comment</span></div>--%>
                                    <%-- <div class="like p-2 cursor"><i class="fa fa-share"></i><span class="ml-1">Share</span></div>--%>
                                </div>
                            </div>
                            <div class="bg-light p-2">

                                <div class="d-flex flex-row align-items-start">
                                    <asp:TextBox runat="server" ID="MyBox" TextMode="MultiLine" Rows="10" Width="595px" /></div>

                                <%-- <div class="mt-2 text-right"><button class="btn btn-primary btn-sm shadow-none" type="button" onclick="AddComment" PostBackUrl="Comment.aspx">Post comment</button><button class="btn btn-outline-primary btn-sm ml-1 shadow-none" type="button" PostBckUrl="Default" >Cancel</button></div>--%>
                                <div class="mt-2 text-right">
                                    <asp:Button runat="server" class="btn btn-primary btn-sm shadow-none" BackColor="White" Width="200px" BorderColor="#0066FF" CssClass="alert-success" Height="40px" ForeColor="Black" href='SubscribeFolder/Comment.aspx?id=<%#Eval("Id") %>' OnClick="AddComment" Text="Post Comment" ID="AddB1" />
                                    <div class="mt-2 text-right">
                                        <asp:Button runat="server" class="btn btn-primary btn-sm shadow-none" BackColor="White" Width="200px" BorderColor="#0066FF" CssClass="alert-success" Height="40px" ForeColor="Black" PostBackUrl="~/Default.aspx" Text="Cancel" ID="Button1" />
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>

                </div>
            </div>

        </div>
    </div>
</asp:Content>
