﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace shopGuru_android.WebService {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="shopGuru_webServiceSoap", Namespace="http://tempuri.org/")]
    public partial class shopGuru_webService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback LoginOperationCompleted;
        
        private System.Threading.SendOrPostCallback RegisterOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetPriceOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetItemOperationCompleted;
        
        private System.Threading.SendOrPostCallback CompareItemListOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetPricesOperationCompleted;
        
        private System.Threading.SendOrPostCallback FillLotteryFormOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public shopGuru_webService() {
            this.Url = "http://shopguruwebservice.azurewebsites.net/shopGuru_webService.asmx";
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event LoginCompletedEventHandler LoginCompleted;
        
        /// <remarks/>
        public event RegisterCompletedEventHandler RegisterCompleted;
        
        /// <remarks/>
        public event GetPriceCompletedEventHandler GetPriceCompleted;
        
        /// <remarks/>
        public event GetItemCompletedEventHandler GetItemCompleted;
        
        /// <remarks/>
        public event CompareItemListCompletedEventHandler CompareItemListCompleted;
        
        /// <remarks/>
        public event GetPricesCompletedEventHandler GetPricesCompleted;
        
        /// <remarks/>
        public event FillLotteryFormCompletedEventHandler FillLotteryFormCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Login", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool Login(string username, string password) {
            object[] results = this.Invoke("Login", new object[] {
                        username,
                        password});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void LoginAsync(string username, string password) {
            this.LoginAsync(username, password, null);
        }
        
        /// <remarks/>
        public void LoginAsync(string username, string password, object userState) {
            if ((this.LoginOperationCompleted == null)) {
                this.LoginOperationCompleted = new System.Threading.SendOrPostCallback(this.OnLoginOperationCompleted);
            }
            this.InvokeAsync("Login", new object[] {
                        username,
                        password}, this.LoginOperationCompleted, userState);
        }
        
        private void OnLoginOperationCompleted(object arg) {
            if ((this.LoginCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.LoginCompleted(this, new LoginCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Register", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool Register(string username, string password, string email, string number) {
            object[] results = this.Invoke("Register", new object[] {
                        username,
                        password,
                        email,
                        number});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void RegisterAsync(string username, string password, string email, string number) {
            this.RegisterAsync(username, password, email, number, null);
        }
        
        /// <remarks/>
        public void RegisterAsync(string username, string password, string email, string number, object userState) {
            if ((this.RegisterOperationCompleted == null)) {
                this.RegisterOperationCompleted = new System.Threading.SendOrPostCallback(this.OnRegisterOperationCompleted);
            }
            this.InvokeAsync("Register", new object[] {
                        username,
                        password,
                        email,
                        number}, this.RegisterOperationCompleted, userState);
        }
        
        private void OnRegisterOperationCompleted(object arg) {
            if ((this.RegisterCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.RegisterCompleted(this, new RegisterCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetPrice", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public decimal GetPrice(string name, string shop) {
            object[] results = this.Invoke("GetPrice", new object[] {
                        name,
                        shop});
            return ((decimal)(results[0]));
        }
        
        /// <remarks/>
        public void GetPriceAsync(string name, string shop) {
            this.GetPriceAsync(name, shop, null);
        }
        
        /// <remarks/>
        public void GetPriceAsync(string name, string shop, object userState) {
            if ((this.GetPriceOperationCompleted == null)) {
                this.GetPriceOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetPriceOperationCompleted);
            }
            this.InvokeAsync("GetPrice", new object[] {
                        name,
                        shop}, this.GetPriceOperationCompleted, userState);
        }
        
        private void OnGetPriceOperationCompleted(object arg) {
            if ((this.GetPriceCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetPriceCompleted(this, new GetPriceCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetItem", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public ItemPrice GetItem(string label) {
            object[] results = this.Invoke("GetItem", new object[] {
                        label});
            return ((ItemPrice)(results[0]));
        }
        
        /// <remarks/>
        public void GetItemAsync(string label) {
            this.GetItemAsync(label, null);
        }
        
        /// <remarks/>
        public void GetItemAsync(string label, object userState) {
            if ((this.GetItemOperationCompleted == null)) {
                this.GetItemOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetItemOperationCompleted);
            }
            this.InvokeAsync("GetItem", new object[] {
                        label}, this.GetItemOperationCompleted, userState);
        }
        
        private void OnGetItemOperationCompleted(object arg) {
            if ((this.GetItemCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetItemCompleted(this, new GetItemCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/CompareItemList", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public ItemPrice[] CompareItemList([System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)] ItemPrice[] list, int precision) {
            object[] results = this.Invoke("CompareItemList", new object[] {
                        list,
                        precision});
            return ((ItemPrice[])(results[0]));
        }
        
        /// <remarks/>
        public void CompareItemListAsync(ItemPrice[] list, int precision) {
            this.CompareItemListAsync(list, precision, null);
        }
        
        /// <remarks/>
        public void CompareItemListAsync(ItemPrice[] list, int precision, object userState) {
            if ((this.CompareItemListOperationCompleted == null)) {
                this.CompareItemListOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCompareItemListOperationCompleted);
            }
            this.InvokeAsync("CompareItemList", new object[] {
                        list,
                        precision}, this.CompareItemListOperationCompleted, userState);
        }
        
        private void OnCompareItemListOperationCompleted(object arg) {
            if ((this.CompareItemListCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CompareItemListCompleted(this, new CompareItemListCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetPrices", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public ItemPrice GetPrices(string label) {
            object[] results = this.Invoke("GetPrices", new object[] {
                        label});
            return ((ItemPrice)(results[0]));
        }
        
        /// <remarks/>
        public void GetPricesAsync(string label) {
            this.GetPricesAsync(label, null);
        }
        
        /// <remarks/>
        public void GetPricesAsync(string label, object userState) {
            if ((this.GetPricesOperationCompleted == null)) {
                this.GetPricesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetPricesOperationCompleted);
            }
            this.InvokeAsync("GetPrices", new object[] {
                        label}, this.GetPricesOperationCompleted, userState);
        }
        
        private void OnGetPricesOperationCompleted(object arg) {
            if ((this.GetPricesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetPricesCompleted(this, new GetPricesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/FillLotteryForm", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string FillLotteryForm([System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")] byte[] bytes) {
            object[] results = this.Invoke("FillLotteryForm", new object[] {
                        bytes});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void FillLotteryFormAsync(byte[] bytes) {
            this.FillLotteryFormAsync(bytes, null);
        }
        
        /// <remarks/>
        public void FillLotteryFormAsync(byte[] bytes, object userState) {
            if ((this.FillLotteryFormOperationCompleted == null)) {
                this.FillLotteryFormOperationCompleted = new System.Threading.SendOrPostCallback(this.OnFillLotteryFormOperationCompleted);
            }
            this.InvokeAsync("FillLotteryForm", new object[] {
                        bytes}, this.FillLotteryFormOperationCompleted, userState);
        }
        
        private void OnFillLotteryFormOperationCompleted(object arg) {
            if ((this.FillLotteryFormCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.FillLotteryFormCompleted(this, new FillLotteryFormCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2556.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class ItemPrice {
        
        private string nameField;
        
        private bool weightableField;
        
        private decimal ikiField;
        
        private decimal maximaField;
        
        private decimal rimiField;
        
        /// <remarks/>
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public bool weightable {
            get {
                return this.weightableField;
            }
            set {
                this.weightableField = value;
            }
        }
        
        /// <remarks/>
        public decimal iki {
            get {
                return this.ikiField;
            }
            set {
                this.ikiField = value;
            }
        }
        
        /// <remarks/>
        public decimal maxima {
            get {
                return this.maximaField;
            }
            set {
                this.maximaField = value;
            }
        }
        
        /// <remarks/>
        public decimal rimi {
            get {
                return this.rimiField;
            }
            set {
                this.rimiField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    public delegate void LoginCompletedEventHandler(object sender, LoginCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoginCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal LoginCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    public delegate void RegisterCompletedEventHandler(object sender, RegisterCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class RegisterCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal RegisterCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    public delegate void GetPriceCompletedEventHandler(object sender, GetPriceCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetPriceCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetPriceCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public decimal Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((decimal)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    public delegate void GetItemCompletedEventHandler(object sender, GetItemCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetItemCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetItemCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public ItemPrice Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((ItemPrice)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    public delegate void CompareItemListCompletedEventHandler(object sender, CompareItemListCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CompareItemListCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal CompareItemListCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public ItemPrice[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((ItemPrice[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    public delegate void GetPricesCompletedEventHandler(object sender, GetPricesCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetPricesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetPricesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public ItemPrice Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((ItemPrice)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    public delegate void FillLotteryFormCompletedEventHandler(object sender, FillLotteryFormCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class FillLotteryFormCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal FillLotteryFormCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591