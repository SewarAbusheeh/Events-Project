using Service.Common.Dto;
using Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication14
{
    public partial class EventdisplayToUser : System.Web.UI.Page
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


            //if (User.IsInRole("Provider"))
            //{
            //    btn1.Visible = true;
            //}
            //else
            //{
            //    btn1.Visible = false;
            //}
            var _eventService = new EventService();
            //  var _eventService = new EventService();
            var userId = (int?)HttpContext.Current.Session["UserId"];
            var result = _eventService.GetAllEvent(userId);

            rptEvent.DataSource = result;
            rptEvent.DataBind();
            //if (Session["UserId"]== null)
            //{

            //    Response.Redirect("~/EventdisplayToUser.aspx");
            //}else

            //{
            //    var Userid = (int)HttpContext.Current.Session["UserId"];




            //if (Id != 0)
            //{

            //    if (Session["UserId"] != null)
            //    {
            //        SubscribeDto subscribeDto = new SubscribeDto
            //        {
            //            EventId = Id,
            //            UserId = (int)HttpContext.Current.Session["UserId"],
            //            Is_Subscribe =true,
            //            Is_Like = false

            //        };
            //        SubscribeService subscribeService = new SubscribeService();
            //        subscribeService.AddSubscribe(subscribeDto);
            //    }
            //    else
            //    {
            //        Response.Redirect("Account/Register.aspx");
            //    }

            //}
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
                    // Response.Redirect("~/EventdisplayToUser.aspx");
                }
                else
                {

                    Response.Redirect("~/Account/Register.aspx");
                }

            }
        }

        protected void Like_Click(object sender, EventArgs e)
        {

            var userId = (int?)HttpContext.Current.Session["UserId"];
            if (userId.HasValue)
            {
                SubscribeDto subscribeDto = new SubscribeDto
                {
                    EventId = Convert.ToInt32(hddnEventId.Value),
                    UserId = userId.Value,
                    Is_Like = true

                };
                SubscribeService subscribeService = new SubscribeService();
              subscribeService.IsLike(subscribeDto);
                if (true)
                {
                
                    Response.Write("<script> alert('you liked')</script>");
                }
              
            }
        }

        protected void Subscribe(object sender, EventArgs e)
        {


            // Session["UserId"]=
            SubscribeDto subscribeDto = new SubscribeDto
            {
                EventId = Id,
                UserId = (int)HttpContext.Current.Session["UserId"],
                Is_Like = false

            };
            if (subscribeDto.UserId != 0)
            {
                SubscribeService subscribeService = new SubscribeService();
                subscribeService.AddSubscribe(subscribeDto);
            }
            else
            {
                Response.Redirect("Account/Register.aspx");
            }

        }


    }
}