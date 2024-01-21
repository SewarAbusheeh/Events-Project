using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication14.FirstWcfServiceReference1;

namespace WebApplication14
{
    public partial class Def : System.Web.UI.Page
    {
        FirstWCFServiceClient clientW = new FirstWCFServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write(clientW.Message());

            int x = clientW.getNum(5, 6);
            Response.Write(x);


            var ts = clientW.GetUserById(8);
            //MyGridView. =ts ;
            //MyGridView.DataBind();
           
                T1.Text = ts.Email;
            //var res = clientW.GetUserById();
            //Response.Write(res);
        }
    }
}