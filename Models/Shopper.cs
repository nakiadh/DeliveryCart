using System.ComponentModel.DataAnnotations;

namespace DeliveryCart.Models
{
    public class Shopper
    {
        public int ShopperID { get; set; }
        public string ShopperName { get; set; } = string.Empty;
        public string ShopperEmail { get; set; } = string.Empty;
        public string ShopperPhone { get; set; } = string.Empty;
    }
}