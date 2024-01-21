

using DAL;
using DAL.Models;
using DAL.Rep;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.Common.Dto;
using Service.Common.Dto;

namespace Services.Services
{
    public class EventService
    {
        //public EventService()
        //{
        //}

        //private EventRep _eventRep;

        //public EventService()
        //{
        //}

        //public EventService(EventRep eventRep)
        //{
        //   EventRep _eventRep = new EventRep();
        //    _eventRep = eventRep;

        //}
        public void CreateEvent(AddEventDto addEventDto)
        {
            EventRep _eventRep = new EventRep();
            Event e = new Event
            {
                ProviderId = addEventDto.ProviderId,

                EventName = addEventDto.EventName,
                CreationDate = addEventDto.CreationDate
            };


            _eventRep.CreateEvent(e);
        }
        public bool DeleteEvent(int Id)
        {
            EventRep _eventRep = new EventRep();
            var res = _eventRep.DeleteEvent(Id);
            return res;
        }
        public void EditEvent(EventDto eventDto)
        {
            Event E = new Event
            {
                CreationDate = eventDto.CreationDate,
                EventName = eventDto.EventName,
                ProviderId = eventDto.ProviderId,
                EventId = eventDto.Id
            };
            EventRep _eventRep = new EventRep();
            _eventRep.EditEvent(E);

        }

        public List<GetAllProviderForDropDownListDto> GetAllProviderForDropDownList()
        {
            EventRep _eventRep = new EventRep();
            return _eventRep.GetAllProviderForDropDownList();
        }
        //public void EditProvider(AddProviderDTO editProviderDTO)
        //{


        //    ProviderRep roviderRep = new ProviderRep();
        //    Provider P = new Provider
        //    {
        //        Email = editProviderDTO.Email,
        //        Name = editProviderDTO.Name,
        //        ProviderId = editProviderDTO.Id

        //    };
        //    roviderRep.EditProvider(P);
        //    // return t;
        //}
        public EventDto GetEventById(int Id)
        {
            EventRep _eventRep = new EventRep();
            var P = _eventRep.GetEventById(Id);
            return P;

        }
      
        public List<EventDto> GetAllEvent(int? userId)
        {
            EventRep _eventRep = new EventRep();
            var L = _eventRep.GetAllEvent(userId);
            return L ;
        }

    
     }
}
