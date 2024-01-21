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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void login(object sender, EventArgs e)
        {
           
            if (Page.IsValid)
            {
                LoginUserDto loginUser = new LoginUserDto
                {
                    Email= EmailTxt.Text ,
                    Password= PasswordTxt.Text
                };
                UserService userService = new UserService();
                var R= userService.loginUser(loginUser);
           
                    Session["Email"] = EmailTxt.Text;
                    Session["UserId"] = R;
                if (Session["UserId"] != null)
                {
                    Response.Redirect("~/EventdisplayToUser.aspx");
                }
                else
                {
                    Response.Write("Invalid Email or Password ");
                }
         
               
            }
           
        }

    }
}