﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contactcostomer.aspx.cs" Inherits="WebApplication14.Contactcostomer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


     
<div class="content">
			<div class="container box">


    	 <!-- Contact Area -->

        <section id="contact" class="mapWrap">
            <div id="googleMap" style="width:100%;"></div>
            <div id="contact-area">
                <div class="container">
                    <h2 class="block_title">Hey !!!</h2>
                    <div class="row">
                        <div class="col-xs-12">
                        </div>
                        <div class="col-sm-6">
                            <div class="moreDetails">
                                <h2 class="con-title">More About me</h2>
                                <p> Lorem ipsum dolor sit amet, consectetur adipisicing elit. Voluptatum animi repudiandae nihil aspernatur repellat temporibus doloremque sint ea laboriosam, excepturi iure inventore rerum voluptatibus, suscipit totam, sit necessitatibus. Rerum, blanditiis. </p>
                                <ul class="address">
                                    <li><i class="pe-7s-map-marker"></i><span>1600 Pennsylvania Ave NW,<br>Washington, DC 20500,<br>United States</span></li>
                                    <li><i class="pe-7s-mail"></i><span>example@gmail.com</span></li>
                                    <li><i class="pe-7s-phone"></i><span>+1-202-555-0144</span></li>
                                    <li><i class="pe-7s-global"></i><span><a href="#">www.themewagon.com</a></span></li>
                                </ul>
                            </div>
                        </div>
                        <div class="col-sm-6">
                            <h2 class="con-title">Contact us</h2>
                            <form role="form">
                              <div class="form-group">
                                <input type="text" class="form-control" id="user_name" placeholder="Enter your name">
                              </div>
                              <div class="form-group">
                                <input type="email" class="form-control" id="your_email" placeholder="Enter your email">
                              </div>
                              <div class="form-group">
                                <textarea name="InputMessage" id="user_message" class="form-control" rows="5" required></textarea>
                              </div>

                              <button type="submit" class="btn medium">Let us know</button>
                            </form>   
                        </div>
                    </div>
                </div><!-- container -->
            </div><!-- contact-area -->
            <div id="social">
                <div class="container">
                    <div class="row">
                        <div class="col-xs-12">
                            <ul class="scoialinks">
                                <li class="normal-txt">Find us on</li>
                                <li class="social-icons"><a class="facebook" href="#"></a></li>
                                <li class="social-icons"><a class="twitter" href="#"></a></li>
                                <li class="social-icons"><a class="linkedin" href="#"></a></li>
                                <li class="social-icons"><a class="google-plus" href="#"></a></li>
                                <li class="social-icons"><a class="wordpress" href="#"></a></li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div><!-- social -->
        </section><!-- contact -->
                </div>
    </div>
</asp:Content>
