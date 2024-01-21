using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Event
    {

        [Key]
        public int EventId { get; set; }
        public string EventName { get; set; }
        public DateTime CreationDate { get; set; }
     //   public DateTime EndDate { get; set; }
       
        public int ProviderId { get; set; }
        [ForeignKey("ProviderId")]
        public virtual Provider ProviderFk { get; set; }
    }
}
