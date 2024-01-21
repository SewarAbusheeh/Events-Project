using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Service.Common.Dto;
using Services.Services;
namespace WebApplication14
{
    public partial class Providerdisplay : System.Web.UI.Page
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
            //using (SqlConnection sqlconn = new SqlConnection(ConnString))
            //{
            //    sqlconn.Open();        //
            //    SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * FROM Providers", sqlconn);
            //    DataTable dataTable = new DataTable();
            //    sqlData.Fill(dataTable);
            //    gd.DataSource = dataTable;
            //    gd.DataBind();
         
        ProviderService providerService = new ProviderService();
           var L= providerService.GetAllProvider();
            MyGridView.DataSource = L;
            MyGridView.DataBind();

            //}
        }

        protected void deletformgrid(object sender, GridViewDeleteEventArgs e)
        {


            int Id  = Convert.ToInt32(MyGridView.DataKeys[e.RowIndex].Value.ToString());
           
            //if (Id > 0)
            //{
            //    Response.Write("Done");
            //}
            //else
            //{
            //    Response.Write("not Done");
            //}


            ProviderService providerService = new ProviderService();
           var res = providerService.DeleteProvider(Id);
            if (res ==true)
            {
                Response.Write("<script> alert('The Data has been Removed')</script>");
              
            }
            else
            {
                Response.Write("<script> alert('There is no Data to removed ')</script>");
            }
          //  Response.Redirect("Providerdisplay.aspx");
        }

        protected void editprovidergrid(object sender, GridViewEditEventArgs e)
        {
           // int Id = Convert.ToInt32();
            //ProviderService providerService = new ProviderService();
            //var res = providerService.CreateProvider(Id);
        }

        protected void EditProvider(object sender, EventArgs e)
        {
            //  int Id = Convert.ToInt32(MyGridView.DataKeys[e.RowIndex].Value.ToString());


            LinkButton LBEPRO = new LinkButton();
            LBEPRO.Click += LBEPRO_Click;

            //ProviderService providerService = new ProviderService();
            //var res = providerService.DeleteProvider(Id);
        }

        private void LBEPRO_Click(object sender, EventArgs e)
        {
          
          //  int Id =Convert.ToInt32(e. ;
            ProviderService providerService = new ProviderService();
           // var res = providerService.(Id);
        }
    }
}