﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mantenimiento_Productos.mierda {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="urn:pruebawsdl", ConfigurationName="mierda.pruebaPortType")]
    public interface pruebaPortType {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/WS/pruebaWS.php/foObtenerProductos", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        string foObtenerProductos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/WS/pruebaWS.php/foObtenerProductos", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<string> foObtenerProductosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/WS/pruebaWS.php/foObtenerTiposProducto", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        string foObtenerTiposProducto();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/WS/pruebaWS.php/foObtenerTiposProducto", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<string> foObtenerTiposProductoAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface pruebaPortTypeChannel : Mantenimiento_Productos.mierda.pruebaPortType, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class pruebaPortTypeClient : System.ServiceModel.ClientBase<Mantenimiento_Productos.mierda.pruebaPortType>, Mantenimiento_Productos.mierda.pruebaPortType {
        
        public pruebaPortTypeClient() {
        }
        
        public pruebaPortTypeClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public pruebaPortTypeClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public pruebaPortTypeClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public pruebaPortTypeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
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
    }
}
