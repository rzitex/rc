﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.8762
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LearnWCF
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Pair", Namespace="http://schemas.datacontract.org/2004/07/LearnWCF")]
    public partial class Pair : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int FirstField;
        
        private int SecondField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int First
        {
            get
            {
                return this.FirstField;
            }
            set
            {
                this.FirstField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Second
        {
            get
            {
                return this.SecondField;
            }
            set
            {
                this.SecondField = value;
            }
        }
    }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="IPairArihmeticService")]
public interface IPairArihmeticService
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPairArihmeticService/Add", ReplyAction="http://tempuri.org/IPairArihmeticService/AddResponse")]
    LearnWCF.Pair Add(LearnWCF.Pair p1, LearnWCF.Pair p2);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPairArihmeticService/Subtract", ReplyAction="http://tempuri.org/IPairArihmeticService/SubtractResponse")]
    LearnWCF.Pair Subtract(LearnWCF.Pair p1, LearnWCF.Pair p2);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
public interface IPairArihmeticServiceChannel : IPairArihmeticService, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
public partial class PairArihmeticServiceClient : System.ServiceModel.ClientBase<IPairArihmeticService>, IPairArihmeticService
{
    
    public PairArihmeticServiceClient()
    {
    }
    
    public PairArihmeticServiceClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public PairArihmeticServiceClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public PairArihmeticServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public PairArihmeticServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public LearnWCF.Pair Add(LearnWCF.Pair p1, LearnWCF.Pair p2)
    {
        return base.Channel.Add(p1, p2);
    }
    
    public LearnWCF.Pair Subtract(LearnWCF.Pair p1, LearnWCF.Pair p2)
    {
        return base.Channel.Subtract(p1, p2);
    }
}
