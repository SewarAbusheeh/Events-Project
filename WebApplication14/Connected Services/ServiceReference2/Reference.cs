﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication14.ServiceReference2 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference2.IFirstWCFService")]
    public interface IFirstWCFService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFirstWCFService/DoWork", ReplyAction="http://tempuri.org/IFirstWCFService/DoWorkResponse")]
        void DoWork();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFirstWCFService/DoWork", ReplyAction="http://tempuri.org/IFirstWCFService/DoWorkResponse")]
        System.Threading.Tasks.Task DoWorkAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFirstWCFService/Message", ReplyAction="http://tempuri.org/IFirstWCFService/MessageResponse")]
        string Message();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFirstWCFService/Message", ReplyAction="http://tempuri.org/IFirstWCFService/MessageResponse")]
        System.Threading.Tasks.Task<string> MessageAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFirstWCFService/getNum", ReplyAction="http://tempuri.org/IFirstWCFService/getNumResponse")]
        int getNum(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFirstWCFService/getNum", ReplyAction="http://tempuri.org/IFirstWCFService/getNumResponse")]
        System.Threading.Tasks.Task<int> getNumAsync(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFirstWCFService/GetAllUsers", ReplyAction="http://tempuri.org/IFirstWCFService/GetAllUsersResponse")]
        Services.Common.Dto.UserDto[] GetAllUsers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFirstWCFService/GetAllUsers", ReplyAction="http://tempuri.org/IFirstWCFService/GetAllUsersResponse")]
        System.Threading.Tasks.Task<Services.Common.Dto.UserDto[]> GetAllUsersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFirstWCFService/GetUserById", ReplyAction="http://tempuri.org/IFirstWCFService/GetUserByIdResponse")]
        Services.Common.Dto.UserDto GetUserById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFirstWCFService/GetUserById", ReplyAction="http://tempuri.org/IFirstWCFService/GetUserByIdResponse")]
        System.Threading.Tasks.Task<Services.Common.Dto.UserDto> GetUserByIdAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IFirstWCFServiceChannel : WebApplication14.ServiceReference2.IFirstWCFService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FirstWCFServiceClient : System.ServiceModel.ClientBase<WebApplication14.ServiceReference2.IFirstWCFService>, WebApplication14.ServiceReference2.IFirstWCFService {
        
        public FirstWCFServiceClient() {
        }
        
        public FirstWCFServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FirstWCFServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FirstWCFServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FirstWCFServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void DoWork() {
            base.Channel.DoWork();
        }
        
        public System.Threading.Tasks.Task DoWorkAsync() {
            return base.Channel.DoWorkAsync();
        }
        
        public string Message() {
            return base.Channel.Message();
        }
        
        public System.Threading.Tasks.Task<string> MessageAsync() {
            return base.Channel.MessageAsync();
        }
        
        public int getNum(int a, int b) {
            return base.Channel.getNum(a, b);
        }
        
        public System.Threading.Tasks.Task<int> getNumAsync(int a, int b) {
            return base.Channel.getNumAsync(a, b);
        }
        
        public Services.Common.Dto.UserDto[] GetAllUsers() {
            return base.Channel.GetAllUsers();
        }
        
        public System.Threading.Tasks.Task<Services.Common.Dto.UserDto[]> GetAllUsersAsync() {
            return base.Channel.GetAllUsersAsync();
        }
        
        public Services.Common.Dto.UserDto GetUserById(int id) {
            return base.Channel.GetUserById(id);
        }
        
        public System.Threading.Tasks.Task<Services.Common.Dto.UserDto> GetUserByIdAsync(int id) {
            return base.Channel.GetUserByIdAsync(id);
        }
    }
}
