using DAL.Models;
using Service.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Rep
{
   public  class ProviderRep
    {
        private CDBContext db;
        //public ProviderRep(CDBContext _db)
        //{
        //    db = _db;

        //}

        public bool CreateProvider(Provider provider)
        {
           using (CDBContext db =new CDBContext())
            {
                db.Providers.Add(provider);
                db.SaveChanges();
            }
            return true;
        } 
        public bool DeleteProvider(int Id)
        {
           
            using (CDBContext db = new CDBContext())
            {
                var D = db.Users.Find(Id);
                 db.Users.Remove(D);
                db.SaveChanges();
              
            }
            return true;
        }
        public void EditProvider( Provider provider)
        {


            using (CDBContext db = new CDBContext())
            {
                  // var d = db.Providers.Find(Id);
                //var d1 = new Provider
                //{
                db.Entry(provider).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                //}
                //db.Providers.(provider);
                //db.SaveChanges();
            }
            //return true;

        }
        public List<ProviderDto> GetAllProvider()
        {
            var ProvList = new List<ProviderDto>();
            using (CDBContext dbb = new CDBContext())
               
            {
                var L = dbb.Providers.ToList();
                foreach (var item in L)
                {
                    ProviderDto providerDto = new ProviderDto
                    {
                        Name=item.Name ,
                        Email=item.Email,
                        Id=item.ProviderId
                    };
                    ProvList.Add(providerDto);
                }
                return ProvList; 
            }
        }

        public ProviderDto GetProviderById(int id)
        {
            using (CDBContext dbb = new CDBContext())

            {
               // Provider P = dbb.Providers.Find(id);
                Provider P = dbb.Providers.FirstOrDefault(x => x.ProviderId == id);
                var PDto = new ProviderDto
                {
                    Name=P.Name,
                    Email=P.Email,
                    Id =P.ProviderId
                };
                return PDto;
            }
        }
    }
}
