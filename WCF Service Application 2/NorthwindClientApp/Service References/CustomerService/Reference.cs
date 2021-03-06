﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NorthwindClientApp.CustomerService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Customer", Namespace="http://schemas.datacontract.org/2004/07/MyServiceApp")]
    [System.SerializableAttribute()]
    public partial class Customer : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CompanyNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CountryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CustomerIdField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CompanyName {
            get {
                return this.CompanyNameField;
            }
            set {
                if ((object.ReferenceEquals(this.CompanyNameField, value) != true)) {
                    this.CompanyNameField = value;
                    this.RaisePropertyChanged("CompanyName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Country {
            get {
                return this.CountryField;
            }
            set {
                if ((object.ReferenceEquals(this.CountryField, value) != true)) {
                    this.CountryField = value;
                    this.RaisePropertyChanged("Country");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CustomerId {
            get {
                return this.CustomerIdField;
            }
            set {
                if ((object.ReferenceEquals(this.CustomerIdField, value) != true)) {
                    this.CustomerIdField = value;
                    this.RaisePropertyChanged("CustomerId");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="Http://wwww.Northwind.com/Services/CustomerService", ConfigurationName="CustomerService.CustomerService")]
    public interface CustomerService {
        
        [System.ServiceModel.OperationContractAttribute(Action="Http://wwww.Northwind.com/Services/CustomerService/CustomerService/GetCustomerByC" +
            "ountry", ReplyAction="Http://wwww.Northwind.com/Services/CustomerService/CustomerService/GetCustomerByC" +
            "ountryResponse")]
        NorthwindClientApp.CustomerService.Customer[] GetCustomerByCountry(string country);
        
        [System.ServiceModel.OperationContractAttribute(Action="Http://wwww.Northwind.com/Services/CustomerService/CustomerService/GetCustomerByN" +
            "ame", ReplyAction="Http://wwww.Northwind.com/Services/CustomerService/CustomerService/GetCustomerByN" +
            "ameResponse")]
        NorthwindClientApp.CustomerService.Customer[] GetCustomerByName(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="Http://wwww.Northwind.com/Services/CustomerService/CustomerService/AddCustomer", ReplyAction="Http://wwww.Northwind.com/Services/CustomerService/CustomerService/AddCustomerRes" +
            "ponse")]
        void AddCustomer(string cumstomerId, string companyName, string address, string city);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface CustomerServiceChannel : NorthwindClientApp.CustomerService.CustomerService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CustomerServiceClient : System.ServiceModel.ClientBase<NorthwindClientApp.CustomerService.CustomerService>, NorthwindClientApp.CustomerService.CustomerService {
        
        public CustomerServiceClient() {
        }
        
        public CustomerServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CustomerServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CustomerServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CustomerServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public NorthwindClientApp.CustomerService.Customer[] GetCustomerByCountry(string country) {
            return base.Channel.GetCustomerByCountry(country);
        }
        
        public NorthwindClientApp.CustomerService.Customer[] GetCustomerByName(string name) {
            return base.Channel.GetCustomerByName(name);
        }
        
        public void AddCustomer(string cumstomerId, string companyName, string address, string city) {
            base.Channel.AddCustomer(cumstomerId, companyName, address, city);
        }
    }
}
