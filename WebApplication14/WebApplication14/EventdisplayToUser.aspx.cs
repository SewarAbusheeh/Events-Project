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
            //if (Session["UserId"]== null)
            //{
               
            //    Response.Redirect("~/EventdisplayToUser.aspx");
            //}else

            //{
            //    var Userid = (int)HttpContext.Current.Session["UserId"];
           

            var _eventService = new EventService();
                //  var _eventService = new EventService();
                var result = _eventService.GetAllEvent();

                rptEvent.DataSource = result;
                rptEvent.DataBind();

            if (Id != 0 )
            {
                SubscribeDto subscribeDto = new SubscribeDto
                {
                    EventId = Id,
                    UserId = (int)HttpContext.Current.Session["UserId"],
                    Is_Like = false

                };

                SubscribeService subscribeService = new SubscribeService();
                subscribeService.AddSubscribe(subscribeDto);
                //if (Id== subscribeDto.EventId && Userid== subscribeDto.UserId)
                //{
                //    SubscribeService subscribeService1 = new SubscribeService();
                //    subscribeService1.DeleteSubscribe(subscribeDto);
                //}
            }

          

        }

        protected void Like(object sender, EventArgs e)
        {


            // Session["UserId"]=
            SubscribeDto subscribeDto = new SubscribeDto
            {
                EventId = Id,
                UserId = (int)HttpContext.Current.Session["UserId"],
                Is_Like = true 

            };
            SubscribeService subscribeService = new SubscribeService();
            subscribeService.AddLike(subscribeDto);

        }

        protected void Subscribe(object sender, EventArgs e)
        {
          

                // Session["UserId"]=
                SubscribeDto subscribeDto = new SubscribeDto
                {
                    EventId =Id,
                    UserId = (int)HttpContext.Current.Session["UserId"],
                    Is_Like = false

                };
                SubscribeService subscribeService = new SubscribeService();
                subscribeService.AddSubscribe(subscribeDto);
            
        }
     

    
    }
}