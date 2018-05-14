using CDiscountApiLib;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDiscountTest
{
    class Program
    {

        static void Main(string[] args)
        {
            MarketplaceAPIService serviceClient = new MarketplaceAPIService();
            //Step 1 Get Token
            string username = ConfigurationManager.AppSettings["username"];
            string password = ConfigurationManager.AppSettings["password"];
            var tokenResponse = serviceClient.GetToken(username,password);
            Console.WriteLine(tokenResponse);

            HeaderMessage headerMessage = CreateHeaderRequest(tokenResponse);

            GetProductListTest(serviceClient, headerMessage);

            GetOrderListTest(serviceClient, headerMessage);

            GetOrderClaimListTest(serviceClient, headerMessage);

            GetOfferQuestionListTest(serviceClient, headerMessage);

            GetOrderQuestionListTest(serviceClient, headerMessage);

            GetDiscussionMailListTest(serviceClient, headerMessage);

            CloseDiscussionListTest(serviceClient, headerMessage);

            SubmitOfferPackageTest(serviceClient, headerMessage);

            SubmitProductPackageTest(serviceClient, headerMessage);

            CreateRefundVoucherTest(serviceClient, headerMessage);

            ValidateOrderListTest(serviceClient, headerMessage);

            ManageParcelTest(serviceClient, headerMessage);

            Console.ReadLine();
        }

        private static void ManageParcelTest(MarketplaceAPIService serviceClient, HeaderMessage headerMessage)
        {
            ManageParcelRequest manageParcelRequest = new ManageParcelRequest();
            manageParcelRequest.ParcelActionsList = new ParcelInfos[]
            {
                new ParcelInfos()
                {
                    ManageParcel = ParcelActionTypes.AskingForDeliveryCertification,
                    ParcelNumber = "9V18111607551",
                    Sku ="MEL0000772133340"
                }
            };
            manageParcelRequest.ScopusId = "1606292151DEE0K";
            var manageParcelResultMessage = serviceClient.ManageParcel(headerMessage, manageParcelRequest);
        }

        private static void ValidateOrderListTest(MarketplaceAPIService serviceClient, HeaderMessage headerMessage)
        {
            ValidateOrderListMessage validateOrderListMessage = new ValidateOrderListMessage();
            validateOrderListMessage.OrderList = new ValidateOrder[]{new ValidateOrder()
            {
                CarrierName = "CarrierName",
                OrderLineList = new ValidateOrderLine[]
                {
                    new ValidateOrderLine(){ AcceptationState = AcceptationStateEnum.AcceptedBySeller , ProductCondition = ProductConditionEnum.New, SellerProductId = "CHI8003970895435" },
                    new ValidateOrderLine(){ AcceptationState = AcceptationStateEnum.AcceptedBySeller , ProductCondition = ProductConditionEnum.New, SellerProductId = "DOD3592668078117" },
                },
                OrderNumber ="1109029051W54OU",
                OrderState = OrderStateEnum.AcceptedBySeller,
                TrackingNumber = "TrackingNumber",
                TrackingUrl ="TrackingNumber"

            } };

            var validationResultMessage = serviceClient.ValidateOrderList(headerMessage, validateOrderListMessage);
        }

        private static void CreateRefundVoucherTest(MarketplaceAPIService serviceClient, HeaderMessage headerMessage)
        {
            CreateRefundVoucherRequest createRefundVoucherRequest = new CreateRefundVoucherRequest();
            createRefundVoucherRequest.CommercialGestureList = new RefundInformation[] { new RefundInformation() { Amount = 10, MotiveId = 132 } };
            createRefundVoucherRequest.OrderNumber = "1510211035PIKEI";
            createRefundVoucherRequest.SellerRefundList = new SellerRefundRequest[]{ new SellerRefundRequest {
                Mode = SellerRefundRequestMode.Claim,
                Motive = RefundMotive.VendorRejection,
            RefundOrderLine = new SellerRefundOrderLine() {
                Ean = "4005274238223" ,
                RefundShippingCharges = true,
                SellerProductId = "42382235"
            }
            }
            };

            var createRefundVoucherMessage = serviceClient.CreateRefundVoucher(headerMessage, createRefundVoucherRequest);
        }

        private static void SubmitProductPackageTest(MarketplaceAPIService serviceClient, HeaderMessage headerMessage)
        {
            ProductPackageRequest productPackageRequest = new ProductPackageRequest() { ZipFileFullPath = "http://www.unsite.fr/product.zip" };
            var submitProductPackageResponse = serviceClient.SubmitProductPackage(headerMessage, productPackageRequest);
        }

        private static void SubmitOfferPackageTest(MarketplaceAPIService serviceClient, HeaderMessage headerMessage)
        {
            OfferPackageRequest offerPackageRequest = new OfferPackageRequest() { ZipFileFullPath = "http://www.unsite.fr/offre.zip" };
            var submitOfferPackageResponse = serviceClient.SubmitOfferPackage(headerMessage, offerPackageRequest);

        }

        private static void CloseDiscussionListTest(MarketplaceAPIService serviceClient, HeaderMessage headerMessage)
        {
            CloseDiscussionRequest closeDiscussionRequest = new CloseDiscussionRequest() { DiscussionIds = new long[] { 866052, 162, 123456 } };

            var closeDiscussionResultMessage = serviceClient.CloseDiscussionList(headerMessage, closeDiscussionRequest);
        }

        private static void GetDiscussionMailListTest(MarketplaceAPIService serviceClient, HeaderMessage headerMessage)
        {

            GetDiscussionMailListRequest getDiscussionMailListRequest = new GetDiscussionMailListRequest();
            getDiscussionMailListRequest.DiscussionIds = new long[] { 375046, 2469, 3405, 4809, 12075, 375645 };
            var discussionMailListMessage = serviceClient.GetDiscussionMailList(headerMessage, getDiscussionMailListRequest);


        }

        private static void GetOrderQuestionListTest(MarketplaceAPIService serviceClient, HeaderMessage headerMessage)
        {
            OrderQuestionFilter orderQuestionFilter = new OrderQuestionFilter();
            orderQuestionFilter.StatusList = new DiscussionStateFilter[] { DiscussionStateFilter.Closed };
            var getOrderQuestionListResponse = serviceClient.GetOrderQuestionList(headerMessage, orderQuestionFilter);
        }

        private static void GetOfferQuestionListTest(MarketplaceAPIService serviceClient, HeaderMessage headerMessage)
        {
            OfferQuestionFilter offerQuestionFilter = new OfferQuestionFilter();
            offerQuestionFilter.StatusList = new DiscussionStateFilter[] { DiscussionStateFilter.Closed };
            var getOfferQuestionListResponse = serviceClient.GetOfferQuestionList(headerMessage, offerQuestionFilter);
        }

        private static void GetOrderClaimListTest(MarketplaceAPIService serviceClient, HeaderMessage headerMessage)
        {
            OrderClaimFilter orderClaimFilter = new OrderClaimFilter();
            orderClaimFilter.StatusList = new DiscussionStateFilter[] { DiscussionStateFilter.Open };
            var getOrderClaimListResponse = serviceClient.GetOrderClaimList(headerMessage, orderClaimFilter);
        }

        private static void GetOrderListTest(MarketplaceAPIService serviceClient, HeaderMessage headerMessage)
        {
            OrderFilter orderFilter = new OrderFilter();
            orderFilter.BeginCreationDate = DateTime.Parse("2011-12-01T00:00:00.00");
            orderFilter.BeginModificationDate = DateTime.Parse("2012-01-02T01:00:00.00");
            orderFilter.EndCreationDate = DateTime.Parse("2012-12-01T23:59:59.99");
            orderFilter.EndModificationDate = DateTime.Parse("2012-01-02T02:00:00.00");
            orderFilter.FetchOrderLines = true;
            orderFilter.States = new OrderStateEnum[]
            {
                OrderStateEnum.CancelledByCustomer,
                OrderStateEnum.WaitingForSellerAcceptation,
                OrderStateEnum.AcceptedBySeller,
                OrderStateEnum.PaymentInProgress,
                OrderStateEnum.WaitingForShipmentAcceptation,
                OrderStateEnum.Shipped,
                OrderStateEnum.RefusedBySeller,
                OrderStateEnum.AutomaticCancellation,
                OrderStateEnum.PaymentRefused,
                OrderStateEnum.ShipmentRefusedBySeller,
                OrderStateEnum.RefusedNoShipment
            };
            var getOrderListResponse = serviceClient.GetOrderList(headerMessage, orderFilter);
        }

        private static void GetProductListTest(MarketplaceAPIService serviceClient, HeaderMessage headerMessage)
        {
            ProductFilter productFilter = new ProductFilter();
            productFilter.CategoryCode = "06010201";

            var productListResponse = serviceClient.GetProductList(headerMessage, productFilter);
        }

        private static HeaderMessage CreateHeaderRequest(string tokenResponse)
        {
            HeaderMessage headerMessage = new HeaderMessage();
            headerMessage.Context = new ContextMessage();
            headerMessage.Context.CatalogID = 1;
            headerMessage.Context.CustomerPoolID = 1;
            headerMessage.Context.SiteID = 100;
            headerMessage.Localization = new LocalizationMessage();
            headerMessage.Localization.Country = Country.Fr;
            headerMessage.Localization.Currency = Currency.Eur;
            headerMessage.Localization.DecimalPosition = 2;
            headerMessage.Localization.Language = Language.Fr;
            headerMessage.Security = new SecurityContext();
            headerMessage.Security.TokenId = tokenResponse;
            headerMessage.Version = "1.0";
            return headerMessage;
        }
    }
}
