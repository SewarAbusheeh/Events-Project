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
    public partial class EditProvider : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ProviderService serviceProvider = new ProviderService();
            //EditProviderDTO e = new EditProviderDTO
            //{

            //};
        }

        protected void AddProvider(object sender, EventArgs e)
        {
            ProviderService serviceProvider = new ProviderService();
            AddProviderDTO addProviderDto = new AddProviderDTO
            {
                Email = EmailTx.Text ,
                Name= UserNameTX.Text 
            };
          var t=  serviceProvider.CreateProvider(addProviderDto);
            if (t==true)
            {
                Response.Redirect("~/Providerdisplay.aspx");
            }

    }
    }
}