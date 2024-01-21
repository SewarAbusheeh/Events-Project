using DAL;
using DAL.Models;
using DAL.Rep;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    class RoleService
    {
        private RoleRep _RoleRep;
        public RoleService(RoleRep RoleRep)
        {


            _RoleRep = RoleRep;
        }

        public void CreateRole(Role role)
        {
            _RoleRep.CreateRole(role);
        }
        public void DeleteRole(int Id)
        {
            _RoleRep.DeleteRole(Id);
        }
        public void EditRole(int Id, Role role)
        {

            _RoleRep.EditRole(Id, role);

        }
        public void  GetAllRoles()
        {
            _RoleRep.GetAllRoles();
        }

      
    }
}
