using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Services.Services;


namespace WebApplication14
{
    public partial class Events : System.Web.UI.Page
    {
       // private readonly EventService eventService1 ;
       //public Events(EventService _eventService1)
       // {
       //     _eventService1 = eventService1;
       // }

        // string ConnString = @"Server=PPCH;Initial Catalog=Webapp14Event;Integrated Security =True;MultipleActiveResultSets=True;";
        protected void Page_Load(object sender, EventArgs e)
        {
           // EventService _eventService = new EventService();
            //  UserService userService = new UserService();
            var _eventService = new EventService();
            //  var _eventService = new EventService();
           var d= _eventService.GetAllEvent();
            //  eventService.GetAllEvent();
            //var L = _eventService.GetAllEvent();
            // DataTable dataTable = new DataTable();
            MyGridView.DataSource = d;
            MyGridView.DataBind();



        }

        protected void AddEventBtn(object sender, EventArgs e)
        {

        }

        protected void DeleteEventgid(object sender, GridViewDeleteEventArgs e)
        {
            int Id = Convert.ToInt32(MyGridView.DataKeys[e.RowIndex].Value.ToString());

           

            EventService eventService = new EventService();
            var res = eventService.DeleteEvent(Id);
            if (res == true)
            {
                Response.Write("<script> alert('The Data has been Removed')</script>");

            }
            else
            {
                Response.Write("<script> alert('There is no Data to removed ')</script>");
            }
        }

        protected void UpdateEventgrid(object sender, GridViewUpdatedEventArgs e)
        {

        }

        protected void UpdateEventgrid(object sender, GridViewUpdateEventArgs e)
        {

        }

        protected void MyGridView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}