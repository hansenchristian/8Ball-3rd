﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _8Ball_Anwendung.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/first", ReplyAction="http://tempuri.org/IService1/firstResponse")]
        int first(int count, bool hit, int[] sinkedBalls);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/first", ReplyAction="http://tempuri.org/IService1/firstResponse")]
        System.Threading.Tasks.Task<int> firstAsync(int count, bool hit, int[] sinkedBalls);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ansage", ReplyAction="http://tempuri.org/IService1/ansageResponse")]
        void ansage([System.ServiceModel.MessageParameterAttribute(Name="ansage")] int ansage1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ansage", ReplyAction="http://tempuri.org/IService1/ansageResponse")]
        System.Threading.Tasks.Task ansageAsync(int ansage);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/other", ReplyAction="http://tempuri.org/IService1/otherResponse")]
        int other(int count, int[] sinkedBalls);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/other", ReplyAction="http://tempuri.org/IService1/otherResponse")]
        System.Threading.Tasks.Task<int> otherAsync(int count, int[] sinkedBalls);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : _8Ball_Anwendung.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<_8Ball_Anwendung.ServiceReference1.IService1>, _8Ball_Anwendung.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int first(int count, bool hit, int[] sinkedBalls) {
            return base.Channel.first(count, hit, sinkedBalls);
        }
        
        public System.Threading.Tasks.Task<int> firstAsync(int count, bool hit, int[] sinkedBalls) {
            return base.Channel.firstAsync(count, hit, sinkedBalls);
        }
        
        public void ansage(int ansage1) {
            base.Channel.ansage(ansage1);
        }
        
        public System.Threading.Tasks.Task ansageAsync(int ansage) {
            return base.Channel.ansageAsync(ansage);
        }
        
        public int other(int count, int[] sinkedBalls) {
            return base.Channel.other(count, sinkedBalls);
        }
        
        public System.Threading.Tasks.Task<int> otherAsync(int count, int[] sinkedBalls) {
            return base.Channel.otherAsync(count, sinkedBalls);
        }
    }
}
