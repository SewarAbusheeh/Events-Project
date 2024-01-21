﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Common.Dto
{
   public  class EditUserDto
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string UserType { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public int ProviderId { get; set; }
        public string ProviderName { get; set; }
    }
}
