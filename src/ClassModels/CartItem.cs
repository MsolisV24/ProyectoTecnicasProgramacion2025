namespace ClassModels
{
    public class CartItem
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public decimal UnitPrice { get; set; }
        public decimal Quantity { get; set; }
        public decimal SubTotal => UnitPrice * Quantity;
    }
}

