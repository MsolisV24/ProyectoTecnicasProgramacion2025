using System.Collections.Generic;
using System.Linq;
using System.Collections.Generic;
using System.Linq;

namespace ClassModels
{
    public class Cart
    {
        public string Username { get; set; } = "";  
        public int FairId { get; set; }
        public int? DeliveryAddressId { get; set; }
        public List<CartItem> Items { get; } = new List<CartItem>();

        public decimal Total => Items.Sum(x => x.SubTotal);
    }
}



