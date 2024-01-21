using Service.Common.Dto;
using Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication14.UserOP
{
    public partial class AddUserProvider : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ProviderService providerService = new ProviderService();
            var res = providerService.GetAllProvider();
            DropDownList1.DataSource = res;
            DropDownList1.DataBind();
        }

        protected void RegisterUserProvider(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                var registerUserproviderDto = new RegisterUserProviderDto()
                {
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                    // ProviderId = 1,
                    ProviderId = Convert.ToInt32(Request.Form[DropDownList1.UniqueID]),
                    RoleId = 3
                };
                var _userService = new UserService();
                var R = _userService.RegisterProviderAccount(registerUserproviderDto);
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