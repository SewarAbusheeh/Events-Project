using Services.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace WebApplication14
{
    public partial class SubscribeDisplay : System.Web.UI.Page
    {
     
        protected void Page_Load(object sender, EventArgs e)
        {
            //using (SqlConnection sqlconn = new SqlConnection(ConnString))
            //{
            //    sqlconn.Open();        //
            //    SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * FROM Subscribes", sqlconn);
            //    DataTable dataTable = new DataTable();
            //    sqlData.Fill(dataTable);
            //    grdview.DataSource = dataTable;
            //    grdview.DataBind();
            //}
            SubscribeService subscribe = new SubscribeService();
            var D= subscribe.GetAllSubscribers();

           
            // userService.UsersList();

            MyGridView.DataSource = D;
            MyGridView.DataBind();
        }
    }
}