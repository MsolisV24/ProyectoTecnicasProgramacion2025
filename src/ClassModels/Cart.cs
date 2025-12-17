namespace ClassModels
{
    public class Cart
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public int FairId { get; set; }
        public int? DeliveryAddressId { get; set; }
        public List<CartItem> Items { get; } = new List<CartItem>();
        public decimal Total => Items.Sum(x => x.SubTotal);
    }
}



