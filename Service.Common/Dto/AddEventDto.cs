using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Common.Dto
{
  public  class AddEventDto
    {
        [Key]
        public int Id { get; set; }
        public string EventName { get; set; }
        public DateTime CreationDate { get; set; }


        public int ProviderId { get; set; }

        public string ProviderName { get; set; }
    }
}
