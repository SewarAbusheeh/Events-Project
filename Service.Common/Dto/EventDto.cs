﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Common.Dto
{
   public  class EventDto
    {
        [Key]
        public int Id { get; set; }
        public string EventName { get; set; }
        public DateTime CreationDate { get; set; }
       

        public int ProviderId { get; set; }
      
        public string  ProviderName { get; set; }
        public bool IsLike { get; set; }
    }
}