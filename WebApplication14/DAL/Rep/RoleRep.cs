using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Rep
{
   public  class RoleRep
    {
        private CDBContext db;
        public RoleRep(CDBContext _db)
        {
            db = _db;

        }
        public void CreateRole(Role role)
        {
            db.Roles.Add(role);
            db.SaveChanges();
        }
        public void DeleteRole(int Id)
        {
            var D = db.Roles.Find(Id);
            db.Roles.Remove(D);
            db.SaveChanges();
        }
        public void EditRole(int Id, Role role)
        {

            if (Id == role.RoleId)
            {

                db.SaveChanges();
            }

        }
        public List<Role> GetAllRoles()
        {
           return  db.Roles.ToList();

        }
    }
}
