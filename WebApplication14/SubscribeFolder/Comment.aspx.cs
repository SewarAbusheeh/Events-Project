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
    public partial class Comment : System.Web.UI.Page
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
            if (Session["UserId"] != null)
            {
                EventService Ser = new EventService();
                var res = Ser.GetEventById(Id);
                SubscribeDto subscribeDto = new SubscribeDto
                {
                    EventId = Id,
                    UserId = (int)HttpContext.Current.Session["UserId"],
                    EventName = res.EventName,
                    CreationDate = res.CreationDate,
                    Is_Like = false ,
                    ProviderName = res.ProviderName

                };
                //rptEvent.DataSource = subscribeDto;
                //rptEvent.DataBind();
                label1.Text = res.EventName;
               
                label2.Text = res.ProviderName;
                //label2.Text.ToString() = res.CreationDate;
            }
            else
            {
              //  Response.Redirect("Account/Register.aspx");
                Response.Redirect("~/Account/Register.aspx");
            }
            //SubscribeService subscribeService = new SubscribeService();
            //subscribeService.AddComment(subscribeDto);
        }
        protected void AddComment(object sender, EventArgs e)
        {

            // Session["UserId"]=
            SubscribeDto subscribeDto1 = new SubscribeDto
            {
                EventId = Id,
                UserId = (int)HttpContext.Current.Session["UserId"],
                Comment = MyBox.Text 

             };
                SubscribeService subscribeService = new SubscribeService();
               var result= subscribeService.AddComment(subscribeDto1);
            if (result ==true)
            {
                Response.Write("<script> alert('Your Comment is  sent')</script>");
                Response.Redirect("~/EventdisplayToUser.aspx");
            }
            else
            {
                Response.Write("<script> alert('Your Comment is not sent')</script>");
            }
          
        }
    }
}