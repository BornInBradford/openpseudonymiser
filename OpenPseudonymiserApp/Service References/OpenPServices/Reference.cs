﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OpenPseudonymiser.OpenPServices {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="OpenPServices.IOpenPServices")]
    public interface IOpenPServices {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOpenPServices/DoWork", ReplyAction="http://tempuri.org/IOpenPServices/DoWorkResponse")]
        void DoWork();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IOpenPServicesChannel : OpenPseudonymiser.OpenPServices.IOpenPServices, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class OpenPServicesClient : System.ServiceModel.ClientBase<OpenPseudonymiser.OpenPServices.IOpenPServices>, OpenPseudonymiser.OpenPServices.IOpenPServices {
        
        public OpenPServicesClient() {
        }
        
        public OpenPServicesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public OpenPServicesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OpenPServicesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OpenPServicesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void DoWork() {
            base.Channel.DoWork();
        }
    }
}
