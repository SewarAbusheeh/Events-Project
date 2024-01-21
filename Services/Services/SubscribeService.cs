using DAL;
using DAL.Models;
using DAL.Rep;
using Service.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
   public  class SubscribeService
    {
       // private SubscribeRep  _subscribeRep;
        //public SubscribeService(SubscribeRep SubscribeRep)
        //{


        //    _subscribeRep = SubscribeRep  ;
        //}

        public void AddSubscribe(SubscribeDto subscribeDto)

        {
             SubscribeRep subscribeRep = new SubscribeRep();
               subscribeRep.AddSubscribe(subscribeDto);
        }
   
        //public void DeleteSubscribe(SubscribeDto subscribeDto )
           
        //{
        //    SubscribeRep subscribeRep = new SubscribeRep();
        //    subscribeRep.DeleteSubscribe(subscribeDto);
        //}
        public void IsLike(SubscribeDto subscribeDto)

        {
            SubscribeRep subscribeRep = new SubscribeRep();
            subscribeRep.IsLike(subscribeDto);
        }
        public bool AddComment(SubscribeDto subscribeDto)

        {
            SubscribeRep subscribeRep = new SubscribeRep();
            subscribeRep.AddComment(subscribeDto);
            return true;
        }
        //public void EditSubscribe(int Id, Subscribe sub)
        //{

        //    if (Id == sub.subscribeId)
        //    {

        //        db.SaveChanges();
        //    }

        //}

        public List <SubscribeDto> GetAllSubscribers()
        {
            SubscribeRep subscribeRep = new SubscribeRep();
           var L =subscribeRep.GetAllSubscribers();
            return L;
        }

    
    }
}
