namespace ClassModels
{
    public class ExpenseRecord
    {
        public int Id { get; set; }
        public int Username { get; set; }
        public int ProducerId { get; set; }
        public int ProductId { get; set; }
        public int FairId { get; set; }
        public DateTime Date { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalAmount => Quantity * UnitPrice;
    }
}

