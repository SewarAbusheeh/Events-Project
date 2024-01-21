<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EventdisplayToUser.aspx.cs" Inherits="WebApplication14.EventdisplayToUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">



    <%--    <h1>
         <asp:Label runat="server" ID="Label3">Wellcom < <%= HttpContext.Current.Session["Email"]%></asp:Label>
    </h1>--%>
    <nav role="navigation" class="col-sm-12">

        <div class="navbar-collapse collapse">

            <!--== Navigation Menu ==-->
            <ul class="nav navbar-nav">
                <%--<li ><a href="Default">Add Event</a></li>--%>

<%--                <asp:Button runat="server" ID="btn1" Text="Add  Event " ForeColor="#3366ff" />--%>
            </ul>
        </div>
    </nav>
    <div class="content">
        <div class="container box">
            <section id="schedule" class="row">
                <div class="title-start schedule-menu col-md-4 col-md-offset-4">
                    <br />
                    <h2>Events Schedule</h2>
                    <p class="sub-text text-center"></p>
                </div>
                <ul class="timeline">
                    <asp:Repeater ID="rptEvent" runat="server">
                        <ItemTemplate>
                            <li>
                                <div class="timeline-badge">
                                    <a><i class="fa fa-circle" id=""></i></a>
                                </div>
                                <div class="timeline-panel">
                                    <div class="timeline-heading">
                                        <h4>Event One</h4>
                                    </div>
                                    <div class="timeline-body">
                                        <p class="timeline-desc col-md-6">Invitamus me testatur sed quod non dum animae tuae lacrimis ut libertatem deum rogus aegritudinis causet. Dicens hoc contra serpentibus isto.</p>
                                        <p class="timeline-other col-md-6">

                                            <em class="timeline-item">Name :<%# Eval("EventName") %></em><em class="timeline-item">Provider : <%# Eval("ProviderName") %>

                                            </em>
                                            <em class="timeline-item">
					                	Ticket: $35 
                                            </em>
                                            <em class="timeline-item">Date :<%# Eval("CreationDate") %></em><em class="timeline-item">Duration : 5days
                                            </em>
                                            <em>
                                                <a href='EventdisplayToUser.aspx?id=<%#Eval("Id") %>'><i class="fa fa-bell" aria-hidden="true"></i></a>&nbsp;   &nbsp;     &nbsp;   &nbsp;   &nbsp;   &nbsp;
											    <%--<a >  <i  href="EventdisplayToUser.aspx?Id=<%#Eval("Id") %>" class="fa fa-bell" aria-hidden="true"> </i> </a>  --%>
                                                <a href='SubscribeFolder/Comment.aspx?id=<%#Eval("Id") %>'><i class="fa fa-comment-o" aria-hidden="true" onclick="AddComment"></i></a>&nbsp;   &nbsp;     &nbsp;      &nbsp;   &nbsp;
										        <a href='SubscribeFolder/Like.aspx?id=<%#Eval("Id") %>' id="Likeid"><i class="fa fa-thumbs-o-up" aria-hidden="true"></i></a>

                                          
                                            </em>


                                        </p>

                                    </div>

                                </div>

                            </li>
                            <%--EventdisplayToUser.aspx?id=<%#Eval("Id") %>--%>
                        </ItemTemplate>
                    </asp:Repeater>
                    <asp:Button Style="display: none" runat="server" ID="Like" ClientIDMode="Static" OnClick="Like_Click" />
                    <asp:HiddenField ID="hddnEventId" ClientIDMode="Static" runat="server" />








                </ul>
          
            </section>
        </div>
    </div>
    <script src="StaticFiles/jquery-3.6.3.slim.min.js"></script>
    <script>
        $(document).ready(function () {
            $(".like").click(function () {
                $(this).toggleClass("heart");
            });
        });
    </script>
    <script>
        function Like(id) {
            $("#hddnEventId").val(id);
            $("#Like").click();
        }
    </script>
    <style>
        a {
            color: #00000030;
            font-size: 1.5em;
            text-decoration: none;
        }

        .heart i.fa-heart {
            color: #f44336;
        }

        .heart {
            animation: heart 0.5s linear;
        }

        @keyframes heart {
            0% {
                transform: rotate(0deg) scale(1.7);
            }

            40% {
                transform: rotate(0deg) scale(1);
            }

            41% {
                transform: rotate(360deg) scale(1);
            }

            100% {
                transform: rotate(0deg) scale(1);
            }
        }

        a:hover {
            color: none !important;
            text-decoration: none;
           
        }
         a:focus {
         color: #b3b3b3;
         text-decoration: underline;
    }
    </style>


</asp:Content>

