﻿using System;
using System.Web.Services;
using System.Diagnostics;
using System.Web.Services.Protocols;
using System.Xml.Serialization;
using System.ComponentModel;

using System.Text;
using System.Xml.Linq;
using System.IO;
using System.Configuration;
using RestSharp;

namespace CDiscountApiLib
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name = "BasicHttpBinding_IMarketplaceAPIService", Namespace = "http://tempuri.org/")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DiscussionFilterBase))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DiscussionThreadBase))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ServiceMessage))]
    public partial class MarketplaceAPIService : System.Web.Services.Protocols.SoapHttpClientProtocol
    {

        public string GetToken(string userName, string password)
        {
            var client = new RestClient("https://sts.cdiscount.com/users/httpIssue.svc/?realm=https%3A%2F%2Fwsvc.cdiscount.com%2FMarketplaceAPIService.svc");
            var request = new RestRequest(Method.GET);
            request.AddHeader("cache-control", "no-cache");
            string svcCredentials = Convert.ToBase64String(ASCIIEncoding.ASCII.GetBytes(userName + ":" + password));

            request.AddHeader("Authorization", "Basic " + svcCredentials);
            request.AddHeader("content-type", "application/json");
            // request.AddParameter("application/json", "{\"id\":3,\"name\":\"Test\",\"age\":23}", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            XElement element = XElement.Load(new StringReader(response.Content));
            return element.Value;
           // return null;
        }
        private System.Threading.SendOrPostCallback GetProductListOperationCompleted;

        private System.Threading.SendOrPostCallback SubmitProductPackageOperationCompleted;

        private System.Threading.SendOrPostCallback GetProductPackageSubmissionResultOperationCompleted;

        private System.Threading.SendOrPostCallback GetProductPackageProductMatchingFileDataOperationCompleted;

        private System.Threading.SendOrPostCallback GetAllowedCategoryTreeOperationCompleted;

        private System.Threading.SendOrPostCallback GetAllAllowedCategoryTreeOperationCompleted;

        private System.Threading.SendOrPostCallback GetModelListOperationCompleted;

        private System.Threading.SendOrPostCallback GetAllModelListOperationCompleted;

        private System.Threading.SendOrPostCallback GetBrandListOperationCompleted;

        private System.Threading.SendOrPostCallback GetProductListByIdentifierOperationCompleted;

        private System.Threading.SendOrPostCallback SubmitOfferPackageOperationCompleted;

        private System.Threading.SendOrPostCallback GetOfferPackageSubmissionResultOperationCompleted;

        private System.Threading.SendOrPostCallback GetOfferListOperationCompleted;

        private System.Threading.SendOrPostCallback GetOfferListPaginatedOperationCompleted;

        private System.Threading.SendOrPostCallback GetSellerInformationOperationCompleted;

        private System.Threading.SendOrPostCallback GetSellerIndicatorsOperationCompleted;

        private System.Threading.SendOrPostCallback GetOrderListOperationCompleted;

        private System.Threading.SendOrPostCallback GetServiceOrderListOperationCompleted;

        private System.Threading.SendOrPostCallback ValidateOrderListOperationCompleted;

        private System.Threading.SendOrPostCallback ManageParcelOperationCompleted;

        private System.Threading.SendOrPostCallback CreateRefundVoucherAfterShipmentOperationCompleted;

        private System.Threading.SendOrPostCallback CreateRefundVoucherOperationCompleted;

        private System.Threading.SendOrPostCallback GetGlobalConfigurationOperationCompleted;

        private System.Threading.SendOrPostCallback GenerateDiscussionMailGuidOperationCompleted;

        private System.Threading.SendOrPostCallback SubmitRelaysFileOperationCompleted;

        private System.Threading.SendOrPostCallback GetRelaysFileSubmissionResultOperationCompleted;

        private System.Threading.SendOrPostCallback GetParcelShopListOperationCompleted;

        private System.Threading.SendOrPostCallback CloseDiscussionListOperationCompleted;

        private System.Threading.SendOrPostCallback GetOrderClaimListOperationCompleted;

        private System.Threading.SendOrPostCallback GetOrderQuestionListOperationCompleted;

        private System.Threading.SendOrPostCallback GetOfferQuestionListOperationCompleted;

        private System.Threading.SendOrPostCallback GetDiscussionMailListOperationCompleted;

        private System.Threading.SendOrPostCallback CreateExternalOrderOperationCompleted;

        private System.Threading.SendOrPostCallback GetExternalOrderStatusOperationCompleted;

        private System.Threading.SendOrPostCallback GetProductStockListOperationCompleted;

        private System.Threading.SendOrPostCallback GetFulfilmentActivationReportListOperationCompleted;

        private System.Threading.SendOrPostCallback GetFulfilmentOrderListToSupplyOperationCompleted;

        private System.Threading.SendOrPostCallback SubmitFulfilmentSupplyOrderOperationCompleted;

        private System.Threading.SendOrPostCallback SubmitFulfilmentOnDemandSupplyOrderOperationCompleted;

        private System.Threading.SendOrPostCallback GetFulfilmentDeliveryDocumentOperationCompleted;

        private System.Threading.SendOrPostCallback SubmitOfferStateActionOperationCompleted;

        private System.Threading.SendOrPostCallback GetFulfilmentSupplyOrderOperationCompleted;

        private System.Threading.SendOrPostCallback SubmitFulfilmentActivationOperationCompleted;

        private System.Threading.SendOrPostCallback GetFulfilmentSupplyOrderReportListOperationCompleted;

        private bool useDefaultCredentialsSetExplicitly;

        /// <remarks/>
        public MarketplaceAPIService()
        {
            this.Url = ConfigurationSettings.AppSettings["Url"];
            if ((this.IsLocalFileSystemWebService(this.Url) == true))
            {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else
            {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }

        public new string Url
        {
            get
            {
                return base.Url;
            }
            set
            {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true)
                            && (this.useDefaultCredentialsSetExplicitly == false))
                            && (this.IsLocalFileSystemWebService(value) == false)))
                {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }

        public new bool UseDefaultCredentials
        {
            get
            {
                return base.UseDefaultCredentials;
            }
            set
            {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }

        /// <remarks/>
        public event GetProductListCompletedEventHandler GetProductListCompleted;

        /// <remarks/>
        public event SubmitProductPackageCompletedEventHandler SubmitProductPackageCompleted;

        /// <remarks/>
        public event GetProductPackageSubmissionResultCompletedEventHandler GetProductPackageSubmissionResultCompleted;

        /// <remarks/>
        public event GetProductPackageProductMatchingFileDataCompletedEventHandler GetProductPackageProductMatchingFileDataCompleted;

        /// <remarks/>
        public event GetAllowedCategoryTreeCompletedEventHandler GetAllowedCategoryTreeCompleted;

        /// <remarks/>
        public event GetAllAllowedCategoryTreeCompletedEventHandler GetAllAllowedCategoryTreeCompleted;

        /// <remarks/>
        public event GetModelListCompletedEventHandler GetModelListCompleted;

        /// <remarks/>
        public event GetAllModelListCompletedEventHandler GetAllModelListCompleted;

        /// <remarks/>
        public event GetBrandListCompletedEventHandler GetBrandListCompleted;

        /// <remarks/>
        public event GetProductListByIdentifierCompletedEventHandler GetProductListByIdentifierCompleted;

        /// <remarks/>
        public event SubmitOfferPackageCompletedEventHandler SubmitOfferPackageCompleted;

        /// <remarks/>
        public event GetOfferPackageSubmissionResultCompletedEventHandler GetOfferPackageSubmissionResultCompleted;

        /// <remarks/>
        public event GetOfferListCompletedEventHandler GetOfferListCompleted;

        /// <remarks/>
        public event GetOfferListPaginatedCompletedEventHandler GetOfferListPaginatedCompleted;

        /// <remarks/>
        public event GetSellerInformationCompletedEventHandler GetSellerInformationCompleted;

        /// <remarks/>
        public event GetSellerIndicatorsCompletedEventHandler GetSellerIndicatorsCompleted;

        /// <remarks/>
        public event GetOrderListCompletedEventHandler GetOrderListCompleted;

        /// <remarks/>
        public event GetServiceOrderListCompletedEventHandler GetServiceOrderListCompleted;

        /// <remarks/>
        public event ValidateOrderListCompletedEventHandler ValidateOrderListCompleted;

        /// <remarks/>
        public event ManageParcelCompletedEventHandler ManageParcelCompleted;

        /// <remarks/>
        public event CreateRefundVoucherAfterShipmentCompletedEventHandler CreateRefundVoucherAfterShipmentCompleted;

        /// <remarks/>
        public event CreateRefundVoucherCompletedEventHandler CreateRefundVoucherCompleted;

        /// <remarks/>
        public event GetGlobalConfigurationCompletedEventHandler GetGlobalConfigurationCompleted;

        /// <remarks/>
        public event GenerateDiscussionMailGuidCompletedEventHandler GenerateDiscussionMailGuidCompleted;

        /// <remarks/>
        public event SubmitRelaysFileCompletedEventHandler SubmitRelaysFileCompleted;

        /// <remarks/>
        public event GetRelaysFileSubmissionResultCompletedEventHandler GetRelaysFileSubmissionResultCompleted;

        /// <remarks/>
        public event GetParcelShopListCompletedEventHandler GetParcelShopListCompleted;

        /// <remarks/>
        public event CloseDiscussionListCompletedEventHandler CloseDiscussionListCompleted;

        /// <remarks/>
        public event GetOrderClaimListCompletedEventHandler GetOrderClaimListCompleted;

        /// <remarks/>
        public event GetOrderQuestionListCompletedEventHandler GetOrderQuestionListCompleted;

        /// <remarks/>
        public event GetOfferQuestionListCompletedEventHandler GetOfferQuestionListCompleted;

        /// <remarks/>
        public event GetDiscussionMailListCompletedEventHandler GetDiscussionMailListCompleted;

        /// <remarks/>
        public event CreateExternalOrderCompletedEventHandler CreateExternalOrderCompleted;

        /// <remarks/>
        public event GetExternalOrderStatusCompletedEventHandler GetExternalOrderStatusCompleted;

        /// <remarks/>
        public event GetProductStockListCompletedEventHandler GetProductStockListCompleted;

        /// <remarks/>
        public event GetFulfilmentActivationReportListCompletedEventHandler GetFulfilmentActivationReportListCompleted;

        /// <remarks/>
        public event GetFulfilmentOrderListToSupplyCompletedEventHandler GetFulfilmentOrderListToSupplyCompleted;

        /// <remarks/>
        public event SubmitFulfilmentSupplyOrderCompletedEventHandler SubmitFulfilmentSupplyOrderCompleted;

        /// <remarks/>
        public event SubmitFulfilmentOnDemandSupplyOrderCompletedEventHandler SubmitFulfilmentOnDemandSupplyOrderCompleted;

        /// <remarks/>
        public event GetFulfilmentDeliveryDocumentCompletedEventHandler GetFulfilmentDeliveryDocumentCompleted;

        /// <remarks/>
        public event SubmitOfferStateActionCompletedEventHandler SubmitOfferStateActionCompleted;

        /// <remarks/>
        public event GetFulfilmentSupplyOrderCompletedEventHandler GetFulfilmentSupplyOrderCompleted;

        /// <remarks/>
        public event SubmitFulfilmentActivationCompletedEventHandler SubmitFulfilmentActivationCompleted;

        /// <remarks/>
        public event GetFulfilmentSupplyOrderReportListCompletedEventHandler GetFulfilmentSupplyOrderReportListCompleted;

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.cdiscount.com/IMarketplaceAPIService/GetProductList", RequestNamespace = "http://www.cdiscount.com", ResponseNamespace = "http://www.cdiscount.com", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public ProductListMessage GetProductList([System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] HeaderMessage headerMessage, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] ProductFilter productFilter)
        {
            object[] results = this.Invoke("GetProductList", new object[] {
                        headerMessage,
                        productFilter});
            return ((ProductListMessage)(results[0]));
        }

        /// <remarks/>
        public void GetProductListAsync(HeaderMessage headerMessage, ProductFilter productFilter)
        {
            this.GetProductListAsync(headerMessage, productFilter, null);
        }

        /// <remarks/>
        public void GetProductListAsync(HeaderMessage headerMessage, ProductFilter productFilter, object userState)
        {
            if ((this.GetProductListOperationCompleted == null))
            {
                this.GetProductListOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetProductListOperationCompleted);
            }
            this.InvokeAsync("GetProductList", new object[] {
                        headerMessage,
                        productFilter}, this.GetProductListOperationCompleted, userState);
        }

        private void OnGetProductListOperationCompleted(object arg)
        {
            if ((this.GetProductListCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetProductListCompleted(this, new GetProductListCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.cdiscount.com/IMarketplaceAPIService/SubmitProductPackage", RequestNamespace = "http://www.cdiscount.com", ResponseNamespace = "http://www.cdiscount.com", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public ProductIntegrationReportMessage SubmitProductPackage([System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] HeaderMessage headerMessage, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] ProductPackageRequest productPackageRequest)
        {
            object[] results = this.Invoke("SubmitProductPackage", new object[] {
                        headerMessage,
                        productPackageRequest});
            return ((ProductIntegrationReportMessage)(results[0]));
        }

        /// <remarks/>
        public void SubmitProductPackageAsync(HeaderMessage headerMessage, ProductPackageRequest productPackageRequest)
        {
            this.SubmitProductPackageAsync(headerMessage, productPackageRequest, null);
        }

        /// <remarks/>
        public void SubmitProductPackageAsync(HeaderMessage headerMessage, ProductPackageRequest productPackageRequest, object userState)
        {
            if ((this.SubmitProductPackageOperationCompleted == null))
            {
                this.SubmitProductPackageOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSubmitProductPackageOperationCompleted);
            }
            this.InvokeAsync("SubmitProductPackage", new object[] {
                        headerMessage,
                        productPackageRequest}, this.SubmitProductPackageOperationCompleted, userState);
        }

        private void OnSubmitProductPackageOperationCompleted(object arg)
        {
            if ((this.SubmitProductPackageCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SubmitProductPackageCompleted(this, new SubmitProductPackageCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.cdiscount.com/IMarketplaceAPIService/GetProductPackageSubmissionResult" +
            "", RequestNamespace = "http://www.cdiscount.com", ResponseNamespace = "http://www.cdiscount.com", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public ProductIntegrationReportMessage GetProductPackageSubmissionResult([System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] HeaderMessage headerMessage, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] PackageFilter productPackageFilter)
        {
            object[] results = this.Invoke("GetProductPackageSubmissionResult", new object[] {
                        headerMessage,
                        productPackageFilter});
            return ((ProductIntegrationReportMessage)(results[0]));
        }

        /// <remarks/>
        public void GetProductPackageSubmissionResultAsync(HeaderMessage headerMessage, PackageFilter productPackageFilter)
        {
            this.GetProductPackageSubmissionResultAsync(headerMessage, productPackageFilter, null);
        }

        /// <remarks/>
        public void GetProductPackageSubmissionResultAsync(HeaderMessage headerMessage, PackageFilter productPackageFilter, object userState)
        {
            if ((this.GetProductPackageSubmissionResultOperationCompleted == null))
            {
                this.GetProductPackageSubmissionResultOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetProductPackageSubmissionResultOperationCompleted);
            }
            this.InvokeAsync("GetProductPackageSubmissionResult", new object[] {
                        headerMessage,
                        productPackageFilter}, this.GetProductPackageSubmissionResultOperationCompleted, userState);
        }

        private void OnGetProductPackageSubmissionResultOperationCompleted(object arg)
        {
            if ((this.GetProductPackageSubmissionResultCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetProductPackageSubmissionResultCompleted(this, new GetProductPackageSubmissionResultCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.cdiscount.com/IMarketplaceAPIService/GetProductPackageProductMatchingF" +
            "ileData", RequestNamespace = "http://www.cdiscount.com", ResponseNamespace = "http://www.cdiscount.com", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public ProductMatchingFileMessage GetProductPackageProductMatchingFileData([System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] HeaderMessage headerMessage, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] PackageFilter productPackageFilter)
        {
            object[] results = this.Invoke("GetProductPackageProductMatchingFileData", new object[] {
                        headerMessage,
                        productPackageFilter});
            return ((ProductMatchingFileMessage)(results[0]));
        }

        /// <remarks/>
        public void GetProductPackageProductMatchingFileDataAsync(HeaderMessage headerMessage, PackageFilter productPackageFilter)
        {
            this.GetProductPackageProductMatchingFileDataAsync(headerMessage, productPackageFilter, null);
        }

        /// <remarks/>
        public void GetProductPackageProductMatchingFileDataAsync(HeaderMessage headerMessage, PackageFilter productPackageFilter, object userState)
        {
            if ((this.GetProductPackageProductMatchingFileDataOperationCompleted == null))
            {
                this.GetProductPackageProductMatchingFileDataOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetProductPackageProductMatchingFileDataOperationCompleted);
            }
            this.InvokeAsync("GetProductPackageProductMatchingFileData", new object[] {
                        headerMessage,
                        productPackageFilter}, this.GetProductPackageProductMatchingFileDataOperationCompleted, userState);
        }

        private void OnGetProductPackageProductMatchingFileDataOperationCompleted(object arg)
        {
            if ((this.GetProductPackageProductMatchingFileDataCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetProductPackageProductMatchingFileDataCompleted(this, new GetProductPackageProductMatchingFileDataCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.cdiscount.com/IMarketplaceAPIService/GetAllowedCategoryTree", RequestNamespace = "http://www.cdiscount.com", ResponseNamespace = "http://www.cdiscount.com", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public CategoryTreeMessage GetAllowedCategoryTree([System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] HeaderMessage headerMessage)
        {
            object[] results = this.Invoke("GetAllowedCategoryTree", new object[] {
                        headerMessage});
            return ((CategoryTreeMessage)(results[0]));
        }

        /// <remarks/>
        public void GetAllowedCategoryTreeAsync(HeaderMessage headerMessage)
        {
            this.GetAllowedCategoryTreeAsync(headerMessage, null);
        }

        /// <remarks/>
        public void GetAllowedCategoryTreeAsync(HeaderMessage headerMessage, object userState)
        {
            if ((this.GetAllowedCategoryTreeOperationCompleted == null))
            {
                this.GetAllowedCategoryTreeOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetAllowedCategoryTreeOperationCompleted);
            }
            this.InvokeAsync("GetAllowedCategoryTree", new object[] {
                        headerMessage}, this.GetAllowedCategoryTreeOperationCompleted, userState);
        }

        private void OnGetAllowedCategoryTreeOperationCompleted(object arg)
        {
            if ((this.GetAllowedCategoryTreeCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetAllowedCategoryTreeCompleted(this, new GetAllowedCategoryTreeCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.cdiscount.com/IMarketplaceAPIService/GetAllAllowedCategoryTree", RequestNamespace = "http://www.cdiscount.com", ResponseNamespace = "http://www.cdiscount.com", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public CategoryTreeMessage GetAllAllowedCategoryTree([System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] HeaderMessage headerMessage)
        {
            object[] results = this.Invoke("GetAllAllowedCategoryTree", new object[] {
                        headerMessage});
            return ((CategoryTreeMessage)(results[0]));
        }

        /// <remarks/>
        public void GetAllAllowedCategoryTreeAsync(HeaderMessage headerMessage)
        {
            this.GetAllAllowedCategoryTreeAsync(headerMessage, null);
        }

        /// <remarks/>
        public void GetAllAllowedCategoryTreeAsync(HeaderMessage headerMessage, object userState)
        {
            if ((this.GetAllAllowedCategoryTreeOperationCompleted == null))
            {
                this.GetAllAllowedCategoryTreeOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetAllAllowedCategoryTreeOperationCompleted);
            }
            this.InvokeAsync("GetAllAllowedCategoryTree", new object[] {
                        headerMessage}, this.GetAllAllowedCategoryTreeOperationCompleted, userState);
        }

        private void OnGetAllAllowedCategoryTreeOperationCompleted(object arg)
        {
            if ((this.GetAllAllowedCategoryTreeCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetAllAllowedCategoryTreeCompleted(this, new GetAllAllowedCategoryTreeCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.cdiscount.com/IMarketplaceAPIService/GetModelList", RequestNamespace = "http://www.cdiscount.com", ResponseNamespace = "http://www.cdiscount.com", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public ProductModelListMessage GetModelList([System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] HeaderMessage headerMessage, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] ModelFilter modelFilter)
        {
            object[] results = this.Invoke("GetModelList", new object[] {
                        headerMessage,
                        modelFilter});
            return ((ProductModelListMessage)(results[0]));
        }

        /// <remarks/>
        public void GetModelListAsync(HeaderMessage headerMessage, ModelFilter modelFilter)
        {
            this.GetModelListAsync(headerMessage, modelFilter, null);
        }

        /// <remarks/>
        public void GetModelListAsync(HeaderMessage headerMessage, ModelFilter modelFilter, object userState)
        {
            if ((this.GetModelListOperationCompleted == null))
            {
                this.GetModelListOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetModelListOperationCompleted);
            }
            this.InvokeAsync("GetModelList", new object[] {
                        headerMessage,
                        modelFilter}, this.GetModelListOperationCompleted, userState);
        }

        private void OnGetModelListOperationCompleted(object arg)
        {
            if ((this.GetModelListCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetModelListCompleted(this, new GetModelListCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.cdiscount.com/IMarketplaceAPIService/GetAllModelList", RequestNamespace = "http://www.cdiscount.com", ResponseNamespace = "http://www.cdiscount.com", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public ProductModelListMessage GetAllModelList([System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] HeaderMessage headerMessage)
        {
            object[] results = this.Invoke("GetAllModelList", new object[] {
                        headerMessage});
            return ((ProductModelListMessage)(results[0]));
        }

        /// <remarks/>
        public void GetAllModelListAsync(HeaderMessage headerMessage)
        {
            this.GetAllModelListAsync(headerMessage, null);
        }

        /// <remarks/>
        public void GetAllModelListAsync(HeaderMessage headerMessage, object userState)
        {
            if ((this.GetAllModelListOperationCompleted == null))
            {
                this.GetAllModelListOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetAllModelListOperationCompleted);
            }
            this.InvokeAsync("GetAllModelList", new object[] {
                        headerMessage}, this.GetAllModelListOperationCompleted, userState);
        }

        private void OnGetAllModelListOperationCompleted(object arg)
        {
            if ((this.GetAllModelListCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetAllModelListCompleted(this, new GetAllModelListCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.cdiscount.com/IMarketplaceAPIService/GetBrandList", RequestNamespace = "http://www.cdiscount.com", ResponseNamespace = "http://www.cdiscount.com", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public BrandListMessage GetBrandList([System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] HeaderMessage headerMessage)
        {
            object[] results = this.Invoke("GetBrandList", new object[] {
                        headerMessage});
            return ((BrandListMessage)(results[0]));
        }

        /// <remarks/>
        public void GetBrandListAsync(HeaderMessage headerMessage)
        {
            this.GetBrandListAsync(headerMessage, null);
        }

        /// <remarks/>
        public void GetBrandListAsync(HeaderMessage headerMessage, object userState)
        {
            if ((this.GetBrandListOperationCompleted == null))
            {
                this.GetBrandListOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetBrandListOperationCompleted);
            }
            this.InvokeAsync("GetBrandList", new object[] {
                        headerMessage}, this.GetBrandListOperationCompleted, userState);
        }

        private void OnGetBrandListOperationCompleted(object arg)
        {
            if ((this.GetBrandListCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetBrandListCompleted(this, new GetBrandListCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.cdiscount.com/IMarketplaceAPIService/GetProductListByIdentifier", RequestNamespace = "http://www.cdiscount.com", ResponseNamespace = "http://www.cdiscount.com", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public ProductListByIdentifierMessage GetProductListByIdentifier([System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] HeaderMessage headerMessage, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] IdentifierRequest identifierRequest)
        {
            object[] results = this.Invoke("GetProductListByIdentifier", new object[] {
                        headerMessage,
                        identifierRequest});
            return ((ProductListByIdentifierMessage)(results[0]));
        }

        /// <remarks/>
        public void GetProductListByIdentifierAsync(HeaderMessage headerMessage, IdentifierRequest identifierRequest)
        {
            this.GetProductListByIdentifierAsync(headerMessage, identifierRequest, null);
        }

        /// <remarks/>
        public void GetProductListByIdentifierAsync(HeaderMessage headerMessage, IdentifierRequest identifierRequest, object userState)
        {
            if ((this.GetProductListByIdentifierOperationCompleted == null))
            {
                this.GetProductListByIdentifierOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetProductListByIdentifierOperationCompleted);
            }
            this.InvokeAsync("GetProductListByIdentifier", new object[] {
                        headerMessage,
                        identifierRequest}, this.GetProductListByIdentifierOperationCompleted, userState);
        }

        private void OnGetProductListByIdentifierOperationCompleted(object arg)
        {
            if ((this.GetProductListByIdentifierCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetProductListByIdentifierCompleted(this, new GetProductListByIdentifierCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.cdiscount.com/IMarketplaceAPIService/SubmitOfferPackage", RequestNamespace = "http://www.cdiscount.com", ResponseNamespace = "http://www.cdiscount.com", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public OfferIntegrationReportMessage SubmitOfferPackage([System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] HeaderMessage headerMessage, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] OfferPackageRequest offerPackageRequest)
        {
            object[] results = this.Invoke("SubmitOfferPackage", new object[] {
                        headerMessage,
                        offerPackageRequest});
            return ((OfferIntegrationReportMessage)(results[0]));
        }

        /// <remarks/>
        public void SubmitOfferPackageAsync(HeaderMessage headerMessage, OfferPackageRequest offerPackageRequest)
        {
            this.SubmitOfferPackageAsync(headerMessage, offerPackageRequest, null);
        }

        /// <remarks/>
        public void SubmitOfferPackageAsync(HeaderMessage headerMessage, OfferPackageRequest offerPackageRequest, object userState)
        {
            if ((this.SubmitOfferPackageOperationCompleted == null))
            {
                this.SubmitOfferPackageOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSubmitOfferPackageOperationCompleted);
            }
            this.InvokeAsync("SubmitOfferPackage", new object[] {
                        headerMessage,
                        offerPackageRequest}, this.SubmitOfferPackageOperationCompleted, userState);
        }

        private void OnSubmitOfferPackageOperationCompleted(object arg)
        {
            if ((this.SubmitOfferPackageCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SubmitOfferPackageCompleted(this, new SubmitOfferPackageCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.cdiscount.com/IMarketplaceAPIService/GetOfferPackageSubmissionResult", RequestNamespace = "http://www.cdiscount.com", ResponseNamespace = "http://www.cdiscount.com", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public OfferIntegrationReportMessage GetOfferPackageSubmissionResult([System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] HeaderMessage headerMessage, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] PackageFilter offerPackageFilter)
        {
            object[] results = this.Invoke("GetOfferPackageSubmissionResult", new object[] {
                        headerMessage,
                        offerPackageFilter});
            return ((OfferIntegrationReportMessage)(results[0]));
        }

        /// <remarks/>
        public void GetOfferPackageSubmissionResultAsync(HeaderMessage headerMessage, PackageFilter offerPackageFilter)
        {
            this.GetOfferPackageSubmissionResultAsync(headerMessage, offerPackageFilter, null);
        }

        /// <remarks/>
        public void GetOfferPackageSubmissionResultAsync(HeaderMessage headerMessage, PackageFilter offerPackageFilter, object userState)
        {
            if ((this.GetOfferPackageSubmissionResultOperationCompleted == null))
            {
                this.GetOfferPackageSubmissionResultOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetOfferPackageSubmissionResultOperationCompleted);
            }
            this.InvokeAsync("GetOfferPackageSubmissionResult", new object[] {
                        headerMessage,
                        offerPackageFilter}, this.GetOfferPackageSubmissionResultOperationCompleted, userState);
        }

        private void OnGetOfferPackageSubmissionResultOperationCompleted(object arg)
        {
            if ((this.GetOfferPackageSubmissionResultCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetOfferPackageSubmissionResultCompleted(this, new GetOfferPackageSubmissionResultCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.cdiscount.com/IMarketplaceAPIService/GetOfferList", RequestNamespace = "http://www.cdiscount.com", ResponseNamespace = "http://www.cdiscount.com", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public OfferListMessage GetOfferList([System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] HeaderMessage headerMessage, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] OfferFilter offerFilter)
        {
            object[] results = this.Invoke("GetOfferList", new object[] {
                        headerMessage,
                        offerFilter});
            return ((OfferListMessage)(results[0]));
        }

        /// <remarks/>
        public void GetOfferListAsync(HeaderMessage headerMessage, OfferFilter offerFilter)
        {
            this.GetOfferListAsync(headerMessage, offerFilter, null);
        }

        /// <remarks/>
        public void GetOfferListAsync(HeaderMessage headerMessage, OfferFilter offerFilter, object userState)
        {
            if ((this.GetOfferListOperationCompleted == null))
            {
                this.GetOfferListOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetOfferListOperationCompleted);
            }
            this.InvokeAsync("GetOfferList", new object[] {
                        headerMessage,
                        offerFilter}, this.GetOfferListOperationCompleted, userState);
        }

        private void OnGetOfferListOperationCompleted(object arg)
        {
            if ((this.GetOfferListCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetOfferListCompleted(this, new GetOfferListCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.cdiscount.com/IMarketplaceAPIService/GetOfferListPaginated", RequestNamespace = "http://www.cdiscount.com", ResponseNamespace = "http://www.cdiscount.com", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public OfferListPaginatedMessage GetOfferListPaginated([System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] HeaderMessage headerMessage, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] OfferFilterPaginated offerFilter)
        {
            object[] results = this.Invoke("GetOfferListPaginated", new object[] {
                        headerMessage,
                        offerFilter});
            return ((OfferListPaginatedMessage)(results[0]));
        }

        /// <remarks/>
        public void GetOfferListPaginatedAsync(HeaderMessage headerMessage, OfferFilterPaginated offerFilter)
        {
            this.GetOfferListPaginatedAsync(headerMessage, offerFilter, null);
        }

        /// <remarks/>
        public void GetOfferListPaginatedAsync(HeaderMessage headerMessage, OfferFilterPaginated offerFilter, object userState)
        {
            if ((this.GetOfferListPaginatedOperationCompleted == null))
            {
                this.GetOfferListPaginatedOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetOfferListPaginatedOperationCompleted);
            }
            this.InvokeAsync("GetOfferListPaginated", new object[] {
                        headerMessage,
                        offerFilter}, this.GetOfferListPaginatedOperationCompleted, userState);
        }

        private void OnGetOfferListPaginatedOperationCompleted(object arg)
        {
            if ((this.GetOfferListPaginatedCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetOfferListPaginatedCompleted(this, new GetOfferListPaginatedCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.cdiscount.com/IMarketplaceAPIService/GetSellerInformation", RequestNamespace = "http://www.cdiscount.com", ResponseNamespace = "http://www.cdiscount.com", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public SellerMessage GetSellerInformation([System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] HeaderMessage headerMessage)
        {
            object[] results = this.Invoke("GetSellerInformation", new object[] {
                        headerMessage});
            return ((SellerMessage)(results[0]));
        }

        /// <remarks/>
        public void GetSellerInformationAsync(HeaderMessage headerMessage)
        {
            this.GetSellerInformationAsync(headerMessage, null);
        }

        /// <remarks/>
        public void GetSellerInformationAsync(HeaderMessage headerMessage, object userState)
        {
            if ((this.GetSellerInformationOperationCompleted == null))
            {
                this.GetSellerInformationOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetSellerInformationOperationCompleted);
            }
            this.InvokeAsync("GetSellerInformation", new object[] {
                        headerMessage}, this.GetSellerInformationOperationCompleted, userState);
        }

        private void OnGetSellerInformationOperationCompleted(object arg)
        {
            if ((this.GetSellerInformationCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetSellerInformationCompleted(this, new GetSellerInformationCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.cdiscount.com/IMarketplaceAPIService/GetSellerIndicators", RequestNamespace = "http://www.cdiscount.com", ResponseNamespace = "http://www.cdiscount.com", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public SellerIndicatorsMessage GetSellerIndicators([System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] HeaderMessage headerMessage)
        {
            object[] results = this.Invoke("GetSellerIndicators", new object[] {
                        headerMessage});
            return ((SellerIndicatorsMessage)(results[0]));
        }

        /// <remarks/>
        public void GetSellerIndicatorsAsync(HeaderMessage headerMessage)
        {
            this.GetSellerIndicatorsAsync(headerMessage, null);
        }

        /// <remarks/>
        public void GetSellerIndicatorsAsync(HeaderMessage headerMessage, object userState)
        {
            if ((this.GetSellerIndicatorsOperationCompleted == null))
            {
                this.GetSellerIndicatorsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetSellerIndicatorsOperationCompleted);
            }
            this.InvokeAsync("GetSellerIndicators", new object[] {
                        headerMessage}, this.GetSellerIndicatorsOperationCompleted, userState);
        }

        private void OnGetSellerIndicatorsOperationCompleted(object arg)
        {
            if ((this.GetSellerIndicatorsCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetSellerIndicatorsCompleted(this, new GetSellerIndicatorsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.cdiscount.com/IMarketplaceAPIService/GetOrderList", RequestNamespace = "http://www.cdiscount.com", ResponseNamespace = "http://www.cdiscount.com", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public OrderListMessage GetOrderList([System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] HeaderMessage headerMessage, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] OrderFilter orderFilter)
        {
            object[] results = this.Invoke("GetOrderList", new object[] {
                        headerMessage,
                        orderFilter});
            return ((OrderListMessage)(results[0]));
        }

        /// <remarks/>
        public void GetOrderListAsync(HeaderMessage headerMessage, OrderFilter orderFilter)
        {
            this.GetOrderListAsync(headerMessage, orderFilter, null);
        }

        /// <remarks/>
        public void GetOrderListAsync(HeaderMessage headerMessage, OrderFilter orderFilter, object userState)
        {
            if ((this.GetOrderListOperationCompleted == null))
            {
                this.GetOrderListOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetOrderListOperationCompleted);
            }
            this.InvokeAsync("GetOrderList", new object[] {
                        headerMessage,
                        orderFilter}, this.GetOrderListOperationCompleted, userState);
        }

        private void OnGetOrderListOperationCompleted(object arg)
        {
            if ((this.GetOrderListCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetOrderListCompleted(this, new GetOrderListCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.cdiscount.com/IMarketplaceAPIService/GetServiceOrderList", RequestNamespace = "http://www.cdiscount.com", ResponseNamespace = "http://www.cdiscount.com", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public ServiceOrderListMessage GetServiceOrderList([System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] HeaderMessage headerMessage, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] OrderFilter orderFilter)
        {
            object[] results = this.Invoke("GetServiceOrderList", new object[] {
                        headerMessage,
                        orderFilter});
            return ((ServiceOrderListMessage)(results[0]));
        }

        /// <remarks/>
        public void GetServiceOrderListAsync(HeaderMessage headerMessage, OrderFilter orderFilter)
        {
            this.GetServiceOrderListAsync(headerMessage, orderFilter, null);
        }

        /// <remarks/>
        public void GetServiceOrderListAsync(HeaderMessage headerMessage, OrderFilter orderFilter, object userState)
        {
            if ((this.GetServiceOrderListOperationCompleted == null))
            {
                this.GetServiceOrderListOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetServiceOrderListOperationCompleted);
            }
            this.InvokeAsync("GetServiceOrderList", new object[] {
                        headerMessage,
                        orderFilter}, this.GetServiceOrderListOperationCompleted, userState);
        }

        private void OnGetServiceOrderListOperationCompleted(object arg)
        {
            if ((this.GetServiceOrderListCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetServiceOrderListCompleted(this, new GetServiceOrderListCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.cdiscount.com/IMarketplaceAPIService/ValidateOrderList", RequestNamespace = "http://www.cdiscount.com", ResponseNamespace = "http://www.cdiscount.com", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public ValidationResultMessage ValidateOrderList([System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] HeaderMessage headerMessage, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] ValidateOrderListMessage validateOrderListMessage)
        {
            object[] results = this.Invoke("ValidateOrderList", new object[] {
                        headerMessage,
                        validateOrderListMessage});
            return ((ValidationResultMessage)(results[0]));
        }

        /// <remarks/>
        public void ValidateOrderListAsync(HeaderMessage headerMessage, ValidateOrderListMessage validateOrderListMessage)
        {
            this.ValidateOrderListAsync(headerMessage, validateOrderListMessage, null);
        }

        /// <remarks/>
        public void ValidateOrderListAsync(HeaderMessage headerMessage, ValidateOrderListMessage validateOrderListMessage, object userState)
        {
            if ((this.ValidateOrderListOperationCompleted == null))
            {
                this.ValidateOrderListOperationCompleted = new System.Threading.SendOrPostCallback(this.OnValidateOrderListOperationCompleted);
            }
            this.InvokeAsync("ValidateOrderList", new object[] {
                        headerMessage,
                        validateOrderListMessage}, this.ValidateOrderListOperationCompleted, userState);
        }

        private void OnValidateOrderListOperationCompleted(object arg)
        {
            if ((this.ValidateOrderListCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ValidateOrderListCompleted(this, new ValidateOrderListCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.cdiscount.com/IMarketplaceAPIService/ManageParcel", RequestNamespace = "http://www.cdiscount.com", ResponseNamespace = "http://www.cdiscount.com", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public ManageParcelResultMessage ManageParcel([System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] HeaderMessage headerMessage, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] ManageParcelRequest manageParcelRequest)
        {
            object[] results = this.Invoke("ManageParcel", new object[] {
                        headerMessage,
                        manageParcelRequest});
            return ((ManageParcelResultMessage)(results[0]));
        }

        /// <remarks/>
        public void ManageParcelAsync(HeaderMessage headerMessage, ManageParcelRequest manageParcelRequest)
        {
            this.ManageParcelAsync(headerMessage, manageParcelRequest, null);
        }

        /// <remarks/>
        public void ManageParcelAsync(HeaderMessage headerMessage, ManageParcelRequest manageParcelRequest, object userState)
        {
            if ((this.ManageParcelOperationCompleted == null))
            {
                this.ManageParcelOperationCompleted = new System.Threading.SendOrPostCallback(this.OnManageParcelOperationCompleted);
            }
            this.InvokeAsync("ManageParcel", new object[] {
                        headerMessage,
                        manageParcelRequest}, this.ManageParcelOperationCompleted, userState);
        }

        private void OnManageParcelOperationCompleted(object arg)
        {
            if ((this.ManageParcelCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ManageParcelCompleted(this, new ManageParcelCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.cdiscount.com/IMarketplaceAPIService/CreateRefundVoucherAfterShipment", RequestNamespace = "http://www.cdiscount.com", ResponseNamespace = "http://www.cdiscount.com", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public SellerRefundResultMessage CreateRefundVoucherAfterShipment([System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] HeaderMessage headerMessage, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] SellerRefundRequestMessage request)
        {
            object[] results = this.Invoke("CreateRefundVoucherAfterShipment", new object[] {
                        headerMessage,
                        request});
            return ((SellerRefundResultMessage)(results[0]));
        }

        /// <remarks/>
        public void CreateRefundVoucherAfterShipmentAsync(HeaderMessage headerMessage, SellerRefundRequestMessage request)
        {
            this.CreateRefundVoucherAfterShipmentAsync(headerMessage, request, null);
        }

        /// <remarks/>
        public void CreateRefundVoucherAfterShipmentAsync(HeaderMessage headerMessage, SellerRefundRequestMessage request, object userState)
        {
            if ((this.CreateRefundVoucherAfterShipmentOperationCompleted == null))
            {
                this.CreateRefundVoucherAfterShipmentOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCreateRefundVoucherAfterShipmentOperationCompleted);
            }
            this.InvokeAsync("CreateRefundVoucherAfterShipment", new object[] {
                        headerMessage,
                        request}, this.CreateRefundVoucherAfterShipmentOperationCompleted, userState);
        }

        private void OnCreateRefundVoucherAfterShipmentOperationCompleted(object arg)
        {
            if ((this.CreateRefundVoucherAfterShipmentCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CreateRefundVoucherAfterShipmentCompleted(this, new CreateRefundVoucherAfterShipmentCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.cdiscount.com/IMarketplaceAPIService/CreateRefundVoucher", RequestNamespace = "http://www.cdiscount.com", ResponseNamespace = "http://www.cdiscount.com", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public CreateRefundVoucherMessage CreateRefundVoucher([System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] HeaderMessage headerMessage, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] CreateRefundVoucherRequest request)
        {
            object[] results = this.Invoke("CreateRefundVoucher", new object[] {
                        headerMessage,
                        request});
            return ((CreateRefundVoucherMessage)(results[0]));
        }

        /// <remarks/>
        public void CreateRefundVoucherAsync(HeaderMessage headerMessage, CreateRefundVoucherRequest request)
        {
            this.CreateRefundVoucherAsync(headerMessage, request, null);
        }

        /// <remarks/>
        public void CreateRefundVoucherAsync(HeaderMessage headerMessage, CreateRefundVoucherRequest request, object userState)
        {
            if ((this.CreateRefundVoucherOperationCompleted == null))
            {
                this.CreateRefundVoucherOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCreateRefundVoucherOperationCompleted);
            }
            this.InvokeAsync("CreateRefundVoucher", new object[] {
                        headerMessage,
                        request}, this.CreateRefundVoucherOperationCompleted, userState);
        }

        private void OnCreateRefundVoucherOperationCompleted(object arg)
        {
            if ((this.CreateRefundVoucherCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CreateRefundVoucherCompleted(this, new CreateRefundVoucherCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.cdiscount.com/IMarketplaceAPIService/GetGlobalConfiguration", RequestNamespace = "http://www.cdiscount.com", ResponseNamespace = "http://www.cdiscount.com", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public GlobalConfigurationMessage GetGlobalConfiguration([System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] HeaderMessage headerMessage)
        {
            object[] results = this.Invoke("GetGlobalConfiguration", new object[] {
                        headerMessage});
            return ((GlobalConfigurationMessage)(results[0]));
        }

        /// <remarks/>
        public void GetGlobalConfigurationAsync(HeaderMessage headerMessage)
        {
            this.GetGlobalConfigurationAsync(headerMessage, null);
        }

        /// <remarks/>
        public void GetGlobalConfigurationAsync(HeaderMessage headerMessage, object userState)
        {
            if ((this.GetGlobalConfigurationOperationCompleted == null))
            {
                this.GetGlobalConfigurationOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetGlobalConfigurationOperationCompleted);
            }
            this.InvokeAsync("GetGlobalConfiguration", new object[] {
                        headerMessage}, this.GetGlobalConfigurationOperationCompleted, userState);
        }

        private void OnGetGlobalConfigurationOperationCompleted(object arg)
        {
            if ((this.GetGlobalConfigurationCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetGlobalConfigurationCompleted(this, new GetGlobalConfigurationCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.cdiscount.com/IMarketplaceAPIService/GenerateDiscussionMailGuid", RequestNamespace = "http://www.cdiscount.com", ResponseNamespace = "http://www.cdiscount.com", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public DiscussionMailGuidCreationResultMessage GenerateDiscussionMailGuid([System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] HeaderMessage headerMessage, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] DiscussionMailGuidCreationRequestMessage request)
        {
            object[] results = this.Invoke("GenerateDiscussionMailGuid", new object[] {
                        headerMessage,
                        request});
            return ((DiscussionMailGuidCreationResultMessage)(results[0]));
        }

        /// <remarks/>
        public void GenerateDiscussionMailGuidAsync(HeaderMessage headerMessage, DiscussionMailGuidCreationRequestMessage request)
        {
            this.GenerateDiscussionMailGuidAsync(headerMessage, request, null);
        }

        /// <remarks/>
        public void GenerateDiscussionMailGuidAsync(HeaderMessage headerMessage, DiscussionMailGuidCreationRequestMessage request, object userState)
        {
            if ((this.GenerateDiscussionMailGuidOperationCompleted == null))
            {
                this.GenerateDiscussionMailGuidOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGenerateDiscussionMailGuidOperationCompleted);
            }
            this.InvokeAsync("GenerateDiscussionMailGuid", new object[] {
                        headerMessage,
                        request}, this.GenerateDiscussionMailGuidOperationCompleted, userState);
        }

        private void OnGenerateDiscussionMailGuidOperationCompleted(object arg)
        {
            if ((this.GenerateDiscussionMailGuidCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GenerateDiscussionMailGuidCompleted(this, new GenerateDiscussionMailGuidCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.cdiscount.com/IMarketplaceAPIService/SubmitRelaysFile", RequestNamespace = "http://www.cdiscount.com", ResponseNamespace = "http://www.cdiscount.com", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public RelaysFileDepositMessage SubmitRelaysFile([System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] HeaderMessage headerMessage, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] RelaysFileIntegrationRequest relaysFileRequest)
        {
            object[] results = this.Invoke("SubmitRelaysFile", new object[] {
                        headerMessage,
                        relaysFileRequest});
            return ((RelaysFileDepositMessage)(results[0]));
        }

        /// <remarks/>
        public void SubmitRelaysFileAsync(HeaderMessage headerMessage, RelaysFileIntegrationRequest relaysFileRequest)
        {
            this.SubmitRelaysFileAsync(headerMessage, relaysFileRequest, null);
        }

        /// <remarks/>
        public void SubmitRelaysFileAsync(HeaderMessage headerMessage, RelaysFileIntegrationRequest relaysFileRequest, object userState)
        {
            if ((this.SubmitRelaysFileOperationCompleted == null))
            {
                this.SubmitRelaysFileOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSubmitRelaysFileOperationCompleted);
            }
            this.InvokeAsync("SubmitRelaysFile", new object[] {
                        headerMessage,
                        relaysFileRequest}, this.SubmitRelaysFileOperationCompleted, userState);
        }

        private void OnSubmitRelaysFileOperationCompleted(object arg)
        {
            if ((this.SubmitRelaysFileCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SubmitRelaysFileCompleted(this, new SubmitRelaysFileCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.cdiscount.com/IMarketplaceAPIService/GetRelaysFileSubmissionResult", RequestNamespace = "http://www.cdiscount.com", ResponseNamespace = "http://www.cdiscount.com", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public RelayIntegrationReportMessage GetRelaysFileSubmissionResult([System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] HeaderMessage headerMessage, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] RelaysFileFilter relaysFileFilter)
        {
            object[] results = this.Invoke("GetRelaysFileSubmissionResult", new object[] {
                        headerMessage,
                        relaysFileFilter});
            return ((RelayIntegrationReportMessage)(results[0]));
        }

        /// <remarks/>
        public void GetRelaysFileSubmissionResultAsync(HeaderMessage headerMessage, RelaysFileFilter relaysFileFilter)
        {
            this.GetRelaysFileSubmissionResultAsync(headerMessage, relaysFileFilter, null);
        }

        /// <remarks/>
        public void GetRelaysFileSubmissionResultAsync(HeaderMessage headerMessage, RelaysFileFilter relaysFileFilter, object userState)
        {
            if ((this.GetRelaysFileSubmissionResultOperationCompleted == null))
            {
                this.GetRelaysFileSubmissionResultOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetRelaysFileSubmissionResultOperationCompleted);
            }
            this.InvokeAsync("GetRelaysFileSubmissionResult", new object[] {
                        headerMessage,
                        relaysFileFilter}, this.GetRelaysFileSubmissionResultOperationCompleted, userState);
        }

        private void OnGetRelaysFileSubmissionResultOperationCompleted(object arg)
        {
            if ((this.GetRelaysFileSubmissionResultCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetRelaysFileSubmissionResultCompleted(this, new GetRelaysFileSubmissionResultCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.cdiscount.com/IMarketplaceAPIService/GetParcelShopList", RequestNamespace = "http://www.cdiscount.com", ResponseNamespace = "http://www.cdiscount.com", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public ParcelShopListMessage GetParcelShopList([System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] HeaderMessage headerMessage)
        {
            object[] results = this.Invoke("GetParcelShopList", new object[] {
                        headerMessage});
            return ((ParcelShopListMessage)(results[0]));
        }

        /// <remarks/>
        public void GetParcelShopListAsync(HeaderMessage headerMessage)
        {
            this.GetParcelShopListAsync(headerMessage, null);
        }

        /// <remarks/>
        public void GetParcelShopListAsync(HeaderMessage headerMessage, object userState)
        {
            if ((this.GetParcelShopListOperationCompleted == null))
            {
                this.GetParcelShopListOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetParcelShopListOperationCompleted);
            }
            this.InvokeAsync("GetParcelShopList", new object[] {
                        headerMessage}, this.GetParcelShopListOperationCompleted, userState);
        }

        private void OnGetParcelShopListOperationCompleted(object arg)
        {
            if ((this.GetParcelShopListCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetParcelShopListCompleted(this, new GetParcelShopListCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.cdiscount.com/IMarketplaceAPIService/CloseDiscussionList", RequestNamespace = "http://www.cdiscount.com", ResponseNamespace = "http://www.cdiscount.com", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public CloseDiscussionResultMessage CloseDiscussionList([System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] HeaderMessage headerMessage, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] CloseDiscussionRequest closeDiscussionRequest)
        {
            object[] results = this.Invoke("CloseDiscussionList", new object[] {
                        headerMessage,
                        closeDiscussionRequest});
            return ((CloseDiscussionResultMessage)(results[0]));
        }

        /// <remarks/>
        public void CloseDiscussionListAsync(HeaderMessage headerMessage, CloseDiscussionRequest closeDiscussionRequest)
        {
            this.CloseDiscussionListAsync(headerMessage, closeDiscussionRequest, null);
        }

        /// <remarks/>
        public void CloseDiscussionListAsync(HeaderMessage headerMessage, CloseDiscussionRequest closeDiscussionRequest, object userState)
        {
            if ((this.CloseDiscussionListOperationCompleted == null))
            {
                this.CloseDiscussionListOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCloseDiscussionListOperationCompleted);
            }
            this.InvokeAsync("CloseDiscussionList", new object[] {
                        headerMessage,
                        closeDiscussionRequest}, this.CloseDiscussionListOperationCompleted, userState);
        }

        private void OnCloseDiscussionListOperationCompleted(object arg)
        {
            if ((this.CloseDiscussionListCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CloseDiscussionListCompleted(this, new CloseDiscussionListCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.cdiscount.com/IMarketplaceAPIService/GetOrderClaimList", RequestNamespace = "http://www.cdiscount.com", ResponseNamespace = "http://www.cdiscount.com", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public OrderClaimListMessage GetOrderClaimList([System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] HeaderMessage headerMessage, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] OrderClaimFilter orderClaimFilter)
        {
            object[] results = this.Invoke("GetOrderClaimList", new object[] {
                        headerMessage,
                        orderClaimFilter});
            return ((OrderClaimListMessage)(results[0]));
        }

        /// <remarks/>
        public void GetOrderClaimListAsync(HeaderMessage headerMessage, OrderClaimFilter orderClaimFilter)
        {
            this.GetOrderClaimListAsync(headerMessage, orderClaimFilter, null);
        }

        /// <remarks/>
        public void GetOrderClaimListAsync(HeaderMessage headerMessage, OrderClaimFilter orderClaimFilter, object userState)
        {
            if ((this.GetOrderClaimListOperationCompleted == null))
            {
                this.GetOrderClaimListOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetOrderClaimListOperationCompleted);
            }
            this.InvokeAsync("GetOrderClaimList", new object[] {
                        headerMessage,
                        orderClaimFilter}, this.GetOrderClaimListOperationCompleted, userState);
        }

        private void OnGetOrderClaimListOperationCompleted(object arg)
        {
            if ((this.GetOrderClaimListCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetOrderClaimListCompleted(this, new GetOrderClaimListCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.cdiscount.com/IMarketplaceAPIService/GetOrderQuestionList", RequestNamespace = "http://www.cdiscount.com", ResponseNamespace = "http://www.cdiscount.com", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public OrderQuestionListMessage GetOrderQuestionList([System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] HeaderMessage headerMessage, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] OrderQuestionFilter orderQuestionFilter)
        {
            object[] results = this.Invoke("GetOrderQuestionList", new object[] {
                        headerMessage,
                        orderQuestionFilter});
            return ((OrderQuestionListMessage)(results[0]));
        }

        /// <remarks/>
        public void GetOrderQuestionListAsync(HeaderMessage headerMessage, OrderQuestionFilter orderQuestionFilter)
        {
            this.GetOrderQuestionListAsync(headerMessage, orderQuestionFilter, null);
        }

        /// <remarks/>
        public void GetOrderQuestionListAsync(HeaderMessage headerMessage, OrderQuestionFilter orderQuestionFilter, object userState)
        {
            if ((this.GetOrderQuestionListOperationCompleted == null))
            {
                this.GetOrderQuestionListOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetOrderQuestionListOperationCompleted);
            }
            this.InvokeAsync("GetOrderQuestionList", new object[] {
                        headerMessage,
                        orderQuestionFilter}, this.GetOrderQuestionListOperationCompleted, userState);
        }

        private void OnGetOrderQuestionListOperationCompleted(object arg)
        {
            if ((this.GetOrderQuestionListCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetOrderQuestionListCompleted(this, new GetOrderQuestionListCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.cdiscount.com/IMarketplaceAPIService/GetOfferQuestionList", RequestNamespace = "http://www.cdiscount.com", ResponseNamespace = "http://www.cdiscount.com", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public OfferQuestionListMessage GetOfferQuestionList([System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] HeaderMessage headerMessage, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] OfferQuestionFilter offerQuestionFilter)
        {
            object[] results = this.Invoke("GetOfferQuestionList", new object[] {
                        headerMessage,
                        offerQuestionFilter});
            return ((OfferQuestionListMessage)(results[0]));
        }

        /// <remarks/>
        public void GetOfferQuestionListAsync(HeaderMessage headerMessage, OfferQuestionFilter offerQuestionFilter)
        {
            this.GetOfferQuestionListAsync(headerMessage, offerQuestionFilter, null);
        }

        /// <remarks/>
        public void GetOfferQuestionListAsync(HeaderMessage headerMessage, OfferQuestionFilter offerQuestionFilter, object userState)
        {
            if ((this.GetOfferQuestionListOperationCompleted == null))
            {
                this.GetOfferQuestionListOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetOfferQuestionListOperationCompleted);
            }
            this.InvokeAsync("GetOfferQuestionList", new object[] {
                        headerMessage,
                        offerQuestionFilter}, this.GetOfferQuestionListOperationCompleted, userState);
        }

        private void OnGetOfferQuestionListOperationCompleted(object arg)
        {
            if ((this.GetOfferQuestionListCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetOfferQuestionListCompleted(this, new GetOfferQuestionListCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.cdiscount.com/IMarketplaceAPIService/GetDiscussionMailList", RequestNamespace = "http://www.cdiscount.com", ResponseNamespace = "http://www.cdiscount.com", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public DiscussionMailListMessage GetDiscussionMailList([System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] HeaderMessage headerMessage, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] GetDiscussionMailListRequest request)
        {
            object[] results = this.Invoke("GetDiscussionMailList", new object[] {
                        headerMessage,
                        request});
            return ((DiscussionMailListMessage)(results[0]));
        }

        /// <remarks/>
        public void GetDiscussionMailListAsync(HeaderMessage headerMessage, GetDiscussionMailListRequest request)
        {
            this.GetDiscussionMailListAsync(headerMessage, request, null);
        }

        /// <remarks/>
        public void GetDiscussionMailListAsync(HeaderMessage headerMessage, GetDiscussionMailListRequest request, object userState)
        {
            if ((this.GetDiscussionMailListOperationCompleted == null))
            {
                this.GetDiscussionMailListOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetDiscussionMailListOperationCompleted);
            }
            this.InvokeAsync("GetDiscussionMailList", new object[] {
                        headerMessage,
                        request}, this.GetDiscussionMailListOperationCompleted, userState);
        }

        private void OnGetDiscussionMailListOperationCompleted(object arg)
        {
            if ((this.GetDiscussionMailListCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetDiscussionMailListCompleted(this, new GetDiscussionMailListCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.cdiscount.com/IMarketplaceAPIService/CreateExternalOrder", RequestNamespace = "http://www.cdiscount.com", ResponseNamespace = "http://www.cdiscount.com", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public OrderIntegrationMessage CreateExternalOrder([System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] HeaderMessage headerMessage, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] OrderIntegrationRequest request)
        {
            object[] results = this.Invoke("CreateExternalOrder", new object[] {
                        headerMessage,
                        request});
            return ((OrderIntegrationMessage)(results[0]));
        }

        /// <remarks/>
        public void CreateExternalOrderAsync(HeaderMessage headerMessage, OrderIntegrationRequest request)
        {
            this.CreateExternalOrderAsync(headerMessage, request, null);
        }

        /// <remarks/>
        public void CreateExternalOrderAsync(HeaderMessage headerMessage, OrderIntegrationRequest request, object userState)
        {
            if ((this.CreateExternalOrderOperationCompleted == null))
            {
                this.CreateExternalOrderOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCreateExternalOrderOperationCompleted);
            }
            this.InvokeAsync("CreateExternalOrder", new object[] {
                        headerMessage,
                        request}, this.CreateExternalOrderOperationCompleted, userState);
        }

        private void OnCreateExternalOrderOperationCompleted(object arg)
        {
            if ((this.CreateExternalOrderCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CreateExternalOrderCompleted(this, new CreateExternalOrderCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.cdiscount.com/IMarketplaceAPIService/GetExternalOrderStatus", RequestNamespace = "http://www.cdiscount.com", ResponseNamespace = "http://www.cdiscount.com", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public OrderStatusMessage GetExternalOrderStatus([System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] HeaderMessage headerMessage, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] OrderStatusRequest request)
        {
            object[] results = this.Invoke("GetExternalOrderStatus", new object[] {
                        headerMessage,
                        request});
            return ((OrderStatusMessage)(results[0]));
        }

        /// <remarks/>
        public void GetExternalOrderStatusAsync(HeaderMessage headerMessage, OrderStatusRequest request)
        {
            this.GetExternalOrderStatusAsync(headerMessage, request, null);
        }

        /// <remarks/>
        public void GetExternalOrderStatusAsync(HeaderMessage headerMessage, OrderStatusRequest request, object userState)
        {
            if ((this.GetExternalOrderStatusOperationCompleted == null))
            {
                this.GetExternalOrderStatusOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetExternalOrderStatusOperationCompleted);
            }
            this.InvokeAsync("GetExternalOrderStatus", new object[] {
                        headerMessage,
                        request}, this.GetExternalOrderStatusOperationCompleted, userState);
        }

        private void OnGetExternalOrderStatusOperationCompleted(object arg)
        {
            if ((this.GetExternalOrderStatusCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetExternalOrderStatusCompleted(this, new GetExternalOrderStatusCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.cdiscount.com/IMarketplaceAPIService/GetProductStockList", RequestNamespace = "http://www.cdiscount.com", ResponseNamespace = "http://www.cdiscount.com", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public ProductStockListMessage GetProductStockList([System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] HeaderMessage headerMessage, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] FulfilmentProductRequest request)
        {
            object[] results = this.Invoke("GetProductStockList", new object[] {
                        headerMessage,
                        request});
            return ((ProductStockListMessage)(results[0]));
        }

        /// <remarks/>
        public void GetProductStockListAsync(HeaderMessage headerMessage, FulfilmentProductRequest request)
        {
            this.GetProductStockListAsync(headerMessage, request, null);
        }

        /// <remarks/>
        public void GetProductStockListAsync(HeaderMessage headerMessage, FulfilmentProductRequest request, object userState)
        {
            if ((this.GetProductStockListOperationCompleted == null))
            {
                this.GetProductStockListOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetProductStockListOperationCompleted);
            }
            this.InvokeAsync("GetProductStockList", new object[] {
                        headerMessage,
                        request}, this.GetProductStockListOperationCompleted, userState);
        }

        private void OnGetProductStockListOperationCompleted(object arg)
        {
            if ((this.GetProductStockListCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetProductStockListCompleted(this, new GetProductStockListCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.cdiscount.com/IMarketplaceAPIService/GetFulfilmentActivationReportList" +
            "", RequestNamespace = "http://www.cdiscount.com", ResponseNamespace = "http://www.cdiscount.com", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public FulfilmentActivationReportMessage GetFulfilmentActivationReportList([System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] HeaderMessage headerMessage, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] FulfilmentActivationReportRequest request)
        {
            object[] results = this.Invoke("GetFulfilmentActivationReportList", new object[] {
                        headerMessage,
                        request});
            return ((FulfilmentActivationReportMessage)(results[0]));
        }

        /// <remarks/>
        public void GetFulfilmentActivationReportListAsync(HeaderMessage headerMessage, FulfilmentActivationReportRequest request)
        {
            this.GetFulfilmentActivationReportListAsync(headerMessage, request, null);
        }

        /// <remarks/>
        public void GetFulfilmentActivationReportListAsync(HeaderMessage headerMessage, FulfilmentActivationReportRequest request, object userState)
        {
            if ((this.GetFulfilmentActivationReportListOperationCompleted == null))
            {
                this.GetFulfilmentActivationReportListOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetFulfilmentActivationReportListOperationCompleted);
            }
            this.InvokeAsync("GetFulfilmentActivationReportList", new object[] {
                        headerMessage,
                        request}, this.GetFulfilmentActivationReportListOperationCompleted, userState);
        }

        private void OnGetFulfilmentActivationReportListOperationCompleted(object arg)
        {
            if ((this.GetFulfilmentActivationReportListCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetFulfilmentActivationReportListCompleted(this, new GetFulfilmentActivationReportListCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.cdiscount.com/IMarketplaceAPIService/GetFulfilmentOrderListToSupply", RequestNamespace = "http://www.cdiscount.com", ResponseNamespace = "http://www.cdiscount.com", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public FulfilmentOrderLineListToSupplyMessage GetFulfilmentOrderListToSupply([System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] HeaderMessage headerMessage, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] FulfilmentOnDemandOrderLineFilter request)
        {
            object[] results = this.Invoke("GetFulfilmentOrderListToSupply", new object[] {
                        headerMessage,
                        request});
            return ((FulfilmentOrderLineListToSupplyMessage)(results[0]));
        }

        /// <remarks/>
        public void GetFulfilmentOrderListToSupplyAsync(HeaderMessage headerMessage, FulfilmentOnDemandOrderLineFilter request)
        {
            this.GetFulfilmentOrderListToSupplyAsync(headerMessage, request, null);
        }

        /// <remarks/>
        public void GetFulfilmentOrderListToSupplyAsync(HeaderMessage headerMessage, FulfilmentOnDemandOrderLineFilter request, object userState)
        {
            if ((this.GetFulfilmentOrderListToSupplyOperationCompleted == null))
            {
                this.GetFulfilmentOrderListToSupplyOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetFulfilmentOrderListToSupplyOperationCompleted);
            }
            this.InvokeAsync("GetFulfilmentOrderListToSupply", new object[] {
                        headerMessage,
                        request}, this.GetFulfilmentOrderListToSupplyOperationCompleted, userState);
        }

        private void OnGetFulfilmentOrderListToSupplyOperationCompleted(object arg)
        {
            if ((this.GetFulfilmentOrderListToSupplyCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetFulfilmentOrderListToSupplyCompleted(this, new GetFulfilmentOrderListToSupplyCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.cdiscount.com/IMarketplaceAPIService/SubmitFulfilmentSupplyOrder", RequestNamespace = "http://www.cdiscount.com", ResponseNamespace = "http://www.cdiscount.com", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public SupplyOrderReportMessage SubmitFulfilmentSupplyOrder([System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] HeaderMessage headerMessage, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] FulfilmentSupplyOrderRequest request)
        {
            object[] results = this.Invoke("SubmitFulfilmentSupplyOrder", new object[] {
                        headerMessage,
                        request});
            return ((SupplyOrderReportMessage)(results[0]));
        }

        /// <remarks/>
        public void SubmitFulfilmentSupplyOrderAsync(HeaderMessage headerMessage, FulfilmentSupplyOrderRequest request)
        {
            this.SubmitFulfilmentSupplyOrderAsync(headerMessage, request, null);
        }

        /// <remarks/>
        public void SubmitFulfilmentSupplyOrderAsync(HeaderMessage headerMessage, FulfilmentSupplyOrderRequest request, object userState)
        {
            if ((this.SubmitFulfilmentSupplyOrderOperationCompleted == null))
            {
                this.SubmitFulfilmentSupplyOrderOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSubmitFulfilmentSupplyOrderOperationCompleted);
            }
            this.InvokeAsync("SubmitFulfilmentSupplyOrder", new object[] {
                        headerMessage,
                        request}, this.SubmitFulfilmentSupplyOrderOperationCompleted, userState);
        }

        private void OnSubmitFulfilmentSupplyOrderOperationCompleted(object arg)
        {
            if ((this.SubmitFulfilmentSupplyOrderCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SubmitFulfilmentSupplyOrderCompleted(this, new SubmitFulfilmentSupplyOrderCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.cdiscount.com/IMarketplaceAPIService/SubmitFulfilmentOnDemandSupplyOrd" +
            "er", RequestNamespace = "http://www.cdiscount.com", ResponseNamespace = "http://www.cdiscount.com", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public SupplyOrderReportMessage SubmitFulfilmentOnDemandSupplyOrder([System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] HeaderMessage headerMessage, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] FulfilmentOnDemandSupplyOrderRequest request)
        {
            object[] results = this.Invoke("SubmitFulfilmentOnDemandSupplyOrder", new object[] {
                        headerMessage,
                        request});
            return ((SupplyOrderReportMessage)(results[0]));
        }

        /// <remarks/>
        public void SubmitFulfilmentOnDemandSupplyOrderAsync(HeaderMessage headerMessage, FulfilmentOnDemandSupplyOrderRequest request)
        {
            this.SubmitFulfilmentOnDemandSupplyOrderAsync(headerMessage, request, null);
        }

        /// <remarks/>
        public void SubmitFulfilmentOnDemandSupplyOrderAsync(HeaderMessage headerMessage, FulfilmentOnDemandSupplyOrderRequest request, object userState)
        {
            if ((this.SubmitFulfilmentOnDemandSupplyOrderOperationCompleted == null))
            {
                this.SubmitFulfilmentOnDemandSupplyOrderOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSubmitFulfilmentOnDemandSupplyOrderOperationCompleted);
            }
            this.InvokeAsync("SubmitFulfilmentOnDemandSupplyOrder", new object[] {
                        headerMessage,
                        request}, this.SubmitFulfilmentOnDemandSupplyOrderOperationCompleted, userState);
        }

        private void OnSubmitFulfilmentOnDemandSupplyOrderOperationCompleted(object arg)
        {
            if ((this.SubmitFulfilmentOnDemandSupplyOrderCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SubmitFulfilmentOnDemandSupplyOrderCompleted(this, new SubmitFulfilmentOnDemandSupplyOrderCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.cdiscount.com/IMarketplaceAPIService/GetFulfilmentDeliveryDocument", RequestNamespace = "http://www.cdiscount.com", ResponseNamespace = "http://www.cdiscount.com", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public FulfilmentDeliveryDocumentMessage GetFulfilmentDeliveryDocument([System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] HeaderMessage headerMessage, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] FulfilmentDeliveryDocumentRequest request)
        {
            object[] results = this.Invoke("GetFulfilmentDeliveryDocument", new object[] {
                        headerMessage,
                        request});
            return ((FulfilmentDeliveryDocumentMessage)(results[0]));
        }

        /// <remarks/>
        public void GetFulfilmentDeliveryDocumentAsync(HeaderMessage headerMessage, FulfilmentDeliveryDocumentRequest request)
        {
            this.GetFulfilmentDeliveryDocumentAsync(headerMessage, request, null);
        }

        /// <remarks/>
        public void GetFulfilmentDeliveryDocumentAsync(HeaderMessage headerMessage, FulfilmentDeliveryDocumentRequest request, object userState)
        {
            if ((this.GetFulfilmentDeliveryDocumentOperationCompleted == null))
            {
                this.GetFulfilmentDeliveryDocumentOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetFulfilmentDeliveryDocumentOperationCompleted);
            }
            this.InvokeAsync("GetFulfilmentDeliveryDocument", new object[] {
                        headerMessage,
                        request}, this.GetFulfilmentDeliveryDocumentOperationCompleted, userState);
        }

        private void OnGetFulfilmentDeliveryDocumentOperationCompleted(object arg)
        {
            if ((this.GetFulfilmentDeliveryDocumentCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetFulfilmentDeliveryDocumentCompleted(this, new GetFulfilmentDeliveryDocumentCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.cdiscount.com/IMarketplaceAPIService/SubmitOfferStateAction", RequestNamespace = "http://www.cdiscount.com", ResponseNamespace = "http://www.cdiscount.com", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public OfferStateReportMessage SubmitOfferStateAction([System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] HeaderMessage headerMessage, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] OfferStateActionRequest offerStateRequest)
        {
            object[] results = this.Invoke("SubmitOfferStateAction", new object[] {
                        headerMessage,
                        offerStateRequest});
            return ((OfferStateReportMessage)(results[0]));
        }

        /// <remarks/>
        public void SubmitOfferStateActionAsync(HeaderMessage headerMessage, OfferStateActionRequest offerStateRequest)
        {
            this.SubmitOfferStateActionAsync(headerMessage, offerStateRequest, null);
        }

        /// <remarks/>
        public void SubmitOfferStateActionAsync(HeaderMessage headerMessage, OfferStateActionRequest offerStateRequest, object userState)
        {
            if ((this.SubmitOfferStateActionOperationCompleted == null))
            {
                this.SubmitOfferStateActionOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSubmitOfferStateActionOperationCompleted);
            }
            this.InvokeAsync("SubmitOfferStateAction", new object[] {
                        headerMessage,
                        offerStateRequest}, this.SubmitOfferStateActionOperationCompleted, userState);
        }

        private void OnSubmitOfferStateActionOperationCompleted(object arg)
        {
            if ((this.SubmitOfferStateActionCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SubmitOfferStateActionCompleted(this, new SubmitOfferStateActionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.cdiscount.com/IMarketplaceAPIService/GetFulfilmentSupplyOrder", RequestNamespace = "http://www.cdiscount.com", ResponseNamespace = "http://www.cdiscount.com", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public SupplyOrderMessage GetFulfilmentSupplyOrder([System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] HeaderMessage headerMessage, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] SupplyOrderRequest request)
        {
            object[] results = this.Invoke("GetFulfilmentSupplyOrder", new object[] {
                        headerMessage,
                        request});
            return ((SupplyOrderMessage)(results[0]));
        }

        /// <remarks/>
        public void GetFulfilmentSupplyOrderAsync(HeaderMessage headerMessage, SupplyOrderRequest request)
        {
            this.GetFulfilmentSupplyOrderAsync(headerMessage, request, null);
        }

        /// <remarks/>
        public void GetFulfilmentSupplyOrderAsync(HeaderMessage headerMessage, SupplyOrderRequest request, object userState)
        {
            if ((this.GetFulfilmentSupplyOrderOperationCompleted == null))
            {
                this.GetFulfilmentSupplyOrderOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetFulfilmentSupplyOrderOperationCompleted);
            }
            this.InvokeAsync("GetFulfilmentSupplyOrder", new object[] {
                        headerMessage,
                        request}, this.GetFulfilmentSupplyOrderOperationCompleted, userState);
        }

        private void OnGetFulfilmentSupplyOrderOperationCompleted(object arg)
        {
            if ((this.GetFulfilmentSupplyOrderCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetFulfilmentSupplyOrderCompleted(this, new GetFulfilmentSupplyOrderCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.cdiscount.com/IMarketplaceAPIService/SubmitFulfilmentActivation", RequestNamespace = "http://www.cdiscount.com", ResponseNamespace = "http://www.cdiscount.com", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public FulfilmentActivationMessage SubmitFulfilmentActivation([System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] HeaderMessage headerMessage, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] FulfilmentActivationRequest request)
        {
            object[] results = this.Invoke("SubmitFulfilmentActivation", new object[] {
                        headerMessage,
                        request});
            return ((FulfilmentActivationMessage)(results[0]));
        }

        /// <remarks/>
        public void SubmitFulfilmentActivationAsync(HeaderMessage headerMessage, FulfilmentActivationRequest request)
        {
            this.SubmitFulfilmentActivationAsync(headerMessage, request, null);
        }

        /// <remarks/>
        public void SubmitFulfilmentActivationAsync(HeaderMessage headerMessage, FulfilmentActivationRequest request, object userState)
        {
            if ((this.SubmitFulfilmentActivationOperationCompleted == null))
            {
                this.SubmitFulfilmentActivationOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSubmitFulfilmentActivationOperationCompleted);
            }
            this.InvokeAsync("SubmitFulfilmentActivation", new object[] {
                        headerMessage,
                        request}, this.SubmitFulfilmentActivationOperationCompleted, userState);
        }

        private void OnSubmitFulfilmentActivationOperationCompleted(object arg)
        {
            if ((this.SubmitFulfilmentActivationCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SubmitFulfilmentActivationCompleted(this, new SubmitFulfilmentActivationCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.cdiscount.com/IMarketplaceAPIService/GetFulfilmentSupplyOrderReportLis" +
            "t", RequestNamespace = "http://www.cdiscount.com", ResponseNamespace = "http://www.cdiscount.com", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public SupplyOrderReportListMessage GetFulfilmentSupplyOrderReportList([System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] HeaderMessage headerMessage, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] SupplyOrderReportRequest request)
        {
            object[] results = this.Invoke("GetFulfilmentSupplyOrderReportList", new object[] {
                        headerMessage,
                        request});
            return ((SupplyOrderReportListMessage)(results[0]));
        }

        /// <remarks/>
        public void GetFulfilmentSupplyOrderReportListAsync(HeaderMessage headerMessage, SupplyOrderReportRequest request)
        {
            this.GetFulfilmentSupplyOrderReportListAsync(headerMessage, request, null);
        }

        /// <remarks/>
        public void GetFulfilmentSupplyOrderReportListAsync(HeaderMessage headerMessage, SupplyOrderReportRequest request, object userState)
        {
            if ((this.GetFulfilmentSupplyOrderReportListOperationCompleted == null))
            {
                this.GetFulfilmentSupplyOrderReportListOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetFulfilmentSupplyOrderReportListOperationCompleted);
            }
            this.InvokeAsync("GetFulfilmentSupplyOrderReportList", new object[] {
                        headerMessage,
                        request}, this.GetFulfilmentSupplyOrderReportListOperationCompleted, userState);
        }

        private void OnGetFulfilmentSupplyOrderReportListOperationCompleted(object arg)
        {
            if ((this.GetFulfilmentSupplyOrderReportListCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetFulfilmentSupplyOrderReportListCompleted(this, new GetFulfilmentSupplyOrderReportListCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        public new void CancelAsync(object userState)
        {
            base.CancelAsync(userState);
        }

        private bool IsLocalFileSystemWebService(string url)
        {
            if (((url == null)
                        || (url == string.Empty)))
            {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024)
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0)))
            {
                return true;
            }
            return false;
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.datacontract.org/2004/07/Cdiscount.Framework.Core.Communication.Me" +
        "ssages")]
    public partial class HeaderMessage
    {

        private ContextMessage contextField;

        private LocalizationMessage localizationField;

        private SecurityContext securityField;

        private string versionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public ContextMessage Context
        {
            get
            {
                return this.contextField;
            }
            set
            {
                this.contextField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public LocalizationMessage Localization
        {
            get
            {
                return this.localizationField;
            }
            set
            {
                this.localizationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public SecurityContext Security
        {
            get
            {
                return this.securityField;
            }
            set
            {
                this.securityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.datacontract.org/2004/07/Cdiscount.Framework.Core.Communication.Me" +
        "ssages")]
    public partial class ContextMessage
    {

        private System.Nullable<int> catalogIDField;

        private bool catalogIDFieldSpecified;

        private string configurationPolicyField;

        private string customerIDField;

        private int customerIdField;

        private bool customerIdFieldSpecified;

        private string customerNumberField;

        private System.Nullable<int> customerPoolIDField;

        private bool customerPoolIDFieldSpecified;

        private GeoCoordinate geoCoordinateField;

        private bool securedContextField;

        private bool securedContextFieldSpecified;

        private int siteIDField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<int> CatalogID
        {
            get
            {
                return this.catalogIDField;
            }
            set
            {
                this.catalogIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CatalogIDSpecified
        {
            get
            {
                return this.catalogIDFieldSpecified;
            }
            set
            {
                this.catalogIDFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string ConfigurationPolicy
        {
            get
            {
                return this.configurationPolicyField;
            }
            set
            {
                this.configurationPolicyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string CustomerID
        {
            get
            {
                return this.customerIDField;
            }
            set
            {
                this.customerIDField = value;
            }
        }

        /// <remarks/>
        public int CustomerId
        {
            get
            {
                return this.customerIdField;
            }
            set
            {
                this.customerIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CustomerIdSpecified
        {
            get
            {
                return this.customerIdFieldSpecified;
            }
            set
            {
                this.customerIdFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string CustomerNumber
        {
            get
            {
                return this.customerNumberField;
            }
            set
            {
                this.customerNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<int> CustomerPoolID
        {
            get
            {
                return this.customerPoolIDField;
            }
            set
            {
                this.customerPoolIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CustomerPoolIDSpecified
        {
            get
            {
                return this.customerPoolIDFieldSpecified;
            }
            set
            {
                this.customerPoolIDFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public GeoCoordinate GeoCoordinate
        {
            get
            {
                return this.geoCoordinateField;
            }
            set
            {
                this.geoCoordinateField = value;
            }
        }

        /// <remarks/>
        public bool SecuredContext
        {
            get
            {
                return this.securedContextField;
            }
            set
            {
                this.securedContextField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SecuredContextSpecified
        {
            get
            {
                return this.securedContextFieldSpecified;
            }
            set
            {
                this.securedContextFieldSpecified = value;
            }
        }

        /// <remarks/>
        public int SiteID
        {
            get
            {
                return this.siteIDField;
            }
            set
            {
                this.siteIDField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.datacontract.org/2004/07/System.Device.Location")]
    public partial class GeoCoordinate
    {

        private double altitudeField;

        private bool altitudeFieldSpecified;

        private double courseField;

        private bool courseFieldSpecified;

        private double horizontalAccuracyField;

        private bool horizontalAccuracyFieldSpecified;

        private double latitudeField;

        private bool latitudeFieldSpecified;

        private double longitudeField;

        private bool longitudeFieldSpecified;

        private double speedField;

        private bool speedFieldSpecified;

        private double verticalAccuracyField;

        private bool verticalAccuracyFieldSpecified;

        /// <remarks/>
        public double Altitude
        {
            get
            {
                return this.altitudeField;
            }
            set
            {
                this.altitudeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AltitudeSpecified
        {
            get
            {
                return this.altitudeFieldSpecified;
            }
            set
            {
                this.altitudeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double Course
        {
            get
            {
                return this.courseField;
            }
            set
            {
                this.courseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CourseSpecified
        {
            get
            {
                return this.courseFieldSpecified;
            }
            set
            {
                this.courseFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double HorizontalAccuracy
        {
            get
            {
                return this.horizontalAccuracyField;
            }
            set
            {
                this.horizontalAccuracyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HorizontalAccuracySpecified
        {
            get
            {
                return this.horizontalAccuracyFieldSpecified;
            }
            set
            {
                this.horizontalAccuracyFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double Latitude
        {
            get
            {
                return this.latitudeField;
            }
            set
            {
                this.latitudeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LatitudeSpecified
        {
            get
            {
                return this.latitudeFieldSpecified;
            }
            set
            {
                this.latitudeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double Longitude
        {
            get
            {
                return this.longitudeField;
            }
            set
            {
                this.longitudeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LongitudeSpecified
        {
            get
            {
                return this.longitudeFieldSpecified;
            }
            set
            {
                this.longitudeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double Speed
        {
            get
            {
                return this.speedField;
            }
            set
            {
                this.speedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SpeedSpecified
        {
            get
            {
                return this.speedFieldSpecified;
            }
            set
            {
                this.speedFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double VerticalAccuracy
        {
            get
            {
                return this.verticalAccuracyField;
            }
            set
            {
                this.verticalAccuracyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool VerticalAccuracySpecified
        {
            get
            {
                return this.verticalAccuracyFieldSpecified;
            }
            set
            {
                this.verticalAccuracyFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class SupplyOrderReportRequest
    {

        private System.Nullable<System.DateTime> beginCreationDateField;

        private bool beginCreationDateFieldSpecified;

        private int[] depositIdListField;

        private System.Nullable<System.DateTime> endCreationDateField;

        private bool endCreationDateFieldSpecified;

        private int pageNumberField;

        private bool pageNumberFieldSpecified;

        private int pageSizeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<System.DateTime> BeginCreationDate
        {
            get
            {
                return this.beginCreationDateField;
            }
            set
            {
                this.beginCreationDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BeginCreationDateSpecified
        {
            get
            {
                return this.beginCreationDateFieldSpecified;
            }
            set
            {
                this.beginCreationDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace = "http://schemas.microsoft.com/2003/10/Serialization/Arrays", IsNullable = false)]
        public int[] DepositIdList
        {
            get
            {
                return this.depositIdListField;
            }
            set
            {
                this.depositIdListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<System.DateTime> EndCreationDate
        {
            get
            {
                return this.endCreationDateField;
            }
            set
            {
                this.endCreationDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EndCreationDateSpecified
        {
            get
            {
                return this.endCreationDateFieldSpecified;
            }
            set
            {
                this.endCreationDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public int PageNumber
        {
            get
            {
                return this.pageNumberField;
            }
            set
            {
                this.pageNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PageNumberSpecified
        {
            get
            {
                return this.pageNumberFieldSpecified;
            }
            set
            {
                this.pageNumberFieldSpecified = value;
            }
        }

        /// <remarks/>
        public int PageSize
        {
            get
            {
                return this.pageSizeField;
            }
            set
            {
                this.pageSizeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.datacontract.org/2004/07/Cdiscount.Service.Marketplace.API.Externa" +
        "l.Contract.Data.Fulfilment")]
    public partial class ProductActivationData
    {

        private FulfilmentProductActionType actionField;

        private double heightField;

        private double lengthField;

        private string productEanField;

        private string sellerProductReferenceField;

        private double weightField;

        private double widthField;

        /// <remarks/>
        public FulfilmentProductActionType Action
        {
            get
            {
                return this.actionField;
            }
            set
            {
                this.actionField = value;
            }
        }

        /// <remarks/>
        public double Height
        {
            get
            {
                return this.heightField;
            }
            set
            {
                this.heightField = value;
            }
        }

        /// <remarks/>
        public double Length
        {
            get
            {
                return this.lengthField;
            }
            set
            {
                this.lengthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string ProductEan
        {
            get
            {
                return this.productEanField;
            }
            set
            {
                this.productEanField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string SellerProductReference
        {
            get
            {
                return this.sellerProductReferenceField;
            }
            set
            {
                this.sellerProductReferenceField = value;
            }
        }

        /// <remarks/>
        public double Weight
        {
            get
            {
                return this.weightField;
            }
            set
            {
                this.weightField = value;
            }
        }

        /// <remarks/>
        public double Width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public enum FulfilmentProductActionType
    {

        /// <remarks/>
        Activation,

        /// <remarks/>
        Deactivation,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class FulfilmentActivationRequest
    {

        private ProductActivationData[] productListField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace = "http://schemas.datacontract.org/2004/07/Cdiscount.Service.Marketplace.API.Externa" +
            "l.Contract.Data.Fulfilment")]
        public ProductActivationData[] ProductList
        {
            get
            {
                return this.productListField;
            }
            set
            {
                this.productListField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class SupplyOrderRequest
    {

        private System.Nullable<System.DateTime> beginModificationDateField;

        private bool beginModificationDateFieldSpecified;

        private System.Nullable<System.DateTime> endModificationDateField;

        private bool endModificationDateFieldSpecified;

        private System.Nullable<int> pageNumberField;

        private bool pageNumberFieldSpecified;

        private System.Nullable<int> pageSizeField;

        private bool pageSizeFieldSpecified;

        private string[] supplyOrderNumberListField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<System.DateTime> BeginModificationDate
        {
            get
            {
                return this.beginModificationDateField;
            }
            set
            {
                this.beginModificationDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BeginModificationDateSpecified
        {
            get
            {
                return this.beginModificationDateFieldSpecified;
            }
            set
            {
                this.beginModificationDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<System.DateTime> EndModificationDate
        {
            get
            {
                return this.endModificationDateField;
            }
            set
            {
                this.endModificationDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EndModificationDateSpecified
        {
            get
            {
                return this.endModificationDateFieldSpecified;
            }
            set
            {
                this.endModificationDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<int> PageNumber
        {
            get
            {
                return this.pageNumberField;
            }
            set
            {
                this.pageNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PageNumberSpecified
        {
            get
            {
                return this.pageNumberFieldSpecified;
            }
            set
            {
                this.pageNumberFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<int> PageSize
        {
            get
            {
                return this.pageSizeField;
            }
            set
            {
                this.pageSizeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PageSizeSpecified
        {
            get
            {
                return this.pageSizeFieldSpecified;
            }
            set
            {
                this.pageSizeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace = "http://schemas.microsoft.com/2003/10/Serialization/Arrays")]
        public string[] SupplyOrderNumberList
        {
            get
            {
                return this.supplyOrderNumberListField;
            }
            set
            {
                this.supplyOrderNumberListField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class OfferStateActionRequest
    {

        private OfferStateActionType actionField;

        private string sellerProductIdField;

        /// <remarks/>
        public OfferStateActionType Action
        {
            get
            {
                return this.actionField;
            }
            set
            {
                this.actionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string SellerProductId
        {
            get
            {
                return this.sellerProductIdField;
            }
            set
            {
                this.sellerProductIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.datacontract.org/2004/07/Cdiscount.Service.Marketplace.API.Externa" +
        "l.Contract.Data.Fulfilment")]
    public enum OfferStateActionType
    {

        /// <remarks/>
        Publish,

        /// <remarks/>
        Unpublish,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class FulfilmentDeliveryDocumentRequest
    {

        private int depositIdField;

        private bool depositIdFieldSpecified;

        /// <remarks/>
        public int DepositId
        {
            get
            {
                return this.depositIdField;
            }
            set
            {
                this.depositIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DepositIdSpecified
        {
            get
            {
                return this.depositIdFieldSpecified;
            }
            set
            {
                this.depositIdFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class FulfilmentOrderLineRequest
    {

        private string orderReferenceField;

        private string productEanField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string OrderReference
        {
            get
            {
                return this.orderReferenceField;
            }
            set
            {
                this.orderReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string ProductEan
        {
            get
            {
                return this.productEanField;
            }
            set
            {
                this.productEanField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class FulfilmentOnDemandSupplyOrderRequest
    {

        private FulfilmentOrderLineRequest[] orderLineListField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        public FulfilmentOrderLineRequest[] OrderLineList
        {
            get
            {
                return this.orderLineListField;
            }
            set
            {
                this.orderLineListField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class FulfilmentProductDescription
    {

        private string externalSupplyOrderIdField;

        private string productEanField;

        private int quantityField;

        private string sellerProductReferenceField;

        private WarehouseType warehouseField;

        private System.Nullable<System.DateTime> warehouseReceptionMinDateField;

        private bool warehouseReceptionMinDateFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string ExternalSupplyOrderId
        {
            get
            {
                return this.externalSupplyOrderIdField;
            }
            set
            {
                this.externalSupplyOrderIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string ProductEan
        {
            get
            {
                return this.productEanField;
            }
            set
            {
                this.productEanField = value;
            }
        }

        /// <remarks/>
        public int Quantity
        {
            get
            {
                return this.quantityField;
            }
            set
            {
                this.quantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string SellerProductReference
        {
            get
            {
                return this.sellerProductReferenceField;
            }
            set
            {
                this.sellerProductReferenceField = value;
            }
        }

        /// <remarks/>
        public WarehouseType Warehouse
        {
            get
            {
                return this.warehouseField;
            }
            set
            {
                this.warehouseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<System.DateTime> WarehouseReceptionMinDate
        {
            get
            {
                return this.warehouseReceptionMinDateField;
            }
            set
            {
                this.warehouseReceptionMinDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WarehouseReceptionMinDateSpecified
        {
            get
            {
                return this.warehouseReceptionMinDateFieldSpecified;
            }
            set
            {
                this.warehouseReceptionMinDateFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public enum WarehouseType
    {

        /// <remarks/>
        CEM,

        /// <remarks/>
        ANZ,

        /// <remarks/>
        SMD,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class FulfilmentSupplyOrderRequest
    {

        private FulfilmentProductDescription[] productListField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        public FulfilmentProductDescription[] ProductList
        {
            get
            {
                return this.productListField;
            }
            set
            {
                this.productListField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class FulfilmentOnDemandOrderLineFilter
    {

        private string orderReferenceField;

        private string productEanField;

        private System.Nullable<WarehouseType> warehouseField;

        private bool warehouseFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string OrderReference
        {
            get
            {
                return this.orderReferenceField;
            }
            set
            {
                this.orderReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string ProductEan
        {
            get
            {
                return this.productEanField;
            }
            set
            {
                this.productEanField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<WarehouseType> Warehouse
        {
            get
            {
                return this.warehouseField;
            }
            set
            {
                this.warehouseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WarehouseSpecified
        {
            get
            {
                return this.warehouseFieldSpecified;
            }
            set
            {
                this.warehouseFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class FulfilmentActivationReportRequest
    {

        private System.Nullable<System.DateTime> beginDateField;

        private bool beginDateFieldSpecified;

        private int[] depositIdListField;

        private System.Nullable<System.DateTime> endDateField;

        private bool endDateFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<System.DateTime> BeginDate
        {
            get
            {
                return this.beginDateField;
            }
            set
            {
                this.beginDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BeginDateSpecified
        {
            get
            {
                return this.beginDateFieldSpecified;
            }
            set
            {
                this.beginDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace = "http://schemas.microsoft.com/2003/10/Serialization/Arrays", IsNullable = false)]
        public int[] DepositIdList
        {
            get
            {
                return this.depositIdListField;
            }
            set
            {
                this.depositIdListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<System.DateTime> EndDate
        {
            get
            {
                return this.endDateField;
            }
            set
            {
                this.endDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EndDateSpecified
        {
            get
            {
                return this.endDateFieldSpecified;
            }
            set
            {
                this.endDateFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.datacontract.org/2004/07/Cdiscount.Service.Marketplace.API.Externa" +
        "l.Contract.Data.Product")]
    public partial class FulfilmentProductRequest
    {

        private string[] barCodeListField;

        private FbcReferencementFilter fulfilmentReferencementField;

        private bool fulfilmentReferencementFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace = "http://schemas.microsoft.com/2003/10/Serialization/Arrays")]
        public string[] BarCodeList
        {
            get
            {
                return this.barCodeListField;
            }
            set
            {
                this.barCodeListField = value;
            }
        }

        /// <remarks/>
        public FbcReferencementFilter FulfilmentReferencement
        {
            get
            {
                return this.fulfilmentReferencementField;
            }
            set
            {
                this.fulfilmentReferencementField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FulfilmentReferencementSpecified
        {
            get
            {
                return this.fulfilmentReferencementFieldSpecified;
            }
            set
            {
                this.fulfilmentReferencementFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public enum FbcReferencementFilter
    {

        /// <remarks/>
        All,

        /// <remarks/>
        OnlyReferenced,

        /// <remarks/>
        OnlyNotReferenced,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.datacontract.org/2004/07/Cdiscount.Service.Marketplace.API.Externa" +
        "l.Contract.Data.Order")]
    public partial class OrderStatusRequest
    {

        private string corporationField;

        private string customerOrderNumberField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Corporation
        {
            get
            {
                return this.corporationField;
            }
            set
            {
                this.corporationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string CustomerOrderNumber
        {
            get
            {
                return this.customerOrderNumberField;
            }
            set
            {
                this.customerOrderNumberField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.datacontract.org/2004/07/Cdiscount.Service.Marketplace.API.Externa" +
        "l.Contract.Data.Order")]
    public partial class ExternalOrderLine
    {

        private string productEanField;

        private string productReferenceField;

        private int quantityField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string ProductEan
        {
            get
            {
                return this.productEanField;
            }
            set
            {
                this.productEanField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string ProductReference
        {
            get
            {
                return this.productReferenceField;
            }
            set
            {
                this.productReferenceField = value;
            }
        }

        /// <remarks/>
        public int Quantity
        {
            get
            {
                return this.quantityField;
            }
            set
            {
                this.quantityField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.datacontract.org/2004/07/Cdiscount.Service.Marketplace.API.Externa" +
        "l.Contract.Data.Order")]
    public partial class ExternalCustomer
    {

        private string additionalShippingAddressField;

        private string cellPhoneNumberField;

        private string civilityField;

        private string customerEmailAddressField;

        private string customerFirstNameField;

        private string customerLastNameField;

        private string landlinePhoneNumberField;

        private string localityField;

        private string shippingAddressField;

        private string shippingAddressTitleField;

        private string shippingCityField;

        private string shippingCountryField;

        private string shippingPostalCodeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string AdditionalShippingAddress
        {
            get
            {
                return this.additionalShippingAddressField;
            }
            set
            {
                this.additionalShippingAddressField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string CellPhoneNumber
        {
            get
            {
                return this.cellPhoneNumberField;
            }
            set
            {
                this.cellPhoneNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Civility
        {
            get
            {
                return this.civilityField;
            }
            set
            {
                this.civilityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string CustomerEmailAddress
        {
            get
            {
                return this.customerEmailAddressField;
            }
            set
            {
                this.customerEmailAddressField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string CustomerFirstName
        {
            get
            {
                return this.customerFirstNameField;
            }
            set
            {
                this.customerFirstNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string CustomerLastName
        {
            get
            {
                return this.customerLastNameField;
            }
            set
            {
                this.customerLastNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string LandlinePhoneNumber
        {
            get
            {
                return this.landlinePhoneNumberField;
            }
            set
            {
                this.landlinePhoneNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Locality
        {
            get
            {
                return this.localityField;
            }
            set
            {
                this.localityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string ShippingAddress
        {
            get
            {
                return this.shippingAddressField;
            }
            set
            {
                this.shippingAddressField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string ShippingAddressTitle
        {
            get
            {
                return this.shippingAddressTitleField;
            }
            set
            {
                this.shippingAddressTitleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string ShippingCity
        {
            get
            {
                return this.shippingCityField;
            }
            set
            {
                this.shippingCityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string ShippingCountry
        {
            get
            {
                return this.shippingCountryField;
            }
            set
            {
                this.shippingCountryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string ShippingPostalCode
        {
            get
            {
                return this.shippingPostalCodeField;
            }
            set
            {
                this.shippingPostalCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.datacontract.org/2004/07/Cdiscount.Service.Marketplace.API.Externa" +
        "l.Contract.Data.Order")]
    public partial class ExternalOrder
    {

        private string commentsField;

        private string corporationField;

        private ExternalCustomer customerField;

        private string customerOrderNumberField;

        private System.Nullable<System.DateTime> orderDateField;

        private bool orderDateFieldSpecified;

        private ExternalOrderLine[] orderLineListField;

        private string shippingModeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Comments
        {
            get
            {
                return this.commentsField;
            }
            set
            {
                this.commentsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Corporation
        {
            get
            {
                return this.corporationField;
            }
            set
            {
                this.corporationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public ExternalCustomer Customer
        {
            get
            {
                return this.customerField;
            }
            set
            {
                this.customerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string CustomerOrderNumber
        {
            get
            {
                return this.customerOrderNumberField;
            }
            set
            {
                this.customerOrderNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<System.DateTime> OrderDate
        {
            get
            {
                return this.orderDateField;
            }
            set
            {
                this.orderDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OrderDateSpecified
        {
            get
            {
                return this.orderDateFieldSpecified;
            }
            set
            {
                this.orderDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        public ExternalOrderLine[] OrderLineList
        {
            get
            {
                return this.orderLineListField;
            }
            set
            {
                this.orderLineListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string ShippingMode
        {
            get
            {
                return this.shippingModeField;
            }
            set
            {
                this.shippingModeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.datacontract.org/2004/07/Cdiscount.Service.Marketplace.API.Externa" +
        "l.Contract.Data.Order")]
    public partial class OrderIntegrationRequest
    {

        private ExternalOrder orderField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public ExternalOrder Order
        {
            get
            {
                return this.orderField;
            }
            set
            {
                this.orderField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class GetDiscussionMailListRequest
    {

        private long[] discussionIdsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace = "http://schemas.microsoft.com/2003/10/Serialization/Arrays", IsNullable = false)]
        public long[] DiscussionIds
        {
            get
            {
                return this.discussionIdsField;
            }
            set
            {
                this.discussionIdsField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OfferQuestionFilter))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OrderQuestionFilter))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OrderClaimFilter))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class DiscussionFilterBase
    {

        private System.Nullable<System.DateTime> beginCreationDateField;

        private bool beginCreationDateFieldSpecified;

        private System.Nullable<System.DateTime> beginModificationDateField;

        private bool beginModificationDateFieldSpecified;

        private System.Nullable<System.DateTime> endCreationDateField;

        private bool endCreationDateFieldSpecified;

        private System.Nullable<System.DateTime> endModificationDateField;

        private bool endModificationDateFieldSpecified;

        private DiscussionStateFilter[] statusListField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<System.DateTime> BeginCreationDate
        {
            get
            {
                return this.beginCreationDateField;
            }
            set
            {
                this.beginCreationDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BeginCreationDateSpecified
        {
            get
            {
                return this.beginCreationDateFieldSpecified;
            }
            set
            {
                this.beginCreationDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<System.DateTime> BeginModificationDate
        {
            get
            {
                return this.beginModificationDateField;
            }
            set
            {
                this.beginModificationDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BeginModificationDateSpecified
        {
            get
            {
                return this.beginModificationDateFieldSpecified;
            }
            set
            {
                this.beginModificationDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<System.DateTime> EndCreationDate
        {
            get
            {
                return this.endCreationDateField;
            }
            set
            {
                this.endCreationDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EndCreationDateSpecified
        {
            get
            {
                return this.endCreationDateFieldSpecified;
            }
            set
            {
                this.endCreationDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<System.DateTime> EndModificationDate
        {
            get
            {
                return this.endModificationDateField;
            }
            set
            {
                this.endModificationDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EndModificationDateSpecified
        {
            get
            {
                return this.endModificationDateFieldSpecified;
            }
            set
            {
                this.endModificationDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        public DiscussionStateFilter[] StatusList
        {
            get
            {
                return this.statusListField;
            }
            set
            {
                this.statusListField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public enum DiscussionStateFilter
    {

        /// <remarks/>
        All,

        /// <remarks/>
        Open,

        /// <remarks/>
        Closed,

        /// <remarks/>
        NotProcessed,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class OfferQuestionFilter : DiscussionFilterBase
    {

        private string[] productEANListField;

        private string[] productSellerReferenceListField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace = "http://schemas.microsoft.com/2003/10/Serialization/Arrays")]
        public string[] ProductEANList
        {
            get
            {
                return this.productEANListField;
            }
            set
            {
                this.productEANListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace = "http://schemas.microsoft.com/2003/10/Serialization/Arrays")]
        public string[] ProductSellerReferenceList
        {
            get
            {
                return this.productSellerReferenceListField;
            }
            set
            {
                this.productSellerReferenceListField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OrderClaimFilter))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class OrderQuestionFilter : DiscussionFilterBase
    {

        private string[] orderNumberListField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace = "http://schemas.microsoft.com/2003/10/Serialization/Arrays")]
        public string[] OrderNumberList
        {
            get
            {
                return this.orderNumberListField;
            }
            set
            {
                this.orderNumberListField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class OrderClaimFilter : OrderQuestionFilter
    {

        private System.Nullable<bool> onlyWithMessageFromCdsCustomerServiceField;

        private bool onlyWithMessageFromCdsCustomerServiceFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<bool> OnlyWithMessageFromCdsCustomerService
        {
            get
            {
                return this.onlyWithMessageFromCdsCustomerServiceField;
            }
            set
            {
                this.onlyWithMessageFromCdsCustomerServiceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OnlyWithMessageFromCdsCustomerServiceSpecified
        {
            get
            {
                return this.onlyWithMessageFromCdsCustomerServiceFieldSpecified;
            }
            set
            {
                this.onlyWithMessageFromCdsCustomerServiceFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class CloseDiscussionRequest
    {

        private long[] discussionIdsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace = "http://schemas.microsoft.com/2003/10/Serialization/Arrays", IsNullable = false)]
        public long[] DiscussionIds
        {
            get
            {
                return this.discussionIdsField;
            }
            set
            {
                this.discussionIdsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class RelaysFileFilter
    {

        private int relaysFileIdField;

        private bool relaysFileIdFieldSpecified;

        /// <remarks/>
        public int RelaysFileId
        {
            get
            {
                return this.relaysFileIdField;
            }
            set
            {
                this.relaysFileIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RelaysFileIdSpecified
        {
            get
            {
                return this.relaysFileIdFieldSpecified;
            }
            set
            {
                this.relaysFileIdFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class RelaysFileIntegrationRequest
    {

        private string relaysFileURIField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string RelaysFileURI
        {
            get
            {
                return this.relaysFileURIField;
            }
            set
            {
                this.relaysFileURIField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.datacontract.org/2004/07/Cdiscount.Service.Marketplace.API.Externa" +
        "l.Contract.Data.Mail")]
    public partial class DiscussionMailGuidCreationRequestMessage
    {

        private string scopusIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string ScopusId
        {
            get
            {
                return this.scopusIdField;
            }
            set
            {
                this.scopusIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class CreateRefundVoucherRequest
    {

        private RefundInformation[] commercialGestureListField;

        private string orderNumberField;

        private SellerRefundRequest[] sellerRefundListField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        public RefundInformation[] CommercialGestureList
        {
            get
            {
                return this.commercialGestureListField;
            }
            set
            {
                this.commercialGestureListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string OrderNumber
        {
            get
            {
                return this.orderNumberField;
            }
            set
            {
                this.orderNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        public SellerRefundRequest[] SellerRefundList
        {
            get
            {
                return this.sellerRefundListField;
            }
            set
            {
                this.sellerRefundListField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class RefundInformation
    {

        private decimal amountField;

        private int motiveIdField;

        /// <remarks/>
        public decimal Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }

        /// <remarks/>
        public int MotiveId
        {
            get
            {
                return this.motiveIdField;
            }
            set
            {
                this.motiveIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class SellerRefundRequest
    {

        private SellerRefundRequestMode modeField;

        private bool modeFieldSpecified;

        private RefundMotive motiveField;

        private bool motiveFieldSpecified;

        private SellerRefundOrderLine refundOrderLineField;

        /// <remarks/>
        public SellerRefundRequestMode Mode
        {
            get
            {
                return this.modeField;
            }
            set
            {
                this.modeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ModeSpecified
        {
            get
            {
                return this.modeFieldSpecified;
            }
            set
            {
                this.modeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public RefundMotive Motive
        {
            get
            {
                return this.motiveField;
            }
            set
            {
                this.motiveField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MotiveSpecified
        {
            get
            {
                return this.motiveFieldSpecified;
            }
            set
            {
                this.motiveFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public SellerRefundOrderLine RefundOrderLine
        {
            get
            {
                return this.refundOrderLineField;
            }
            set
            {
                this.refundOrderLineField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public enum SellerRefundRequestMode
    {

        /// <remarks/>
        Claim,

        /// <remarks/>
        Retraction,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public enum RefundMotive
    {

        /// <remarks/>
        VendorRejection,

        /// <remarks/>
        ClientCancellation,

        /// <remarks/>
        VendorRejectionAndClientCancellation,

        /// <remarks/>
        ClientClaim,

        /// <remarks/>
        VendorInitiatedRefund,

        /// <remarks/>
        ClientRetraction,

        /// <remarks/>
        NoClientWithDrawal,

        /// <remarks/>
        ProductStockUnavailable,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class SellerRefundOrderLine
    {

        private string eanField;

        private System.Nullable<bool> refundShippingChargesField;

        private bool refundShippingChargesFieldSpecified;

        private string sellerProductIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Ean
        {
            get
            {
                return this.eanField;
            }
            set
            {
                this.eanField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<bool> RefundShippingCharges
        {
            get
            {
                return this.refundShippingChargesField;
            }
            set
            {
                this.refundShippingChargesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RefundShippingChargesSpecified
        {
            get
            {
                return this.refundShippingChargesFieldSpecified;
            }
            set
            {
                this.refundShippingChargesFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string SellerProductId
        {
            get
            {
                return this.sellerProductIdField;
            }
            set
            {
                this.sellerProductIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class SellerRefundRequestMessage
    {

        private string orderNumberField;

        private SellerRefundRequest[] sellerRefundRequestListField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string OrderNumber
        {
            get
            {
                return this.orderNumberField;
            }
            set
            {
                this.orderNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        public SellerRefundRequest[] SellerRefundRequestList
        {
            get
            {
                return this.sellerRefundRequestListField;
            }
            set
            {
                this.sellerRefundRequestListField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class ParcelInfos
    {

        private ParcelActionTypes manageParcelField;

        private bool manageParcelFieldSpecified;

        private string parcelNumberField;

        private string skuField;

        /// <remarks/>
        public ParcelActionTypes ManageParcel
        {
            get
            {
                return this.manageParcelField;
            }
            set
            {
                this.manageParcelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ManageParcelSpecified
        {
            get
            {
                return this.manageParcelFieldSpecified;
            }
            set
            {
                this.manageParcelFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string ParcelNumber
        {
            get
            {
                return this.parcelNumberField;
            }
            set
            {
                this.parcelNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Sku
        {
            get
            {
                return this.skuField;
            }
            set
            {
                this.skuField = value;
            }
        }
    }

    /// <remarks/>
    [System.FlagsAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public enum ParcelActionTypes
    {

        /// <remarks/>
        AskingForInvestigation = 1,

        /// <remarks/>
        AskingForDeliveryCertification = 2,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class ManageParcelRequest
    {

        private ParcelInfos[] parcelActionsListField;

        private string scopusIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        public ParcelInfos[] ParcelActionsList
        {
            get
            {
                return this.parcelActionsListField;
            }
            set
            {
                this.parcelActionsListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string ScopusId
        {
            get
            {
                return this.scopusIdField;
            }
            set
            {
                this.scopusIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class ValidateOrderLine
    {

        private AcceptationStateEnum acceptationStateField;

        private bool acceptationStateFieldSpecified;

        private ProductConditionEnum productConditionField;

        private bool productConditionFieldSpecified;

        private string sellerProductIdField;

        private System.Nullable<AskingForReturnType> typeOfReturnField;

        private bool typeOfReturnFieldSpecified;

        /// <remarks/>
        public AcceptationStateEnum AcceptationState
        {
            get
            {
                return this.acceptationStateField;
            }
            set
            {
                this.acceptationStateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AcceptationStateSpecified
        {
            get
            {
                return this.acceptationStateFieldSpecified;
            }
            set
            {
                this.acceptationStateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public ProductConditionEnum ProductCondition
        {
            get
            {
                return this.productConditionField;
            }
            set
            {
                this.productConditionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ProductConditionSpecified
        {
            get
            {
                return this.productConditionFieldSpecified;
            }
            set
            {
                this.productConditionFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string SellerProductId
        {
            get
            {
                return this.sellerProductIdField;
            }
            set
            {
                this.sellerProductIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<AskingForReturnType> TypeOfReturn
        {
            get
            {
                return this.typeOfReturnField;
            }
            set
            {
                this.typeOfReturnField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TypeOfReturnSpecified
        {
            get
            {
                return this.typeOfReturnFieldSpecified;
            }
            set
            {
                this.typeOfReturnFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public enum AcceptationStateEnum
    {

        /// <remarks/>
        None,

        /// <remarks/>
        AcceptedBySeller,

        /// <remarks/>
        RefusedBySeller,

        /// <remarks/>
        ShippedBySeller,

        /// <remarks/>
        RefundedAfterShipping,

        /// <remarks/>
        ShipmentRefusedBySeller,

        /// <remarks/>
        RefundedAfterShipmentRefused,

        /// <remarks/>
        CancelledBeforeNotificationByCustomer,

        /// <remarks/>
        CancelledBeforePaymentByCustomer,

        /// <remarks/>
        CancellationRequestPending,

        /// <remarks/>
        CancelledAfterPaymentByCustomer,

        /// <remarks/>
        RefundedAfterCustomerCancellation,

        /// <remarks/>
        PaymentRefused,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public enum ProductConditionEnum
    {

        /// <remarks/>
        None,

        /// <remarks/>
        LikeNew,

        /// <remarks/>
        VeryGoodState,

        /// <remarks/>
        GoodState,

        /// <remarks/>
        AverageState,

        /// <remarks/>
        Refurbished,

        /// <remarks/>
        New,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public enum AskingForReturnType
    {

        /// <remarks/>
        AskingForReturn,

        /// <remarks/>
        AskingForReturnAndRemoval,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class ValidateOrder
    {

        private string carrierNameField;

        private ValidateOrderLine[] orderLineListField;

        private string orderNumberField;

        private OrderStateEnum orderStateField;

        private bool orderStateFieldSpecified;

        private string trackingNumberField;

        private string trackingUrlField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string CarrierName
        {
            get
            {
                return this.carrierNameField;
            }
            set
            {
                this.carrierNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        public ValidateOrderLine[] OrderLineList
        {
            get
            {
                return this.orderLineListField;
            }
            set
            {
                this.orderLineListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string OrderNumber
        {
            get
            {
                return this.orderNumberField;
            }
            set
            {
                this.orderNumberField = value;
            }
        }

        /// <remarks/>
        public OrderStateEnum OrderState
        {
            get
            {
                return this.orderStateField;
            }
            set
            {
                this.orderStateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OrderStateSpecified
        {
            get
            {
                return this.orderStateFieldSpecified;
            }
            set
            {
                this.orderStateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string TrackingNumber
        {
            get
            {
                return this.trackingNumberField;
            }
            set
            {
                this.trackingNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string TrackingUrl
        {
            get
            {
                return this.trackingUrlField;
            }
            set
            {
                this.trackingUrlField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public enum OrderStateEnum
    {

        /// <remarks/>
        CancelledByCustomer,

        /// <remarks/>
        WaitingForSellerAcceptation,

        /// <remarks/>
        AcceptedBySeller,

        /// <remarks/>
        PaymentInProgress,

        /// <remarks/>
        WaitingForShipmentAcceptation,

        /// <remarks/>
        Shipped,

        /// <remarks/>
        RefusedBySeller,

        /// <remarks/>
        AutomaticCancellation,

        /// <remarks/>
        PaymentRefused,

        /// <remarks/>
        ShipmentRefusedBySeller,

        /// <remarks/>
        None,

        /// <remarks/>
        ValidatedFianet,

        /// <remarks/>
        RefusedNoShipment,

        /// <remarks/>
        AvailableOnStore,

        /// <remarks/>
        NonPickedUpByCustomer,

        /// <remarks/>
        PickedUp,

        /// <remarks/>
        ServiceCanceled,

        /// <remarks/>
        PendingShipmentForAssociatedProduct,

        /// <remarks/>
        BlockedWaitingForTreatment,

        /// <remarks/>
        BlockedWaitingForProof,

        /// <remarks/>
        BlockedRepeatedLitigationSuspicion,

        /// <remarks/>
        BlockedFraudSuspicion,

        /// <remarks/>
        BlockedConfirmed,

        /// <remarks/>
        FinishedGenerixUpdate,

        /// <remarks/>
        BlockedRepeatedLitigationSuspicionConfirmation,

        /// <remarks/>
        BlockedFraudSuspicionConfirmation,

        /// <remarks/>
        CegidDown,

        /// <remarks/>
        BlockedAutomaticCds,

        /// <remarks/>
        BeingCancelled,

        /// <remarks/>
        BeingModified,

        /// <remarks/>
        RequestGoingToGnx,

        /// <remarks/>
        PartialInGnx,

        /// <remarks/>
        BeingValidatedFianet,

        /// <remarks/>
        BlockedMarketplaceService,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class ValidateOrderListMessage
    {

        private ValidateOrder[] orderListField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        public ValidateOrder[] OrderList
        {
            get
            {
                return this.orderListField;
            }
            set
            {
                this.orderListField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class OrderFilter
    {

        private System.Nullable<System.DateTime> beginCreationDateField;

        private bool beginCreationDateFieldSpecified;

        private System.Nullable<System.DateTime> beginModificationDateField;

        private bool beginModificationDateFieldSpecified;

        private string corporationCodeField;

        private System.Nullable<System.DateTime> endCreationDateField;

        private bool endCreationDateFieldSpecified;

        private System.Nullable<System.DateTime> endModificationDateField;

        private bool endModificationDateFieldSpecified;

        private bool fetchOrderLinesField;

        private bool fetchOrderLinesFieldSpecified;

        private bool fetchParcelsField;

        private bool fetchParcelsFieldSpecified;

        private bool includeExternalFbcSiteIdField;

        private bool includeExternalFbcSiteIdFieldSpecified;

        private string[] orderReferenceListField;

        private System.Nullable<OrderTypeEnum> orderTypeField;

        private bool orderTypeFieldSpecified;

        private string partnerOrderRefField;

        private OrderStateEnum[] statesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<System.DateTime> BeginCreationDate
        {
            get
            {
                return this.beginCreationDateField;
            }
            set
            {
                this.beginCreationDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BeginCreationDateSpecified
        {
            get
            {
                return this.beginCreationDateFieldSpecified;
            }
            set
            {
                this.beginCreationDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<System.DateTime> BeginModificationDate
        {
            get
            {
                return this.beginModificationDateField;
            }
            set
            {
                this.beginModificationDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BeginModificationDateSpecified
        {
            get
            {
                return this.beginModificationDateFieldSpecified;
            }
            set
            {
                this.beginModificationDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string CorporationCode
        {
            get
            {
                return this.corporationCodeField;
            }
            set
            {
                this.corporationCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<System.DateTime> EndCreationDate
        {
            get
            {
                return this.endCreationDateField;
            }
            set
            {
                this.endCreationDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EndCreationDateSpecified
        {
            get
            {
                return this.endCreationDateFieldSpecified;
            }
            set
            {
                this.endCreationDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<System.DateTime> EndModificationDate
        {
            get
            {
                return this.endModificationDateField;
            }
            set
            {
                this.endModificationDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EndModificationDateSpecified
        {
            get
            {
                return this.endModificationDateFieldSpecified;
            }
            set
            {
                this.endModificationDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool FetchOrderLines
        {
            get
            {
                return this.fetchOrderLinesField;
            }
            set
            {
                this.fetchOrderLinesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FetchOrderLinesSpecified
        {
            get
            {
                return this.fetchOrderLinesFieldSpecified;
            }
            set
            {
                this.fetchOrderLinesFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool FetchParcels
        {
            get
            {
                return this.fetchParcelsField;
            }
            set
            {
                this.fetchParcelsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FetchParcelsSpecified
        {
            get
            {
                return this.fetchParcelsFieldSpecified;
            }
            set
            {
                this.fetchParcelsFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool IncludeExternalFbcSiteId
        {
            get
            {
                return this.includeExternalFbcSiteIdField;
            }
            set
            {
                this.includeExternalFbcSiteIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeExternalFbcSiteIdSpecified
        {
            get
            {
                return this.includeExternalFbcSiteIdFieldSpecified;
            }
            set
            {
                this.includeExternalFbcSiteIdFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace = "http://schemas.microsoft.com/2003/10/Serialization/Arrays")]
        public string[] OrderReferenceList
        {
            get
            {
                return this.orderReferenceListField;
            }
            set
            {
                this.orderReferenceListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<OrderTypeEnum> OrderType
        {
            get
            {
                return this.orderTypeField;
            }
            set
            {
                this.orderTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OrderTypeSpecified
        {
            get
            {
                return this.orderTypeFieldSpecified;
            }
            set
            {
                this.orderTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string PartnerOrderRef
        {
            get
            {
                return this.partnerOrderRefField;
            }
            set
            {
                this.partnerOrderRefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        public OrderStateEnum[] States
        {
            get
            {
                return this.statesField;
            }
            set
            {
                this.statesField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public enum OrderTypeEnum
    {

        /// <remarks/>
        IsFulfillment,

        /// <remarks/>
        MKPFBC,

        /// <remarks/>
        EXTFBC,

        /// <remarks/>
        None,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class OfferFilterPaginated
    {

        private System.Nullable<OfferFilterCriterion> offerFilterCriterionField;

        private bool offerFilterCriterionFieldSpecified;

        private System.Nullable<int> offerPoolIdField;

        private bool offerPoolIdFieldSpecified;

        private System.Nullable<OfferSortOrder> offerSortOrderField;

        private bool offerSortOrderFieldSpecified;

        private int pageNumberField;

        private string[] sellerProductIdListField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<OfferFilterCriterion> OfferFilterCriterion
        {
            get
            {
                return this.offerFilterCriterionField;
            }
            set
            {
                this.offerFilterCriterionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OfferFilterCriterionSpecified
        {
            get
            {
                return this.offerFilterCriterionFieldSpecified;
            }
            set
            {
                this.offerFilterCriterionFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<int> OfferPoolId
        {
            get
            {
                return this.offerPoolIdField;
            }
            set
            {
                this.offerPoolIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OfferPoolIdSpecified
        {
            get
            {
                return this.offerPoolIdFieldSpecified;
            }
            set
            {
                this.offerPoolIdFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<OfferSortOrder> OfferSortOrder
        {
            get
            {
                return this.offerSortOrderField;
            }
            set
            {
                this.offerSortOrderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OfferSortOrderSpecified
        {
            get
            {
                return this.offerSortOrderFieldSpecified;
            }
            set
            {
                this.offerSortOrderFieldSpecified = value;
            }
        }

        /// <remarks/>
        public int PageNumber
        {
            get
            {
                return this.pageNumberField;
            }
            set
            {
                this.pageNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace = "http://schemas.microsoft.com/2003/10/Serialization/Arrays")]
        public string[] SellerProductIdList
        {
            get
            {
                return this.sellerProductIdListField;
            }
            set
            {
                this.sellerProductIdListField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public enum OfferFilterCriterion
    {

        /// <remarks/>
        NewOffersOnly,

        /// <remarks/>
        UsedOffersOnly,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public enum OfferSortOrder
    {

        /// <remarks/>
        BySoldQuantityDescending,

        /// <remarks/>
        ByPriceAscending,

        /// <remarks/>
        ByPriceDescending,

        /// <remarks/>
        ByCreationDateDescending,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class OfferFilter
    {

        private System.Nullable<int> offerPoolIdField;

        private bool offerPoolIdFieldSpecified;

        private string[] sellerProductIdListField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<int> OfferPoolId
        {
            get
            {
                return this.offerPoolIdField;
            }
            set
            {
                this.offerPoolIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OfferPoolIdSpecified
        {
            get
            {
                return this.offerPoolIdFieldSpecified;
            }
            set
            {
                this.offerPoolIdFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace = "http://schemas.microsoft.com/2003/10/Serialization/Arrays")]
        public string[] SellerProductIdList
        {
            get
            {
                return this.sellerProductIdListField;
            }
            set
            {
                this.sellerProductIdListField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class OfferPackageRequest
    {

        private string zipFileFullPathField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string ZipFileFullPath
        {
            get
            {
                return this.zipFileFullPathField;
            }
            set
            {
                this.zipFileFullPathField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class IdentifierRequest
    {

        private IdentifierTypeEnum identifierTypeField;

        private bool identifierTypeFieldSpecified;

        private string[] valueListField;

        /// <remarks/>
        public IdentifierTypeEnum IdentifierType
        {
            get
            {
                return this.identifierTypeField;
            }
            set
            {
                this.identifierTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IdentifierTypeSpecified
        {
            get
            {
                return this.identifierTypeFieldSpecified;
            }
            set
            {
                this.identifierTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace = "http://schemas.microsoft.com/2003/10/Serialization/Arrays")]
        public string[] ValueList
        {
            get
            {
                return this.valueListField;
            }
            set
            {
                this.valueListField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public enum IdentifierTypeEnum
    {

        /// <remarks/>
        EAN,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class ModelFilter
    {

        private string[] categoryCodeListField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace = "http://schemas.microsoft.com/2003/10/Serialization/Arrays")]
        public string[] CategoryCodeList
        {
            get
            {
                return this.categoryCodeListField;
            }
            set
            {
                this.categoryCodeListField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class PackageFilter
    {

        private long packageIDField;

        private bool packageIDFieldSpecified;

        /// <remarks/>
        public long PackageID
        {
            get
            {
                return this.packageIDField;
            }
            set
            {
                this.packageIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PackageIDSpecified
        {
            get
            {
                return this.packageIDFieldSpecified;
            }
            set
            {
                this.packageIDFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class ProductPackageRequest
    {

        private string zipFileFullPathField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string ZipFileFullPath
        {
            get
            {
                return this.zipFileFullPathField;
            }
            set
            {
                this.zipFileFullPathField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class OfferProduct
    {

        private OfferPriceBenchMark bestOfferField;

        private long bestOfferIdField;

        private bool bestOfferIdFieldSpecified;

        private decimal bestOfferShippingChargesField;

        private bool bestOfferShippingChargesFieldSpecified;

        private System.DateTime lastUpdateDateField;

        private bool lastUpdateDateFieldSpecified;

        private long offerIdField;

        private bool offerIdFieldSpecified;

        private OfferPool[] offerPoolListField;

        private OfferStateEnum offerStateField;

        private bool offerStateFieldSpecified;

        private decimal priceField;

        private bool priceFieldSpecified;

        private ProductConditionEnum productConditionField;

        private bool productConditionFieldSpecified;

        private string productEanField;

        private string productIdField;

        private string productImageUrlField;

        private string productNameField;

        private string sellerProductIdField;

        private int stockField;

        private bool stockFieldSpecified;

        private SupplyModeType supplyModeField;

        private bool supplyModeFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public OfferPriceBenchMark BestOffer
        {
            get
            {
                return this.bestOfferField;
            }
            set
            {
                this.bestOfferField = value;
            }
        }

        /// <remarks/>
        public long BestOfferId
        {
            get
            {
                return this.bestOfferIdField;
            }
            set
            {
                this.bestOfferIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BestOfferIdSpecified
        {
            get
            {
                return this.bestOfferIdFieldSpecified;
            }
            set
            {
                this.bestOfferIdFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal BestOfferShippingCharges
        {
            get
            {
                return this.bestOfferShippingChargesField;
            }
            set
            {
                this.bestOfferShippingChargesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BestOfferShippingChargesSpecified
        {
            get
            {
                return this.bestOfferShippingChargesFieldSpecified;
            }
            set
            {
                this.bestOfferShippingChargesFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime LastUpdateDate
        {
            get
            {
                return this.lastUpdateDateField;
            }
            set
            {
                this.lastUpdateDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LastUpdateDateSpecified
        {
            get
            {
                return this.lastUpdateDateFieldSpecified;
            }
            set
            {
                this.lastUpdateDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public long OfferId
        {
            get
            {
                return this.offerIdField;
            }
            set
            {
                this.offerIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OfferIdSpecified
        {
            get
            {
                return this.offerIdFieldSpecified;
            }
            set
            {
                this.offerIdFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        public OfferPool[] OfferPoolList
        {
            get
            {
                return this.offerPoolListField;
            }
            set
            {
                this.offerPoolListField = value;
            }
        }

        /// <remarks/>
        public OfferStateEnum OfferState
        {
            get
            {
                return this.offerStateField;
            }
            set
            {
                this.offerStateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OfferStateSpecified
        {
            get
            {
                return this.offerStateFieldSpecified;
            }
            set
            {
                this.offerStateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal Price
        {
            get
            {
                return this.priceField;
            }
            set
            {
                this.priceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PriceSpecified
        {
            get
            {
                return this.priceFieldSpecified;
            }
            set
            {
                this.priceFieldSpecified = value;
            }
        }

        /// <remarks/>
        public ProductConditionEnum ProductCondition
        {
            get
            {
                return this.productConditionField;
            }
            set
            {
                this.productConditionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ProductConditionSpecified
        {
            get
            {
                return this.productConditionFieldSpecified;
            }
            set
            {
                this.productConditionFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string ProductEan
        {
            get
            {
                return this.productEanField;
            }
            set
            {
                this.productEanField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string ProductId
        {
            get
            {
                return this.productIdField;
            }
            set
            {
                this.productIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string ProductImageUrl
        {
            get
            {
                return this.productImageUrlField;
            }
            set
            {
                this.productImageUrlField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string ProductName
        {
            get
            {
                return this.productNameField;
            }
            set
            {
                this.productNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string SellerProductId
        {
            get
            {
                return this.sellerProductIdField;
            }
            set
            {
                this.sellerProductIdField = value;
            }
        }

        /// <remarks/>
        public int Stock
        {
            get
            {
                return this.stockField;
            }
            set
            {
                this.stockField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StockSpecified
        {
            get
            {
                return this.stockFieldSpecified;
            }
            set
            {
                this.stockFieldSpecified = value;
            }
        }

        /// <remarks/>
        public SupplyModeType SupplyMode
        {
            get
            {
                return this.supplyModeField;
            }
            set
            {
                this.supplyModeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SupplyModeSpecified
        {
            get
            {
                return this.supplyModeFieldSpecified;
            }
            set
            {
                this.supplyModeFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class OfferPriceBenchMark
    {

        private decimal bestOfferPriceField;

        private bool bestOfferPriceFieldSpecified;

        private bool isBestOfferPriceField;

        private bool isBestOfferPriceFieldSpecified;

        private ProductConditionEnum productConditionField;

        private bool productConditionFieldSpecified;

        private ProductStateEnum productStateField;

        private bool productStateFieldSpecified;

        private decimal shippingChargesField;

        private bool shippingChargesFieldSpecified;

        /// <remarks/>
        public decimal BestOfferPrice
        {
            get
            {
                return this.bestOfferPriceField;
            }
            set
            {
                this.bestOfferPriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BestOfferPriceSpecified
        {
            get
            {
                return this.bestOfferPriceFieldSpecified;
            }
            set
            {
                this.bestOfferPriceFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool IsBestOfferPrice
        {
            get
            {
                return this.isBestOfferPriceField;
            }
            set
            {
                this.isBestOfferPriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsBestOfferPriceSpecified
        {
            get
            {
                return this.isBestOfferPriceFieldSpecified;
            }
            set
            {
                this.isBestOfferPriceFieldSpecified = value;
            }
        }

        /// <remarks/>
        public ProductConditionEnum ProductCondition
        {
            get
            {
                return this.productConditionField;
            }
            set
            {
                this.productConditionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ProductConditionSpecified
        {
            get
            {
                return this.productConditionFieldSpecified;
            }
            set
            {
                this.productConditionFieldSpecified = value;
            }
        }

        /// <remarks/>
        public ProductStateEnum ProductState
        {
            get
            {
                return this.productStateField;
            }
            set
            {
                this.productStateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ProductStateSpecified
        {
            get
            {
                return this.productStateFieldSpecified;
            }
            set
            {
                this.productStateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal ShippingCharges
        {
            get
            {
                return this.shippingChargesField;
            }
            set
            {
                this.shippingChargesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ShippingChargesSpecified
        {
            get
            {
                return this.shippingChargesFieldSpecified;
            }
            set
            {
                this.shippingChargesFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public enum ProductStateEnum
    {

        /// <remarks/>
        New,

        /// <remarks/>
        Used,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class OfferPool
    {

        private string descriptionField;

        private int idField;

        private bool idFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public int Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IdSpecified
        {
            get
            {
                return this.idFieldSpecified;
            }
            set
            {
                this.idFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public enum OfferStateEnum
    {

        /// <remarks/>
        WaitingForProductActivation,

        /// <remarks/>
        Active,

        /// <remarks/>
        Inactive,

        /// <remarks/>
        Archived,

        /// <remarks/>
        Fulfillment,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.datacontract.org/2004/07/Cdiscount.Service.Marketplace.API.Externa" +
        "l.Contract.Data.Offer.Enum")]
    public enum SupplyModeType
    {

        /// <remarks/>
        Mkp,

        /// <remarks/>
        Fbc,

        /// <remarks/>
        Ttd,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class SupplyOrderReportLine
    {

        private ArrayOfKeyValueOfintstringKeyValueOfintstring[] errorDetailsField;

        private int orderedQuantityField;

        private string productEanField;

        private long sellerIdField;

        private bool sellerIdFieldSpecified;

        private string sellerProductReferenceField;

        private string sellerSupplyOrderNumberField;

        private string supplyOrderNumberField;

        private System.Nullable<WarehouseType> warehouseField;

        private System.Nullable<System.DateTime> warehouseReceptionMinDateField;

        private bool warehouseReceptionMinDateFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        [System.Xml.Serialization.XmlArrayItemAttribute("KeyValueOfintstring", Namespace = "http://schemas.microsoft.com/2003/10/Serialization/Arrays", IsNullable = false)]
        public ArrayOfKeyValueOfintstringKeyValueOfintstring[] ErrorDetails
        {
            get
            {
                return this.errorDetailsField;
            }
            set
            {
                this.errorDetailsField = value;
            }
        }

        /// <remarks/>
        public int OrderedQuantity
        {
            get
            {
                return this.orderedQuantityField;
            }
            set
            {
                this.orderedQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string ProductEan
        {
            get
            {
                return this.productEanField;
            }
            set
            {
                this.productEanField = value;
            }
        }

        /// <remarks/>
        public long SellerId
        {
            get
            {
                return this.sellerIdField;
            }
            set
            {
                this.sellerIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SellerIdSpecified
        {
            get
            {
                return this.sellerIdFieldSpecified;
            }
            set
            {
                this.sellerIdFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string SellerProductReference
        {
            get
            {
                return this.sellerProductReferenceField;
            }
            set
            {
                this.sellerProductReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string SellerSupplyOrderNumber
        {
            get
            {
                return this.sellerSupplyOrderNumberField;
            }
            set
            {
                this.sellerSupplyOrderNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string SupplyOrderNumber
        {
            get
            {
                return this.supplyOrderNumberField;
            }
            set
            {
                this.supplyOrderNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<WarehouseType> Warehouse
        {
            get
            {
                return this.warehouseField;
            }
            set
            {
                this.warehouseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<System.DateTime> WarehouseReceptionMinDate
        {
            get
            {
                return this.warehouseReceptionMinDateField;
            }
            set
            {
                this.warehouseReceptionMinDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WarehouseReceptionMinDateSpecified
        {
            get
            {
                return this.warehouseReceptionMinDateFieldSpecified;
            }
            set
            {
                this.warehouseReceptionMinDateFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/2003/10/Serialization/Arrays")]
    public partial class ArrayOfKeyValueOfintstringKeyValueOfintstring
    {

        private int keyField;

        private string valueField;

        /// <remarks/>
        public int Key
        {
            get
            {
                return this.keyField;
            }
            set
            {
                this.keyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class SupplyOrderReport
    {

        private int depositIdField;

        private SupplyOrderReportLine[] reportLineListField;

        /// <remarks/>
        public int DepositId
        {
            get
            {
                return this.depositIdField;
            }
            set
            {
                this.depositIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        public SupplyOrderReportLine[] ReportLineList
        {
            get
            {
                return this.reportLineListField;
            }
            set
            {
                this.reportLineListField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class SupplyOrderLine
    {

        private bool isFodField;

        private bool isFodFieldSpecified;

        private string[] orderReferenceListField;

        private int orderedQuantityField;

        private bool orderedQuantityFieldSpecified;

        private string productEanField;

        private System.Nullable<int> receivedQuantityField;

        private bool receivedQuantityFieldSpecified;

        private string sellerProductReferenceField;

        private string sellerSupplyOrderNumberField;

        private System.Nullable<SupplyOrderStatusType> statusField;

        private bool statusFieldSpecified;

        private string supplyOrderNumberField;

        private int undeliveredQuantityField;

        private bool undeliveredQuantityFieldSpecified;

        private System.Nullable<WarehouseType> warehouseField;

        private bool warehouseFieldSpecified;

        private System.Nullable<System.DateTime> warehouseReceptionMinDateField;

        private bool warehouseReceptionMinDateFieldSpecified;

        /// <remarks/>
        public bool IsFod
        {
            get
            {
                return this.isFodField;
            }
            set
            {
                this.isFodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsFodSpecified
        {
            get
            {
                return this.isFodFieldSpecified;
            }
            set
            {
                this.isFodFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace = "http://schemas.microsoft.com/2003/10/Serialization/Arrays")]
        public string[] OrderReferenceList
        {
            get
            {
                return this.orderReferenceListField;
            }
            set
            {
                this.orderReferenceListField = value;
            }
        }

        /// <remarks/>
        public int OrderedQuantity
        {
            get
            {
                return this.orderedQuantityField;
            }
            set
            {
                this.orderedQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OrderedQuantitySpecified
        {
            get
            {
                return this.orderedQuantityFieldSpecified;
            }
            set
            {
                this.orderedQuantityFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string ProductEan
        {
            get
            {
                return this.productEanField;
            }
            set
            {
                this.productEanField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<int> ReceivedQuantity
        {
            get
            {
                return this.receivedQuantityField;
            }
            set
            {
                this.receivedQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReceivedQuantitySpecified
        {
            get
            {
                return this.receivedQuantityFieldSpecified;
            }
            set
            {
                this.receivedQuantityFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string SellerProductReference
        {
            get
            {
                return this.sellerProductReferenceField;
            }
            set
            {
                this.sellerProductReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string SellerSupplyOrderNumber
        {
            get
            {
                return this.sellerSupplyOrderNumberField;
            }
            set
            {
                this.sellerSupplyOrderNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<SupplyOrderStatusType> Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StatusSpecified
        {
            get
            {
                return this.statusFieldSpecified;
            }
            set
            {
                this.statusFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string SupplyOrderNumber
        {
            get
            {
                return this.supplyOrderNumberField;
            }
            set
            {
                this.supplyOrderNumberField = value;
            }
        }

        /// <remarks/>
        public int UndeliveredQuantity
        {
            get
            {
                return this.undeliveredQuantityField;
            }
            set
            {
                this.undeliveredQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UndeliveredQuantitySpecified
        {
            get
            {
                return this.undeliveredQuantityFieldSpecified;
            }
            set
            {
                this.undeliveredQuantityFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<WarehouseType> Warehouse
        {
            get
            {
                return this.warehouseField;
            }
            set
            {
                this.warehouseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WarehouseSpecified
        {
            get
            {
                return this.warehouseFieldSpecified;
            }
            set
            {
                this.warehouseFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<System.DateTime> WarehouseReceptionMinDate
        {
            get
            {
                return this.warehouseReceptionMinDateField;
            }
            set
            {
                this.warehouseReceptionMinDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WarehouseReceptionMinDateSpecified
        {
            get
            {
                return this.warehouseReceptionMinDateFieldSpecified;
            }
            set
            {
                this.warehouseReceptionMinDateFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public enum SupplyOrderStatusType
    {

        /// <remarks/>
        Registered,

        /// <remarks/>
        AppointmentScheduled,

        /// <remarks/>
        SupplyingInProgress,

        /// <remarks/>
        SupplyingDone,

        /// <remarks/>
        Rejected,

        /// <remarks/>
        Validated,

        /// <remarks/>
        Cancelled,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class FulfilmentOrderLine
    {

        private System.DateTime expectedCustomerDeliveryMaxField;

        private bool expectedCustomerDeliveryMaxFieldSpecified;

        private System.DateTime expectedCustomerDeliveryMinField;

        private bool expectedCustomerDeliveryMinFieldSpecified;

        private System.DateTime latestWarehouseDeliveryDateField;

        private bool latestWarehouseDeliveryDateFieldSpecified;

        private System.DateTime orderDateField;

        private bool orderDateFieldSpecified;

        private string orderReferenceField;

        private string productEanField;

        private string productNameField;

        private int quantityField;

        private bool quantityFieldSpecified;

        private string sellerProductReferenceField;

        private System.Nullable<WarehouseType> warehouseField;

        private bool warehouseFieldSpecified;

        /// <remarks/>
        public System.DateTime ExpectedCustomerDeliveryMax
        {
            get
            {
                return this.expectedCustomerDeliveryMaxField;
            }
            set
            {
                this.expectedCustomerDeliveryMaxField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ExpectedCustomerDeliveryMaxSpecified
        {
            get
            {
                return this.expectedCustomerDeliveryMaxFieldSpecified;
            }
            set
            {
                this.expectedCustomerDeliveryMaxFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime ExpectedCustomerDeliveryMin
        {
            get
            {
                return this.expectedCustomerDeliveryMinField;
            }
            set
            {
                this.expectedCustomerDeliveryMinField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ExpectedCustomerDeliveryMinSpecified
        {
            get
            {
                return this.expectedCustomerDeliveryMinFieldSpecified;
            }
            set
            {
                this.expectedCustomerDeliveryMinFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime LatestWarehouseDeliveryDate
        {
            get
            {
                return this.latestWarehouseDeliveryDateField;
            }
            set
            {
                this.latestWarehouseDeliveryDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LatestWarehouseDeliveryDateSpecified
        {
            get
            {
                return this.latestWarehouseDeliveryDateFieldSpecified;
            }
            set
            {
                this.latestWarehouseDeliveryDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime OrderDate
        {
            get
            {
                return this.orderDateField;
            }
            set
            {
                this.orderDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OrderDateSpecified
        {
            get
            {
                return this.orderDateFieldSpecified;
            }
            set
            {
                this.orderDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string OrderReference
        {
            get
            {
                return this.orderReferenceField;
            }
            set
            {
                this.orderReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string ProductEan
        {
            get
            {
                return this.productEanField;
            }
            set
            {
                this.productEanField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string ProductName
        {
            get
            {
                return this.productNameField;
            }
            set
            {
                this.productNameField = value;
            }
        }

        /// <remarks/>
        public int Quantity
        {
            get
            {
                return this.quantityField;
            }
            set
            {
                this.quantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool QuantitySpecified
        {
            get
            {
                return this.quantityFieldSpecified;
            }
            set
            {
                this.quantityFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string SellerProductReference
        {
            get
            {
                return this.sellerProductReferenceField;
            }
            set
            {
                this.sellerProductReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<WarehouseType> Warehouse
        {
            get
            {
                return this.warehouseField;
            }
            set
            {
                this.warehouseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WarehouseSpecified
        {
            get
            {
                return this.warehouseFieldSpecified;
            }
            set
            {
                this.warehouseFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class FulfilmentActivationReportDetails
    {

        private FulfilmentProductActionType actionField;

        private bool actionFieldSpecified;

        private System.Nullable<bool> actionSuccessField;

        private bool actionSuccessFieldSpecified;

        private string descriptionField;

        private System.Nullable<double> heightField;

        private bool heightFieldSpecified;

        private System.Nullable<double> lengthField;

        private bool lengthFieldSpecified;

        private string productEanField;

        private string productIdField;

        private string sellerProductReferenceField;

        private System.Nullable<float> weightField;

        private bool weightFieldSpecified;

        private System.Nullable<double> widthField;

        private bool widthFieldSpecified;

        /// <remarks/>
        public FulfilmentProductActionType Action
        {
            get
            {
                return this.actionField;
            }
            set
            {
                this.actionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ActionSpecified
        {
            get
            {
                return this.actionFieldSpecified;
            }
            set
            {
                this.actionFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<bool> ActionSuccess
        {
            get
            {
                return this.actionSuccessField;
            }
            set
            {
                this.actionSuccessField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ActionSuccessSpecified
        {
            get
            {
                return this.actionSuccessFieldSpecified;
            }
            set
            {
                this.actionSuccessFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<double> Height
        {
            get
            {
                return this.heightField;
            }
            set
            {
                this.heightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HeightSpecified
        {
            get
            {
                return this.heightFieldSpecified;
            }
            set
            {
                this.heightFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<double> Length
        {
            get
            {
                return this.lengthField;
            }
            set
            {
                this.lengthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LengthSpecified
        {
            get
            {
                return this.lengthFieldSpecified;
            }
            set
            {
                this.lengthFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string ProductEan
        {
            get
            {
                return this.productEanField;
            }
            set
            {
                this.productEanField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string ProductId
        {
            get
            {
                return this.productIdField;
            }
            set
            {
                this.productIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string SellerProductReference
        {
            get
            {
                return this.sellerProductReferenceField;
            }
            set
            {
                this.sellerProductReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<float> Weight
        {
            get
            {
                return this.weightField;
            }
            set
            {
                this.weightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WeightSpecified
        {
            get
            {
                return this.weightFieldSpecified;
            }
            set
            {
                this.weightFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<double> Width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WidthSpecified
        {
            get
            {
                return this.widthFieldSpecified;
            }
            set
            {
                this.widthFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class FulfilmentActivationReport
    {

        private System.Nullable<int> depositIdField;

        private bool depositIdFieldSpecified;

        private FulfilmentActivationReportDetails[] detailsListField;

        private int numberOfActivatedProductsField;

        private bool numberOfActivatedProductsFieldSpecified;

        private int numberOfDeactivatedProductsField;

        private bool numberOfDeactivatedProductsFieldSpecified;

        private int numberOfProcessedProductsField;

        private bool numberOfProcessedProductsFieldSpecified;

        private int numberOfProductsField;

        private bool numberOfProductsFieldSpecified;

        private int numberOfProductsInErrorField;

        private bool numberOfProductsInErrorFieldSpecified;

        private int numberOfRemainingProductsToProcessField;

        private bool numberOfRemainingProductsToProcessFieldSpecified;

        private System.DateTime reportDateField;

        private bool reportDateFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<int> DepositId
        {
            get
            {
                return this.depositIdField;
            }
            set
            {
                this.depositIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DepositIdSpecified
        {
            get
            {
                return this.depositIdFieldSpecified;
            }
            set
            {
                this.depositIdFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        public FulfilmentActivationReportDetails[] DetailsList
        {
            get
            {
                return this.detailsListField;
            }
            set
            {
                this.detailsListField = value;
            }
        }

        /// <remarks/>
        public int NumberOfActivatedProducts
        {
            get
            {
                return this.numberOfActivatedProductsField;
            }
            set
            {
                this.numberOfActivatedProductsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NumberOfActivatedProductsSpecified
        {
            get
            {
                return this.numberOfActivatedProductsFieldSpecified;
            }
            set
            {
                this.numberOfActivatedProductsFieldSpecified = value;
            }
        }

        /// <remarks/>
        public int NumberOfDeactivatedProducts
        {
            get
            {
                return this.numberOfDeactivatedProductsField;
            }
            set
            {
                this.numberOfDeactivatedProductsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NumberOfDeactivatedProductsSpecified
        {
            get
            {
                return this.numberOfDeactivatedProductsFieldSpecified;
            }
            set
            {
                this.numberOfDeactivatedProductsFieldSpecified = value;
            }
        }

        /// <remarks/>
        public int NumberOfProcessedProducts
        {
            get
            {
                return this.numberOfProcessedProductsField;
            }
            set
            {
                this.numberOfProcessedProductsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NumberOfProcessedProductsSpecified
        {
            get
            {
                return this.numberOfProcessedProductsFieldSpecified;
            }
            set
            {
                this.numberOfProcessedProductsFieldSpecified = value;
            }
        }

        /// <remarks/>
        public int NumberOfProducts
        {
            get
            {
                return this.numberOfProductsField;
            }
            set
            {
                this.numberOfProductsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NumberOfProductsSpecified
        {
            get
            {
                return this.numberOfProductsFieldSpecified;
            }
            set
            {
                this.numberOfProductsFieldSpecified = value;
            }
        }

        /// <remarks/>
        public int NumberOfProductsInError
        {
            get
            {
                return this.numberOfProductsInErrorField;
            }
            set
            {
                this.numberOfProductsInErrorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NumberOfProductsInErrorSpecified
        {
            get
            {
                return this.numberOfProductsInErrorFieldSpecified;
            }
            set
            {
                this.numberOfProductsInErrorFieldSpecified = value;
            }
        }

        /// <remarks/>
        public int NumberOfRemainingProductsToProcess
        {
            get
            {
                return this.numberOfRemainingProductsToProcessField;
            }
            set
            {
                this.numberOfRemainingProductsToProcessField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NumberOfRemainingProductsToProcessSpecified
        {
            get
            {
                return this.numberOfRemainingProductsToProcessFieldSpecified;
            }
            set
            {
                this.numberOfRemainingProductsToProcessFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime ReportDate
        {
            get
            {
                return this.reportDateField;
            }
            set
            {
                this.reportDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReportDateSpecified
        {
            get
            {
                return this.reportDateFieldSpecified;
            }
            set
            {
                this.reportDateFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class DiscussionMail
    {

        private long discussionIdField;

        private bool discussionIdFieldSpecified;

        private string mailAddressField;

        private DiscussionMailStatusEnum operationStatusField;

        private bool operationStatusFieldSpecified;

        /// <remarks/>
        public long DiscussionId
        {
            get
            {
                return this.discussionIdField;
            }
            set
            {
                this.discussionIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DiscussionIdSpecified
        {
            get
            {
                return this.discussionIdFieldSpecified;
            }
            set
            {
                this.discussionIdFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string MailAddress
        {
            get
            {
                return this.mailAddressField;
            }
            set
            {
                this.mailAddressField = value;
            }
        }

        /// <remarks/>
        public DiscussionMailStatusEnum OperationStatus
        {
            get
            {
                return this.operationStatusField;
            }
            set
            {
                this.operationStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OperationStatusSpecified
        {
            get
            {
                return this.operationStatusFieldSpecified;
            }
            set
            {
                this.operationStatusFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public enum DiscussionMailStatusEnum
    {

        /// <remarks/>
        DiscussionNotFound,

        /// <remarks/>
        UnknownError,

        /// <remarks/>
        Success,

        /// <remarks/>
        DiscussionClosed,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class Message
    {

        private string contentField;

        private string senderField;

        private System.DateTime timestampField;

        private bool timestampFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Content
        {
            get
            {
                return this.contentField;
            }
            set
            {
                this.contentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Sender
        {
            get
            {
                return this.senderField;
            }
            set
            {
                this.senderField = value;
            }
        }

        /// <remarks/>
        public System.DateTime Timestamp
        {
            get
            {
                return this.timestampField;
            }
            set
            {
                this.timestampField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TimestampSpecified
        {
            get
            {
                return this.timestampFieldSpecified;
            }
            set
            {
                this.timestampFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OfferQuestion))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OrderQuestion))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OrderClaim))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class DiscussionThreadBase
    {

        private System.Nullable<System.DateTime> closeDateField;

        private bool closeDateFieldSpecified;

        private System.DateTime creationDateField;

        private bool creationDateFieldSpecified;

        private long idField;

        private bool idFieldSpecified;

        private System.Nullable<System.DateTime> lastUpdatedDateField;

        private bool lastUpdatedDateFieldSpecified;

        private Message[] messagesField;

        private DiscussionState statusField;

        private bool statusFieldSpecified;

        private string subjectField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<System.DateTime> CloseDate
        {
            get
            {
                return this.closeDateField;
            }
            set
            {
                this.closeDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CloseDateSpecified
        {
            get
            {
                return this.closeDateFieldSpecified;
            }
            set
            {
                this.closeDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime CreationDate
        {
            get
            {
                return this.creationDateField;
            }
            set
            {
                this.creationDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CreationDateSpecified
        {
            get
            {
                return this.creationDateFieldSpecified;
            }
            set
            {
                this.creationDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public long Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IdSpecified
        {
            get
            {
                return this.idFieldSpecified;
            }
            set
            {
                this.idFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<System.DateTime> LastUpdatedDate
        {
            get
            {
                return this.lastUpdatedDateField;
            }
            set
            {
                this.lastUpdatedDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LastUpdatedDateSpecified
        {
            get
            {
                return this.lastUpdatedDateFieldSpecified;
            }
            set
            {
                this.lastUpdatedDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        public Message[] Messages
        {
            get
            {
                return this.messagesField;
            }
            set
            {
                this.messagesField = value;
            }
        }

        /// <remarks/>
        public DiscussionState Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StatusSpecified
        {
            get
            {
                return this.statusFieldSpecified;
            }
            set
            {
                this.statusFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Subject
        {
            get
            {
                return this.subjectField;
            }
            set
            {
                this.subjectField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public enum DiscussionState
    {

        /// <remarks/>
        Open,

        /// <remarks/>
        Closed,

        /// <remarks/>
        NotProcessed,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class OfferQuestion : DiscussionThreadBase
    {

        private string productEANField;

        private string productSellerReferenceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string ProductEAN
        {
            get
            {
                return this.productEANField;
            }
            set
            {
                this.productEANField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string ProductSellerReference
        {
            get
            {
                return this.productSellerReferenceField;
            }
            set
            {
                this.productSellerReferenceField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OrderClaim))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class OrderQuestion : DiscussionThreadBase
    {

        private string orderNumberField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string OrderNumber
        {
            get
            {
                return this.orderNumberField;
            }
            set
            {
                this.orderNumberField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class OrderClaim : OrderQuestion
    {

        private ClaimType claimTypeField;

        private bool claimTypeFieldSpecified;

        /// <remarks/>
        public ClaimType ClaimType
        {
            get
            {
                return this.claimTypeField;
            }
            set
            {
                this.claimTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ClaimTypeSpecified
        {
            get
            {
                return this.claimTypeFieldSpecified;
            }
            set
            {
                this.claimTypeFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public enum ClaimType
    {

        /// <remarks/>
        PackageNotReceived,

        /// <remarks/>
        IncompletePackage,

        /// <remarks/>
        MissingAccessories,

        /// <remarks/>
        DamagedProduct,

        /// <remarks/>
        WrongProductReference,

        /// <remarks/>
        WrongRefundAmount,

        /// <remarks/>
        RefundNotReceived,

        /// <remarks/>
        ProductNotWorking,

        /// <remarks/>
        Other,

        /// <remarks/>
        ProductCanceling,

        /// <remarks/>
        OrderCanceling,

        /// <remarks/>
        WishToWithdraw,

        /// <remarks/>
        OrderNotShipped,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class CloseDiscussionResult
    {

        private long discussionIdField;

        private bool discussionIdFieldSpecified;

        private CloseDiscussionStatus operationStatusField;

        private bool operationStatusFieldSpecified;

        /// <remarks/>
        public long DiscussionId
        {
            get
            {
                return this.discussionIdField;
            }
            set
            {
                this.discussionIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DiscussionIdSpecified
        {
            get
            {
                return this.discussionIdFieldSpecified;
            }
            set
            {
                this.discussionIdFieldSpecified = value;
            }
        }

        /// <remarks/>
        public CloseDiscussionStatus OperationStatus
        {
            get
            {
                return this.operationStatusField;
            }
            set
            {
                this.operationStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OperationStatusSpecified
        {
            get
            {
                return this.operationStatusFieldSpecified;
            }
            set
            {
                this.operationStatusFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public enum CloseDiscussionStatus
    {

        /// <remarks/>
        DiscussionClosed,

        /// <remarks/>
        DiscussionNotFound,

        /// <remarks/>
        UnauthorizedCancelPending,

        /// <remarks/>
        UnauthorizedLastAnswer,

        /// <remarks/>
        AlreadyClosed,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class ParcelShop
    {

        private string addressComplementField;

        private string cityField;

        private System.Nullable<System.DateTime> closingDateField;

        private bool closingDateFieldSpecified;

        private System.Nullable<System.DateTime> exceptionalClosingDate1Field;

        private bool exceptionalClosingDate1FieldSpecified;

        private System.Nullable<System.DateTime> exceptionalClosingDate2Field;

        private bool exceptionalClosingDate2FieldSpecified;

        private System.Nullable<System.DateTime> exceptionalClosingDate3Field;

        private bool exceptionalClosingDate3FieldSpecified;

        private System.Nullable<System.DateTime> exceptionalClosingDate4Field;

        private bool exceptionalClosingDate4FieldSpecified;

        private System.Nullable<System.DateTime> exceptionalClosingDate5Field;

        private bool exceptionalClosingDate5FieldSpecified;

        private string fridayAfternoonClosingHourField;

        private string fridayAfternoonOpeningHourField;

        private string fridayMorningClosingHourField;

        private string fridayMorningOpeningHourField;

        private bool isStoreShipmentActiveField;

        private bool isStoreShipmentActiveFieldSpecified;

        private bool isTakeAwayDeliveryActiveField;

        private bool isTakeAwayDeliveryActiveFieldSpecified;

        private System.Nullable<double> latitudeField;

        private bool latitudeFieldSpecified;

        private string localityField;

        private System.Nullable<double> longitudeField;

        private bool longitudeFieldSpecified;

        private string mondayAfternoonClosingHourField;

        private string mondayAfternoonOpeningHourField;

        private string mondayMorningClosingHourField;

        private string mondayMorningOpeningHourField;

        private string nameField;

        private System.Nullable<System.DateTime> openingDateField;

        private bool openingDateFieldSpecified;

        private string phoneNumberField;

        private string referenceField;

        private string saturdayAfternoonClosingHourField;

        private string saturdayAfternoonOpeningHourField;

        private string saturdayMorningClosingHourField;

        private string saturdayMorningOpeningHourField;

        private string streetAndStreetNumberField;

        private string sundayAfternoonClosingHourField;

        private string sundayAfternoonOpeningHourField;

        private string sundayMorningClosingHourField;

        private string sundayMorningOpeningHourField;

        private System.Nullable<System.DateTime> temporaryClosingEndDateField;

        private bool temporaryClosingEndDateFieldSpecified;

        private System.Nullable<System.DateTime> temporaryClosingStartDateField;

        private bool temporaryClosingStartDateFieldSpecified;

        private string thursdayAfternoonClosingHourField;

        private string thursdayAfternoonOpeningHourField;

        private string thursdayMorningClosingHourField;

        private string thursdayMorningOpeningHourField;

        private string tuesdayAfternoonClosingHourField;

        private string tuesdayAfternoonOpeningHourField;

        private string tuesdayMorningClosingHourField;

        private string tuesdayMorningOpeningHourField;

        private string wednesdayAfternoonClosingHourField;

        private string wednesdayAfternoonOpeningHourField;

        private string wednesdayMorningClosingHourField;

        private string wednesdayMorningOpeningHourField;

        private string zipCodeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string AddressComplement
        {
            get
            {
                return this.addressComplementField;
            }
            set
            {
                this.addressComplementField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string City
        {
            get
            {
                return this.cityField;
            }
            set
            {
                this.cityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<System.DateTime> ClosingDate
        {
            get
            {
                return this.closingDateField;
            }
            set
            {
                this.closingDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ClosingDateSpecified
        {
            get
            {
                return this.closingDateFieldSpecified;
            }
            set
            {
                this.closingDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<System.DateTime> ExceptionalClosingDate1
        {
            get
            {
                return this.exceptionalClosingDate1Field;
            }
            set
            {
                this.exceptionalClosingDate1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ExceptionalClosingDate1Specified
        {
            get
            {
                return this.exceptionalClosingDate1FieldSpecified;
            }
            set
            {
                this.exceptionalClosingDate1FieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<System.DateTime> ExceptionalClosingDate2
        {
            get
            {
                return this.exceptionalClosingDate2Field;
            }
            set
            {
                this.exceptionalClosingDate2Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ExceptionalClosingDate2Specified
        {
            get
            {
                return this.exceptionalClosingDate2FieldSpecified;
            }
            set
            {
                this.exceptionalClosingDate2FieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<System.DateTime> ExceptionalClosingDate3
        {
            get
            {
                return this.exceptionalClosingDate3Field;
            }
            set
            {
                this.exceptionalClosingDate3Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ExceptionalClosingDate3Specified
        {
            get
            {
                return this.exceptionalClosingDate3FieldSpecified;
            }
            set
            {
                this.exceptionalClosingDate3FieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<System.DateTime> ExceptionalClosingDate4
        {
            get
            {
                return this.exceptionalClosingDate4Field;
            }
            set
            {
                this.exceptionalClosingDate4Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ExceptionalClosingDate4Specified
        {
            get
            {
                return this.exceptionalClosingDate4FieldSpecified;
            }
            set
            {
                this.exceptionalClosingDate4FieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<System.DateTime> ExceptionalClosingDate5
        {
            get
            {
                return this.exceptionalClosingDate5Field;
            }
            set
            {
                this.exceptionalClosingDate5Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ExceptionalClosingDate5Specified
        {
            get
            {
                return this.exceptionalClosingDate5FieldSpecified;
            }
            set
            {
                this.exceptionalClosingDate5FieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string FridayAfternoonClosingHour
        {
            get
            {
                return this.fridayAfternoonClosingHourField;
            }
            set
            {
                this.fridayAfternoonClosingHourField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string FridayAfternoonOpeningHour
        {
            get
            {
                return this.fridayAfternoonOpeningHourField;
            }
            set
            {
                this.fridayAfternoonOpeningHourField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string FridayMorningClosingHour
        {
            get
            {
                return this.fridayMorningClosingHourField;
            }
            set
            {
                this.fridayMorningClosingHourField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string FridayMorningOpeningHour
        {
            get
            {
                return this.fridayMorningOpeningHourField;
            }
            set
            {
                this.fridayMorningOpeningHourField = value;
            }
        }

        /// <remarks/>
        public bool IsStoreShipmentActive
        {
            get
            {
                return this.isStoreShipmentActiveField;
            }
            set
            {
                this.isStoreShipmentActiveField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsStoreShipmentActiveSpecified
        {
            get
            {
                return this.isStoreShipmentActiveFieldSpecified;
            }
            set
            {
                this.isStoreShipmentActiveFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool IsTakeAwayDeliveryActive
        {
            get
            {
                return this.isTakeAwayDeliveryActiveField;
            }
            set
            {
                this.isTakeAwayDeliveryActiveField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsTakeAwayDeliveryActiveSpecified
        {
            get
            {
                return this.isTakeAwayDeliveryActiveFieldSpecified;
            }
            set
            {
                this.isTakeAwayDeliveryActiveFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<double> Latitude
        {
            get
            {
                return this.latitudeField;
            }
            set
            {
                this.latitudeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LatitudeSpecified
        {
            get
            {
                return this.latitudeFieldSpecified;
            }
            set
            {
                this.latitudeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Locality
        {
            get
            {
                return this.localityField;
            }
            set
            {
                this.localityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<double> Longitude
        {
            get
            {
                return this.longitudeField;
            }
            set
            {
                this.longitudeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LongitudeSpecified
        {
            get
            {
                return this.longitudeFieldSpecified;
            }
            set
            {
                this.longitudeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string MondayAfternoonClosingHour
        {
            get
            {
                return this.mondayAfternoonClosingHourField;
            }
            set
            {
                this.mondayAfternoonClosingHourField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string MondayAfternoonOpeningHour
        {
            get
            {
                return this.mondayAfternoonOpeningHourField;
            }
            set
            {
                this.mondayAfternoonOpeningHourField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string MondayMorningClosingHour
        {
            get
            {
                return this.mondayMorningClosingHourField;
            }
            set
            {
                this.mondayMorningClosingHourField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string MondayMorningOpeningHour
        {
            get
            {
                return this.mondayMorningOpeningHourField;
            }
            set
            {
                this.mondayMorningOpeningHourField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<System.DateTime> OpeningDate
        {
            get
            {
                return this.openingDateField;
            }
            set
            {
                this.openingDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OpeningDateSpecified
        {
            get
            {
                return this.openingDateFieldSpecified;
            }
            set
            {
                this.openingDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string PhoneNumber
        {
            get
            {
                return this.phoneNumberField;
            }
            set
            {
                this.phoneNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Reference
        {
            get
            {
                return this.referenceField;
            }
            set
            {
                this.referenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string SaturdayAfternoonClosingHour
        {
            get
            {
                return this.saturdayAfternoonClosingHourField;
            }
            set
            {
                this.saturdayAfternoonClosingHourField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string SaturdayAfternoonOpeningHour
        {
            get
            {
                return this.saturdayAfternoonOpeningHourField;
            }
            set
            {
                this.saturdayAfternoonOpeningHourField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string SaturdayMorningClosingHour
        {
            get
            {
                return this.saturdayMorningClosingHourField;
            }
            set
            {
                this.saturdayMorningClosingHourField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string SaturdayMorningOpeningHour
        {
            get
            {
                return this.saturdayMorningOpeningHourField;
            }
            set
            {
                this.saturdayMorningOpeningHourField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string StreetAndStreetNumber
        {
            get
            {
                return this.streetAndStreetNumberField;
            }
            set
            {
                this.streetAndStreetNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string SundayAfternoonClosingHour
        {
            get
            {
                return this.sundayAfternoonClosingHourField;
            }
            set
            {
                this.sundayAfternoonClosingHourField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string SundayAfternoonOpeningHour
        {
            get
            {
                return this.sundayAfternoonOpeningHourField;
            }
            set
            {
                this.sundayAfternoonOpeningHourField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string SundayMorningClosingHour
        {
            get
            {
                return this.sundayMorningClosingHourField;
            }
            set
            {
                this.sundayMorningClosingHourField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string SundayMorningOpeningHour
        {
            get
            {
                return this.sundayMorningOpeningHourField;
            }
            set
            {
                this.sundayMorningOpeningHourField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<System.DateTime> TemporaryClosingEndDate
        {
            get
            {
                return this.temporaryClosingEndDateField;
            }
            set
            {
                this.temporaryClosingEndDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TemporaryClosingEndDateSpecified
        {
            get
            {
                return this.temporaryClosingEndDateFieldSpecified;
            }
            set
            {
                this.temporaryClosingEndDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<System.DateTime> TemporaryClosingStartDate
        {
            get
            {
                return this.temporaryClosingStartDateField;
            }
            set
            {
                this.temporaryClosingStartDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TemporaryClosingStartDateSpecified
        {
            get
            {
                return this.temporaryClosingStartDateFieldSpecified;
            }
            set
            {
                this.temporaryClosingStartDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string ThursdayAfternoonClosingHour
        {
            get
            {
                return this.thursdayAfternoonClosingHourField;
            }
            set
            {
                this.thursdayAfternoonClosingHourField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string ThursdayAfternoonOpeningHour
        {
            get
            {
                return this.thursdayAfternoonOpeningHourField;
            }
            set
            {
                this.thursdayAfternoonOpeningHourField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string ThursdayMorningClosingHour
        {
            get
            {
                return this.thursdayMorningClosingHourField;
            }
            set
            {
                this.thursdayMorningClosingHourField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string ThursdayMorningOpeningHour
        {
            get
            {
                return this.thursdayMorningOpeningHourField;
            }
            set
            {
                this.thursdayMorningOpeningHourField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string TuesdayAfternoonClosingHour
        {
            get
            {
                return this.tuesdayAfternoonClosingHourField;
            }
            set
            {
                this.tuesdayAfternoonClosingHourField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string TuesdayAfternoonOpeningHour
        {
            get
            {
                return this.tuesdayAfternoonOpeningHourField;
            }
            set
            {
                this.tuesdayAfternoonOpeningHourField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string TuesdayMorningClosingHour
        {
            get
            {
                return this.tuesdayMorningClosingHourField;
            }
            set
            {
                this.tuesdayMorningClosingHourField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string TuesdayMorningOpeningHour
        {
            get
            {
                return this.tuesdayMorningOpeningHourField;
            }
            set
            {
                this.tuesdayMorningOpeningHourField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string WednesdayAfternoonClosingHour
        {
            get
            {
                return this.wednesdayAfternoonClosingHourField;
            }
            set
            {
                this.wednesdayAfternoonClosingHourField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string WednesdayAfternoonOpeningHour
        {
            get
            {
                return this.wednesdayAfternoonOpeningHourField;
            }
            set
            {
                this.wednesdayAfternoonOpeningHourField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string WednesdayMorningClosingHour
        {
            get
            {
                return this.wednesdayMorningClosingHourField;
            }
            set
            {
                this.wednesdayMorningClosingHourField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string WednesdayMorningOpeningHour
        {
            get
            {
                return this.wednesdayMorningOpeningHourField;
            }
            set
            {
                this.wednesdayMorningOpeningHourField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string ZipCode
        {
            get
            {
                return this.zipCodeField;
            }
            set
            {
                this.zipCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class RelayIntegrationLog
    {

        private string[] errorsField;

        private System.DateTime logDateField;

        private bool logDateFieldSpecified;

        private string relayReferenceField;

        private bool validatedField;

        private bool validatedFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace = "http://schemas.microsoft.com/2003/10/Serialization/Arrays")]
        public string[] Errors
        {
            get
            {
                return this.errorsField;
            }
            set
            {
                this.errorsField = value;
            }
        }

        /// <remarks/>
        public System.DateTime LogDate
        {
            get
            {
                return this.logDateField;
            }
            set
            {
                this.logDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LogDateSpecified
        {
            get
            {
                return this.logDateFieldSpecified;
            }
            set
            {
                this.logDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string RelayReference
        {
            get
            {
                return this.relayReferenceField;
            }
            set
            {
                this.relayReferenceField = value;
            }
        }

        /// <remarks/>
        public bool Validated
        {
            get
            {
                return this.validatedField;
            }
            set
            {
                this.validatedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ValidatedSpecified
        {
            get
            {
                return this.validatedFieldSpecified;
            }
            set
            {
                this.validatedFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class Carrier
    {

        private int carrierIdField;

        private bool carrierIdFieldSpecified;

        private string defaultURLField;

        private string nameField;

        /// <remarks/>
        public int CarrierId
        {
            get
            {
                return this.carrierIdField;
            }
            set
            {
                this.carrierIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CarrierIdSpecified
        {
            get
            {
                return this.carrierIdFieldSpecified;
            }
            set
            {
                this.carrierIdFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string DefaultURL
        {
            get
            {
                return this.defaultURLField;
            }
            set
            {
                this.defaultURLField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class ValidateOrderLineResult
    {

        private Error[] errorsField;

        private string sellerProductIdField;

        private bool updatedField;

        private bool updatedFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        public Error[] Errors
        {
            get
            {
                return this.errorsField;
            }
            set
            {
                this.errorsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string SellerProductId
        {
            get
            {
                return this.sellerProductIdField;
            }
            set
            {
                this.sellerProductIdField = value;
            }
        }

        /// <remarks/>
        public bool Updated
        {
            get
            {
                return this.updatedField;
            }
            set
            {
                this.updatedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UpdatedSpecified
        {
            get
            {
                return this.updatedFieldSpecified;
            }
            set
            {
                this.updatedFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class Error
    {

        private ErrorTypeEnum errorTypeField;

        private string messageField;

        /// <remarks/>
        public ErrorTypeEnum ErrorType
        {
            get
            {
                return this.errorTypeField;
            }
            set
            {
                this.errorTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Message
        {
            get
            {
                return this.messageField;
            }
            set
            {
                this.messageField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public enum ErrorTypeEnum
    {

        /// <remarks/>
        UnexpectedException,

        /// <remarks/>
        MissingField,

        /// <remarks/>
        PackageNotFound,

        /// <remarks/>
        PackageMatchingFileError,

        /// <remarks/>
        OrderNotFound,

        /// <remarks/>
        OrderStateIncoherent,

        /// <remarks/>
        OrderLineCancelledAcceptedConflict,

        /// <remarks/>
        SellerNotFound,

        /// <remarks/>
        InvalidFileFormat,

        /// <remarks/>
        FileAlreadySubmitted,

        /// <remarks/>
        InvalidRequest,

        /// <remarks/>
        FileDownloadException,

        /// <remarks/>
        SellerNotAuthorized,

        /// <remarks/>
        OrderLineNotFound,

        /// <remarks/>
        OrderLineIncoherentState,

        /// <remarks/>
        FunctionNotActive,

        /// <remarks/>
        OrderPriceOrQuantityError,

        /// <remarks/>
        OrderTrackingInformationError,

        /// <remarks/>
        TooManyProductsInPackageError,

        /// <remarks/>
        Quota,

        /// <remarks/>
        RefundError,

        /// <remarks/>
        DiscussionCreationError,

        /// <remarks/>
        ConfigurationError,

        /// <remarks/>
        OrderPartiallyCanceled,

        /// <remarks/>
        OrderLineUpdateNotAuthorized,

        /// <remarks/>
        OrderUpdateNotAuthorized,

        /// <remarks/>
        AskingForReturnAndRemovalNotAuthorized,

        /// <remarks/>
        OrderLineError,

        /// <remarks/>
        UnauthorizedValueException,

        /// <remarks/>
        NotAuthorizedException,

        /// <remarks/>
        FulfillmentApiException,

        /// <remarks/>
        OfferNotFoundException,

        /// <remarks/>
        OperationManagerServiceException,

        /// <remarks/>
        InactiveSellerError,

        /// <remarks/>
        NoDataError,

        /// <remarks/>
        ProductIntegrationClosed,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class ValidateOrderResult
    {

        private Error[] errorsField;

        private string orderNumberField;

        private ValidateOrderLineResult[] validateOrderLineResultsField;

        private bool validatedField;

        private bool validatedFieldSpecified;

        private Error[] warningsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        public Error[] Errors
        {
            get
            {
                return this.errorsField;
            }
            set
            {
                this.errorsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string OrderNumber
        {
            get
            {
                return this.orderNumberField;
            }
            set
            {
                this.orderNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        public ValidateOrderLineResult[] ValidateOrderLineResults
        {
            get
            {
                return this.validateOrderLineResultsField;
            }
            set
            {
                this.validateOrderLineResultsField = value;
            }
        }

        /// <remarks/>
        public bool Validated
        {
            get
            {
                return this.validatedField;
            }
            set
            {
                this.validatedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ValidatedSpecified
        {
            get
            {
                return this.validatedFieldSpecified;
            }
            set
            {
                this.validatedFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        public Error[] Warnings
        {
            get
            {
                return this.warningsField;
            }
            set
            {
                this.warningsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class AssociatedOrderInfo
    {

        private string associatedSkuField;

        private string customerMailField;

        private string customerPhoneField;

        private string orderNumberField;

        private System.Nullable<OrderStateEnum> orderStateField;

        private bool orderStateFieldSpecified;

        private string productSheetUrlField;

        private System.Nullable<System.DateTime> realDeliveryDateField;

        private bool realDeliveryDateFieldSpecified;

        private string serviceOrderNumberField;

        private Address shippingAddressField;

        private string skuField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string AssociatedSku
        {
            get
            {
                return this.associatedSkuField;
            }
            set
            {
                this.associatedSkuField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string CustomerMail
        {
            get
            {
                return this.customerMailField;
            }
            set
            {
                this.customerMailField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string CustomerPhone
        {
            get
            {
                return this.customerPhoneField;
            }
            set
            {
                this.customerPhoneField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string OrderNumber
        {
            get
            {
                return this.orderNumberField;
            }
            set
            {
                this.orderNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<OrderStateEnum> OrderState
        {
            get
            {
                return this.orderStateField;
            }
            set
            {
                this.orderStateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OrderStateSpecified
        {
            get
            {
                return this.orderStateFieldSpecified;
            }
            set
            {
                this.orderStateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string ProductSheetUrl
        {
            get
            {
                return this.productSheetUrlField;
            }
            set
            {
                this.productSheetUrlField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<System.DateTime> RealDeliveryDate
        {
            get
            {
                return this.realDeliveryDateField;
            }
            set
            {
                this.realDeliveryDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RealDeliveryDateSpecified
        {
            get
            {
                return this.realDeliveryDateFieldSpecified;
            }
            set
            {
                this.realDeliveryDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string ServiceOrderNumber
        {
            get
            {
                return this.serviceOrderNumberField;
            }
            set
            {
                this.serviceOrderNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public Address ShippingAddress
        {
            get
            {
                return this.shippingAddressField;
            }
            set
            {
                this.shippingAddressField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Sku
        {
            get
            {
                return this.skuField;
            }
            set
            {
                this.skuField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class Address
    {

        private string address1Field;

        private string address2Field;

        private string apartmentNumberField;

        private string buildingField;

        private string cityField;

        private Civility civilityField;

        private bool civilityFieldSpecified;

        private string companyNameField;

        private string countryField;

        private string countyField;

        private string firstNameField;

        private string instructionsField;

        private string lastNameField;

        private string placeNameField;

        private string relayIdField;

        private string streetField;

        private string zipCodeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Address1
        {
            get
            {
                return this.address1Field;
            }
            set
            {
                this.address1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Address2
        {
            get
            {
                return this.address2Field;
            }
            set
            {
                this.address2Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string ApartmentNumber
        {
            get
            {
                return this.apartmentNumberField;
            }
            set
            {
                this.apartmentNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Building
        {
            get
            {
                return this.buildingField;
            }
            set
            {
                this.buildingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string City
        {
            get
            {
                return this.cityField;
            }
            set
            {
                this.cityField = value;
            }
        }

        /// <remarks/>
        public Civility Civility
        {
            get
            {
                return this.civilityField;
            }
            set
            {
                this.civilityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CivilitySpecified
        {
            get
            {
                return this.civilityFieldSpecified;
            }
            set
            {
                this.civilityFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string CompanyName
        {
            get
            {
                return this.companyNameField;
            }
            set
            {
                this.companyNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Country
        {
            get
            {
                return this.countryField;
            }
            set
            {
                this.countryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string County
        {
            get
            {
                return this.countyField;
            }
            set
            {
                this.countyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string FirstName
        {
            get
            {
                return this.firstNameField;
            }
            set
            {
                this.firstNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Instructions
        {
            get
            {
                return this.instructionsField;
            }
            set
            {
                this.instructionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string LastName
        {
            get
            {
                return this.lastNameField;
            }
            set
            {
                this.lastNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string PlaceName
        {
            get
            {
                return this.placeNameField;
            }
            set
            {
                this.placeNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string RelayId
        {
            get
            {
                return this.relayIdField;
            }
            set
            {
                this.relayIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Street
        {
            get
            {
                return this.streetField;
            }
            set
            {
                this.streetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string ZipCode
        {
            get
            {
                return this.zipCodeField;
            }
            set
            {
                this.zipCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public enum Civility
    {

        /// <remarks/>
        None,

        /// <remarks/>
        MR,

        /// <remarks/>
        MISS,

        /// <remarks/>
        MRS,

        /// <remarks/>
        DR,

        /// <remarks/>
        PHD,

        /// <remarks/>
        PR,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class Voucher
    {

        private System.Nullable<System.DateTime> createDateField;

        private bool createDateFieldSpecified;

        private RefundInformation refundInformationField;

        private System.Nullable<VoucherSourceActor> sourceField;

        private bool sourceFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<System.DateTime> CreateDate
        {
            get
            {
                return this.createDateField;
            }
            set
            {
                this.createDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CreateDateSpecified
        {
            get
            {
                return this.createDateFieldSpecified;
            }
            set
            {
                this.createDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public RefundInformation RefundInformation
        {
            get
            {
                return this.refundInformationField;
            }
            set
            {
                this.refundInformationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<VoucherSourceActor> Source
        {
            get
            {
                return this.sourceField;
            }
            set
            {
                this.sourceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SourceSpecified
        {
            get
            {
                return this.sourceFieldSpecified;
            }
            set
            {
                this.sourceFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public enum VoucherSourceActor
    {

        /// <remarks/>
        Customer,

        /// <remarks/>
        CDiscount,

        /// <remarks/>
        Seller,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class ParcelItem
    {

        private string productNameField;

        private int quantityField;

        private bool quantityFieldSpecified;

        private string skuField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string ProductName
        {
            get
            {
                return this.productNameField;
            }
            set
            {
                this.productNameField = value;
            }
        }

        /// <remarks/>
        public int Quantity
        {
            get
            {
                return this.quantityField;
            }
            set
            {
                this.quantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool QuantitySpecified
        {
            get
            {
                return this.quantityFieldSpecified;
            }
            set
            {
                this.quantityFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Sku
        {
            get
            {
                return this.skuField;
            }
            set
            {
                this.skuField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class Parcel
    {

        private string customerNumField;

        private string externalCarrierNameField;

        private string externalCarrierTrackingUrlField;

        private bool isCustomerReturnField;

        private bool isCustomerReturnFieldSpecified;

        private ParcelItem[] parcelItemListField;

        private System.Nullable<ParcelStatus> parcelStatusField;

        private bool parcelStatusFieldSpecified;

        private string realCarrierCodeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string CustomerNum
        {
            get
            {
                return this.customerNumField;
            }
            set
            {
                this.customerNumField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string ExternalCarrierName
        {
            get
            {
                return this.externalCarrierNameField;
            }
            set
            {
                this.externalCarrierNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string ExternalCarrierTrackingUrl
        {
            get
            {
                return this.externalCarrierTrackingUrlField;
            }
            set
            {
                this.externalCarrierTrackingUrlField = value;
            }
        }

        /// <remarks/>
        public bool IsCustomerReturn
        {
            get
            {
                return this.isCustomerReturnField;
            }
            set
            {
                this.isCustomerReturnField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsCustomerReturnSpecified
        {
            get
            {
                return this.isCustomerReturnFieldSpecified;
            }
            set
            {
                this.isCustomerReturnFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        public ParcelItem[] ParcelItemList
        {
            get
            {
                return this.parcelItemListField;
            }
            set
            {
                this.parcelItemListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<ParcelStatus> ParcelStatus
        {
            get
            {
                return this.parcelStatusField;
            }
            set
            {
                this.parcelStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ParcelStatusSpecified
        {
            get
            {
                return this.parcelStatusFieldSpecified;
            }
            set
            {
                this.parcelStatusFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string RealCarrierCode
        {
            get
            {
                return this.realCarrierCodeField;
            }
            set
            {
                this.realCarrierCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public enum ParcelStatus
    {

        /// <remarks/>
        Delivered,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Not Delivered - Back Transporter")]
        NotDeliveredBackTransporter,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Not Delivered - Lost Or Broken")]
        NotDeliveredLostOrBroken,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Committed The Transporter")]
        CommittedTheTransporter,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("On Going Delivery")]
        OnGoingDelivery,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("In Point Relay")]
        InPointRelay,

        /// <remarks/>
        Other,

        /// <remarks/>
        Prepared,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class OrderLine
    {

        private System.Nullable<AcceptationStateEnum> acceptationStateField;

        private bool acceptationStateFieldSpecified;

        private string categoryCodeField;

        private System.DateTime deliveryDateMaxField;

        private bool deliveryDateMaxFieldSpecified;

        private System.DateTime deliveryDateMinField;

        private bool deliveryDateMinFieldSpecified;

        private bool hasClaimField;

        private bool hasClaimFieldSpecified;

        private System.Nullable<decimal> initialPriceField;

        private bool initialPriceFieldSpecified;

        private bool isCDAVField;

        private bool isCDAVFieldSpecified;

        private System.Nullable<bool> isNegotiatedField;

        private bool isNegotiatedFieldSpecified;

        private bool isProductEanGeneratedField;

        private bool isProductEanGeneratedFieldSpecified;

        private string nameField;

        private OrderLine[] orderLineChildListField;

        private System.Nullable<ProductConditionEnum> productConditionField;

        private bool productConditionFieldSpecified;

        private string productEanField;

        private string productIdField;

        private decimal purchasePriceField;

        private bool purchasePriceFieldSpecified;

        private int quantityField;

        private bool quantityFieldSpecified;

        private System.Nullable<bool> refundShippingChargesField;

        private bool refundShippingChargesFieldSpecified;

        private int rowIdField;

        private bool rowIdFieldSpecified;

        private string sellerProductIdField;

        private System.DateTime shippingDateMaxField;

        private bool shippingDateMaxFieldSpecified;

        private System.DateTime shippingDateMinField;

        private bool shippingDateMinFieldSpecified;

        private string skuField;

        private string skuParentField;

        private decimal unitAdditionalShippingChargesField;

        private bool unitAdditionalShippingChargesFieldSpecified;

        private decimal unitShippingChargesField;

        private bool unitShippingChargesFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<AcceptationStateEnum> AcceptationState
        {
            get
            {
                return this.acceptationStateField;
            }
            set
            {
                this.acceptationStateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AcceptationStateSpecified
        {
            get
            {
                return this.acceptationStateFieldSpecified;
            }
            set
            {
                this.acceptationStateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string CategoryCode
        {
            get
            {
                return this.categoryCodeField;
            }
            set
            {
                this.categoryCodeField = value;
            }
        }

        /// <remarks/>
        public System.DateTime DeliveryDateMax
        {
            get
            {
                return this.deliveryDateMaxField;
            }
            set
            {
                this.deliveryDateMaxField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DeliveryDateMaxSpecified
        {
            get
            {
                return this.deliveryDateMaxFieldSpecified;
            }
            set
            {
                this.deliveryDateMaxFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime DeliveryDateMin
        {
            get
            {
                return this.deliveryDateMinField;
            }
            set
            {
                this.deliveryDateMinField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DeliveryDateMinSpecified
        {
            get
            {
                return this.deliveryDateMinFieldSpecified;
            }
            set
            {
                this.deliveryDateMinFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool HasClaim
        {
            get
            {
                return this.hasClaimField;
            }
            set
            {
                this.hasClaimField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HasClaimSpecified
        {
            get
            {
                return this.hasClaimFieldSpecified;
            }
            set
            {
                this.hasClaimFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<decimal> InitialPrice
        {
            get
            {
                return this.initialPriceField;
            }
            set
            {
                this.initialPriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InitialPriceSpecified
        {
            get
            {
                return this.initialPriceFieldSpecified;
            }
            set
            {
                this.initialPriceFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool IsCDAV
        {
            get
            {
                return this.isCDAVField;
            }
            set
            {
                this.isCDAVField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsCDAVSpecified
        {
            get
            {
                return this.isCDAVFieldSpecified;
            }
            set
            {
                this.isCDAVFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<bool> IsNegotiated
        {
            get
            {
                return this.isNegotiatedField;
            }
            set
            {
                this.isNegotiatedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsNegotiatedSpecified
        {
            get
            {
                return this.isNegotiatedFieldSpecified;
            }
            set
            {
                this.isNegotiatedFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool IsProductEanGenerated
        {
            get
            {
                return this.isProductEanGeneratedField;
            }
            set
            {
                this.isProductEanGeneratedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsProductEanGeneratedSpecified
        {
            get
            {
                return this.isProductEanGeneratedFieldSpecified;
            }
            set
            {
                this.isProductEanGeneratedFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        public OrderLine[] OrderLineChildList
        {
            get
            {
                return this.orderLineChildListField;
            }
            set
            {
                this.orderLineChildListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<ProductConditionEnum> ProductCondition
        {
            get
            {
                return this.productConditionField;
            }
            set
            {
                this.productConditionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ProductConditionSpecified
        {
            get
            {
                return this.productConditionFieldSpecified;
            }
            set
            {
                this.productConditionFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string ProductEan
        {
            get
            {
                return this.productEanField;
            }
            set
            {
                this.productEanField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string ProductId
        {
            get
            {
                return this.productIdField;
            }
            set
            {
                this.productIdField = value;
            }
        }

        /// <remarks/>
        public decimal PurchasePrice
        {
            get
            {
                return this.purchasePriceField;
            }
            set
            {
                this.purchasePriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PurchasePriceSpecified
        {
            get
            {
                return this.purchasePriceFieldSpecified;
            }
            set
            {
                this.purchasePriceFieldSpecified = value;
            }
        }

        /// <remarks/>
        public int Quantity
        {
            get
            {
                return this.quantityField;
            }
            set
            {
                this.quantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool QuantitySpecified
        {
            get
            {
                return this.quantityFieldSpecified;
            }
            set
            {
                this.quantityFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<bool> RefundShippingCharges
        {
            get
            {
                return this.refundShippingChargesField;
            }
            set
            {
                this.refundShippingChargesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RefundShippingChargesSpecified
        {
            get
            {
                return this.refundShippingChargesFieldSpecified;
            }
            set
            {
                this.refundShippingChargesFieldSpecified = value;
            }
        }

        /// <remarks/>
        public int RowId
        {
            get
            {
                return this.rowIdField;
            }
            set
            {
                this.rowIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RowIdSpecified
        {
            get
            {
                return this.rowIdFieldSpecified;
            }
            set
            {
                this.rowIdFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string SellerProductId
        {
            get
            {
                return this.sellerProductIdField;
            }
            set
            {
                this.sellerProductIdField = value;
            }
        }

        /// <remarks/>
        public System.DateTime ShippingDateMax
        {
            get
            {
                return this.shippingDateMaxField;
            }
            set
            {
                this.shippingDateMaxField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ShippingDateMaxSpecified
        {
            get
            {
                return this.shippingDateMaxFieldSpecified;
            }
            set
            {
                this.shippingDateMaxFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime ShippingDateMin
        {
            get
            {
                return this.shippingDateMinField;
            }
            set
            {
                this.shippingDateMinField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ShippingDateMinSpecified
        {
            get
            {
                return this.shippingDateMinFieldSpecified;
            }
            set
            {
                this.shippingDateMinFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Sku
        {
            get
            {
                return this.skuField;
            }
            set
            {
                this.skuField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string SkuParent
        {
            get
            {
                return this.skuParentField;
            }
            set
            {
                this.skuParentField = value;
            }
        }

        /// <remarks/>
        public decimal UnitAdditionalShippingCharges
        {
            get
            {
                return this.unitAdditionalShippingChargesField;
            }
            set
            {
                this.unitAdditionalShippingChargesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UnitAdditionalShippingChargesSpecified
        {
            get
            {
                return this.unitAdditionalShippingChargesFieldSpecified;
            }
            set
            {
                this.unitAdditionalShippingChargesFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal UnitShippingCharges
        {
            get
            {
                return this.unitShippingChargesField;
            }
            set
            {
                this.unitShippingChargesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UnitShippingChargesSpecified
        {
            get
            {
                return this.unitShippingChargesFieldSpecified;
            }
            set
            {
                this.unitShippingChargesFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class OfferOrder
    {

        private string codeField;

        private string creationDateField;

        private string expirationDateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string CreationDate
        {
            get
            {
                return this.creationDateField;
            }
            set
            {
                this.creationDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string ExpirationDate
        {
            get
            {
                return this.expirationDateField;
            }
            set
            {
                this.expirationDateField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class Customer
    {

        private System.Nullable<Civility> civilityField;

        private bool civilityFieldSpecified;

        private string customerIdField;

        private string emailField;

        private string encryptedEmailField;

        private string firstNameField;

        private string lastNameField;

        private string mobilePhoneField;

        private string phoneField;

        private string shippingFirstNameField;

        private string shippingLastNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<Civility> Civility
        {
            get
            {
                return this.civilityField;
            }
            set
            {
                this.civilityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CivilitySpecified
        {
            get
            {
                return this.civilityFieldSpecified;
            }
            set
            {
                this.civilityFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string CustomerId
        {
            get
            {
                return this.customerIdField;
            }
            set
            {
                this.customerIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Email
        {
            get
            {
                return this.emailField;
            }
            set
            {
                this.emailField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string EncryptedEmail
        {
            get
            {
                return this.encryptedEmailField;
            }
            set
            {
                this.encryptedEmailField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string FirstName
        {
            get
            {
                return this.firstNameField;
            }
            set
            {
                this.firstNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string LastName
        {
            get
            {
                return this.lastNameField;
            }
            set
            {
                this.lastNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string MobilePhone
        {
            get
            {
                return this.mobilePhoneField;
            }
            set
            {
                this.mobilePhoneField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Phone
        {
            get
            {
                return this.phoneField;
            }
            set
            {
                this.phoneField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string ShippingFirstName
        {
            get
            {
                return this.shippingFirstNameField;
            }
            set
            {
                this.shippingFirstNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string ShippingLastName
        {
            get
            {
                return this.shippingLastNameField;
            }
            set
            {
                this.shippingLastNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class Corporation
    {

        private short businessUnitIdField;

        private bool businessUnitIdFieldSpecified;

        private string corporationCodeField;

        private short corporationIdField;

        private string corporationNameField;

        private System.Nullable<bool> isMarketPlaceActiveField;

        private bool isMarketPlaceActiveFieldSpecified;

        /// <remarks/>
        public short BusinessUnitId
        {
            get
            {
                return this.businessUnitIdField;
            }
            set
            {
                this.businessUnitIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BusinessUnitIdSpecified
        {
            get
            {
                return this.businessUnitIdFieldSpecified;
            }
            set
            {
                this.businessUnitIdFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string CorporationCode
        {
            get
            {
                return this.corporationCodeField;
            }
            set
            {
                this.corporationCodeField = value;
            }
        }

        /// <remarks/>
        public short CorporationId
        {
            get
            {
                return this.corporationIdField;
            }
            set
            {
                this.corporationIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string CorporationName
        {
            get
            {
                return this.corporationNameField;
            }
            set
            {
                this.corporationNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<bool> IsMarketPlaceActive
        {
            get
            {
                return this.isMarketPlaceActiveField;
            }
            set
            {
                this.isMarketPlaceActiveField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsMarketPlaceActiveSpecified
        {
            get
            {
                return this.isMarketPlaceActiveFieldSpecified;
            }
            set
            {
                this.isMarketPlaceActiveFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ServiceOrder))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class Order
    {

        private bool archiveParcelListField;

        private bool archiveParcelListFieldSpecified;

        private Address billingAddressField;

        private Corporation corporationField;

        private System.DateTime creationDateField;

        private bool creationDateFieldSpecified;

        private Customer customerField;

        private bool hasClaimsField;

        private bool hasClaimsFieldSpecified;

        private decimal initialTotalAmountField;

        private bool initialTotalAmountFieldSpecified;

        private decimal initialTotalShippingChargesAmountField;

        private bool initialTotalShippingChargesAmountFieldSpecified;

        private bool isCLogistiqueOrderField;

        private System.Nullable<System.DateTime> lastUpdatedDateField;

        private bool lastUpdatedDateFieldSpecified;

        private string modGesLogField;

        private System.Nullable<System.DateTime> modifiedDateField;

        private bool modifiedDateFieldSpecified;

        private OfferOrder offerField;

        private OrderLine[] orderLineListField;

        private string orderNumberField;

        private System.Nullable<OrderStateEnum> orderStateField;

        private bool orderStateFieldSpecified;

        private Parcel[] parcelListField;

        private string partnerOrderRefField;

        private decimal shippedTotalAmountField;

        private bool shippedTotalAmountFieldSpecified;

        private decimal shippedTotalShippingChargesField;

        private bool shippedTotalShippingChargesFieldSpecified;

        private Address shippingAddressField;

        private string shippingCodeField;

        private System.Nullable<System.DateTime> shippingDateMaxField;

        private bool shippingDateMaxFieldSpecified;

        private System.Nullable<System.DateTime> shippingDateMinField;

        private bool shippingDateMinFieldSpecified;

        private decimal siteCommissionPromisedAmountField;

        private bool siteCommissionPromisedAmountFieldSpecified;

        private decimal siteCommissionShippedAmountField;

        private bool siteCommissionShippedAmountFieldSpecified;

        private decimal siteCommissionValidatedAmountField;

        private bool siteCommissionValidatedAmountFieldSpecified;

        private OrderStatusType statusField;

        private bool statusFieldSpecified;

        private decimal validatedTotalAmountField;

        private bool validatedTotalAmountFieldSpecified;

        private decimal validatedTotalShippingChargesField;

        private bool validatedTotalShippingChargesFieldSpecified;

        private ValidationStatusType validationStatusField;

        private bool validationStatusFieldSpecified;

        private System.Nullable<int> visaCegidField;

        private bool visaCegidFieldSpecified;

        private Voucher[] voucherListField;

        /// <remarks/>
        public bool ArchiveParcelList
        {
            get
            {
                return this.archiveParcelListField;
            }
            set
            {
                this.archiveParcelListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ArchiveParcelListSpecified
        {
            get
            {
                return this.archiveParcelListFieldSpecified;
            }
            set
            {
                this.archiveParcelListFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public Address BillingAddress
        {
            get
            {
                return this.billingAddressField;
            }
            set
            {
                this.billingAddressField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public Corporation Corporation
        {
            get
            {
                return this.corporationField;
            }
            set
            {
                this.corporationField = value;
            }
        }

        /// <remarks/>
        public System.DateTime CreationDate
        {
            get
            {
                return this.creationDateField;
            }
            set
            {
                this.creationDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CreationDateSpecified
        {
            get
            {
                return this.creationDateFieldSpecified;
            }
            set
            {
                this.creationDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public Customer Customer
        {
            get
            {
                return this.customerField;
            }
            set
            {
                this.customerField = value;
            }
        }

        /// <remarks/>
        public bool HasClaims
        {
            get
            {
                return this.hasClaimsField;
            }
            set
            {
                this.hasClaimsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HasClaimsSpecified
        {
            get
            {
                return this.hasClaimsFieldSpecified;
            }
            set
            {
                this.hasClaimsFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal InitialTotalAmount
        {
            get
            {
                return this.initialTotalAmountField;
            }
            set
            {
                this.initialTotalAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InitialTotalAmountSpecified
        {
            get
            {
                return this.initialTotalAmountFieldSpecified;
            }
            set
            {
                this.initialTotalAmountFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal InitialTotalShippingChargesAmount
        {
            get
            {
                return this.initialTotalShippingChargesAmountField;
            }
            set
            {
                this.initialTotalShippingChargesAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InitialTotalShippingChargesAmountSpecified
        {
            get
            {
                return this.initialTotalShippingChargesAmountFieldSpecified;
            }
            set
            {
                this.initialTotalShippingChargesAmountFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool IsCLogistiqueOrder
        {
            get
            {
                return this.isCLogistiqueOrderField;
            }
            set
            {
                this.isCLogistiqueOrderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<System.DateTime> LastUpdatedDate
        {
            get
            {
                return this.lastUpdatedDateField;
            }
            set
            {
                this.lastUpdatedDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LastUpdatedDateSpecified
        {
            get
            {
                return this.lastUpdatedDateFieldSpecified;
            }
            set
            {
                this.lastUpdatedDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string ModGesLog
        {
            get
            {
                return this.modGesLogField;
            }
            set
            {
                this.modGesLogField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<System.DateTime> ModifiedDate
        {
            get
            {
                return this.modifiedDateField;
            }
            set
            {
                this.modifiedDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ModifiedDateSpecified
        {
            get
            {
                return this.modifiedDateFieldSpecified;
            }
            set
            {
                this.modifiedDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public OfferOrder Offer
        {
            get
            {
                return this.offerField;
            }
            set
            {
                this.offerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        public OrderLine[] OrderLineList
        {
            get
            {
                return this.orderLineListField;
            }
            set
            {
                this.orderLineListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string OrderNumber
        {
            get
            {
                return this.orderNumberField;
            }
            set
            {
                this.orderNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<OrderStateEnum> OrderState
        {
            get
            {
                return this.orderStateField;
            }
            set
            {
                this.orderStateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OrderStateSpecified
        {
            get
            {
                return this.orderStateFieldSpecified;
            }
            set
            {
                this.orderStateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        public Parcel[] ParcelList
        {
            get
            {
                return this.parcelListField;
            }
            set
            {
                this.parcelListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string PartnerOrderRef
        {
            get
            {
                return this.partnerOrderRefField;
            }
            set
            {
                this.partnerOrderRefField = value;
            }
        }

        /// <remarks/>
        public decimal ShippedTotalAmount
        {
            get
            {
                return this.shippedTotalAmountField;
            }
            set
            {
                this.shippedTotalAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ShippedTotalAmountSpecified
        {
            get
            {
                return this.shippedTotalAmountFieldSpecified;
            }
            set
            {
                this.shippedTotalAmountFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal ShippedTotalShippingCharges
        {
            get
            {
                return this.shippedTotalShippingChargesField;
            }
            set
            {
                this.shippedTotalShippingChargesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ShippedTotalShippingChargesSpecified
        {
            get
            {
                return this.shippedTotalShippingChargesFieldSpecified;
            }
            set
            {
                this.shippedTotalShippingChargesFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public Address ShippingAddress
        {
            get
            {
                return this.shippingAddressField;
            }
            set
            {
                this.shippingAddressField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string ShippingCode
        {
            get
            {
                return this.shippingCodeField;
            }
            set
            {
                this.shippingCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<System.DateTime> ShippingDateMax
        {
            get
            {
                return this.shippingDateMaxField;
            }
            set
            {
                this.shippingDateMaxField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ShippingDateMaxSpecified
        {
            get
            {
                return this.shippingDateMaxFieldSpecified;
            }
            set
            {
                this.shippingDateMaxFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<System.DateTime> ShippingDateMin
        {
            get
            {
                return this.shippingDateMinField;
            }
            set
            {
                this.shippingDateMinField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ShippingDateMinSpecified
        {
            get
            {
                return this.shippingDateMinFieldSpecified;
            }
            set
            {
                this.shippingDateMinFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal SiteCommissionPromisedAmount
        {
            get
            {
                return this.siteCommissionPromisedAmountField;
            }
            set
            {
                this.siteCommissionPromisedAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SiteCommissionPromisedAmountSpecified
        {
            get
            {
                return this.siteCommissionPromisedAmountFieldSpecified;
            }
            set
            {
                this.siteCommissionPromisedAmountFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal SiteCommissionShippedAmount
        {
            get
            {
                return this.siteCommissionShippedAmountField;
            }
            set
            {
                this.siteCommissionShippedAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SiteCommissionShippedAmountSpecified
        {
            get
            {
                return this.siteCommissionShippedAmountFieldSpecified;
            }
            set
            {
                this.siteCommissionShippedAmountFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal SiteCommissionValidatedAmount
        {
            get
            {
                return this.siteCommissionValidatedAmountField;
            }
            set
            {
                this.siteCommissionValidatedAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SiteCommissionValidatedAmountSpecified
        {
            get
            {
                return this.siteCommissionValidatedAmountFieldSpecified;
            }
            set
            {
                this.siteCommissionValidatedAmountFieldSpecified = value;
            }
        }

        /// <remarks/>
        public OrderStatusType Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StatusSpecified
        {
            get
            {
                return this.statusFieldSpecified;
            }
            set
            {
                this.statusFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal ValidatedTotalAmount
        {
            get
            {
                return this.validatedTotalAmountField;
            }
            set
            {
                this.validatedTotalAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ValidatedTotalAmountSpecified
        {
            get
            {
                return this.validatedTotalAmountFieldSpecified;
            }
            set
            {
                this.validatedTotalAmountFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal ValidatedTotalShippingCharges
        {
            get
            {
                return this.validatedTotalShippingChargesField;
            }
            set
            {
                this.validatedTotalShippingChargesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ValidatedTotalShippingChargesSpecified
        {
            get
            {
                return this.validatedTotalShippingChargesFieldSpecified;
            }
            set
            {
                this.validatedTotalShippingChargesFieldSpecified = value;
            }
        }

        /// <remarks/>
        public ValidationStatusType ValidationStatus
        {
            get
            {
                return this.validationStatusField;
            }
            set
            {
                this.validationStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ValidationStatusSpecified
        {
            get
            {
                return this.validationStatusFieldSpecified;
            }
            set
            {
                this.validationStatusFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<int> VisaCegid
        {
            get
            {
                return this.visaCegidField;
            }
            set
            {
                this.visaCegidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool VisaCegidSpecified
        {
            get
            {
                return this.visaCegidFieldSpecified;
            }
            set
            {
                this.visaCegidFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        public Voucher[] VoucherList
        {
            get
            {
                return this.voucherListField;
            }
            set
            {
                this.voucherListField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public enum OrderStatusType
    {

        /// <remarks/>
        NonValidated,

        /// <remarks/>
        NoPaymentAttempt,

        /// <remarks/>
        Cancelled,

        /// <remarks/>
        Validated,

        /// <remarks/>
        Waiting,

        /// <remarks/>
        Completed,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public enum ValidationStatusType
    {

        /// <remarks/>
        ValidatingFianet,

        /// <remarks/>
        PreAccepted,

        /// <remarks/>
        None,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class ServiceOrder : Order
    {

        private AssociatedOrderInfo[] associatedOrderInfoListField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        public AssociatedOrderInfo[] AssociatedOrderInfoList
        {
            get
            {
                return this.associatedOrderInfoListField;
            }
            set
            {
                this.associatedOrderInfoListField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class SellerIndicator
    {

        private System.Nullable<System.DateTime> computationDateField;

        private bool computationDateFieldSpecified;

        private string descriptionField;

        private System.Nullable<decimal> thresholdField;

        private bool thresholdFieldSpecified;

        private TresholdType thresholdTypeField;

        private bool thresholdTypeFieldSpecified;

        private System.Nullable<decimal> valueD30Field;

        private bool valueD30FieldSpecified;

        private System.Nullable<decimal> valueD60Field;

        private bool valueD60FieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<System.DateTime> ComputationDate
        {
            get
            {
                return this.computationDateField;
            }
            set
            {
                this.computationDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ComputationDateSpecified
        {
            get
            {
                return this.computationDateFieldSpecified;
            }
            set
            {
                this.computationDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<decimal> Threshold
        {
            get
            {
                return this.thresholdField;
            }
            set
            {
                this.thresholdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ThresholdSpecified
        {
            get
            {
                return this.thresholdFieldSpecified;
            }
            set
            {
                this.thresholdFieldSpecified = value;
            }
        }

        /// <remarks/>
        public TresholdType ThresholdType
        {
            get
            {
                return this.thresholdTypeField;
            }
            set
            {
                this.thresholdTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ThresholdTypeSpecified
        {
            get
            {
                return this.thresholdTypeFieldSpecified;
            }
            set
            {
                this.thresholdTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<decimal> ValueD30
        {
            get
            {
                return this.valueD30Field;
            }
            set
            {
                this.valueD30Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ValueD30Specified
        {
            get
            {
                return this.valueD30FieldSpecified;
            }
            set
            {
                this.valueD30FieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<decimal> ValueD60
        {
            get
            {
                return this.valueD60Field;
            }
            set
            {
                this.valueD60Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ValueD60Specified
        {
            get
            {
                return this.valueD60FieldSpecified;
            }
            set
            {
                this.valueD60FieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public enum TresholdType
    {

        /// <remarks/>
        ThresholdMin,

        /// <remarks/>
        ThresholdMax,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class Seller
    {

        private string emailField;

        private SellerSubStateEnum isAvailableField;

        private bool isAvailableFieldSpecified;

        private string loginField;

        private string mobileNumberField;

        private string phoneNumberField;

        private Address sellerAddressField;

        private string shopNameField;

        private string shopUrlField;

        private string siretNumberField;

        private SellerStateEnum stateField;

        private bool stateFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Email
        {
            get
            {
                return this.emailField;
            }
            set
            {
                this.emailField = value;
            }
        }

        /// <remarks/>
        public SellerSubStateEnum IsAvailable
        {
            get
            {
                return this.isAvailableField;
            }
            set
            {
                this.isAvailableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsAvailableSpecified
        {
            get
            {
                return this.isAvailableFieldSpecified;
            }
            set
            {
                this.isAvailableFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Login
        {
            get
            {
                return this.loginField;
            }
            set
            {
                this.loginField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string MobileNumber
        {
            get
            {
                return this.mobileNumberField;
            }
            set
            {
                this.mobileNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string PhoneNumber
        {
            get
            {
                return this.phoneNumberField;
            }
            set
            {
                this.phoneNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public Address SellerAddress
        {
            get
            {
                return this.sellerAddressField;
            }
            set
            {
                this.sellerAddressField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string ShopName
        {
            get
            {
                return this.shopNameField;
            }
            set
            {
                this.shopNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string ShopUrl
        {
            get
            {
                return this.shopUrlField;
            }
            set
            {
                this.shopUrlField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string SiretNumber
        {
            get
            {
                return this.siretNumberField;
            }
            set
            {
                this.siretNumberField = value;
            }
        }

        /// <remarks/>
        public SellerStateEnum State
        {
            get
            {
                return this.stateField;
            }
            set
            {
                this.stateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StateSpecified
        {
            get
            {
                return this.stateFieldSpecified;
            }
            set
            {
                this.stateFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public enum SellerSubStateEnum
    {

        /// <remarks/>
        Holidays,

        /// <remarks/>
        ActiveSeller,

        /// <remarks/>
        BannedSeller,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public enum SellerStateEnum
    {

        /// <remarks/>
        Activated,

        /// <remarks/>
        Deactivated,

        /// <remarks/>
        PutOnNotice,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class DeliveryModeInformation
    {

        private string codeField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class ShippingInformation
    {

        private decimal additionalShippingChargesField;

        private bool additionalShippingChargesFieldSpecified;

        private DeliveryModeInformation deliveryModeField;

        private int maxLeadTimeField;

        private bool maxLeadTimeFieldSpecified;

        private int minLeadTimeField;

        private bool minLeadTimeFieldSpecified;

        private decimal shippingChargesField;

        private bool shippingChargesFieldSpecified;

        /// <remarks/>
        public decimal AdditionalShippingCharges
        {
            get
            {
                return this.additionalShippingChargesField;
            }
            set
            {
                this.additionalShippingChargesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AdditionalShippingChargesSpecified
        {
            get
            {
                return this.additionalShippingChargesFieldSpecified;
            }
            set
            {
                this.additionalShippingChargesFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public DeliveryModeInformation DeliveryMode
        {
            get
            {
                return this.deliveryModeField;
            }
            set
            {
                this.deliveryModeField = value;
            }
        }

        /// <remarks/>
        public int MaxLeadTime
        {
            get
            {
                return this.maxLeadTimeField;
            }
            set
            {
                this.maxLeadTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaxLeadTimeSpecified
        {
            get
            {
                return this.maxLeadTimeFieldSpecified;
            }
            set
            {
                this.maxLeadTimeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public int MinLeadTime
        {
            get
            {
                return this.minLeadTimeField;
            }
            set
            {
                this.minLeadTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MinLeadTimeSpecified
        {
            get
            {
                return this.minLeadTimeFieldSpecified;
            }
            set
            {
                this.minLeadTimeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal ShippingCharges
        {
            get
            {
                return this.shippingChargesField;
            }
            set
            {
                this.shippingChargesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ShippingChargesSpecified
        {
            get
            {
                return this.shippingChargesFieldSpecified;
            }
            set
            {
                this.shippingChargesFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class DiscountComponent
    {

        private decimal discountValueField;

        private bool discountValueFieldSpecified;

        private System.DateTime endDateField;

        private bool endDateFieldSpecified;

        private decimal priceField;

        private bool priceFieldSpecified;

        private System.DateTime startDateField;

        private bool startDateFieldSpecified;

        private DiscountType typeField;

        private bool typeFieldSpecified;

        /// <remarks/>
        public decimal DiscountValue
        {
            get
            {
                return this.discountValueField;
            }
            set
            {
                this.discountValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DiscountValueSpecified
        {
            get
            {
                return this.discountValueFieldSpecified;
            }
            set
            {
                this.discountValueFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime EndDate
        {
            get
            {
                return this.endDateField;
            }
            set
            {
                this.endDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EndDateSpecified
        {
            get
            {
                return this.endDateFieldSpecified;
            }
            set
            {
                this.endDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal Price
        {
            get
            {
                return this.priceField;
            }
            set
            {
                this.priceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PriceSpecified
        {
            get
            {
                return this.priceFieldSpecified;
            }
            set
            {
                this.priceFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime StartDate
        {
            get
            {
                return this.startDateField;
            }
            set
            {
                this.startDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StartDateSpecified
        {
            get
            {
                return this.startDateFieldSpecified;
            }
            set
            {
                this.startDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public DiscountType Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TypeSpecified
        {
            get
            {
                return this.typeFieldSpecified;
            }
            set
            {
                this.typeFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public enum DiscountType
    {

        /// <remarks/>
        StrikedPrice,

        /// <remarks/>
        Flash,

        /// <remarks/>
        Sales,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class Offer
    {

        private decimal bestShippingChargesField;

        private bool bestShippingChargesFieldSpecified;

        private string commentsField;

        private System.DateTime creationDateField;

        private bool creationDateFieldSpecified;

        private decimal deaTaxField;

        private bool deaTaxFieldSpecified;

        private DiscountComponent[] discountListField;

        private decimal ecoTaxField;

        private bool ecoTaxFieldSpecified;

        private decimal integrationPriceField;

        private bool integrationPriceFieldSpecified;

        private bool isCDAVField;

        private bool isCDAVFieldSpecified;

        private System.DateTime lastUpdateDateField;

        private bool lastUpdateDateFieldSpecified;

        private LogisticMode logisticModeField;

        private bool logisticModeFieldSpecified;

        private System.Nullable<decimal> minimumPriceForPriceAlignmentField;

        private bool minimumPriceForPriceAlignmentFieldSpecified;

        private OfferPriceBenchMark offerBenchMarkField;

        private OfferPool[] offerPoolListField;

        private OfferStateEnum offerStateField;

        private bool offerStateFieldSpecified;

        private string parentProductIdField;

        private decimal priceField;

        private bool priceFieldSpecified;

        private PriceAlignmentAction priceMustBeAlignedField;

        private bool priceMustBeAlignedFieldSpecified;

        private ProductConditionEnum productConditionField;

        private bool productConditionFieldSpecified;

        private string productEanField;

        private string productIdField;

        private ProductPackagingUnit productPackagingUnitField;

        private bool productPackagingUnitFieldSpecified;

        private decimal productPackagingUnitPriceField;

        private bool productPackagingUnitPriceFieldSpecified;

        private decimal productPackagingValueField;

        private bool productPackagingValueFieldSpecified;

        private string sellerProductIdField;

        private ShippingInformation[] shippingInformationListField;

        private int stockField;

        private bool stockFieldSpecified;

        private System.Nullable<decimal> strikedPriceField;

        private bool strikedPriceFieldSpecified;

        private decimal vatRateField;

        private bool vatRateFieldSpecified;

        /// <remarks/>
        public decimal BestShippingCharges
        {
            get
            {
                return this.bestShippingChargesField;
            }
            set
            {
                this.bestShippingChargesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BestShippingChargesSpecified
        {
            get
            {
                return this.bestShippingChargesFieldSpecified;
            }
            set
            {
                this.bestShippingChargesFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Comments
        {
            get
            {
                return this.commentsField;
            }
            set
            {
                this.commentsField = value;
            }
        }

        /// <remarks/>
        public System.DateTime CreationDate
        {
            get
            {
                return this.creationDateField;
            }
            set
            {
                this.creationDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CreationDateSpecified
        {
            get
            {
                return this.creationDateFieldSpecified;
            }
            set
            {
                this.creationDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal DeaTax
        {
            get
            {
                return this.deaTaxField;
            }
            set
            {
                this.deaTaxField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DeaTaxSpecified
        {
            get
            {
                return this.deaTaxFieldSpecified;
            }
            set
            {
                this.deaTaxFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        public DiscountComponent[] DiscountList
        {
            get
            {
                return this.discountListField;
            }
            set
            {
                this.discountListField = value;
            }
        }

        /// <remarks/>
        public decimal EcoTax
        {
            get
            {
                return this.ecoTaxField;
            }
            set
            {
                this.ecoTaxField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EcoTaxSpecified
        {
            get
            {
                return this.ecoTaxFieldSpecified;
            }
            set
            {
                this.ecoTaxFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal IntegrationPrice
        {
            get
            {
                return this.integrationPriceField;
            }
            set
            {
                this.integrationPriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IntegrationPriceSpecified
        {
            get
            {
                return this.integrationPriceFieldSpecified;
            }
            set
            {
                this.integrationPriceFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool IsCDAV
        {
            get
            {
                return this.isCDAVField;
            }
            set
            {
                this.isCDAVField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsCDAVSpecified
        {
            get
            {
                return this.isCDAVFieldSpecified;
            }
            set
            {
                this.isCDAVFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime LastUpdateDate
        {
            get
            {
                return this.lastUpdateDateField;
            }
            set
            {
                this.lastUpdateDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LastUpdateDateSpecified
        {
            get
            {
                return this.lastUpdateDateFieldSpecified;
            }
            set
            {
                this.lastUpdateDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public LogisticMode LogisticMode
        {
            get
            {
                return this.logisticModeField;
            }
            set
            {
                this.logisticModeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LogisticModeSpecified
        {
            get
            {
                return this.logisticModeFieldSpecified;
            }
            set
            {
                this.logisticModeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<decimal> MinimumPriceForPriceAlignment
        {
            get
            {
                return this.minimumPriceForPriceAlignmentField;
            }
            set
            {
                this.minimumPriceForPriceAlignmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MinimumPriceForPriceAlignmentSpecified
        {
            get
            {
                return this.minimumPriceForPriceAlignmentFieldSpecified;
            }
            set
            {
                this.minimumPriceForPriceAlignmentFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public OfferPriceBenchMark OfferBenchMark
        {
            get
            {
                return this.offerBenchMarkField;
            }
            set
            {
                this.offerBenchMarkField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        public OfferPool[] OfferPoolList
        {
            get
            {
                return this.offerPoolListField;
            }
            set
            {
                this.offerPoolListField = value;
            }
        }

        /// <remarks/>
        public OfferStateEnum OfferState
        {
            get
            {
                return this.offerStateField;
            }
            set
            {
                this.offerStateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OfferStateSpecified
        {
            get
            {
                return this.offerStateFieldSpecified;
            }
            set
            {
                this.offerStateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string ParentProductId
        {
            get
            {
                return this.parentProductIdField;
            }
            set
            {
                this.parentProductIdField = value;
            }
        }

        /// <remarks/>
        public decimal Price
        {
            get
            {
                return this.priceField;
            }
            set
            {
                this.priceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PriceSpecified
        {
            get
            {
                return this.priceFieldSpecified;
            }
            set
            {
                this.priceFieldSpecified = value;
            }
        }

        /// <remarks/>
        public PriceAlignmentAction PriceMustBeAligned
        {
            get
            {
                return this.priceMustBeAlignedField;
            }
            set
            {
                this.priceMustBeAlignedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PriceMustBeAlignedSpecified
        {
            get
            {
                return this.priceMustBeAlignedFieldSpecified;
            }
            set
            {
                this.priceMustBeAlignedFieldSpecified = value;
            }
        }

        /// <remarks/>
        public ProductConditionEnum ProductCondition
        {
            get
            {
                return this.productConditionField;
            }
            set
            {
                this.productConditionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ProductConditionSpecified
        {
            get
            {
                return this.productConditionFieldSpecified;
            }
            set
            {
                this.productConditionFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string ProductEan
        {
            get
            {
                return this.productEanField;
            }
            set
            {
                this.productEanField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string ProductId
        {
            get
            {
                return this.productIdField;
            }
            set
            {
                this.productIdField = value;
            }
        }

        /// <remarks/>
        public ProductPackagingUnit ProductPackagingUnit
        {
            get
            {
                return this.productPackagingUnitField;
            }
            set
            {
                this.productPackagingUnitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ProductPackagingUnitSpecified
        {
            get
            {
                return this.productPackagingUnitFieldSpecified;
            }
            set
            {
                this.productPackagingUnitFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal ProductPackagingUnitPrice
        {
            get
            {
                return this.productPackagingUnitPriceField;
            }
            set
            {
                this.productPackagingUnitPriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ProductPackagingUnitPriceSpecified
        {
            get
            {
                return this.productPackagingUnitPriceFieldSpecified;
            }
            set
            {
                this.productPackagingUnitPriceFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal ProductPackagingValue
        {
            get
            {
                return this.productPackagingValueField;
            }
            set
            {
                this.productPackagingValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ProductPackagingValueSpecified
        {
            get
            {
                return this.productPackagingValueFieldSpecified;
            }
            set
            {
                this.productPackagingValueFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string SellerProductId
        {
            get
            {
                return this.sellerProductIdField;
            }
            set
            {
                this.sellerProductIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        public ShippingInformation[] ShippingInformationList
        {
            get
            {
                return this.shippingInformationListField;
            }
            set
            {
                this.shippingInformationListField = value;
            }
        }

        /// <remarks/>
        public int Stock
        {
            get
            {
                return this.stockField;
            }
            set
            {
                this.stockField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StockSpecified
        {
            get
            {
                return this.stockFieldSpecified;
            }
            set
            {
                this.stockFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<decimal> StrikedPrice
        {
            get
            {
                return this.strikedPriceField;
            }
            set
            {
                this.strikedPriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StrikedPriceSpecified
        {
            get
            {
                return this.strikedPriceFieldSpecified;
            }
            set
            {
                this.strikedPriceFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal VatRate
        {
            get
            {
                return this.vatRateField;
            }
            set
            {
                this.vatRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool VatRateSpecified
        {
            get
            {
                return this.vatRateFieldSpecified;
            }
            set
            {
                this.vatRateFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public enum LogisticMode
    {

        /// <remarks/>
        Marketplace,

        /// <remarks/>
        Fulfilment,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Fulfilment on demand")]
        Fulfilmentondemand,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public enum PriceAlignmentAction
    {

        /// <remarks/>
        Empty,

        /// <remarks/>
        Unknown,

        /// <remarks/>
        Align,

        /// <remarks/>
        DontAlign,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public enum ProductPackagingUnit
    {

        /// <remarks/>
        None,

        /// <remarks/>
        Liter,

        /// <remarks/>
        Kilogram,

        /// <remarks/>
        SquareMeter,

        /// <remarks/>
        CubicMeter,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class OfferReportPropertyLog
    {

        private string logMessageField;

        private string nameField;

        private string propertyCodeField;

        private string propertyErrorField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string LogMessage
        {
            get
            {
                return this.logMessageField;
            }
            set
            {
                this.logMessageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string PropertyCode
        {
            get
            {
                return this.propertyCodeField;
            }
            set
            {
                this.propertyCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string PropertyError
        {
            get
            {
                return this.propertyErrorField;
            }
            set
            {
                this.propertyErrorField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class OfferReportLog
    {

        private System.DateTime logDateField;

        private bool logDateFieldSpecified;

        private string offerIntegrationStatusField;

        private string productEanField;

        private OfferReportPropertyLog[] propertyListField;

        private string sellerProductIdField;

        private string skuField;

        private bool validatedField;

        private bool validatedFieldSpecified;

        /// <remarks/>
        public System.DateTime LogDate
        {
            get
            {
                return this.logDateField;
            }
            set
            {
                this.logDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LogDateSpecified
        {
            get
            {
                return this.logDateFieldSpecified;
            }
            set
            {
                this.logDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string OfferIntegrationStatus
        {
            get
            {
                return this.offerIntegrationStatusField;
            }
            set
            {
                this.offerIntegrationStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string ProductEan
        {
            get
            {
                return this.productEanField;
            }
            set
            {
                this.productEanField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        public OfferReportPropertyLog[] PropertyList
        {
            get
            {
                return this.propertyListField;
            }
            set
            {
                this.propertyListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string SellerProductId
        {
            get
            {
                return this.sellerProductIdField;
            }
            set
            {
                this.sellerProductIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Sku
        {
            get
            {
                return this.skuField;
            }
            set
            {
                this.skuField = value;
            }
        }

        /// <remarks/>
        public bool Validated
        {
            get
            {
                return this.validatedField;
            }
            set
            {
                this.validatedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ValidatedSpecified
        {
            get
            {
                return this.validatedFieldSpecified;
            }
            set
            {
                this.validatedFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class VariationDescription
    {

        private string variantValueDescriptionField;

        private int variantValueIdField;

        private bool variantValueIdFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string VariantValueDescription
        {
            get
            {
                return this.variantValueDescriptionField;
            }
            set
            {
                this.variantValueDescriptionField = value;
            }
        }

        /// <remarks/>
        public int VariantValueId
        {
            get
            {
                return this.variantValueIdField;
            }
            set
            {
                this.variantValueIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool VariantValueIdSpecified
        {
            get
            {
                return this.variantValueIdFieldSpecified;
            }
            set
            {
                this.variantValueIdFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class ModelDefinition
    {

        private ArrayOfKeyValueOfstringArrayOfstringty7Ep6D1KeyValueOfstringArrayOfstringty7Ep6D1[] listPropertiesField;

        private string[] mandatoryModelPropertiesField;

        private ArrayOfKeyValueOfstringArrayOfstringty7Ep6D1KeyValueOfstringArrayOfstringty7Ep6D1[] multipleFreeTextPropertiesField;

        private ArrayOfKeyValueOfstringArrayOfstringty7Ep6D1KeyValueOfstringArrayOfstringty7Ep6D1[] singleFreeTextPropertiesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        [System.Xml.Serialization.XmlArrayItemAttribute("KeyValueOfstringArrayOfstringty7Ep6D1", Namespace = "http://schemas.microsoft.com/2003/10/Serialization/Arrays", IsNullable = false)]
        public ArrayOfKeyValueOfstringArrayOfstringty7Ep6D1KeyValueOfstringArrayOfstringty7Ep6D1[] ListProperties
        {
            get
            {
                return this.listPropertiesField;
            }
            set
            {
                this.listPropertiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace = "http://schemas.microsoft.com/2003/10/Serialization/Arrays")]
        public string[] MandatoryModelProperties
        {
            get
            {
                return this.mandatoryModelPropertiesField;
            }
            set
            {
                this.mandatoryModelPropertiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        [System.Xml.Serialization.XmlArrayItemAttribute("KeyValueOfstringArrayOfstringty7Ep6D1", Namespace = "http://schemas.microsoft.com/2003/10/Serialization/Arrays", IsNullable = false)]
        public ArrayOfKeyValueOfstringArrayOfstringty7Ep6D1KeyValueOfstringArrayOfstringty7Ep6D1[] MultipleFreeTextProperties
        {
            get
            {
                return this.multipleFreeTextPropertiesField;
            }
            set
            {
                this.multipleFreeTextPropertiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        [System.Xml.Serialization.XmlArrayItemAttribute("KeyValueOfstringArrayOfstringty7Ep6D1", Namespace = "http://schemas.microsoft.com/2003/10/Serialization/Arrays", IsNullable = false)]
        public ArrayOfKeyValueOfstringArrayOfstringty7Ep6D1KeyValueOfstringArrayOfstringty7Ep6D1[] SingleFreeTextProperties
        {
            get
            {
                return this.singleFreeTextPropertiesField;
            }
            set
            {
                this.singleFreeTextPropertiesField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/2003/10/Serialization/Arrays")]
    public partial class ArrayOfKeyValueOfstringArrayOfstringty7Ep6D1KeyValueOfstringArrayOfstringty7Ep6D1
    {

        private string keyField;

        private string[] valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Key
        {
            get
            {
                return this.keyField;
            }
            set
            {
                this.keyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        public string[] Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class ProductModel
    {

        private string categoryCodeField;

        private ModelDefinition definitionField;

        private int modelIdField;

        private bool modelIdFieldSpecified;

        private string nameField;

        private string productXmlStructureField;

        private VariationDescription[] variationValueListField;

        private string versionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string CategoryCode
        {
            get
            {
                return this.categoryCodeField;
            }
            set
            {
                this.categoryCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public ModelDefinition Definition
        {
            get
            {
                return this.definitionField;
            }
            set
            {
                this.definitionField = value;
            }
        }

        /// <remarks/>
        public int ModelId
        {
            get
            {
                return this.modelIdField;
            }
            set
            {
                this.modelIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ModelIdSpecified
        {
            get
            {
                return this.modelIdFieldSpecified;
            }
            set
            {
                this.modelIdFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string ProductXmlStructure
        {
            get
            {
                return this.productXmlStructureField;
            }
            set
            {
                this.productXmlStructureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        public VariationDescription[] VariationValueList
        {
            get
            {
                return this.variationValueListField;
            }
            set
            {
                this.variationValueListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class CategoryTree
    {

        private bool allowOfferIntegrationField;

        private bool allowOfferIntegrationFieldSpecified;

        private bool allowProductIntegrationField;

        private bool allowProductIntegrationFieldSpecified;

        private CategoryTree[] childrenCategoryListField;

        private string codeField;

        private System.Nullable<bool> isEANOptionalField;

        private bool isEANOptionalFieldSpecified;

        private bool isStandardProductKindEligibleField;

        private bool isStandardProductKindEligibleFieldSpecified;

        private bool isVariantProductKindEligibleField;

        private bool isVariantProductKindEligibleFieldSpecified;

        private string nameField;

        /// <remarks/>
        public bool AllowOfferIntegration
        {
            get
            {
                return this.allowOfferIntegrationField;
            }
            set
            {
                this.allowOfferIntegrationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AllowOfferIntegrationSpecified
        {
            get
            {
                return this.allowOfferIntegrationFieldSpecified;
            }
            set
            {
                this.allowOfferIntegrationFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool AllowProductIntegration
        {
            get
            {
                return this.allowProductIntegrationField;
            }
            set
            {
                this.allowProductIntegrationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AllowProductIntegrationSpecified
        {
            get
            {
                return this.allowProductIntegrationFieldSpecified;
            }
            set
            {
                this.allowProductIntegrationFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        public CategoryTree[] ChildrenCategoryList
        {
            get
            {
                return this.childrenCategoryListField;
            }
            set
            {
                this.childrenCategoryListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<bool> IsEANOptional
        {
            get
            {
                return this.isEANOptionalField;
            }
            set
            {
                this.isEANOptionalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsEANOptionalSpecified
        {
            get
            {
                return this.isEANOptionalFieldSpecified;
            }
            set
            {
                this.isEANOptionalFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool IsStandardProductKindEligible
        {
            get
            {
                return this.isStandardProductKindEligibleField;
            }
            set
            {
                this.isStandardProductKindEligibleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsStandardProductKindEligibleSpecified
        {
            get
            {
                return this.isStandardProductKindEligibleFieldSpecified;
            }
            set
            {
                this.isStandardProductKindEligibleFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool IsVariantProductKindEligible
        {
            get
            {
                return this.isVariantProductKindEligibleField;
            }
            set
            {
                this.isVariantProductKindEligibleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsVariantProductKindEligibleSpecified
        {
            get
            {
                return this.isVariantProductKindEligibleFieldSpecified;
            }
            set
            {
                this.isVariantProductKindEligibleFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class ProductMatching
    {

        private string colorField;

        private string commentField;

        private string eanField;

        private ProductMatchingStatusEnum matchingStatusField;

        private string nameField;

        private string sellerProductIdField;

        private string sizeField;

        private string skuField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Color
        {
            get
            {
                return this.colorField;
            }
            set
            {
                this.colorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Comment
        {
            get
            {
                return this.commentField;
            }
            set
            {
                this.commentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Ean
        {
            get
            {
                return this.eanField;
            }
            set
            {
                this.eanField = value;
            }
        }

        /// <remarks/>
        public ProductMatchingStatusEnum MatchingStatus
        {
            get
            {
                return this.matchingStatusField;
            }
            set
            {
                this.matchingStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string SellerProductId
        {
            get
            {
                return this.sellerProductIdField;
            }
            set
            {
                this.sellerProductIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Size
        {
            get
            {
                return this.sizeField;
            }
            set
            {
                this.sizeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Sku
        {
            get
            {
                return this.skuField;
            }
            set
            {
                this.skuField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public enum ProductMatchingStatusEnum
    {

        /// <remarks/>
        None,

        /// <remarks/>
        Pending,

        /// <remarks/>
        Ok,

        /// <remarks/>
        Ko,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class ProductReportPropertyLog
    {

        private string errorCodeField;

        private string logMessageField;

        private string nameField;

        private string propertyErrorField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string ErrorCode
        {
            get
            {
                return this.errorCodeField;
            }
            set
            {
                this.errorCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string LogMessage
        {
            get
            {
                return this.logMessageField;
            }
            set
            {
                this.logMessageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string PropertyError
        {
            get
            {
                return this.propertyErrorField;
            }
            set
            {
                this.propertyErrorField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class ProductReportLog
    {

        private System.DateTime logDateField;

        private bool logDateFieldSpecified;

        private string productIntegrationStatusField;

        private ProductReportPropertyLog[] propertyListField;

        private string sKUField;

        private bool validatedField;

        private bool validatedFieldSpecified;

        /// <remarks/>
        public System.DateTime LogDate
        {
            get
            {
                return this.logDateField;
            }
            set
            {
                this.logDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LogDateSpecified
        {
            get
            {
                return this.logDateFieldSpecified;
            }
            set
            {
                this.logDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string ProductIntegrationStatus
        {
            get
            {
                return this.productIntegrationStatusField;
            }
            set
            {
                this.productIntegrationStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        public ProductReportPropertyLog[] PropertyList
        {
            get
            {
                return this.propertyListField;
            }
            set
            {
                this.propertyListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string SKU
        {
            get
            {
                return this.sKUField;
            }
            set
            {
                this.sKUField = value;
            }
        }

        /// <remarks/>
        public bool Validated
        {
            get
            {
                return this.validatedField;
            }
            set
            {
                this.validatedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ValidatedSpecified
        {
            get
            {
                return this.validatedFieldSpecified;
            }
            set
            {
                this.validatedFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class Product
    {

        private string brandNameField;

        private string[] eANListField;

        private string iSBNField;

        private string nameField;

        private ProductTypeEnum productTypeField;

        private bool productTypeFieldSpecified;

        private string sKUField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string BrandName
        {
            get
            {
                return this.brandNameField;
            }
            set
            {
                this.brandNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace = "http://schemas.microsoft.com/2003/10/Serialization/Arrays")]
        public string[] EANList
        {
            get
            {
                return this.eANListField;
            }
            set
            {
                this.eANListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string ISBN
        {
            get
            {
                return this.iSBNField;
            }
            set
            {
                this.iSBNField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public ProductTypeEnum ProductType
        {
            get
            {
                return this.productTypeField;
            }
            set
            {
                this.productTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ProductTypeSpecified
        {
            get
            {
                return this.productTypeFieldSpecified;
            }
            set
            {
                this.productTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string SKU
        {
            get
            {
                return this.sKUField;
            }
            set
            {
                this.sKUField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public enum ProductTypeEnum
    {

        /// <remarks/>
        Standard,

        /// <remarks/>
        Variant,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com/ProductByIdentifier")]
    public partial class ProductByIdentifier
    {

        private string brandNameField;

        private string categoryCodeField;

        private string colorField;

        private string eanField;

        private string errorMessageField;

        private string fatherProductIdField;

        private bool hasErrorField;

        private bool hasErrorFieldSpecified;

        private string imageUrlField;

        private string nameField;

        private System.Nullable<ProductTypeEnum> productTypeField;

        private bool productTypeFieldSpecified;

        private string sizeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string BrandName
        {
            get
            {
                return this.brandNameField;
            }
            set
            {
                this.brandNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string CategoryCode
        {
            get
            {
                return this.categoryCodeField;
            }
            set
            {
                this.categoryCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Color
        {
            get
            {
                return this.colorField;
            }
            set
            {
                this.colorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Ean
        {
            get
            {
                return this.eanField;
            }
            set
            {
                this.eanField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string ErrorMessage
        {
            get
            {
                return this.errorMessageField;
            }
            set
            {
                this.errorMessageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string FatherProductId
        {
            get
            {
                return this.fatherProductIdField;
            }
            set
            {
                this.fatherProductIdField = value;
            }
        }

        /// <remarks/>
        public bool HasError
        {
            get
            {
                return this.hasErrorField;
            }
            set
            {
                this.hasErrorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HasErrorSpecified
        {
            get
            {
                return this.hasErrorFieldSpecified;
            }
            set
            {
                this.hasErrorFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string ImageUrl
        {
            get
            {
                return this.imageUrlField;
            }
            set
            {
                this.imageUrlField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<ProductTypeEnum> ProductType
        {
            get
            {
                return this.productTypeField;
            }
            set
            {
                this.productTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ProductTypeSpecified
        {
            get
            {
                return this.productTypeFieldSpecified;
            }
            set
            {
                this.productTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Size
        {
            get
            {
                return this.sizeField;
            }
            set
            {
                this.sizeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.datacontract.org/2004/07/Cdiscount.Service.Marketplace.API.Externa" +
        "l.Contract.Data.Product")]
    public partial class ProductStock
    {

        private int blockedStockField;

        private string eanField;

        private System.Nullable<int> fodStockField;

        private int frontStockField;

        private bool isReferencedField;

        private string libelleField;

        private string sellerReferenceField;

        private string skuField;

        private int stockInWarehouseField;

        private string warehouseField;

        /// <remarks/>
        public int BlockedStock
        {
            get
            {
                return this.blockedStockField;
            }
            set
            {
                this.blockedStockField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Ean
        {
            get
            {
                return this.eanField;
            }
            set
            {
                this.eanField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<int> FodStock
        {
            get
            {
                return this.fodStockField;
            }
            set
            {
                this.fodStockField = value;
            }
        }

        /// <remarks/>
        public int FrontStock
        {
            get
            {
                return this.frontStockField;
            }
            set
            {
                this.frontStockField = value;
            }
        }

        /// <remarks/>
        public bool IsReferenced
        {
            get
            {
                return this.isReferencedField;
            }
            set
            {
                this.isReferencedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Libelle
        {
            get
            {
                return this.libelleField;
            }
            set
            {
                this.libelleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string SellerReference
        {
            get
            {
                return this.sellerReferenceField;
            }
            set
            {
                this.sellerReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Sku
        {
            get
            {
                return this.skuField;
            }
            set
            {
                this.skuField = value;
            }
        }

        /// <remarks/>
        public int StockInWarehouse
        {
            get
            {
                return this.stockInWarehouseField;
            }
            set
            {
                this.stockInWarehouseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Warehouse
        {
            get
            {
                return this.warehouseField;
            }
            set
            {
                this.warehouseField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class Brand
    {

        private string brandNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string BrandName
        {
            get
            {
                return this.brandNameField;
            }
            set
            {
                this.brandNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SellerRefundResultMessage))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SellerRefundResult))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RefundInformationMessage))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ParcelActionResult))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ServiceBaseAPIMessage))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OfferProductListPaginatedMessage))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SupplyOrderReportListMessage))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FulfilmentActivationMessage))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SupplyOrderMessage))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OfferStateReportMessage))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SupplyOrderReportMessage))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FulfilmentOrderLineListToSupplyMessage))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FulfilmentActivationReportMessage))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DiscussionMailListMessage))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OfferQuestionListMessage))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OrderQuestionListMessage))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OrderClaimListMessage))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CloseDiscussionResultMessage))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ParcelShopListMessage))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RelayIntegrationReportMessage))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RelaysFileDepositMessage))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GlobalConfigurationMessage))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CreateRefundVoucherMessage))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ManageParcelResultMessage))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ValidationResultMessage))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ServiceOrderListMessage))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OrderListMessage))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SellerIndicatorsMessage))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SellerMessage))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OfferListMessage))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OfferListPaginatedMessage))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OfferIntegrationReportMessage))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ProductModelListMessage))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CategoryTreeMessage))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ProductMatchingFileMessage))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ProductIntegrationReportMessage))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ProductListMessage))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ProductListByIdentifierMessage))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OrderIntegrationMessage))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DiscussionMailGuidCreationResultMessage))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OrderStatusMessage))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ProductStockListMessage))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BrandListMessage))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FulfilmentDeliveryDocumentMessage))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.datacontract.org/2004/07/Cdiscount.Framework.Core.Communication.Me" +
        "ssages")]
    public partial class ServiceMessage
    {

        private string errorMessageField;

        private bool operationSuccessField;

        private bool operationSuccessFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string ErrorMessage
        {
            get
            {
                return this.errorMessageField;
            }
            set
            {
                this.errorMessageField = value;
            }
        }

        /// <remarks/>
        public bool OperationSuccess
        {
            get
            {
                return this.operationSuccessField;
            }
            set
            {
                this.operationSuccessField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OperationSuccessSpecified
        {
            get
            {
                return this.operationSuccessFieldSpecified;
            }
            set
            {
                this.operationSuccessFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class SellerRefundResultMessage : ServiceMessage
    {

        private string orderNumberField;

        private SellerRefundResult[] sellerRefundResultListField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string OrderNumber
        {
            get
            {
                return this.orderNumberField;
            }
            set
            {
                this.orderNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        public SellerRefundResult[] SellerRefundResultList
        {
            get
            {
                return this.sellerRefundResultListField;
            }
            set
            {
                this.sellerRefundResultListField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class SellerRefundResult : ServiceMessage
    {

        private string eanField;

        private RefundMotive motiveField;

        private string sellerProductIdField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Ean
        {
            get
            {
                return this.eanField;
            }
            set
            {
                this.eanField = value;
            }
        }

        /// <remarks/>
        public RefundMotive Motive
        {
            get
            {
                return this.motiveField;
            }
            set
            {
                this.motiveField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string SellerProductId
        {
            get
            {
                return this.sellerProductIdField;
            }
            set
            {
                this.sellerProductIdField = value;
            }
        }

        /// <remarks/>
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class RefundInformationMessage : ServiceMessage
    {

        private decimal amountField;

        private int motiveIdField;

        /// <remarks/>
        public decimal Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }

        /// <remarks/>
        public int MotiveId
        {
            get
            {
                return this.motiveIdField;
            }
            set
            {
                this.motiveIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class ParcelActionResult : ServiceMessage
    {

        private ParcelActionTypes actionTypeField;

        private bool actionTypeFieldSpecified;

        private bool isActionCreatedField;

        private bool isActionCreatedFieldSpecified;

        private string parcelNumberField;

        /// <remarks/>
        public ParcelActionTypes ActionType
        {
            get
            {
                return this.actionTypeField;
            }
            set
            {
                this.actionTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ActionTypeSpecified
        {
            get
            {
                return this.actionTypeFieldSpecified;
            }
            set
            {
                this.actionTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool IsActionCreated
        {
            get
            {
                return this.isActionCreatedField;
            }
            set
            {
                this.isActionCreatedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsActionCreatedSpecified
        {
            get
            {
                return this.isActionCreatedFieldSpecified;
            }
            set
            {
                this.isActionCreatedFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string ParcelNumber
        {
            get
            {
                return this.parcelNumberField;
            }
            set
            {
                this.parcelNumberField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OfferProductListPaginatedMessage))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SupplyOrderReportListMessage))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FulfilmentActivationMessage))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SupplyOrderMessage))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OfferStateReportMessage))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SupplyOrderReportMessage))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FulfilmentOrderLineListToSupplyMessage))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FulfilmentActivationReportMessage))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DiscussionMailListMessage))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OfferQuestionListMessage))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OrderQuestionListMessage))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OrderClaimListMessage))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CloseDiscussionResultMessage))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ParcelShopListMessage))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RelayIntegrationReportMessage))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RelaysFileDepositMessage))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GlobalConfigurationMessage))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CreateRefundVoucherMessage))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ManageParcelResultMessage))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ValidationResultMessage))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ServiceOrderListMessage))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OrderListMessage))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SellerIndicatorsMessage))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SellerMessage))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OfferListMessage))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OfferListPaginatedMessage))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OfferIntegrationReportMessage))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ProductModelListMessage))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CategoryTreeMessage))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ProductMatchingFileMessage))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ProductIntegrationReportMessage))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ProductListMessage))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ProductListByIdentifierMessage))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OrderIntegrationMessage))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DiscussionMailGuidCreationResultMessage))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OrderStatusMessage))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ProductStockListMessage))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BrandListMessage))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FulfilmentDeliveryDocumentMessage))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class ServiceBaseAPIMessage : ServiceMessage
    {

        private Error[] errorListField;

        private string sellerLoginField;

        private string tokenIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        public Error[] ErrorList
        {
            get
            {
                return this.errorListField;
            }
            set
            {
                this.errorListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string SellerLogin
        {
            get
            {
                return this.sellerLoginField;
            }
            set
            {
                this.sellerLoginField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string TokenId
        {
            get
            {
                return this.tokenIdField;
            }
            set
            {
                this.tokenIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class OfferProductListPaginatedMessage : ServiceBaseAPIMessage
    {

        private int currentPageNumberField;

        private bool currentPageNumberFieldSpecified;

        private int numberOfPagesField;

        private bool numberOfPagesFieldSpecified;

        private OfferProduct[] offerProductListField;

        private int offerTotalCountField;

        private bool offerTotalCountFieldSpecified;

        /// <remarks/>
        public int CurrentPageNumber
        {
            get
            {
                return this.currentPageNumberField;
            }
            set
            {
                this.currentPageNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CurrentPageNumberSpecified
        {
            get
            {
                return this.currentPageNumberFieldSpecified;
            }
            set
            {
                this.currentPageNumberFieldSpecified = value;
            }
        }

        /// <remarks/>
        public int NumberOfPages
        {
            get
            {
                return this.numberOfPagesField;
            }
            set
            {
                this.numberOfPagesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NumberOfPagesSpecified
        {
            get
            {
                return this.numberOfPagesFieldSpecified;
            }
            set
            {
                this.numberOfPagesFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        public OfferProduct[] OfferProductList
        {
            get
            {
                return this.offerProductListField;
            }
            set
            {
                this.offerProductListField = value;
            }
        }

        /// <remarks/>
        public int OfferTotalCount
        {
            get
            {
                return this.offerTotalCountField;
            }
            set
            {
                this.offerTotalCountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OfferTotalCountSpecified
        {
            get
            {
                return this.offerTotalCountFieldSpecified;
            }
            set
            {
                this.offerTotalCountFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class SupplyOrderReportListMessage : ServiceBaseAPIMessage
    {

        private int currentPageNumberField;

        private int numberOfPagesField;

        private SupplyOrderReport[] reportListField;

        /// <remarks/>
        public int CurrentPageNumber
        {
            get
            {
                return this.currentPageNumberField;
            }
            set
            {
                this.currentPageNumberField = value;
            }
        }

        /// <remarks/>
        public int NumberOfPages
        {
            get
            {
                return this.numberOfPagesField;
            }
            set
            {
                this.numberOfPagesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        public SupplyOrderReport[] ReportList
        {
            get
            {
                return this.reportListField;
            }
            set
            {
                this.reportListField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class FulfilmentActivationMessage : ServiceBaseAPIMessage
    {

        private int depositIdField;

        private bool depositIdFieldSpecified;

        /// <remarks/>
        public int DepositId
        {
            get
            {
                return this.depositIdField;
            }
            set
            {
                this.depositIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DepositIdSpecified
        {
            get
            {
                return this.depositIdFieldSpecified;
            }
            set
            {
                this.depositIdFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class SupplyOrderMessage : ServiceBaseAPIMessage
    {

        private int currentPageNumberField;

        private bool currentPageNumberFieldSpecified;

        private int numberOfPagesField;

        private bool numberOfPagesFieldSpecified;

        private SupplyOrderLine[] supplyOrderLineListField;

        /// <remarks/>
        public int CurrentPageNumber
        {
            get
            {
                return this.currentPageNumberField;
            }
            set
            {
                this.currentPageNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CurrentPageNumberSpecified
        {
            get
            {
                return this.currentPageNumberFieldSpecified;
            }
            set
            {
                this.currentPageNumberFieldSpecified = value;
            }
        }

        /// <remarks/>
        public int NumberOfPages
        {
            get
            {
                return this.numberOfPagesField;
            }
            set
            {
                this.numberOfPagesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NumberOfPagesSpecified
        {
            get
            {
                return this.numberOfPagesFieldSpecified;
            }
            set
            {
                this.numberOfPagesFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        public SupplyOrderLine[] SupplyOrderLineList
        {
            get
            {
                return this.supplyOrderLineListField;
            }
            set
            {
                this.supplyOrderLineListField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class OfferStateReportMessage : ServiceBaseAPIMessage
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class SupplyOrderReportMessage : ServiceBaseAPIMessage
    {

        private int depositIdField;

        /// <remarks/>
        public int DepositId
        {
            get
            {
                return this.depositIdField;
            }
            set
            {
                this.depositIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class FulfilmentOrderLineListToSupplyMessage : ServiceBaseAPIMessage
    {

        private FulfilmentOrderLine[] orderLineListField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        public FulfilmentOrderLine[] OrderLineList
        {
            get
            {
                return this.orderLineListField;
            }
            set
            {
                this.orderLineListField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class FulfilmentActivationReportMessage : ServiceBaseAPIMessage
    {

        private FulfilmentActivationReport[] fulfilmentActivationReportListField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        public FulfilmentActivationReport[] FulfilmentActivationReportList
        {
            get
            {
                return this.fulfilmentActivationReportListField;
            }
            set
            {
                this.fulfilmentActivationReportListField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class DiscussionMailListMessage : ServiceBaseAPIMessage
    {

        private DiscussionMail[] discussionMailListField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        public DiscussionMail[] DiscussionMailList
        {
            get
            {
                return this.discussionMailListField;
            }
            set
            {
                this.discussionMailListField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class OfferQuestionListMessage : ServiceBaseAPIMessage
    {

        private OfferQuestion[] offerQuestionListField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        public OfferQuestion[] OfferQuestionList
        {
            get
            {
                return this.offerQuestionListField;
            }
            set
            {
                this.offerQuestionListField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class OrderQuestionListMessage : ServiceBaseAPIMessage
    {

        private OrderQuestion[] orderQuestionListField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        public OrderQuestion[] OrderQuestionList
        {
            get
            {
                return this.orderQuestionListField;
            }
            set
            {
                this.orderQuestionListField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class OrderClaimListMessage : ServiceBaseAPIMessage
    {

        private OrderClaim[] orderClaimListField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        public OrderClaim[] OrderClaimList
        {
            get
            {
                return this.orderClaimListField;
            }
            set
            {
                this.orderClaimListField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class CloseDiscussionResultMessage : ServiceBaseAPIMessage
    {

        private CloseDiscussionResult[] closeDiscussionResultListField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        public CloseDiscussionResult[] CloseDiscussionResultList
        {
            get
            {
                return this.closeDiscussionResultListField;
            }
            set
            {
                this.closeDiscussionResultListField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class ParcelShopListMessage : ServiceBaseAPIMessage
    {

        private ParcelShop[] parcelShopListField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        public ParcelShop[] ParcelShopList
        {
            get
            {
                return this.parcelShopListField;
            }
            set
            {
                this.parcelShopListField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class RelayIntegrationReportMessage : ServiceBaseAPIMessage
    {

        private int numberOfErrorsField;

        private bool numberOfErrorsFieldSpecified;

        private int relaysFileIdField;

        private bool relaysFileIdFieldSpecified;

        private string relaysFileIntegrationStatusField;

        private RelayIntegrationLog[] relaysLogListField;

        /// <remarks/>
        public int NumberOfErrors
        {
            get
            {
                return this.numberOfErrorsField;
            }
            set
            {
                this.numberOfErrorsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NumberOfErrorsSpecified
        {
            get
            {
                return this.numberOfErrorsFieldSpecified;
            }
            set
            {
                this.numberOfErrorsFieldSpecified = value;
            }
        }

        /// <remarks/>
        public int RelaysFileId
        {
            get
            {
                return this.relaysFileIdField;
            }
            set
            {
                this.relaysFileIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RelaysFileIdSpecified
        {
            get
            {
                return this.relaysFileIdFieldSpecified;
            }
            set
            {
                this.relaysFileIdFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string RelaysFileIntegrationStatus
        {
            get
            {
                return this.relaysFileIntegrationStatusField;
            }
            set
            {
                this.relaysFileIntegrationStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        public RelayIntegrationLog[] RelaysLogList
        {
            get
            {
                return this.relaysLogListField;
            }
            set
            {
                this.relaysLogListField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class RelaysFileDepositMessage : ServiceBaseAPIMessage
    {

        private int relaysFileIdField;

        private bool relaysFileIdFieldSpecified;

        /// <remarks/>
        public int RelaysFileId
        {
            get
            {
                return this.relaysFileIdField;
            }
            set
            {
                this.relaysFileIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RelaysFileIdSpecified
        {
            get
            {
                return this.relaysFileIdFieldSpecified;
            }
            set
            {
                this.relaysFileIdFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class GlobalConfigurationMessage : ServiceBaseAPIMessage
    {

        private Carrier[] carrierListField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        public Carrier[] CarrierList
        {
            get
            {
                return this.carrierListField;
            }
            set
            {
                this.carrierListField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class CreateRefundVoucherMessage : ServiceBaseAPIMessage
    {

        private RefundInformationMessage[] commercialGestureListField;

        private string orderNumberField;

        private SellerRefundResult[] sellerRefundListField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        public RefundInformationMessage[] CommercialGestureList
        {
            get
            {
                return this.commercialGestureListField;
            }
            set
            {
                this.commercialGestureListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string OrderNumber
        {
            get
            {
                return this.orderNumberField;
            }
            set
            {
                this.orderNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        public SellerRefundResult[] SellerRefundList
        {
            get
            {
                return this.sellerRefundListField;
            }
            set
            {
                this.sellerRefundListField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class ManageParcelResultMessage : ServiceBaseAPIMessage
    {

        private ParcelActionResult[] parcelActionResultListField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        public ParcelActionResult[] ParcelActionResultList
        {
            get
            {
                return this.parcelActionResultListField;
            }
            set
            {
                this.parcelActionResultListField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class ValidationResultMessage : ServiceBaseAPIMessage
    {

        private ValidateOrderResult[] validateOrderResultsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        public ValidateOrderResult[] ValidateOrderResults
        {
            get
            {
                return this.validateOrderResultsField;
            }
            set
            {
                this.validateOrderResultsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class ServiceOrderListMessage : ServiceBaseAPIMessage
    {

        private ServiceOrder[] serviceOrderListField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        public ServiceOrder[] ServiceOrderList
        {
            get
            {
                return this.serviceOrderListField;
            }
            set
            {
                this.serviceOrderListField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class OrderListMessage : ServiceBaseAPIMessage
    {

        private Order[] orderListField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        public Order[] OrderList
        {
            get
            {
                return this.orderListField;
            }
            set
            {
                this.orderListField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class SellerIndicatorsMessage : ServiceBaseAPIMessage
    {

        private SellerIndicator[] sellerIndicatorsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        public SellerIndicator[] SellerIndicators
        {
            get
            {
                return this.sellerIndicatorsField;
            }
            set
            {
                this.sellerIndicatorsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class SellerMessage : ServiceBaseAPIMessage
    {

        private DeliveryModeInformation[] deliveryModesField;

        private OfferPool[] offerPoolListField;

        private Seller sellerField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        public DeliveryModeInformation[] DeliveryModes
        {
            get
            {
                return this.deliveryModesField;
            }
            set
            {
                this.deliveryModesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        public OfferPool[] OfferPoolList
        {
            get
            {
                return this.offerPoolListField;
            }
            set
            {
                this.offerPoolListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public Seller Seller
        {
            get
            {
                return this.sellerField;
            }
            set
            {
                this.sellerField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OfferListPaginatedMessage))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class OfferListMessage : ServiceBaseAPIMessage
    {

        private Offer[] offerListField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        public Offer[] OfferList
        {
            get
            {
                return this.offerListField;
            }
            set
            {
                this.offerListField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class OfferListPaginatedMessage : OfferListMessage
    {

        private int currentPageNumberField;

        private bool currentPageNumberFieldSpecified;

        private int numberOfPagesField;

        private bool numberOfPagesFieldSpecified;

        /// <remarks/>
        public int CurrentPageNumber
        {
            get
            {
                return this.currentPageNumberField;
            }
            set
            {
                this.currentPageNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CurrentPageNumberSpecified
        {
            get
            {
                return this.currentPageNumberFieldSpecified;
            }
            set
            {
                this.currentPageNumberFieldSpecified = value;
            }
        }

        /// <remarks/>
        public int NumberOfPages
        {
            get
            {
                return this.numberOfPagesField;
            }
            set
            {
                this.numberOfPagesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NumberOfPagesSpecified
        {
            get
            {
                return this.numberOfPagesFieldSpecified;
            }
            set
            {
                this.numberOfPagesFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class OfferIntegrationReportMessage : ServiceBaseAPIMessage
    {

        private int numberOfErrorsField;

        private bool numberOfErrorsFieldSpecified;

        private OfferReportLog[] offerLogListField;

        private long packageIdField;

        private bool packageIdFieldSpecified;

        private string packageIntegrationStatusField;

        /// <remarks/>
        public int NumberOfErrors
        {
            get
            {
                return this.numberOfErrorsField;
            }
            set
            {
                this.numberOfErrorsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NumberOfErrorsSpecified
        {
            get
            {
                return this.numberOfErrorsFieldSpecified;
            }
            set
            {
                this.numberOfErrorsFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        public OfferReportLog[] OfferLogList
        {
            get
            {
                return this.offerLogListField;
            }
            set
            {
                this.offerLogListField = value;
            }
        }

        /// <remarks/>
        public long PackageId
        {
            get
            {
                return this.packageIdField;
            }
            set
            {
                this.packageIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PackageIdSpecified
        {
            get
            {
                return this.packageIdFieldSpecified;
            }
            set
            {
                this.packageIdFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string PackageIntegrationStatus
        {
            get
            {
                return this.packageIntegrationStatusField;
            }
            set
            {
                this.packageIntegrationStatusField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class ProductModelListMessage : ServiceBaseAPIMessage
    {

        private ProductModel[] modelListField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        public ProductModel[] ModelList
        {
            get
            {
                return this.modelListField;
            }
            set
            {
                this.modelListField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class CategoryTreeMessage : ServiceBaseAPIMessage
    {

        private CategoryTree categoryTreeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public CategoryTree CategoryTree
        {
            get
            {
                return this.categoryTreeField;
            }
            set
            {
                this.categoryTreeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class ProductMatchingFileMessage : ServiceBaseAPIMessage
    {

        private long packageIdField;

        private bool packageIdFieldSpecified;

        private ProductMatching[] productMatchingListField;

        /// <remarks/>
        public long PackageId
        {
            get
            {
                return this.packageIdField;
            }
            set
            {
                this.packageIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PackageIdSpecified
        {
            get
            {
                return this.packageIdFieldSpecified;
            }
            set
            {
                this.packageIdFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        public ProductMatching[] ProductMatchingList
        {
            get
            {
                return this.productMatchingListField;
            }
            set
            {
                this.productMatchingListField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class ProductIntegrationReportMessage : ServiceBaseAPIMessage
    {

        private int numberOfErrorsField;

        private bool numberOfErrorsFieldSpecified;

        private long packageIdField;

        private bool packageIdFieldSpecified;

        private string packageIntegrationStatusField;

        private ProductReportLog[] productLogListField;

        /// <remarks/>
        public int NumberOfErrors
        {
            get
            {
                return this.numberOfErrorsField;
            }
            set
            {
                this.numberOfErrorsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NumberOfErrorsSpecified
        {
            get
            {
                return this.numberOfErrorsFieldSpecified;
            }
            set
            {
                this.numberOfErrorsFieldSpecified = value;
            }
        }

        /// <remarks/>
        public long PackageId
        {
            get
            {
                return this.packageIdField;
            }
            set
            {
                this.packageIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PackageIdSpecified
        {
            get
            {
                return this.packageIdFieldSpecified;
            }
            set
            {
                this.packageIdFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string PackageIntegrationStatus
        {
            get
            {
                return this.packageIntegrationStatusField;
            }
            set
            {
                this.packageIntegrationStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        public ProductReportLog[] ProductLogList
        {
            get
            {
                return this.productLogListField;
            }
            set
            {
                this.productLogListField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class ProductListMessage : ServiceBaseAPIMessage
    {

        private Product[] productListField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        public Product[] ProductList
        {
            get
            {
                return this.productListField;
            }
            set
            {
                this.productListField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com/ProductByIdentifier")]
    public partial class ProductListByIdentifierMessage : ServiceBaseAPIMessage
    {

        private ProductByIdentifier[] productListByIdentifierField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        public ProductByIdentifier[] ProductListByIdentifier
        {
            get
            {
                return this.productListByIdentifierField;
            }
            set
            {
                this.productListByIdentifierField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.datacontract.org/2004/07/Cdiscount.Service.Marketplace.API.Externa" +
        "l.Contract.Data")]
    public partial class OrderIntegrationMessage : ServiceBaseAPIMessage
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.datacontract.org/2004/07/Cdiscount.Service.Marketplace.API.Externa" +
        "l.Contract.Data.Mail")]
    public partial class DiscussionMailGuidCreationResultMessage : ServiceBaseAPIMessage
    {

        private string mailGuidField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string MailGuid
        {
            get
            {
                return this.mailGuidField;
            }
            set
            {
                this.mailGuidField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.datacontract.org/2004/07/Cdiscount.Service.Marketplace.API.Externa" +
        "l.Contract.Data.Order")]
    public partial class OrderStatusMessage : ServiceBaseAPIMessage
    {

        private ExternalOrderStatus statusField;

        private bool statusFieldSpecified;

        /// <remarks/>
        public ExternalOrderStatus Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StatusSpecified
        {
            get
            {
                return this.statusFieldSpecified;
            }
            set
            {
                this.statusFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public enum ExternalOrderStatus
    {

        /// <remarks/>
        Ok,

        /// <remarks/>
        Pending,

        /// <remarks/>
        Ko,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.datacontract.org/2004/07/Cdiscount.Service.Marketplace.API.Externa" +
        "l.Contract.Data.Product")]
    public partial class ProductStockListMessage : ServiceBaseAPIMessage
    {

        private ProductStock[] productStockListField;

        private FulfilmentProductListStatus statusField;

        private bool statusFieldSpecified;

        private int totalProductCountField;

        private bool totalProductCountFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        public ProductStock[] ProductStockList
        {
            get
            {
                return this.productStockListField;
            }
            set
            {
                this.productStockListField = value;
            }
        }

        /// <remarks/>
        public FulfilmentProductListStatus Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StatusSpecified
        {
            get
            {
                return this.statusFieldSpecified;
            }
            set
            {
                this.statusFieldSpecified = value;
            }
        }

        /// <remarks/>
        public int TotalProductCount
        {
            get
            {
                return this.totalProductCountField;
            }
            set
            {
                this.totalProductCountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TotalProductCountSpecified
        {
            get
            {
                return this.totalProductCountFieldSpecified;
            }
            set
            {
                this.totalProductCountFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public enum FulfilmentProductListStatus
    {

        /// <remarks/>
        Ok,

        /// <remarks/>
        NoData,

        /// <remarks/>
        KO,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.datacontract.org/2004/07/Cdiscount.Service.Marketplace.API.Externa" +
        "l.Contract.Data.Product")]
    public partial class BrandListMessage : ServiceBaseAPIMessage
    {

        private Brand[] brandListField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Namespace = "http://www.cdiscount.com")]
        public Brand[] BrandList
        {
            get
            {
                return this.brandListField;
            }
            set
            {
                this.brandListField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.datacontract.org/2004/07/Cdiscount.Service.Marketplace.API.Externa" +
        "l.Contract.Data.Fulfilment")]
    public partial class FulfilmentDeliveryDocumentMessage : ServiceBaseAPIMessage
    {

        private string pdfDocumentField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string PdfDocument
        {
            get
            {
                return this.pdfDocumentField;
            }
            set
            {
                this.pdfDocumentField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.cdiscount.com")]
    public partial class ProductFilter
    {

        private string categoryCodeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string CategoryCode
        {
            get
            {
                return this.categoryCodeField;
            }
            set
            {
                this.categoryCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.datacontract.org/2004/07/Cdiscount.Framework.Core.Communication.Me" +
        "ssages")]
    public partial class SubjectLocality
    {

        private string addressField;

        private string dnsNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string DnsName
        {
            get
            {
                return this.dnsNameField;
            }
            set
            {
                this.dnsNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.datacontract.org/2004/07/Cdiscount.Framework.Core.Communication.Me" +
        "ssages")]
    public partial class SecurityDescriptor
    {

        private Authorization authorizationField;

        private string functionIdentifierField;

        private int versionField;

        /// <remarks/>
        public Authorization Authorization
        {
            get
            {
                return this.authorizationField;
            }
            set
            {
                this.authorizationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string FunctionIdentifier
        {
            get
            {
                return this.functionIdentifierField;
            }
            set
            {
                this.functionIdentifierField = value;
            }
        }

        /// <remarks/>
        public int Version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.datacontract.org/2004/07/Cdiscount.Framework.Core.Communication.Me" +
        "ssages")]
    public enum Authorization
    {

        /// <remarks/>
        None,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.datacontract.org/2004/07/Cdiscount.Framework.Core.Communication.Me" +
        "ssages")]
    public partial class DomainRights
    {

        private string nameField;

        private SecurityDescriptor[] securityDescriptorListField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        public SecurityDescriptor[] SecurityDescriptorList
        {
            get
            {
                return this.securityDescriptorListField;
            }
            set
            {
                this.securityDescriptorListField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.datacontract.org/2004/07/Cdiscount.Framework.Core.Communication.Me" +
        "ssages")]
    public partial class SecurityContext
    {

        private DomainRights[] domainRightsListField;

        private string issuerIDField;

        private string sessionIDField;

        private SubjectLocality subjectLocalityField;

        private string tokenIdField;

        private string userNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        public DomainRights[] DomainRightsList
        {
            get
            {
                return this.domainRightsListField;
            }
            set
            {
                this.domainRightsListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string IssuerID
        {
            get
            {
                return this.issuerIDField;
            }
            set
            {
                this.issuerIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string SessionID
        {
            get
            {
                return this.sessionIDField;
            }
            set
            {
                this.sessionIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public SubjectLocality SubjectLocality
        {
            get
            {
                return this.subjectLocalityField;
            }
            set
            {
                this.subjectLocalityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string TokenId
        {
            get
            {
                return this.tokenIdField;
            }
            set
            {
                this.tokenIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string UserName
        {
            get
            {
                return this.userNameField;
            }
            set
            {
                this.userNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.datacontract.org/2004/07/Cdiscount.Framework.Core.Communication.Me" +
        "ssages")]
    public partial class LocalizationMessage
    {

        private Country countryField;

        private bool countryFieldSpecified;

        private string cultureNameField;

        private Currency currencyField;

        private bool currencyFieldSpecified;

        private System.Nullable<int> decimalPositionField;

        private bool decimalPositionFieldSpecified;

        private Language languageField;

        private bool languageFieldSpecified;

        /// <remarks/>
        public Country Country
        {
            get
            {
                return this.countryField;
            }
            set
            {
                this.countryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CountrySpecified
        {
            get
            {
                return this.countryFieldSpecified;
            }
            set
            {
                this.countryFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string CultureName
        {
            get
            {
                return this.cultureNameField;
            }
            set
            {
                this.cultureNameField = value;
            }
        }

        /// <remarks/>
        public Currency Currency
        {
            get
            {
                return this.currencyField;
            }
            set
            {
                this.currencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CurrencySpecified
        {
            get
            {
                return this.currencyFieldSpecified;
            }
            set
            {
                this.currencyFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<int> DecimalPosition
        {
            get
            {
                return this.decimalPositionField;
            }
            set
            {
                this.decimalPositionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DecimalPositionSpecified
        {
            get
            {
                return this.decimalPositionFieldSpecified;
            }
            set
            {
                this.decimalPositionFieldSpecified = value;
            }
        }

        /// <remarks/>
        public Language Language
        {
            get
            {
                return this.languageField;
            }
            set
            {
                this.languageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LanguageSpecified
        {
            get
            {
                return this.languageFieldSpecified;
            }
            set
            {
                this.languageFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.datacontract.org/2004/07/Cdiscount.Framework.Core.Communication.Me" +
        "ssages")]
    public enum Country
    {

        /// <remarks/>
        Fr,

        /// <remarks/>
        Be,

        /// <remarks/>
        AF,

        /// <remarks/>
        ZA,

        /// <remarks/>
        AX,

        /// <remarks/>
        AL,

        /// <remarks/>
        DZ,

        /// <remarks/>
        De,

        /// <remarks/>
        AD,

        /// <remarks/>
        AO,

        /// <remarks/>
        AI,

        /// <remarks/>
        AQ,

        /// <remarks/>
        AG,

        /// <remarks/>
        AN,

        /// <remarks/>
        SA,

        /// <remarks/>
        AR,

        /// <remarks/>
        AM,

        /// <remarks/>
        AW,

        /// <remarks/>
        AU,

        /// <remarks/>
        AT,

        /// <remarks/>
        AZ,

        /// <remarks/>
        BS,

        /// <remarks/>
        BH,

        /// <remarks/>
        BD,

        /// <remarks/>
        BB,

        /// <remarks/>
        BY,

        /// <remarks/>
        BZ,

        /// <remarks/>
        BJ,

        /// <remarks/>
        BM,

        /// <remarks/>
        BT,

        /// <remarks/>
        BO,

        /// <remarks/>
        BA,

        /// <remarks/>
        BW,

        /// <remarks/>
        BV,

        /// <remarks/>
        BR,

        /// <remarks/>
        BN,

        /// <remarks/>
        BG,

        /// <remarks/>
        BF,

        /// <remarks/>
        BI,

        /// <remarks/>
        KY,

        /// <remarks/>
        KH,

        /// <remarks/>
        CM,

        /// <remarks/>
        CA,

        /// <remarks/>
        CV,

        /// <remarks/>
        CF,

        /// <remarks/>
        CL,

        /// <remarks/>
        CN,

        /// <remarks/>
        CX,

        /// <remarks/>
        CY,

        /// <remarks/>
        CC,

        /// <remarks/>
        CO,

        /// <remarks/>
        KM,

        /// <remarks/>
        CG,

        /// <remarks/>
        CD,

        /// <remarks/>
        CK,

        /// <remarks/>
        KR,

        /// <remarks/>
        KP,

        /// <remarks/>
        CR,

        /// <remarks/>
        CI,

        /// <remarks/>
        HR,

        /// <remarks/>
        CU,

        /// <remarks/>
        DK,

        /// <remarks/>
        DJ,

        /// <remarks/>
        DO,

        /// <remarks/>
        DM,

        /// <remarks/>
        EG,

        /// <remarks/>
        SV,

        /// <remarks/>
        AE,

        /// <remarks/>
        EC,

        /// <remarks/>
        ER,

        /// <remarks/>
        ES,

        /// <remarks/>
        EE,

        /// <remarks/>
        Us,

        /// <remarks/>
        ET,

        /// <remarks/>
        FK,

        /// <remarks/>
        FO,

        /// <remarks/>
        FJ,

        /// <remarks/>
        FI,

        /// <remarks/>
        GA,

        /// <remarks/>
        GM,

        /// <remarks/>
        GE,

        /// <remarks/>
        GS,

        /// <remarks/>
        GH,

        /// <remarks/>
        GI,

        /// <remarks/>
        GR,

        /// <remarks/>
        GD,

        /// <remarks/>
        GL,

        /// <remarks/>
        GP,

        /// <remarks/>
        GU,

        /// <remarks/>
        GT,

        /// <remarks/>
        GG,

        /// <remarks/>
        GN,

        /// <remarks/>
        GW,

        /// <remarks/>
        GQ,

        /// <remarks/>
        GY,

        /// <remarks/>
        GF,

        /// <remarks/>
        HT,

        /// <remarks/>
        HM,

        /// <remarks/>
        HN,

        /// <remarks/>
        HK,

        /// <remarks/>
        HU,

        /// <remarks/>
        IM,

        /// <remarks/>
        UM,

        /// <remarks/>
        VG,

        /// <remarks/>
        VI,

        /// <remarks/>
        IN,

        /// <remarks/>
        ID,

        /// <remarks/>
        IR,

        /// <remarks/>
        IQ,

        /// <remarks/>
        IE,

        /// <remarks/>
        IS,

        /// <remarks/>
        IL,

        /// <remarks/>
        IT,

        /// <remarks/>
        JM,

        /// <remarks/>
        JP,

        /// <remarks/>
        JE,

        /// <remarks/>
        JO,

        /// <remarks/>
        KZ,

        /// <remarks/>
        KE,

        /// <remarks/>
        KG,

        /// <remarks/>
        KI,

        /// <remarks/>
        KW,

        /// <remarks/>
        LA,

        /// <remarks/>
        LS,

        /// <remarks/>
        LV,

        /// <remarks/>
        LB,

        /// <remarks/>
        LR,

        /// <remarks/>
        LY,

        /// <remarks/>
        LI,

        /// <remarks/>
        LT,

        /// <remarks/>
        LU,

        /// <remarks/>
        MO,

        /// <remarks/>
        MK,

        /// <remarks/>
        MG,

        /// <remarks/>
        MY,

        /// <remarks/>
        MW,

        /// <remarks/>
        MV,

        /// <remarks/>
        ML,

        /// <remarks/>
        MT,

        /// <remarks/>
        MP,

        /// <remarks/>
        MA,

        /// <remarks/>
        MH,

        /// <remarks/>
        MQ,

        /// <remarks/>
        MU,

        /// <remarks/>
        MR,

        /// <remarks/>
        YT,

        /// <remarks/>
        MX,

        /// <remarks/>
        FM,

        /// <remarks/>
        MD,

        /// <remarks/>
        MC,

        /// <remarks/>
        MN,

        /// <remarks/>
        ME,

        /// <remarks/>
        MS,

        /// <remarks/>
        MZ,

        /// <remarks/>
        MM,

        /// <remarks/>
        NA,

        /// <remarks/>
        NR,

        /// <remarks/>
        NP,

        /// <remarks/>
        NI,

        /// <remarks/>
        NE,

        /// <remarks/>
        NG,

        /// <remarks/>
        NU,

        /// <remarks/>
        NF,

        /// <remarks/>
        NO,

        /// <remarks/>
        NC,

        /// <remarks/>
        NZ,

        /// <remarks/>
        IO,

        /// <remarks/>
        OM,

        /// <remarks/>
        UG,

        /// <remarks/>
        UZ,

        /// <remarks/>
        PK,

        /// <remarks/>
        PW,

        /// <remarks/>
        PS,

        /// <remarks/>
        PA,

        /// <remarks/>
        PG,

        /// <remarks/>
        PY,

        /// <remarks/>
        NL,

        /// <remarks/>
        PE,

        /// <remarks/>
        PH,

        /// <remarks/>
        PN,

        /// <remarks/>
        PL,

        /// <remarks/>
        PF,

        /// <remarks/>
        PR,

        /// <remarks/>
        PT,

        /// <remarks/>
        QA,

        /// <remarks/>
        RE,

        /// <remarks/>
        RO,

        /// <remarks/>
        GB,

        /// <remarks/>
        RU,

        /// <remarks/>
        RW,

        /// <remarks/>
        EH,

        /// <remarks/>
        BL,

        /// <remarks/>
        SH,

        /// <remarks/>
        LC,

        /// <remarks/>
        KN,

        /// <remarks/>
        SM,

        /// <remarks/>
        MF,

        /// <remarks/>
        PM,

        /// <remarks/>
        VA,

        /// <remarks/>
        VC,

        /// <remarks/>
        SB,

        /// <remarks/>
        WS,

        /// <remarks/>
        AS,

        /// <remarks/>
        ST,

        /// <remarks/>
        SN,

        /// <remarks/>
        RS,

        /// <remarks/>
        SC,

        /// <remarks/>
        SL,

        /// <remarks/>
        SG,

        /// <remarks/>
        SK,

        /// <remarks/>
        SI,

        /// <remarks/>
        SO,

        /// <remarks/>
        SD,

        /// <remarks/>
        LK,

        /// <remarks/>
        SE,

        /// <remarks/>
        CH,

        /// <remarks/>
        SR,

        /// <remarks/>
        SJ,

        /// <remarks/>
        SZ,

        /// <remarks/>
        SY,

        /// <remarks/>
        TJ,

        /// <remarks/>
        TW,

        /// <remarks/>
        TZ,

        /// <remarks/>
        TD,

        /// <remarks/>
        CZ,

        /// <remarks/>
        TF,

        /// <remarks/>
        TH,

        /// <remarks/>
        TL,

        /// <remarks/>
        TG,

        /// <remarks/>
        TK,

        /// <remarks/>
        TO,

        /// <remarks/>
        TT,

        /// <remarks/>
        TN,

        /// <remarks/>
        TM,

        /// <remarks/>
        TC,

        /// <remarks/>
        TR,

        /// <remarks/>
        TV,

        /// <remarks/>
        UA,

        /// <remarks/>
        UY,

        /// <remarks/>
        VU,

        /// <remarks/>
        VE,

        /// <remarks/>
        VN,

        /// <remarks/>
        WF,

        /// <remarks/>
        YE,

        /// <remarks/>
        ZM,

        /// <remarks/>
        ZW,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.datacontract.org/2004/07/Cdiscount.Framework.Core.Communication.Me" +
        "ssages")]
    public enum Currency
    {

        /// <remarks/>
        Aed,

        /// <remarks/>
        Afn,

        /// <remarks/>
        All,

        /// <remarks/>
        Amd,

        /// <remarks/>
        Ang,

        /// <remarks/>
        Aoa,

        /// <remarks/>
        Ars,

        /// <remarks/>
        Aud,

        /// <remarks/>
        Awg,

        /// <remarks/>
        Azn,

        /// <remarks/>
        Bam,

        /// <remarks/>
        Bbd,

        /// <remarks/>
        Bdt,

        /// <remarks/>
        Bgn,

        /// <remarks/>
        Bhd,

        /// <remarks/>
        Bif,

        /// <remarks/>
        Bmd,

        /// <remarks/>
        Bnd,

        /// <remarks/>
        Bob,

        /// <remarks/>
        Bov,

        /// <remarks/>
        Brl,

        /// <remarks/>
        Bsd,

        /// <remarks/>
        Btn,

        /// <remarks/>
        Bwp,

        /// <remarks/>
        Byr,

        /// <remarks/>
        Bzd,

        /// <remarks/>
        Cad,

        /// <remarks/>
        Cdf,

        /// <remarks/>
        Che,

        /// <remarks/>
        Chf,

        /// <remarks/>
        Chw,

        /// <remarks/>
        Clf,

        /// <remarks/>
        Clp,

        /// <remarks/>
        Cny,

        /// <remarks/>
        Cop,

        /// <remarks/>
        Cou,

        /// <remarks/>
        Crc,

        /// <remarks/>
        Cuc,

        /// <remarks/>
        Cup,

        /// <remarks/>
        Cve,

        /// <remarks/>
        Czk,

        /// <remarks/>
        Djf,

        /// <remarks/>
        Dkk,

        /// <remarks/>
        Dop,

        /// <remarks/>
        Dzd,

        /// <remarks/>
        Egp,

        /// <remarks/>
        Ern,

        /// <remarks/>
        Etb,

        /// <remarks/>
        Eur,

        /// <remarks/>
        Fjd,

        /// <remarks/>
        Fkp,

        /// <remarks/>
        Gbp,

        /// <remarks/>
        Gel,

        /// <remarks/>
        Ghs,

        /// <remarks/>
        Gip,

        /// <remarks/>
        Gmd,

        /// <remarks/>
        Gnf,

        /// <remarks/>
        Gtq,

        /// <remarks/>
        Gyd,

        /// <remarks/>
        Hkd,

        /// <remarks/>
        Hnl,

        /// <remarks/>
        Hrk,

        /// <remarks/>
        Htg,

        /// <remarks/>
        Huf,

        /// <remarks/>
        Idr,

        /// <remarks/>
        Ils,

        /// <remarks/>
        Inr,

        /// <remarks/>
        Iqd,

        /// <remarks/>
        Irr,

        /// <remarks/>
        Isk,

        /// <remarks/>
        Jmd,

        /// <remarks/>
        Jod,

        /// <remarks/>
        Jpy,

        /// <remarks/>
        Kes,

        /// <remarks/>
        Kgs,

        /// <remarks/>
        Khr,

        /// <remarks/>
        Kmf,

        /// <remarks/>
        Kpw,

        /// <remarks/>
        Krw,

        /// <remarks/>
        Kwd,

        /// <remarks/>
        Kyd,

        /// <remarks/>
        Kzt,

        /// <remarks/>
        Lak,

        /// <remarks/>
        Lbp,

        /// <remarks/>
        Lkr,

        /// <remarks/>
        Lrd,

        /// <remarks/>
        Lsl,

        /// <remarks/>
        Ltl,

        /// <remarks/>
        Lyd,

        /// <remarks/>
        Mad,

        /// <remarks/>
        Mdl,

        /// <remarks/>
        Mga,

        /// <remarks/>
        Mkd,

        /// <remarks/>
        Mmk,

        /// <remarks/>
        Mnt,

        /// <remarks/>
        Mop,

        /// <remarks/>
        Mro,

        /// <remarks/>
        Mur,

        /// <remarks/>
        Mvr,

        /// <remarks/>
        Mwk,

        /// <remarks/>
        Mxn,

        /// <remarks/>
        Mxv,

        /// <remarks/>
        Myr,

        /// <remarks/>
        Mzn,

        /// <remarks/>
        Nad,

        /// <remarks/>
        Ngn,

        /// <remarks/>
        Nio,

        /// <remarks/>
        Nok,

        /// <remarks/>
        Npr,

        /// <remarks/>
        Nzd,

        /// <remarks/>
        Omr,

        /// <remarks/>
        Pab,

        /// <remarks/>
        Pen,

        /// <remarks/>
        Pgk,

        /// <remarks/>
        Php,

        /// <remarks/>
        Pkr,

        /// <remarks/>
        Pln,

        /// <remarks/>
        Pyg,

        /// <remarks/>
        Qar,

        /// <remarks/>
        Ron,

        /// <remarks/>
        Rsd,

        /// <remarks/>
        Rub,

        /// <remarks/>
        Rwf,

        /// <remarks/>
        Sar,

        /// <remarks/>
        Sbd,

        /// <remarks/>
        Scr,

        /// <remarks/>
        Sdg,

        /// <remarks/>
        Sek,

        /// <remarks/>
        Sgd,

        /// <remarks/>
        Shp,

        /// <remarks/>
        Sll,

        /// <remarks/>
        Sos,

        /// <remarks/>
        Srd,

        /// <remarks/>
        Ssp,

        /// <remarks/>
        Std,

        /// <remarks/>
        Svc,

        /// <remarks/>
        Syp,

        /// <remarks/>
        Szl,

        /// <remarks/>
        Thb,

        /// <remarks/>
        Tjs,

        /// <remarks/>
        Tmt,

        /// <remarks/>
        Tnd,

        /// <remarks/>
        Top,

        /// <remarks/>
        Try,

        /// <remarks/>
        Ttd,

        /// <remarks/>
        Twd,

        /// <remarks/>
        Tzs,

        /// <remarks/>
        Uah,

        /// <remarks/>
        Ugx,

        /// <remarks/>
        Usd,

        /// <remarks/>
        Usn,

        /// <remarks/>
        Uyi,

        /// <remarks/>
        Uyu,

        /// <remarks/>
        Uzs,

        /// <remarks/>
        Vef,

        /// <remarks/>
        Vnd,

        /// <remarks/>
        Vuv,

        /// <remarks/>
        Wst,

        /// <remarks/>
        Xaf,

        /// <remarks/>
        Xag,

        /// <remarks/>
        Xau,

        /// <remarks/>
        Xba,

        /// <remarks/>
        Xbb,

        /// <remarks/>
        Xbc,

        /// <remarks/>
        Xbd,

        /// <remarks/>
        Xcd,

        /// <remarks/>
        Xdr,

        /// <remarks/>
        Xof,

        /// <remarks/>
        Xpd,

        /// <remarks/>
        Xpf,

        /// <remarks/>
        Xpt,

        /// <remarks/>
        Xsu,

        /// <remarks/>
        Xts,

        /// <remarks/>
        Xua,

        /// <remarks/>
        Xxx,

        /// <remarks/>
        Yer,

        /// <remarks/>
        Zar,

        /// <remarks/>
        Zmw,

        /// <remarks/>
        Zwl,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.datacontract.org/2004/07/Cdiscount.Framework.Core.Communication.Me" +
        "ssages")]
    public enum Language
    {

        /// <remarks/>
        Fr,

        /// <remarks/>
        En,

        /// <remarks/>
        De,

        /// <remarks/>
        Es,

        /// <remarks/>
        Th,

        /// <remarks/>
        Vi,

        /// <remarks/>
        NotDefined,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void GetProductListCompletedEventHandler(object sender, GetProductListCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetProductListCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GetProductListCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public ProductListMessage Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((ProductListMessage)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void SubmitProductPackageCompletedEventHandler(object sender, SubmitProductPackageCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SubmitProductPackageCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal SubmitProductPackageCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public ProductIntegrationReportMessage Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((ProductIntegrationReportMessage)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void GetProductPackageSubmissionResultCompletedEventHandler(object sender, GetProductPackageSubmissionResultCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetProductPackageSubmissionResultCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GetProductPackageSubmissionResultCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public ProductIntegrationReportMessage Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((ProductIntegrationReportMessage)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void GetProductPackageProductMatchingFileDataCompletedEventHandler(object sender, GetProductPackageProductMatchingFileDataCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetProductPackageProductMatchingFileDataCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GetProductPackageProductMatchingFileDataCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public ProductMatchingFileMessage Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((ProductMatchingFileMessage)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void GetAllowedCategoryTreeCompletedEventHandler(object sender, GetAllowedCategoryTreeCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetAllowedCategoryTreeCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GetAllowedCategoryTreeCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public CategoryTreeMessage Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((CategoryTreeMessage)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void GetAllAllowedCategoryTreeCompletedEventHandler(object sender, GetAllAllowedCategoryTreeCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetAllAllowedCategoryTreeCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GetAllAllowedCategoryTreeCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public CategoryTreeMessage Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((CategoryTreeMessage)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void GetModelListCompletedEventHandler(object sender, GetModelListCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetModelListCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GetModelListCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public ProductModelListMessage Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((ProductModelListMessage)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void GetAllModelListCompletedEventHandler(object sender, GetAllModelListCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetAllModelListCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GetAllModelListCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public ProductModelListMessage Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((ProductModelListMessage)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void GetBrandListCompletedEventHandler(object sender, GetBrandListCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetBrandListCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GetBrandListCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public BrandListMessage Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((BrandListMessage)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void GetProductListByIdentifierCompletedEventHandler(object sender, GetProductListByIdentifierCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetProductListByIdentifierCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GetProductListByIdentifierCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public ProductListByIdentifierMessage Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((ProductListByIdentifierMessage)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void SubmitOfferPackageCompletedEventHandler(object sender, SubmitOfferPackageCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SubmitOfferPackageCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal SubmitOfferPackageCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public OfferIntegrationReportMessage Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((OfferIntegrationReportMessage)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void GetOfferPackageSubmissionResultCompletedEventHandler(object sender, GetOfferPackageSubmissionResultCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetOfferPackageSubmissionResultCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GetOfferPackageSubmissionResultCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public OfferIntegrationReportMessage Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((OfferIntegrationReportMessage)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void GetOfferListCompletedEventHandler(object sender, GetOfferListCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetOfferListCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GetOfferListCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public OfferListMessage Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((OfferListMessage)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void GetOfferListPaginatedCompletedEventHandler(object sender, GetOfferListPaginatedCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetOfferListPaginatedCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GetOfferListPaginatedCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public OfferListPaginatedMessage Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((OfferListPaginatedMessage)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void GetSellerInformationCompletedEventHandler(object sender, GetSellerInformationCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetSellerInformationCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GetSellerInformationCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public SellerMessage Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((SellerMessage)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void GetSellerIndicatorsCompletedEventHandler(object sender, GetSellerIndicatorsCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetSellerIndicatorsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GetSellerIndicatorsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public SellerIndicatorsMessage Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((SellerIndicatorsMessage)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void GetOrderListCompletedEventHandler(object sender, GetOrderListCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetOrderListCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GetOrderListCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public OrderListMessage Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((OrderListMessage)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void GetServiceOrderListCompletedEventHandler(object sender, GetServiceOrderListCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetServiceOrderListCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GetServiceOrderListCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public ServiceOrderListMessage Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((ServiceOrderListMessage)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void ValidateOrderListCompletedEventHandler(object sender, ValidateOrderListCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ValidateOrderListCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal ValidateOrderListCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public ValidationResultMessage Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((ValidationResultMessage)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void ManageParcelCompletedEventHandler(object sender, ManageParcelCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ManageParcelCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal ManageParcelCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public ManageParcelResultMessage Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((ManageParcelResultMessage)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void CreateRefundVoucherAfterShipmentCompletedEventHandler(object sender, CreateRefundVoucherAfterShipmentCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CreateRefundVoucherAfterShipmentCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal CreateRefundVoucherAfterShipmentCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public SellerRefundResultMessage Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((SellerRefundResultMessage)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void CreateRefundVoucherCompletedEventHandler(object sender, CreateRefundVoucherCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CreateRefundVoucherCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal CreateRefundVoucherCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public CreateRefundVoucherMessage Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((CreateRefundVoucherMessage)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void GetGlobalConfigurationCompletedEventHandler(object sender, GetGlobalConfigurationCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetGlobalConfigurationCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GetGlobalConfigurationCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public GlobalConfigurationMessage Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((GlobalConfigurationMessage)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void GenerateDiscussionMailGuidCompletedEventHandler(object sender, GenerateDiscussionMailGuidCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GenerateDiscussionMailGuidCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GenerateDiscussionMailGuidCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public DiscussionMailGuidCreationResultMessage Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((DiscussionMailGuidCreationResultMessage)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void SubmitRelaysFileCompletedEventHandler(object sender, SubmitRelaysFileCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SubmitRelaysFileCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal SubmitRelaysFileCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public RelaysFileDepositMessage Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((RelaysFileDepositMessage)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void GetRelaysFileSubmissionResultCompletedEventHandler(object sender, GetRelaysFileSubmissionResultCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetRelaysFileSubmissionResultCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GetRelaysFileSubmissionResultCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public RelayIntegrationReportMessage Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((RelayIntegrationReportMessage)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void GetParcelShopListCompletedEventHandler(object sender, GetParcelShopListCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetParcelShopListCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GetParcelShopListCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public ParcelShopListMessage Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((ParcelShopListMessage)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void CloseDiscussionListCompletedEventHandler(object sender, CloseDiscussionListCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CloseDiscussionListCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal CloseDiscussionListCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public CloseDiscussionResultMessage Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((CloseDiscussionResultMessage)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void GetOrderClaimListCompletedEventHandler(object sender, GetOrderClaimListCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetOrderClaimListCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GetOrderClaimListCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public OrderClaimListMessage Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((OrderClaimListMessage)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void GetOrderQuestionListCompletedEventHandler(object sender, GetOrderQuestionListCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetOrderQuestionListCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GetOrderQuestionListCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public OrderQuestionListMessage Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((OrderQuestionListMessage)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void GetOfferQuestionListCompletedEventHandler(object sender, GetOfferQuestionListCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetOfferQuestionListCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GetOfferQuestionListCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public OfferQuestionListMessage Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((OfferQuestionListMessage)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void GetDiscussionMailListCompletedEventHandler(object sender, GetDiscussionMailListCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetDiscussionMailListCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GetDiscussionMailListCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public DiscussionMailListMessage Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((DiscussionMailListMessage)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void CreateExternalOrderCompletedEventHandler(object sender, CreateExternalOrderCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CreateExternalOrderCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal CreateExternalOrderCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public OrderIntegrationMessage Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((OrderIntegrationMessage)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void GetExternalOrderStatusCompletedEventHandler(object sender, GetExternalOrderStatusCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetExternalOrderStatusCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GetExternalOrderStatusCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public OrderStatusMessage Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((OrderStatusMessage)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void GetProductStockListCompletedEventHandler(object sender, GetProductStockListCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetProductStockListCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GetProductStockListCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public ProductStockListMessage Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((ProductStockListMessage)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void GetFulfilmentActivationReportListCompletedEventHandler(object sender, GetFulfilmentActivationReportListCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetFulfilmentActivationReportListCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GetFulfilmentActivationReportListCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public FulfilmentActivationReportMessage Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((FulfilmentActivationReportMessage)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void GetFulfilmentOrderListToSupplyCompletedEventHandler(object sender, GetFulfilmentOrderListToSupplyCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetFulfilmentOrderListToSupplyCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GetFulfilmentOrderListToSupplyCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public FulfilmentOrderLineListToSupplyMessage Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((FulfilmentOrderLineListToSupplyMessage)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void SubmitFulfilmentSupplyOrderCompletedEventHandler(object sender, SubmitFulfilmentSupplyOrderCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SubmitFulfilmentSupplyOrderCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal SubmitFulfilmentSupplyOrderCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public SupplyOrderReportMessage Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((SupplyOrderReportMessage)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void SubmitFulfilmentOnDemandSupplyOrderCompletedEventHandler(object sender, SubmitFulfilmentOnDemandSupplyOrderCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SubmitFulfilmentOnDemandSupplyOrderCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal SubmitFulfilmentOnDemandSupplyOrderCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public SupplyOrderReportMessage Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((SupplyOrderReportMessage)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void GetFulfilmentDeliveryDocumentCompletedEventHandler(object sender, GetFulfilmentDeliveryDocumentCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetFulfilmentDeliveryDocumentCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GetFulfilmentDeliveryDocumentCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public FulfilmentDeliveryDocumentMessage Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((FulfilmentDeliveryDocumentMessage)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void SubmitOfferStateActionCompletedEventHandler(object sender, SubmitOfferStateActionCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SubmitOfferStateActionCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal SubmitOfferStateActionCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public OfferStateReportMessage Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((OfferStateReportMessage)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void GetFulfilmentSupplyOrderCompletedEventHandler(object sender, GetFulfilmentSupplyOrderCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetFulfilmentSupplyOrderCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GetFulfilmentSupplyOrderCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public SupplyOrderMessage Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((SupplyOrderMessage)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void SubmitFulfilmentActivationCompletedEventHandler(object sender, SubmitFulfilmentActivationCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SubmitFulfilmentActivationCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal SubmitFulfilmentActivationCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public FulfilmentActivationMessage Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((FulfilmentActivationMessage)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void GetFulfilmentSupplyOrderReportListCompletedEventHandler(object sender, GetFulfilmentSupplyOrderReportListCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetFulfilmentSupplyOrderReportListCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GetFulfilmentSupplyOrderReportListCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public SupplyOrderReportListMessage Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((SupplyOrderReportListMessage)(this.results[0]));
            }
        }
    }
}