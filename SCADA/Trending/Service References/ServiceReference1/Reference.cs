﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Trending.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.ITrending", CallbackContract=typeof(Trending.ServiceReference1.ITrendingCallback))]
    public interface ITrending {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITrending/SubscriberInitialization", ReplyAction="http://tempuri.org/ITrending/SubscriberInitializationResponse")]
        void SubscriberInitialization();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITrending/SubscriberInitialization", ReplyAction="http://tempuri.org/ITrending/SubscriberInitializationResponse")]
        System.Threading.Tasks.Task SubscriberInitializationAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITrendingCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ITrending/TagValueChanged")]
        void TagValueChanged(string name, double value);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITrendingChannel : Trending.ServiceReference1.ITrending, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TrendingClient : System.ServiceModel.DuplexClientBase<Trending.ServiceReference1.ITrending>, Trending.ServiceReference1.ITrending {
        
        public TrendingClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public TrendingClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public TrendingClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public TrendingClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public TrendingClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void SubscriberInitialization() {
            base.Channel.SubscriberInitialization();
        }
        
        public System.Threading.Tasks.Task SubscriberInitializationAsync() {
            return base.Channel.SubscriberInitializationAsync();
        }
    }
}
