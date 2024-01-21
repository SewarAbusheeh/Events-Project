using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication14.FirstWcfServiceReference1;

namespace WebApplication14
{
    public partial class ToTestWCF : System.Web.UI.Page
    {
        FirstWCFServiceClient clientW = new FirstWCFServiceClient();
           
        protected void Page_Load(object sender, EventArgs e)
        {
            var x1 = clientW.GetUserById(8);
            T1.Text = x1.Email;
        }
    }
}