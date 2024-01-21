using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Rep
{
   public  class CommentRep
    {
        private CDBContext db;
        public CommentRep(CDBContext _db)
        {
            db = _db;

        }

        public void CreateComment(Comment comment)
        {
            db.Comments.Add(comment);
            db.SaveChanges();
        }
        public void DeleteComment(int Id)
        {
            var D = db.Comments.Find(Id);
            db.Comments.Remove(D);
            db.SaveChanges();
        }
        public void EditComment(int Id, Comment comment)
        {

            if (Id == comment.commentId)
            {

                db.SaveChanges();
            }

        }
        public List<Comment> GetAllComment()
        {
            return db.Comments.ToList();
        }

    }
}
