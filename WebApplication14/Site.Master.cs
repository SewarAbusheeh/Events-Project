using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication14
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["Email"] != null)
            {

                //Response.Redirect("EventdisplayToUser.aspx");
                LOGOUT.Visible = true;
                Reg.Visible = false;
                LOGIN.Visible = false;
            }
            else
            {

               // Response.Redirect("EventdisplayToUser.aspx");
                LOGOUT.Visible = false;
                Reg.Visible = true;
                LOGIN.Visible = true;
            }

        }
    }
}