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
  
  public   class ProviderService
    {
        private ProviderRep _providerRep;
        //public ProviderService(ProviderRep providerRep)
        //{
        //    _providerRep = providerRep;

        //}

        public bool CreateProvider(AddProviderDTO addProviderdto)
        {
            ProviderRep roviderRep = new ProviderRep();
            Provider P = new Provider
            {
                Email= addProviderdto.Email,
                Name= addProviderdto.Name

            };
           var  t= roviderRep.CreateProvider(P);
            return t;
        }
        public bool DeleteProvider(int Id)
        {
            ProviderRep _providerRep = new ProviderRep();
            var result = _providerRep.DeleteProvider(Id);
            return result;
        }
        public void EditProvider( AddProviderDTO editProviderDTO)
        {


            ProviderRep roviderRep = new ProviderRep();
            Provider P = new Provider
            {
                Email = editProviderDTO.Email,
                Name = editProviderDTO.Name ,
                ProviderId= editProviderDTO.Id

            };
             roviderRep.EditProvider(P);
           // return t;
        }
        public List <ProviderDto> GetAllProvider()
        {
            ProviderRep roviderRep = new ProviderRep();
            var L= roviderRep.GetAllProvider();
            return L;
        }

        public ProviderDto   GetProviderById(int id)
        {
            ProviderRep roviderRep = new ProviderRep();
            var P= roviderRep.GetProviderById(id);
            return P;
        }
    }
}
