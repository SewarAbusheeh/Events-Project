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
    public partial class UserDisplay : System.Web.UI.Page
    {
       // UserService userService = new UserService();
        //string ConnString = @"Server=PPCH;Initial Catalog=Webapp14Event;Integrated Security =True;MultipleActiveResultSets=True;";
        protected void Page_Load(object sender, EventArgs e)
        {
            //using (SqlConnection sqlconn = new SqlConnection(ConnString))
            //{
            //sqlconn.Open();        //
            //SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * FROM Users", sqlconn);
            // UserService userser = new UserService();
            // userser.GetAllUsers();
            //DataTable dataTable = new DataTable();
            //sqlData.Fill(dataTable);
            //User.DataSource = dataTable;
            //User.DataBind();
            //  UserService userService = new UserService();
            UserService userService = new UserService();
            var userDto = userService.UsersList();
            // userService.UsersList();

            MyGridView.DataSource = userDto;
            MyGridView.DataBind();
            //User.DataSource = userDto;
            //User.DataBind();

            //}
        }

     

        protected void AddUser(object sender, EventArgs e)
        {
            //var addUserDto = new AddUserDto()
            //{
            //    Email = txtEmail.Text,
            //    Password = txtPassword.Text,
            //    ProviderId = 1,
            //    RoleId = 1
            //};
            //var _userService = new UserService();
            // _userService.AddUser(addUserDto);
        }

     

        protected void DeleteUserfrom(object sender, GridViewDeleteEventArgs e)
        {
            int Id = Convert.ToInt32(MyGridView.DataKeys[e.RowIndex].Value.ToString());



            ProviderService providerService = new ProviderService();
            var res = providerService.DeleteProvider(Id);
            if (res == true)
            {
                Response.Write("<script> alert('The Data has been Removed')</script>");

            }
            else
            {
                Response.Write("<script> alert('There is no Data to removed ')</script>");
            }

        }
        protected void RegisterUserProvider(object sender, EventArgs e)
        {
            //if (Page.IsValid)
            //{
            //    var registerUserproviderDto = new RegisterUserProviderDto()
            //    {
            //        Email = txtEmail.Text,
            //        Password = txtPassword.Text,
            //        // ProviderId = 1,
            //        ProviderId = Convert.ToInt32(Request.Form[DropDownList1.UniqueID]),
            //        RoleId = 3
            //    };
            //    var _userService = new UserService();
            //    var R = _userService.RegisterProviderAccount(registerUserproviderDto);
            //    if (R == true)
            //    {
            //        Response.Redirect("~/UserDisplay.aspx");
            //    }
            //    else
            //    {
            //        //  MessageError.Text.;
            //        Response.Write("Invalid Email or Password ");

            //    }

            //}
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["UserName"] = "what ";
           
            Response.Redirect("~/Default.ASPX");
          
        }
    }
}