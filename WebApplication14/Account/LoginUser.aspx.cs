﻿using Services.Common.Dto;
using Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication14.Account
{
    public partial class LoginUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //protected void login(object sender, EventArgs e)
        //{
        //    if (User.IsInRole("Provider"))
        //    {
        //        Response.Write("kkk");
        //    }
        //    else
        //    {
        //        Response.Write("sdfkn");
        //    }
        //    LoginUserDto loginUser = new LoginUserDto
        //        {
        //            Email = txtEmail.Text,
        //            Password = PasswordTxt.Text
        //        };
        //        UserService userService = new UserService();
        //        var R = userService.loginUser(loginUser);

        //        Session["Email"] = txtEmail.Text; 
        //        Session["UserId"] = R;
        //        if (Session["UserId"] != null && R != -1)
        //        {
        //            Response.Redirect("~/EventdisplayToUser.aspx");
        //        }
        //        else
        //        {
        //            Labeltxt.Text = "Invalid Email or Password ";
        //            //Response.Write("Invalid Email or Password ");
        //        }


            

        //}
    }
}