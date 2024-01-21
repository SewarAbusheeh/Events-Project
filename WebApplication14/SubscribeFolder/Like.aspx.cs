using Service.Common.Dto;
using Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication14.SubscribeFolder
{
    public partial class Like : System.Web.UI.Page
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
            if (Id != 0)
            {

                if (Session["UserId"] != null)
                {
                    SubscribeDto subscribeDto = new SubscribeDto
                    {
                        EventId = Id,
                        UserId = (int)HttpContext.Current.Session["UserId"],
                        Is_Like = true

                    };
                    SubscribeService subscribeService = new SubscribeService();
                    subscribeService.IsLike(subscribeDto);
                    Response.Redirect("~/EventdisplayToUser.aspx");
                }
                else
                {

                    Response.Redirect("~/Account/Register.aspx");
                }

            }
        }
    }
}