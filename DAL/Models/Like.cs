using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
   public   class Like
    {
        [Key]
        public int commentId { get; set; }

        public bool Is_LikeU { get; set; }
        public int EventId { get; set; }
        [ForeignKey("EventId")]
        public virtual Event EventFK { get; set; }



        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }
    }
}
