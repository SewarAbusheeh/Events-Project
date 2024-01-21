<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="WebApplication14.Dashboard.Dashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     
    <title> Admin Dashboard</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <!-- Bootstrap -->
    <link href="bootstrap/css/bootstrap.min.css" rel="stylesheet"/>
    <!-- styles -->
    <link href="css/styles.css" rel="stylesheet"/>

    <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
      <script src="https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js"></script>
      <script src="https://oss.maxcdn.com/libs/respond.js/1.3.0/respond.min.js"></script>
    <![endif]-->
 
</head>
<body>
   	<div class="header">
	     <div class="container">
	        <div class="row">
	           <div class="col-md-5">
	              <!-- Logo -->
	              <div class="logo">
	                 <h1><a href="index.html">Admin Dashboard</a></h1>
	              </div>
	           </div>
	           <div class="col-md-5">
	              <div class="row">
	                <div class="col-lg-12">
	                  <div class="input-group form">
	                       <input type="text" class="form-control" placeholder="Search..." />
	                       <span class="input-group-btn">
	                         <button class="btn btn-primary" type="button">Search</button>
	                       </span>
	                  </div>
	                </div>
	              </div>
	           </div>
	           <div class="col-md-2">
	              <div class="navbar navbar-inverse" role="banner">
	                  <nav class="collapse navbar-collapse bs-navbar-collapse navbar-right" role="navigation">
	                    <ul class="nav navbar-nav">
	                      <li class="dropdown">
	                        <a href="#" class="dropdown-toggle" data-toggle="dropdown">My Account <b class="caret"></b></a>
	                        <ul class="dropdown-menu animated fadeInUp">
	                          <li><a href="profile.html">Profile</a></li>
	                          <li><a href="login.html">Logout</a></li>
	                        </ul>
	                      </li>
	                    </ul>
	                  </nav>
	              </div>
	           </div>
	        </div>
	     </div>
	</div>

    <div class="page-content">
        <div class="row">
            <div class="col-md-2">
                <div class="sidebar content-box" style="display: block;">
                    <ul class="nav">
                        <!-- Main menu -->
                        <li class="current"><a href="Dashboard.aspx"><i class="glyphicon glyphicon-home"></i> Dashboard</a></li>
                        <li><a href="calendar.html"><i class="glyphicon glyphicon-calendar"></i> Calendar</a></li>
                        <li><a href="../EventdisplayToUser.aspx"><i class="glyphicon glyphicon-stats"></i> EventsU</a></li>
                        <li><a href="../Providerdisplay.aspx"><i class="glyphicon glyphicon-pencil"></i> Provider</a></li>
                        <li><a href="../Events.aspx"><i class="glyphicon glyphicon-pencil"></i> Events</a></li>
                        <li><a href="../UserDisplay.aspx"><i class="glyphicon glyphicon-pencil"></i> Users</a></li>
                     

                      
                        
						       
                       
                        <li class="submenu">
                            <a href="#">
                                <i class="glyphicon glyphicon-list"></i> Pages
                                <span class="caret pull-right"></span>
                            </a>
                            <!-- Sub menu -->
                            <ul>
                                <li><a href="login.html">Login</a></li>
                                <li><a href="signup.html">Signup</a></li>
                            </ul>
                        </li>
                    </ul>
                </div>

            

            </div>
        </div>
    </div>
		
    <footer>
         <div class="container" >
         
            <div class="copy text-center">
               Copyright 2023 <a href='#'>PPCH</a>
            </div>
            
         </div>
      </footer>

    <!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
    <script src="https://code.jquery.com/jquery.js"></script>
    <!-- Include all compiled plugins (below), or include individual files as needed -->
    <script src="bootstrap/js/bootstrap.min.js"></script>
    <script src="js/custom.js"></script>
</body>
</html>
