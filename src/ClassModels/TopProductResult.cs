namespace ClassModels
{
    public class TopProductResult
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public decimal TotalQuantity { get; set; }
    }
}

