using Services.Common.Dto;
using Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication14.UserOP
{
    public partial class EditUser : System.Web.UI.Page
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
            UserService userService = new UserService();
            var ddl = userService.GetAllProvider();
            var U = userService.GetUserById(Id);
            T1.Text = U.Email;
            T2.Text = U.Password;
            Dropdownl1.DataSource = ddl;
            Dropdownl1.SelectedValue = U.Id.ToString();
            Dropdownl1.DataBind();

        }
        protected void Edit_User(object sender, EventArgs e)
        {
            UserService userService = new UserService();

            UserDto userDto = new UserDto
            {

            };
            // userService.EditUser(userDto);
        }
      

    }

}