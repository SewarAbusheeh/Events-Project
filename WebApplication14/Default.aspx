<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication14._Default" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


	<asp:TextBox runat="server" ID="T1"></asp:TextBox>
<%--		<nav role="navigation" class="col-sm-12">
							
							<div class="navbar-collapse collapse">

								<!--== Navigation Menu ==-->
								<ul class="nav navbar-nav">
									<li ><a href="Default">Add Event</a></li>
						
                                 
								</ul>
							</div>
						</nav>--%>
		<header id="header">
			<div id="menu" class="header-menu fixed">
			
			</div>

			<!--== Site Description ==-->
			<div class="header-cta">
				<div class="container">
					<div class="row">
						<div class="entry-content">
				            <p><span class="start-text"><b>From THE MARCH 7, 2023</span></p>
				            <h4 class="entry-title"><a href="#">Organizing World class events</a></h4>
				            <h5><span><b>International ...</b></span></h5>
					    </div>
					</div>
				</div>
			</div>

			<div class="header-bg">
				<div id="preloader">
					<div class="preloader"></div>
				</div>
				<div class="main-slider" id="main-slider">

					<!--== Main Slider ==-->
					<ul class="slides">
					     
						   	<li><img src="StaticFiles/images/demo/bg-slide-01.jpg" alt="Slide Image"/></li>
					
						<li><img src="StaticFiles/images/demo/blog1.jpg" alt="Slide Image"/></li>

					</ul>

				</div>
			</div>
		</header>
 <div class="content">
			<div class="container box">


				<!--===============================-->
				<!--== About us ===================-->
				<!--===============================-->
		<section id="about" class="about-us">
			<div class="title-start col-md-4 col-md-offset-4">
			<br />
				<h2>About Us</h2>
				<p class="sub-text text-center">Know our great story</p>
			</div>
			<div class="container">
			<div class="about-first">
			<div class="block col-md-4">
				<div class="content-block">
					<i class="fa fa-users fa-3x"></i>
					<h3>Huge Customers</h3>
					<p>I am text block. Click edit button to change this text. Lorem ipsum dolor sit amet, consectetur adipiscing elit.</p>
				</div>
			</div>
			<div class="block col-md-4">
				<div class="content-block">
					<i class="fa fa-rocket fa-3x"></i>
					<h3>RESPONSIVE DESIGN</h3>
					<p>I am text block. Click edit button to change this text. Lorem ipsum dolor sit amet, consectetur adipiscing elit.</p>
				</div>
			</div>
			<div class="block col-md-4">
				<div class="content-block">
					<i class="fa fa-trophy fa-3x"></i>
					<h3>Award Winning Company</h3>
					<p>I am text block. Click edit button to change this text. Lorem ipsum dolor sit amet, consectetur adipiscing elit.</p>
				</div>
			</div>
			</div>
			<div class="about-part">
			<div class="col-md-8">
			
				<h3>ABOUT US</h3>
				

				<p>Nullam enim nunc, sollicitudin eget rhoncus non, iaculis quis metus. Nunc urna diam, blandit nec ipsum eu, mollis convallis lectus. Vestibulum sapien mauris, auctor quis magna sed, pretium vestibulum est. Mauris vitae tristique urna. Nullam enim nunc, sollicitudin eget rhoncus non, iaculis quis metus. Nunc urna diam, blandit nec ipsum eu, mollis convallis lectus.

				Vestibulum sapien mauris, auctor quis magna sed, pretium vestibulum est. Mauris vitae tristique urna.</p>
			</div>
			<div class="col-md-4">

				<p> Design</p>
				<div class="progress">
				  <div class="progress-bar" role="progressbar" aria-valuenow="60" aria-valuemin="0" aria-valuemax="100" style="width: 60%;">
				    60%
				  </div>
				</div>
				<br/>
				<p> Idea</p>
				<div class="progress">
				  <div class="progress-bar" role="progressbar" aria-valuenow="60" aria-valuemin="0" aria-valuemax="100" style="width: 80%;">
				    80%
				  </div>
				</div>
				<br/>
			</div>
			</div>
			</div>
		</section>
					<section id="team" class="team"> 
					<div class="container">
				<div class="title-start team-menu col-md-4 col-md-offset-4">
					<h2 class="team-heading">Our Agent</h2>
					<p class="sub-text text-center">Meet the greatest Team of Themewagon</p>
				</div>
				</div>
					<div class="team-member row">
					<div class="col-md-3 col-sm-6 member">
						<img class="blog-image" src="StaticFiles/images/team1.jpg" width="" height="280" alt="Blog Image 2"/>
						<p class="name-member">Jon Doe, CEO</p>
					    <ul class="team-ist">
					     <li>CSS3 </li>	
					     <li>HTML5 </li>
					     <li>Adobe</li>	
					     </ul>
					    <div class="team-social">
					    <i class="fa fa-2x fa-tumblr-square"></i>
					    <i class="fa fa-2x fa-facebook"></i>
					    <i class="fa fa-2x fa-twitter"></i>
					    <i class="fa fa-2x fa-linkedin"></i>
					    </div>
					</div>
					<div class="col-md-3 col-sm-6 member">
						<img class="blog-image" src="StaticFiles/images/team2.jpg" width="" height="280" alt="Blog Image 2"/>
					    <p class="name-member">Jon Doe, Head of Ideas</p>
					    <ul class="team-ist">
					     <li>CSS3 </li>	
					     <li>HTML5 </li>
					     <li>Adobe</li>	
					     </ul>
					    <div class="team-social">
					    <i class="fa fa-2x fa-tumblr-square"></i>
					    <i class="fa fa-2x fa-facebook"></i>
					    <i class="fa fa-2x fa-twitter"></i>
					    <i class="fa fa-2x fa-linkedin"></i>
					    </div>
					</div>
					<div class="col-md-3 col-sm-6 member">
						<img class="blog-image" src="StaticFiles/images/team3.jpg" width="" height="280" alt="Blog Image 2"/>
					    <p class="name-member">Jon Doe, Chief Developer</p>
					    <ul class="team-ist">
					     <li>CSS3 </li>	
					     <li>HTML5 </li>
					     <li>Adobe</li>	
					     </ul>
					    <div class="team-social">
					    <i class="fa fa-2x fa-tumblr-square"></i>
					    <i class="fa fa-2x fa-facebook"></i>
					    <i class="fa fa-2x fa-twitter"></i>
					    <i class="fa fa-2x fa-linkedin"></i>
					    </div>
					</div>
					<div class="col-md-3 col-sm-6 member">
						<img class="blog-image" src="StaticFiles/images/team4.jpg" width="" height="280" alt="Blog Image 2"/>
						<p class="name-member">Jon Doe, Event Manager</p>
					    <ul class="team-ist">
					     <li>CSS3 </li>	
					     <li>HTML5 </li>
					     <li>Adobe</li>	
					     </ul>
					    <div class="team-social">
					    <i class="fa fa-2x fa-tumblr-square"></i>
					    <i class="fa fa-2x fa-facebook"></i>
					    <i class="fa fa-2x fa-twitter"></i>
					    <i class="fa fa-2x fa-linkedin"></i>
					    </div>
					</div>
					</div>

				</section>
				 
				
	
	 </div>
	 </div>
	
				
		<div>
	
				</div>
	
</asp:Content>
