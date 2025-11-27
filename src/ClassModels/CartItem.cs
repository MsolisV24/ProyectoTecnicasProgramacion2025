namespace ClassModels
{
    public class CartItem
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = "";
        public decimal UnitPrice { get; set; }
        public decimal Quantity { get; set; }

        public decimal SubTotal => UnitPrice * Quantity;
    }
}

