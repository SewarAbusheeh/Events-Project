using DAL.Models;
using Services.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace FirstWcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IFirstWCFService" in both code and config file together.
    [ServiceContract]
    public interface IFirstWCFService
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        string  Message();
        [OperationContract]
        int getNum(int a ,int b );
      
        [OperationContract]
        List<UserDto> GetAllUsers();


        //[OperationContract]


        ////int getNum1(int a, int b);
        [OperationContract]
        UserDto GetUserById(int id);
        //[OperationContract] // to expose
        //List<UserDto> getallusers();
    }
}
