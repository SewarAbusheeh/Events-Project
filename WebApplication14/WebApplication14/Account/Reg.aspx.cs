using Services.Common.Dto;
using Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication14.Account
{
    public partial class Reg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void RegisterUser(object sender, EventArgs e)
        {
            //_userService
            // validation on the web server level
            
            if (Page.IsValid)
            {
                var registerUserDto = new RegisterUserDto()
                {
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                    ProviderId = 1,
                    RoleId = 1
                };
                var _userService = new UserService();
                var R = _userService.RegisterUser(registerUserDto);
                if (R == true)
                {
                    Response.Redirect("Login.aspx");
                }
                else
                {
                    //  MessageError.Text.;
                    Response.Write("Invalid Email or Password ");

                }
               
            }
        }
    }
}