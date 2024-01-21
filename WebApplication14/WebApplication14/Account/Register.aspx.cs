using Services.Common.Dto;
using Services.Services;
using System;
using System.Web.UI;

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
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                    ProviderId = 1,
                    RoleId = 1
                };
                var _userService = new UserService();
                _userService.RegisterUser(registerUserDto);
            }          
        }
    }
}