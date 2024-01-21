using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication14.FirstWcfServiceReference1;

namespace WebApplication14
{
    public partial class _Default : Page
    {
        FirstWCFServiceClient clientW = new FirstWCFServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            //  Response.Write( clientW.Message());

            //int x  = clientW.getNum(5, 6);
            //Response.Write(x);
            //var x1 = clientW.GetUserById(8);
            //T1.Text = x1.Email;
        }
      
    }
}