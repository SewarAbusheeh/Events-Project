using Service.Common.Dto;
using Services.Common.Dto;
using Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication14.UserOP
{
    public partial class AddUserCo : System.Web.UI.Page
    {
        public int Id
        {
            get
            {
                return Request.QueryString["id"] == null ? 0 : Convert.ToInt32(Request.QueryString["id"]);
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Subscribe(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                // Session["UserId"]=
                SubscribeDto subscribeDto = new SubscribeDto
                {
                    EventId = Id,
                    UserId = (int)HttpContext.Current.Session["UserId"],
                    Is_Like = false

                };
                SubscribeService subscribeService = new SubscribeService();
                subscribeService.AddSubscribe(subscribeDto);
            }
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
                    Response.Redirect("~/UserDisplay.aspx");
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