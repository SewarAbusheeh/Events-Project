using DAL;
using DAL.Models;
using DAL.Rep;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    class CommentService
    {
        private CommentRep _CommentRep;
        public CommentService(CommentRep CommentRep)
        {
            _CommentRep = CommentRep;

        }

        public void CreateComment(Comment comment)
        {
            _CommentRep.CreateComment(comment);
        }
        public void DeleteComment(int Id)
        {
            _CommentRep.DeleteComment(Id);
        }
        public void EditComment(int Id,Comment comment)
        {

            _CommentRep.EditComment(Id , comment);

        }
        public void GetAllComment()
        {
            _CommentRep.GetAllComment();
        }


    }
}
