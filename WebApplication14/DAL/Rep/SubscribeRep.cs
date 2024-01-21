using DAL.Models;
using Service.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Rep
{
    public class SubscribeRep
    {
        private CDBContext db;
        //public SubscribeRep(CDBContext _db)
        //{
        //    db = _db;

        //}

        public void  AddSubscribe(SubscribeDto subscribeDto)
        {
           
            using (CDBContext db =new CDBContext())
            {
                
                    Subscribe subscribe = new Subscribe
                    {
                        EventId= subscribeDto.EventId ,
                        UserId= subscribeDto.UserId,
                        Is_Like= subscribeDto.Is_Like
                    };

                     db.Subscribes.Add(subscribe);
                     db.SaveChanges();
                //     if (subscribe.Is_Like==true)
                //{

                //}
            }
          
        }
        public void DeleteSubscribe(SubscribeDto  dto)
        {
            using (CDBContext db = new CDBContext())
            {

                Subscribe subscribe = new Subscribe
                { };
        
            }
        }
        public void AddComment(SubscribeDto subscribeDto)
        {
            using (CDBContext db = new CDBContext())
            {

                Subscribe subscribe = new Subscribe
                {
                    EventId = subscribeDto.EventId,
                    UserId = subscribeDto.UserId,
                    Is_Like = subscribeDto.Is_Like ,
                     Comment =subscribeDto.Comment
                };


                db.Subscribes.Add(subscribe);
                db.SaveChanges();

            }
        }
        public void AddLike(SubscribeDto subscribeDto )
        {
            using (CDBContext db = new CDBContext())
            {

                Subscribe subscribe = new Subscribe
                {
                    EventId = subscribeDto.EventId,
                    UserId = subscribeDto.UserId,
                    Is_Like = subscribeDto.Is_Like
                };
          

                db.Subscribes.Add(subscribe);
                db.SaveChanges();
      
            }
        }
        //public void EditSubscribe(int Id, Subscribe sub)
        //{

        //    if (Id == sub.subscribeId)
        //    {

        //        db.SaveChanges();
        //    }

        //}
        public List<SubscribeDto> GetAllSubscribers()
        {
            var L = new List<SubscribeDto>();
            using (CDBContext DB =new CDBContext())
            {
                var Listdb = DB.Subscribes.ToList();
                if (Listdb != null)
                {
                    foreach (var item in Listdb)
                    {
                        SubscribeDto dto = new SubscribeDto
                        {
                            Id= item.subscribeId,
                            UserId = item.UserId,
                            EventId = item.EventId,
                        //    EventName = item.EventName,
                              Is_Like= item.Is_Like
                      //      Email= item.Email,
                      
                           
                        };
                        if (item.User != null)
                        {
                            dto.Email = DB.Users.Where(x => x.UserId == item.UserId).Select(x => x.Email).FirstOrDefault();
                        }
                        if (item.EventFK != null)
                        {
                            dto.EventName = DB.Events.Where(x => x.EventId == item.EventId).Select(x => x.EventName).FirstOrDefault();
                        }
                        L.Add(dto);
                    }
                }
            }
            return L;
        }
    }
}
