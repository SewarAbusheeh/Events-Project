using DAL.Models;
using DAL.Rep;
using Services.Common.Dto;
using Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace FirstWcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "FirstWCFService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select FirstWCFService.svc or FirstWCFService.svc.cs at the Solution Explorer and start debugging.
    public class FirstWCFService : IFirstWCFService
    {
        public void DoWork()
        {
        }

    
        [DataContract]
        public class UserDto
        {
            public int Id { get; set; }
            public string Email { get; set; }
            public string UserName { get; set; }
            public string Password { get; set; }
            public string UserType { get; set; }
        }

        public List<Services.Common.Dto.UserDto> getallusers()
        {
            UserRep userrep = new UserRep();
            UserService userService = new UserService();
            var res = userService.UsersList();
            return res;
        }

        public int getNum(int a, int b)
        {
            var x = a + b;
            return x;
        }



        public Services.Common.Dto.UserDto GetUserById(int id)
        {
            UserRep userrep = new UserRep();
            //  UserService userService = new UserService();
            //  var res = userService.GetUserById(id);
            var res = userrep.GetUserById(id);
            return res;
        }

        public string Message()
        {
            return "hello";
        }

        List<Services.Common.Dto.UserDto> IFirstWCFService.GetAllUsers()
        {
            UserRep userrep = new UserRep();
            UserService userService = new UserService();
            var res = userService.UsersList();
            return res;
        }

        //List<UserDto> IFirstWCFService.GetAllUsers()
        //{
        //    UserRep userrep = new UserRep();
        //    var res = userrep.GetAllUsers();
        //    return res;
        //}
    }
}
