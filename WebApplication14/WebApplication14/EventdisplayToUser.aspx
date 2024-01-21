<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EventdisplayToUser.aspx.cs" Inherits="WebApplication14.EventdisplayToUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
  
    
	<div>
		<button type="button"></button>
	</div>

<%--    <h1>
         <asp:Label runat="server" ID="Label3">Wellcom < <%= HttpContext.Current.Session["Email"]%></asp:Label>
    </h1>--%>
    <div class="content">
        <div class="container box">
            <section id="schedule" class="row">
                <div class="title-start schedule-menu col-md-4 col-md-offset-4">
                    <br />
                    <h2>Events Schedule</h2>
                    <p class="sub-text text-center"></p>
                </div>
                <ul class="timeline">
                    <asp:Repeater ID="rptEvent" runat="server"  >
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
					                	
					                	<em class="timeline-item">
					                	Name :<%# Eval("EventName") %></em><em class="timeline-item">Provider : <%# Eval("ProviderName") %>

					                	</em>
					                	<em class="timeline-item">
					                	Ticket: $35 
					                	</em>
					                	<em class="timeline-item">
					                      Date :<%# Eval("CreationDate") %></em><em class="timeline-item">Duration : 5days
					                	</em>
										<em>
												 <a href='EventdisplayToUser.aspx?id=<%#Eval("Id") %>'   >  <i     class="fa fa-bell" aria-hidden="true"></i> </a>  
											 <%--<a >  <i  href="EventdisplayToUser.aspx?Id=<%#Eval("Id") %>" class="fa fa-bell" aria-hidden="true"> </i> </a>  --%>
										     <a  href='EventdisplayToUser.aspx?id=<%#Eval("Id") %>' >   <i class="fa fa-comment-o"  aria-hidden="true" onClick="Like"> </i> </a>
										     <a   href='EventdisplayToUser.aspx?id=<%#Eval("Id") %>'>   <i class="fa fa-thumbs-o-up"  aria-hidden="true"> </i> </a> 
											
											</em>
										     
									
					                </p>
									
					            </div>
					             
					        </div>
							
					    </li>
                        </ItemTemplate>
                    </asp:Repeater>

                            





                   
                </ul>
				<%--<asp:Button  runat="server" onclick="Subscribe" href="EventdisplayToUser.aspx?Id=<%#Eval("Id") %>" class="fa fa-bell" aria-hidden="true"  />--%>
		
            </section>
        </div>
    </div>
<%--	 <asp:Button runat="server"   Width="250px" Text="AddProvidet" ID="Button2"  PostBackUrl="~/SubscribeFolder/suscribe.aspx" OnClick="Subscribe"  href="EventdisplayToUser.aspx?Id=<%#Eval("Id") %>"   BackColor="White" BorderColor="#0066FF" CssClass="alert-success" Height="40px" ForeColor="Black" />--%>
	  <button Width="250px" Text="sub"   PostBackUrl="~/SubscribeFolder/suscribe.aspx" OnClick="Subscribe"   href="EventdisplayToUser.aspx?Id=<%#Eval("Id") %>"   BackColor="White" BorderColor="#0066FF" CssClass="alert-success" Height="40px" ForeColor="Black" ></button>
</asp:Content>

