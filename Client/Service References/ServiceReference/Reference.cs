﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.ServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetAllResponseMessage", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class GetAllResponseMessage : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Client.ServiceReference.StockDetails[] StocksField;
        
        private int PageField;
        
        private int SizeField;
        
        private int CountField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public Client.ServiceReference.StockDetails[] Stocks {
            get {
                return this.StocksField;
            }
            set {
                if ((object.ReferenceEquals(this.StocksField, value) != true)) {
                    this.StocksField = value;
                    this.RaisePropertyChanged("Stocks");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=1)]
        public int Page {
            get {
                return this.PageField;
            }
            set {
                if ((this.PageField.Equals(value) != true)) {
                    this.PageField = value;
                    this.RaisePropertyChanged("Page");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
        public int Size {
            get {
                return this.SizeField;
            }
            set {
                if ((this.SizeField.Equals(value) != true)) {
                    this.SizeField = value;
                    this.RaisePropertyChanged("Size");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public int Count {
            get {
                return this.CountField;
            }
            set {
                if ((this.CountField.Equals(value) != true)) {
                    this.CountField = value;
                    this.RaisePropertyChanged("Count");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="StockDetails", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class StockDetails : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int IdField;
        
        private decimal PriceField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public decimal Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfInt", Namespace="http://tempuri.org/", ItemName="int")]
    [System.SerializableAttribute()]
    public class ArrayOfInt : System.Collections.Generic.List<int> {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetByIdsResponseMessage", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class GetByIdsResponseMessage : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Client.ServiceReference.StockDetails[] StocksField;
        
        private int PageField;
        
        private int SizeField;
        
        private int CountField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public Client.ServiceReference.StockDetails[] Stocks {
            get {
                return this.StocksField;
            }
            set {
                if ((object.ReferenceEquals(this.StocksField, value) != true)) {
                    this.StocksField = value;
                    this.RaisePropertyChanged("Stocks");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=1)]
        public int Page {
            get {
                return this.PageField;
            }
            set {
                if ((this.PageField.Equals(value) != true)) {
                    this.PageField = value;
                    this.RaisePropertyChanged("Page");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
        public int Size {
            get {
                return this.SizeField;
            }
            set {
                if ((this.SizeField.Equals(value) != true)) {
                    this.SizeField = value;
                    this.RaisePropertyChanged("Size");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public int Count {
            get {
                return this.CountField;
            }
            set {
                if ((this.CountField.Equals(value) != true)) {
                    this.CountField = value;
                    this.RaisePropertyChanged("Count");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetByIdResponseMessage", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class GetByIdResponseMessage : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Client.ServiceReference.StockDetails StockField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public Client.ServiceReference.StockDetails Stock {
            get {
                return this.StockField;
            }
            set {
                if ((object.ReferenceEquals(this.StockField, value) != true)) {
                    this.StockField = value;
                    this.RaisePropertyChanged("Stock");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.StockExchangeServiceSoap")]
    public interface StockExchangeServiceSoap {
        
        // CODEGEN: Generating message contract since element name GetAllResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAll", ReplyAction="*")]
        Client.ServiceReference.GetAllResponse GetAll(Client.ServiceReference.GetAllRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAll", ReplyAction="*")]
        System.Threading.Tasks.Task<Client.ServiceReference.GetAllResponse> GetAllAsync(Client.ServiceReference.GetAllRequest request);
        
        // CODEGEN: Generating message contract since element name ids from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetByIds", ReplyAction="*")]
        Client.ServiceReference.GetByIdsResponse GetByIds(Client.ServiceReference.GetByIdsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetByIds", ReplyAction="*")]
        System.Threading.Tasks.Task<Client.ServiceReference.GetByIdsResponse> GetByIdsAsync(Client.ServiceReference.GetByIdsRequest request);
        
        // CODEGEN: Generating message contract since element name GetByIdResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetById", ReplyAction="*")]
        Client.ServiceReference.GetByIdResponse GetById(Client.ServiceReference.GetByIdRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetById", ReplyAction="*")]
        System.Threading.Tasks.Task<Client.ServiceReference.GetByIdResponse> GetByIdAsync(Client.ServiceReference.GetByIdRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAll", Namespace="http://tempuri.org/", Order=0)]
        public Client.ServiceReference.GetAllRequestBody Body;
        
        public GetAllRequest() {
        }
        
        public GetAllRequest(Client.ServiceReference.GetAllRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetAllRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int page;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int size;
        
        public GetAllRequestBody() {
        }
        
        public GetAllRequestBody(int page, int size) {
            this.page = page;
            this.size = size;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAllResponse", Namespace="http://tempuri.org/", Order=0)]
        public Client.ServiceReference.GetAllResponseBody Body;
        
        public GetAllResponse() {
        }
        
        public GetAllResponse(Client.ServiceReference.GetAllResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetAllResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Client.ServiceReference.GetAllResponseMessage GetAllResult;
        
        public GetAllResponseBody() {
        }
        
        public GetAllResponseBody(Client.ServiceReference.GetAllResponseMessage GetAllResult) {
            this.GetAllResult = GetAllResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetByIdsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetByIds", Namespace="http://tempuri.org/", Order=0)]
        public Client.ServiceReference.GetByIdsRequestBody Body;
        
        public GetByIdsRequest() {
        }
        
        public GetByIdsRequest(Client.ServiceReference.GetByIdsRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetByIdsRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Client.ServiceReference.ArrayOfInt ids;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int page;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public int size;
        
        public GetByIdsRequestBody() {
        }
        
        public GetByIdsRequestBody(Client.ServiceReference.ArrayOfInt ids, int page, int size) {
            this.ids = ids;
            this.page = page;
            this.size = size;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetByIdsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetByIdsResponse", Namespace="http://tempuri.org/", Order=0)]
        public Client.ServiceReference.GetByIdsResponseBody Body;
        
        public GetByIdsResponse() {
        }
        
        public GetByIdsResponse(Client.ServiceReference.GetByIdsResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetByIdsResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Client.ServiceReference.GetByIdsResponseMessage GetByIdsResult;
        
        public GetByIdsResponseBody() {
        }
        
        public GetByIdsResponseBody(Client.ServiceReference.GetByIdsResponseMessage GetByIdsResult) {
            this.GetByIdsResult = GetByIdsResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetByIdRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetById", Namespace="http://tempuri.org/", Order=0)]
        public Client.ServiceReference.GetByIdRequestBody Body;
        
        public GetByIdRequest() {
        }
        
        public GetByIdRequest(Client.ServiceReference.GetByIdRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetByIdRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int id;
        
        public GetByIdRequestBody() {
        }
        
        public GetByIdRequestBody(int id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetByIdResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetByIdResponse", Namespace="http://tempuri.org/", Order=0)]
        public Client.ServiceReference.GetByIdResponseBody Body;
        
        public GetByIdResponse() {
        }
        
        public GetByIdResponse(Client.ServiceReference.GetByIdResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetByIdResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Client.ServiceReference.GetByIdResponseMessage GetByIdResult;
        
        public GetByIdResponseBody() {
        }
        
        public GetByIdResponseBody(Client.ServiceReference.GetByIdResponseMessage GetByIdResult) {
            this.GetByIdResult = GetByIdResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface StockExchangeServiceSoapChannel : Client.ServiceReference.StockExchangeServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class StockExchangeServiceSoapClient : System.ServiceModel.ClientBase<Client.ServiceReference.StockExchangeServiceSoap>, Client.ServiceReference.StockExchangeServiceSoap {
        
        public StockExchangeServiceSoapClient() {
        }
        
        public StockExchangeServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public StockExchangeServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StockExchangeServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StockExchangeServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Client.ServiceReference.GetAllResponse Client.ServiceReference.StockExchangeServiceSoap.GetAll(Client.ServiceReference.GetAllRequest request) {
            return base.Channel.GetAll(request);
        }
        
        public Client.ServiceReference.GetAllResponseMessage GetAll(int page, int size) {
            Client.ServiceReference.GetAllRequest inValue = new Client.ServiceReference.GetAllRequest();
            inValue.Body = new Client.ServiceReference.GetAllRequestBody();
            inValue.Body.page = page;
            inValue.Body.size = size;
            Client.ServiceReference.GetAllResponse retVal = ((Client.ServiceReference.StockExchangeServiceSoap)(this)).GetAll(inValue);
            return retVal.Body.GetAllResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Client.ServiceReference.GetAllResponse> Client.ServiceReference.StockExchangeServiceSoap.GetAllAsync(Client.ServiceReference.GetAllRequest request) {
            return base.Channel.GetAllAsync(request);
        }
        
        public System.Threading.Tasks.Task<Client.ServiceReference.GetAllResponse> GetAllAsync(int page, int size) {
            Client.ServiceReference.GetAllRequest inValue = new Client.ServiceReference.GetAllRequest();
            inValue.Body = new Client.ServiceReference.GetAllRequestBody();
            inValue.Body.page = page;
            inValue.Body.size = size;
            return ((Client.ServiceReference.StockExchangeServiceSoap)(this)).GetAllAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Client.ServiceReference.GetByIdsResponse Client.ServiceReference.StockExchangeServiceSoap.GetByIds(Client.ServiceReference.GetByIdsRequest request) {
            return base.Channel.GetByIds(request);
        }
        
        public Client.ServiceReference.GetByIdsResponseMessage GetByIds(Client.ServiceReference.ArrayOfInt ids, int page, int size) {
            Client.ServiceReference.GetByIdsRequest inValue = new Client.ServiceReference.GetByIdsRequest();
            inValue.Body = new Client.ServiceReference.GetByIdsRequestBody();
            inValue.Body.ids = ids;
            inValue.Body.page = page;
            inValue.Body.size = size;
            Client.ServiceReference.GetByIdsResponse retVal = ((Client.ServiceReference.StockExchangeServiceSoap)(this)).GetByIds(inValue);
            return retVal.Body.GetByIdsResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Client.ServiceReference.GetByIdsResponse> Client.ServiceReference.StockExchangeServiceSoap.GetByIdsAsync(Client.ServiceReference.GetByIdsRequest request) {
            return base.Channel.GetByIdsAsync(request);
        }
        
        public System.Threading.Tasks.Task<Client.ServiceReference.GetByIdsResponse> GetByIdsAsync(Client.ServiceReference.ArrayOfInt ids, int page, int size) {
            Client.ServiceReference.GetByIdsRequest inValue = new Client.ServiceReference.GetByIdsRequest();
            inValue.Body = new Client.ServiceReference.GetByIdsRequestBody();
            inValue.Body.ids = ids;
            inValue.Body.page = page;
            inValue.Body.size = size;
            return ((Client.ServiceReference.StockExchangeServiceSoap)(this)).GetByIdsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Client.ServiceReference.GetByIdResponse Client.ServiceReference.StockExchangeServiceSoap.GetById(Client.ServiceReference.GetByIdRequest request) {
            return base.Channel.GetById(request);
        }
        
        public Client.ServiceReference.GetByIdResponseMessage GetById(int id) {
            Client.ServiceReference.GetByIdRequest inValue = new Client.ServiceReference.GetByIdRequest();
            inValue.Body = new Client.ServiceReference.GetByIdRequestBody();
            inValue.Body.id = id;
            Client.ServiceReference.GetByIdResponse retVal = ((Client.ServiceReference.StockExchangeServiceSoap)(this)).GetById(inValue);
            return retVal.Body.GetByIdResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Client.ServiceReference.GetByIdResponse> Client.ServiceReference.StockExchangeServiceSoap.GetByIdAsync(Client.ServiceReference.GetByIdRequest request) {
            return base.Channel.GetByIdAsync(request);
        }
        
        public System.Threading.Tasks.Task<Client.ServiceReference.GetByIdResponse> GetByIdAsync(int id) {
            Client.ServiceReference.GetByIdRequest inValue = new Client.ServiceReference.GetByIdRequest();
            inValue.Body = new Client.ServiceReference.GetByIdRequestBody();
            inValue.Body.id = id;
            return ((Client.ServiceReference.StockExchangeServiceSoap)(this)).GetByIdAsync(inValue);
        }
    }
}