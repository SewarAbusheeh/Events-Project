using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Comment
    {
        [Key]
        public int commentId { get; set; }

        public string CommentU { get; set; }
        public int SubscribeId { get; set; }
        public virtual Subscribe Subscribe { get; set; }
    }
}
