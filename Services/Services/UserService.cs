using DAL;
using DAL.Models;
using DAL.Rep;
using Service.Common.Dto;
using Services.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    //public interface IUserService
    //{
    //    void Register(User user);
    //    bool Login(string Email, string Password);
    //    void Logout();
    //    void Subscribe(int UserId ,int EventId );
    //    void Like(int UserId, int EventId);
    //    void AddComment(int UserId, int SubId);
    //}
    public class UserService 
    {

        //public UserService(UserRep UserRep)
        //{

        public List<ProviderDto> GetAllProvider()
        {
            UserRep Rep = new UserRep();
            var L = Rep.GetAllProvider();
            return L;
        }
        public void AddUserCo(User user)

        {
            //User user = new User
            //{
            //    Email = addUserDto.Email,
            //    Password = addUserDto.Password,
            //    ProviderId = addUserDto.ProviderId,
            //    RoleId = addUserDto.RoleId,
            //};
             UserRep _UserRep = new UserRep( );
            _UserRep.AddUser(user);
        }
        public void DeleteUser(int Id)
        {
              UserRep _UserRep = new UserRep();
            _UserRep.DeleteUser(Id);

        }
        public void EditUser(int Id , DAL.Models.User user)
        {
            UserRep _UserRep = new UserRep();

            _UserRep.EditUser(Id, user);
           
        }
        public List<UserDto> UsersList()
        {

            UserRep _UserRep = new UserRep();
            var user= _UserRep.GetAllUsers();
            return user;
        }

        public UserDto GetUserById(int id)
        {
            UserRep _UserRep = new UserRep();
          //  User user = _UserRep.GetUserById(id);
            var userdto = _UserRep.GetUserById(id);
            return userdto;
        }

        public bool RegisterUser(RegisterUserDto registerUserDto)
        {
            
            var user = new DAL.Models.User()
            {
                Email = registerUserDto.Email,
                Password = registerUserDto.Password,
                ProviderId = registerUserDto.ProviderId,
                RoleId = registerUserDto.RoleId,                
            };

            UserRep _UserRep = new UserRep();
            var ret= _UserRep.RegisterUser(user);
            return ret ;
        }
        public bool RegisterProviderAccount(RegisterUserProviderDto registerUserProviderDto)
        {

            var user = new DAL.Models.User()
            {
                Email = registerUserProviderDto.Email,
                Password = registerUserProviderDto.Password,
                ProviderId = registerUserProviderDto.ProviderId,
             RoleId = registerUserProviderDto.RoleId,
            };

            UserRep _UserRep = new UserRep();
            var ret = _UserRep.RegisterProviderAccount(user);
            return ret;
        }
        public int  loginUser(LoginUserDto loginuserdto)   //
        {

            DAL.Models.User U = new DAL.Models.User()
            {
                Email = loginuserdto.Email,
                Password = loginuserdto.Password,
               
            };
            UserRep _userRep = new UserRep();
             var ReturnCode= _userRep.loginUser(U);
            return ReturnCode;


        }
        //public void AddComment(int UserId, int SubId)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Like(int UserId, int EventId)
        //{
        //    throw new NotImplementedException();
        //}

        //public bool Login(string Email, string Password)
        //{
        //    return db.Users.Where(a => a.Email == Email && a.Password == Password).Any();
        //}
        //public void Register(User user) 
        //{
        //    User user1 = new User
        //    {
        //        Email = user.Email,
        //        Password = user.Password,
        //        RoleId = 1          // RoleId=1 which means Customer In Database
        //    };
        //        db.Users.Add(user1);
        //}
        //public void Logout()
        //{
        //    throw new NotImplementedException();
        //}



        //public void Subscribe(int UserId, int EventId)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
