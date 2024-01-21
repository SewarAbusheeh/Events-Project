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
    public partial class Register : System.Web.UI.Page
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
                    Email = TextBox1.Text,
                    Password = TextBox2.Text,
                    ProviderId = 1,
                    RoleId = 1
                };
                var _userService = new UserService();
                var R = _userService.RegisterUser(registerUserDto);
                if (R == true)
                {
                    Response.Redirect("LoginUser.aspx");
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