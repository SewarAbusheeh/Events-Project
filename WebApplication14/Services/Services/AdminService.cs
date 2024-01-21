using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    //public interface IAdminService
    //{
    //    bool Login(string Email, string Password);
    //    void Logout();
       
    //    void AddUser();
    //    void EditUser(int id);
    //    void DeleteUser(int id);
    //    void AddEvent();
    //    void EditEvent(int id );
    //    void DeleteEvent(int id);
    
    //    void AddRole();
    //    void DeleteRole(int id);
    //}
    public class AdminService
    {
        private CDBContext db;
        public AdminService(CDBContext _db)
        {
            db = _db;

        }
        //public void AddEvent()
        //{
        //    throw new NotImplementedException();
        //}

        //public void AddRole()
        //{
        //    throw new NotImplementedException();
        //}

        //public void AddUser()
        //{
        //    throw new NotImplementedException();
        //}

        //public void DeleteEvent(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //public void DeleteRole(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //public void DeleteUser(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //public void EditEvent(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //public void EditUser(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //public bool Login(string Email, string Password)
        //{
        //    return db.Users.Where(a => a.Email == Email && a.Password == Password).Any();
        //}

        //public void Logout()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
