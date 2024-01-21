using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Common.Dto
{
    public class SubscribeDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
       
        public  string Email { get; set; }
        public int EventId { get; set; }
        public String Comment { get; set; }
        public String EventName { get; set; }
     
        public bool Is_Like { get; set; }
    }
}
