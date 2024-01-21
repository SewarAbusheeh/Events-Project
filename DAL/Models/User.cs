using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string UserType { get; set; }
        public int RoleId { get; set; }

        [ForeignKey("RoleId")]
        public Role RoleFk { get; set; }
        public int ProviderId { get; set; }

        [ForeignKey("ProviderId")]
        public  Provider ProviderFk { get; set; }

    }
}
