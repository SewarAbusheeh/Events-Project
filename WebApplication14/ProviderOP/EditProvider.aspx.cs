using Service.Common.Dto;
using Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication14.ProviderOP
{
    public partial class EditProvider1 : System.Web.UI.Page
    {
        ProviderService Ser = new ProviderService();
        public int Id
        {
            get
            {
                return Request.QueryString["id"] == null ? 0 : Convert.ToInt32(Request.QueryString["id"]);
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            ProviderService Ser = new ProviderService();
            var res= Ser.GetProviderById(Id);
            txtEmail.Text = res.Email;
            txtName.Text = res.Name;


        }

        protected void EditBtn_Click(object sender, EventArgs e)
        {
            ProviderService Ser = new ProviderService();
           var d= Ser.GetProviderById(Id);
            AddProviderDTO addProviderDto = new AddProviderDTO
            {
                Email = Request.Form[txtEmail.UniqueID],
                Name = Request.Form[txtName.UniqueID],
                Id =d.Id
               // Id = Ser.GetProviderById(Id) ;
            };
            //d.Name=Request.Form(EmailTx.Text.un)
         //   d.Id=Convert.
             Ser.EditProvider(addProviderDto);
            //if (t == true)
            //{
            Response.Redirect("~/Providerdisplay.aspx");
            
        }

        //protected void EditProvider(object sender, EventArgs e)
        //{
        //    ProviderService Ser = new ProviderService();
        //    //AddProviderDTO addProviderDto = new AddProviderDTO
        //    //{
        //    //    Email = EmailTx.Text,
        //    //    Name = UserNameTX.Text
        //    //};
        //    //var t = Ser.(addProviderDto);
        //    //if (t == true)
        //    //{
        //    //    Response.Redirect("~/Providerdisplay.aspx");
        //    //}
        //}

    }
}