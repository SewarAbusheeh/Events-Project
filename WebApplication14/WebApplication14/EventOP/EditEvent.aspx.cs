using Services.Common.Dto;
using Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication14.EventOP
{
    public partial class EditEvent : System.Web.UI.Page
    {
        EventService Ser = new EventService();
        public int Id
        {
            get
            {
                return Request.QueryString["id"] == null ? 0 : Convert.ToInt32(Request.QueryString["id"]);
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            EventService Ser = new EventService();
            var res = Ser.GetEventById(Id);
            var ddl = Ser.GetAllProviderForDropDownList();
            //  txtEmail.Text = res.ProviderId;
            EventNameTxt.Text = res.EventName;

            DropDownList1.DataSource = ddl;
            DropDownList1.SelectedValue = res.ProviderId.ToString();
            DropDownList1.DataBind();
            // CreationDate.Se;ect
            //ProviderName. = res.ProviderName;
            //ProviderId.


        }

        protected void EditEventM(object sender, EventArgs e)
        {
            EventService Ser = new EventService();
            var d = Ser.GetEventById(Id);
            var EventDto1 = new EventDto
            {
                //Email = Request.Form[txtEmail.UniqueID],
                //Name = Request.Form[txtName.UniqueID],
                Id = d.Id,
                ProviderId = Convert.ToInt32(Request.Form[DropDownList1.UniqueID]),
                CreationDate = DateTime.Now,
                EventName = Request.Form[EventNameTxt.UniqueID],
                // Id = Ser.GetProviderById(Id) ;
            };
            //d.Name=Request.Form(EmailTx.Text.un)
            //   d.Id=Convert.
            Ser.EditEvent(EventDto1);
            //if (t == true)
            //{
            Response.Redirect("~/Events.aspx");

        }

       
    }
}