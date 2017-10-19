﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ArchitectureTemplate.Infrastructure.WCF.Client.ServiceReferenceScreens {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceScreens.IScreenServiceContract")]
    public interface IScreenServiceContract {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IScreenServiceContract/GetById", ReplyAction="http://tempuri.org/IScreenServiceContract/GetByIdResponse")]
        ArchitectureTemplate.Infrastructure.WCF.Contracts.Entities.ScreenContract GetById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IScreenServiceContract/GetById", ReplyAction="http://tempuri.org/IScreenServiceContract/GetByIdResponse")]
        System.Threading.Tasks.Task<ArchitectureTemplate.Infrastructure.WCF.Contracts.Entities.ScreenContract> GetByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IScreenServiceContract/GetByName", ReplyAction="http://tempuri.org/IScreenServiceContract/GetByNameResponse")]
        ArchitectureTemplate.Infrastructure.WCF.Contracts.Entities.ScreenContract GetByName(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IScreenServiceContract/GetByName", ReplyAction="http://tempuri.org/IScreenServiceContract/GetByNameResponse")]
        System.Threading.Tasks.Task<ArchitectureTemplate.Infrastructure.WCF.Contracts.Entities.ScreenContract> GetByNameAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IScreenServiceContract/GetScreensByContains", ReplyAction="http://tempuri.org/IScreenServiceContract/GetScreensByContainsResponse")]
        ArchitectureTemplate.Infrastructure.WCF.Contracts.Entities.ScreenContract[] GetScreensByContains(string key);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IScreenServiceContract/GetScreensByContains", ReplyAction="http://tempuri.org/IScreenServiceContract/GetScreensByContainsResponse")]
        System.Threading.Tasks.Task<ArchitectureTemplate.Infrastructure.WCF.Contracts.Entities.ScreenContract[]> GetScreensByContainsAsync(string key);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IScreenServiceContract/GetScreensByRange", ReplyAction="http://tempuri.org/IScreenServiceContract/GetScreensByRangeResponse")]
        ArchitectureTemplate.Infrastructure.WCF.Contracts.Entities.ScreenContract[] GetScreensByRange(int idBegin, int idEnd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IScreenServiceContract/GetScreensByRange", ReplyAction="http://tempuri.org/IScreenServiceContract/GetScreensByRangeResponse")]
        System.Threading.Tasks.Task<ArchitectureTemplate.Infrastructure.WCF.Contracts.Entities.ScreenContract[]> GetScreensByRangeAsync(int idBegin, int idEnd);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IScreenServiceContractChannel : ArchitectureTemplate.Infrastructure.WCF.Client.ServiceReferenceScreens.IScreenServiceContract, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ScreenServiceContractClient : System.ServiceModel.ClientBase<ArchitectureTemplate.Infrastructure.WCF.Client.ServiceReferenceScreens.IScreenServiceContract>, ArchitectureTemplate.Infrastructure.WCF.Client.ServiceReferenceScreens.IScreenServiceContract {
        
        public ScreenServiceContractClient() {
        }
        
        public ScreenServiceContractClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ScreenServiceContractClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ScreenServiceContractClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ScreenServiceContractClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ArchitectureTemplate.Infrastructure.WCF.Contracts.Entities.ScreenContract GetById(int id) {
            return base.Channel.GetById(id);
        }
        
        public System.Threading.Tasks.Task<ArchitectureTemplate.Infrastructure.WCF.Contracts.Entities.ScreenContract> GetByIdAsync(int id) {
            return base.Channel.GetByIdAsync(id);
        }
        
        public ArchitectureTemplate.Infrastructure.WCF.Contracts.Entities.ScreenContract GetByName(string name) {
            return base.Channel.GetByName(name);
        }
        
        public System.Threading.Tasks.Task<ArchitectureTemplate.Infrastructure.WCF.Contracts.Entities.ScreenContract> GetByNameAsync(string name) {
            return base.Channel.GetByNameAsync(name);
        }
        
        public ArchitectureTemplate.Infrastructure.WCF.Contracts.Entities.ScreenContract[] GetScreensByContains(string key) {
            return base.Channel.GetScreensByContains(key);
        }
        
        public System.Threading.Tasks.Task<ArchitectureTemplate.Infrastructure.WCF.Contracts.Entities.ScreenContract[]> GetScreensByContainsAsync(string key) {
            return base.Channel.GetScreensByContainsAsync(key);
        }
        
        public ArchitectureTemplate.Infrastructure.WCF.Contracts.Entities.ScreenContract[] GetScreensByRange(int idBegin, int idEnd) {
            return base.Channel.GetScreensByRange(idBegin, idEnd);
        }
        
        public System.Threading.Tasks.Task<ArchitectureTemplate.Infrastructure.WCF.Contracts.Entities.ScreenContract[]> GetScreensByRangeAsync(int idBegin, int idEnd) {
            return base.Channel.GetScreensByRangeAsync(idBegin, idEnd);
        }
    }
}