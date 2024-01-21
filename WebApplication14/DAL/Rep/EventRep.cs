using DAL.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.Common.Dto;
using Service.Common.Dto;

namespace DAL.Rep
{
    public class EventRep
    {
        private CDBContext db;

        //public EventRep()
        //{
        //}

        //public EventRep(CDBContext _db)
        //{
        //    db = _db;

        //}
        public List<GetAllProviderForDropDownListDto> GetAllProviderForDropDownList()
        {
            var proList = new List<GetAllProviderForDropDownListDto>();
            using (CDBContext DB = new CDBContext())
            {
                var Elist = DB.Providers.ToList();
                if (Elist != null)
                {
                    foreach (var item in Elist)
                    {
                        var data = new GetAllProviderForDropDownListDto
                        {
                            Id = item.ProviderId,
                            Name = item.Name
                        };

                        proList.Add(data);
                    }
                }
                return proList;
            }
        }
        //}
        public void CreateEvent(Event @event)
        {
            using (CDBContext db = new CDBContext())
            {
                //if (@event.ProviderFk == null)
                //{
                //    data.ProviderName = db.Providers.Where(x => x.ProviderId == item.ProviderId).Select(x => x.Name).FirstOrDefault();
                //    @event.ProviderId = db.Providers.
                //        }
                db.Events.Add(@event);
                db.SaveChanges();
            }


        }
        public bool DeleteEvent(int Id)
        {
            using (CDBContext db = new CDBContext())
            {
                var D = db.Events.Find(Id);
                db.Events.Remove(D);
                db.SaveChanges();
            }
            return true;
        }
        public void EditEvent(Event eventDto)
        {

            using (CDBContext db = new CDBContext())
            {
                db.Entry(eventDto).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }

        }
        public List<EventDto> GetAllEvent()
        {
            var EventList = new List<EventDto>(); // This List from ViewModel name EventDto 
            // string cs = ConfigurationManager.ConnectionStrings["newDatabaseContext"].ConnectionString;
            using (CDBContext db = new CDBContext())
            {
                var Elist = db.Events.ToList();
                if (Elist != null)
                {
                    foreach (var item in Elist)
                    {
                        var data = new EventDto
                        {
                            Id = item.EventId,
                            EventName = item.EventName,
                            ProviderId = item.ProviderId,
                            CreationDate = item.CreationDate,

                        };
                        if (item.ProviderFk != null)
                        {
                            data.ProviderName = db.Providers.Where(x => x.ProviderId == item.ProviderId).Select(x => x.Name).FirstOrDefault();
                        }
                        EventList.Add(data);

                    }
                }
                return EventList;
            }
        }
        public EventDto GetEventById(int id)
        {
            using (CDBContext db = new CDBContext())

            {
                // Provider P = dbb.Providers.Find(id);
                Event P = db.Events.FirstOrDefault(x => x.EventId == id);
                var PDto = new EventDto
                {
                    EventName = P.EventName,
                    CreationDate = P.CreationDate,
                    Id = P.EventId,
                    ProviderId = P.ProviderId
                };
                return PDto;
            }
        }
        // SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * FROM Events", cs);
        // DataTable dataTable = new DataTable();
        //var r=  sqlData.Fill(dataTable);
        //string Q= "SELECT * FROM Events " ;

        //SqlCommand command = new SqlCommand(Q,con);
        //SqlDataReader sqlData = command.ExecuteReader();
        //var s = sqlData;
        // var  v = sqlData.HasRows;
        //  List <Event> events = "";
        // db.Events.ToList();


    }
}



