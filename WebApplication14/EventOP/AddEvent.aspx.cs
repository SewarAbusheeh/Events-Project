using Service.Common.Dto;
using Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication14.EventOP
{
    public partial class AddEvent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            EventService eventService = new EventService();
            var res = eventService.GetAllProviderForDropDownList();
            DropDownList1.DataSource = res;
            DropDownList1.DataBind();


        }

        protected void AddEventM(object sender, EventArgs e)
        {
            var dto = new AddEventDto
            {
                //ProviderId=Convert.ToInt32(DropDownList1.SelectedValue),
                ProviderId = Convert.ToInt32(Request.Form[DropDownList1.UniqueID]),// watch out girl becuse its come from a drop down which means from  view 
                EventName = EventName.Text,
              
                CreationDate = Calendar1.SelectedDate,
                
              //  ProviderName = DropDownList1.SelectedValue
            };
            EventService eventService = new EventService();
             eventService.CreateEvent(dto);
        }
    }
}