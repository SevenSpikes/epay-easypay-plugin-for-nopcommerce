using Nop.Web.Framework.Mvc.Models;

namespace Nop.Plugin.Payments.ePay.Models
{
    public class EasyPayErrorModel : BaseNopModel
    {
        public int OrderId { get; set; }
    }
}