using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Common.Dto
{
   public  class RegisterUserProviderDto
    {
       
        
        public string Email { get; set; }
       
        public string Password { get; set; }

        public int RoleId { get; set; }
        public int ProviderId { get; set; }
        public string ProviderName { get; set; }
    }
}
