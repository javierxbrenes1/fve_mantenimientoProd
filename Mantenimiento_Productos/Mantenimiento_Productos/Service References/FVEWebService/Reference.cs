﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mantenimiento_Productos.FVEWebService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="urn:WebServiceFVEwsdl", ConfigurationName="FVEWebService.FVEWebServicePortType")]
    public interface FVEWebServicePortType {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/WS/WebServiceFVE.php/foObtenerProductos", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        string foObtenerProductos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/WS/WebServiceFVE.php/foObtenerProductos", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<string> foObtenerProductosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/WS/WebServiceFVE.php/foObtenerTiposProducto", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        string foObtenerTiposProducto();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/WS/WebServiceFVE.php/foObtenerTiposProducto", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<string> foObtenerTiposProductoAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/WS/WebServiceFVE.php/foBuscarProducto", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="vloProducto")]
        Mantenimiento_Productos.FVEWebService.Productos foBuscarProducto(int prod_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/WS/WebServiceFVE.php/foBuscarProducto", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="vloProducto")]
        System.Threading.Tasks.Task<Mantenimiento_Productos.FVEWebService.Productos> foBuscarProductoAsync(int prod_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/WS/WebServiceFVE.php/foActualizarProducto", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        string foActualizarProducto(Mantenimiento_Productos.FVEWebService.Productos vloProducto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/WS/WebServiceFVE.php/foActualizarProducto", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<string> foActualizarProductoAsync(Mantenimiento_Productos.FVEWebService.Productos vloProducto);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="urn:WebServiceFVEwsdl")]
    public partial class Productos : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int prod_idField;
        
        private int tip_prod_idField;
        
        private string prod_nomField;
        
        private string prod_descField;
        
        private float prod_prc_actField;
        
        private string prod_fec_cmb_prcField;
        
        private int prod_stsField;
        
        private int prod_prmField;
        
        private string prod_rut_imgField;
        
        private string prod_unit_medField;
        
        /// <remarks/>
        public int prod_id {
            get {
                return this.prod_idField;
            }
            set {
                this.prod_idField = value;
                this.RaisePropertyChanged("prod_id");
            }
        }
        
        /// <remarks/>
        public int tip_prod_id {
            get {
                return this.tip_prod_idField;
            }
            set {
                this.tip_prod_idField = value;
                this.RaisePropertyChanged("tip_prod_id");
            }
        }
        
        /// <remarks/>
        public string prod_nom {
            get {
                return this.prod_nomField;
            }
            set {
                this.prod_nomField = value;
                this.RaisePropertyChanged("prod_nom");
            }
        }
        
        /// <remarks/>
        public string prod_desc {
            get {
                return this.prod_descField;
            }
            set {
                this.prod_descField = value;
                this.RaisePropertyChanged("prod_desc");
            }
        }
        
        /// <remarks/>
        public float prod_prc_act {
            get {
                return this.prod_prc_actField;
            }
            set {
                this.prod_prc_actField = value;
                this.RaisePropertyChanged("prod_prc_act");
            }
        }
        
        /// <remarks/>
        public string prod_fec_cmb_prc {
            get {
                return this.prod_fec_cmb_prcField;
            }
            set {
                this.prod_fec_cmb_prcField = value;
                this.RaisePropertyChanged("prod_fec_cmb_prc");
            }
        }
        
        /// <remarks/>
        public int prod_sts {
            get {
                return this.prod_stsField;
            }
            set {
                this.prod_stsField = value;
                this.RaisePropertyChanged("prod_sts");
            }
        }
        
        /// <remarks/>
        public int prod_prm {
            get {
                return this.prod_prmField;
            }
            set {
                this.prod_prmField = value;
                this.RaisePropertyChanged("prod_prm");
            }
        }
        
        /// <remarks/>
        public string prod_rut_img {
            get {
                return this.prod_rut_imgField;
            }
            set {
                this.prod_rut_imgField = value;
                this.RaisePropertyChanged("prod_rut_img");
            }
        }
        
        /// <remarks/>
        public string prod_unit_med {
            get {
                return this.prod_unit_medField;
            }
            set {
                this.prod_unit_medField = value;
                this.RaisePropertyChanged("prod_unit_med");
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
    public interface FVEWebServicePortTypeChannel : Mantenimiento_Productos.FVEWebService.FVEWebServicePortType, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FVEWebServicePortTypeClient : System.ServiceModel.ClientBase<Mantenimiento_Productos.FVEWebService.FVEWebServicePortType>, Mantenimiento_Productos.FVEWebService.FVEWebServicePortType {
        
        public FVEWebServicePortTypeClient() {
        }
        
        public FVEWebServicePortTypeClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FVEWebServicePortTypeClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FVEWebServicePortTypeClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FVEWebServicePortTypeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string foObtenerProductos() {
            return base.Channel.foObtenerProductos();
        }
        
        public System.Threading.Tasks.Task<string> foObtenerProductosAsync() {
            return base.Channel.foObtenerProductosAsync();
        }
        
        public string foObtenerTiposProducto() {
            return base.Channel.foObtenerTiposProducto();
        }
        
        public System.Threading.Tasks.Task<string> foObtenerTiposProductoAsync() {
            return base.Channel.foObtenerTiposProductoAsync();
        }
        
        public Mantenimiento_Productos.FVEWebService.Productos foBuscarProducto(int prod_id) {
            return base.Channel.foBuscarProducto(prod_id);
        }
        
        public System.Threading.Tasks.Task<Mantenimiento_Productos.FVEWebService.Productos> foBuscarProductoAsync(int prod_id) {
            return base.Channel.foBuscarProductoAsync(prod_id);
        }
        
        public string foActualizarProducto(Mantenimiento_Productos.FVEWebService.Productos vloProducto) {
            return base.Channel.foActualizarProducto(vloProducto);
        }
        
        public System.Threading.Tasks.Task<string> foActualizarProductoAsync(Mantenimiento_Productos.FVEWebService.Productos vloProducto) {
            return base.Channel.foActualizarProductoAsync(vloProducto);
        }
    }
}
