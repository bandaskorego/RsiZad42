﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IBankManager", CallbackContract=typeof(Client.ServiceReference1.IBankManagerCallback), SessionMode=System.ServiceModel.SessionMode.Required)]
    public interface IBankManager {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBankManager/addWorker", ReplyAction="http://tempuri.org/IBankManager/addWorkerResponse")]
        void addWorker(WcfContract.Worker w);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBankManager/addWorker", ReplyAction="http://tempuri.org/IBankManager/addWorkerResponse")]
        System.Threading.Tasks.Task addWorkerAsync(WcfContract.Worker w);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBankManager/getAll", ReplyAction="http://tempuri.org/IBankManager/getAllResponse")]
        WcfContract.Worker[] getAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBankManager/getAll", ReplyAction="http://tempuri.org/IBankManager/getAllResponse")]
        System.Threading.Tasks.Task<WcfContract.Worker[]> getAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IBankManager/getCountOfWorkersWithSalaryGreaterThen")]
        void getCountOfWorkersWithSalaryGreaterThen(double avg);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IBankManager/getCountOfWorkersWithSalaryGreaterThen")]
        System.Threading.Tasks.Task getCountOfWorkersWithSalaryGreaterThenAsync(double avg);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBankManagerCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IBankManager/Wynik")]
        void Wynik(int count);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBankManagerChannel : Client.ServiceReference1.IBankManager, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BankManagerClient : System.ServiceModel.DuplexClientBase<Client.ServiceReference1.IBankManager>, Client.ServiceReference1.IBankManager {
        
        public BankManagerClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public BankManagerClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public BankManagerClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public BankManagerClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public BankManagerClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void addWorker(WcfContract.Worker w) {
            base.Channel.addWorker(w);
        }
        
        public System.Threading.Tasks.Task addWorkerAsync(WcfContract.Worker w) {
            return base.Channel.addWorkerAsync(w);
        }
        
        public WcfContract.Worker[] getAll() {
            return base.Channel.getAll();
        }
        
        public System.Threading.Tasks.Task<WcfContract.Worker[]> getAllAsync() {
            return base.Channel.getAllAsync();
        }
        
        public void getCountOfWorkersWithSalaryGreaterThen(double avg) {
            base.Channel.getCountOfWorkersWithSalaryGreaterThen(avg);
        }
        
        public System.Threading.Tasks.Task getCountOfWorkersWithSalaryGreaterThenAsync(double avg) {
            return base.Channel.getCountOfWorkersWithSalaryGreaterThenAsync(avg);
        }
    }
}