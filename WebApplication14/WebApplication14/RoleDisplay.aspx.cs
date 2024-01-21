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
    public partial class RoleDisplay : System.Web.UI.Page
    {
        string ConnString = @"Server=PPCH;Initial Catalog=Webapp14Event;Integrated Security =True;MultipleActiveResultSets=True;";
        protected void Page_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlconn = new SqlConnection(ConnString))
            {
                sqlconn.Open();        //
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * FROM Roles", sqlconn);
                DataTable dataTable = new DataTable();
                sqlData.Fill(dataTable);
                Roles.DataSource = dataTable;
                Roles.DataBind();
            }
        }
    }
}