using System.Web.Mvc;
using System.Web.Routing;
using Nop.Web.Framework.Mvc.Routes;

namespace Nop.Plugin.Payments.ePay
{
    public partial class RouteProvider : IRouteProvider
    {
        public void RegisterRoutes(RouteCollection routes)
        {
            //PDT
            routes.MapRoute("Plugin.Payments.ePay.PDTHandler",
                 "Plugins/PaymentEpay/PDTHandler",
                 new { controller = "PaymentEpay", action = "PDTHandler" },
                 new[] { "Nop.Plugin.Payments.ePay.Controllers" }
            );

            routes.MapRoute("Plugin.Payments.ePay.CancelOrder",
                "Plugins/PaymentEpay/CancelOrder",
                new { controller = "PaymentEpay", action = "CancelOrder" },
                new[] { "Nop.Plugin.Payments.ePay.Controllers" }
                );

            routes.MapRoute("Plugin.Payments.ePay.PaymentDone",
               "Plugins/PaymentEpay/PaymentDone",
               new { controller = "PaymentEpay", action = "PaymentDone" },
               new[] { "Nop.Plugin.Payments.ePay.Controllers" }
               );

            routes.MapRoute("Plugin.Payments.ePay.EasyPayInfo",
              "Plugins/PaymentEpay/EasyPayInfo",
              new { controller = "PaymentEpay", action = "EasyPayInfo" },
              new[] { "Nop.Plugin.Payments.ePay.Controllers" }
              );

            routes.MapRoute("Plugin.Payments.ePay.EasyPayError",
             "Plugins/PaymentEpay/EasyPayError",
             new { controller = "PaymentEpay", action = "EasyPayError" },
             new[] { "Nop.Plugin.Payments.ePay.Controllers" }
             );
        }
        public int Priority
        {
            get
            {
                return 0;
            }
        }
    }
}
