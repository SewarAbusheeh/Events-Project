using System;
using Services.Common.Dto;
using Services.Services;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Script.Services;
using System.Web.Script.Serialization;

namespace WebApplication14
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod(MessageName = "GetUsers", Description = "get userS info")]
        [System.Xml.Serialization.XmlInclude(typeof(UserDto))]
        public List<UserDto> GetUsers()
        {
            UserService userService = new UserService();
            var userlist = userService.UsersList();

            return userlist;
        }
        [WebMethod(MessageName = "GetUsersBYJSON", Description = "get userS info")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public void GetUsersBYJSON()
        {
            UserService userService = new UserService();
            var userlist = userService.UsersList();
            JavaScriptSerializer ser = new JavaScriptSerializer(); // JavaScriptSerializer --> class to convert to JSON
            HttpContext.Current.Response.Write(ser.Serialize(userlist));  // HttpContext.Current.Response.Write  --> to make print 


        }
        [WebMethod(MessageName = "GetUserBYID", Description = "get user info")]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public void GetUserBYID(int id)
        {
            UserService userService = new UserService();
            var userlist = userService.GetUserById(id);
            JavaScriptSerializer ser = new JavaScriptSerializer();
            HttpContext.Current.Response.Write(ser.Serialize(userlist));

        }
        [WebMethod(MessageName = "GetUserBYIDXML", Description = "get user info")]
        [System.Xml.Serialization.XmlInclude(typeof(UserDto))]
        public UserDto GetUserBYIDXML(int id)
        {
            UserService userService = new UserService();
            var userlist = userService.GetUserById(id);



            return userlist;

        }
    }
}
