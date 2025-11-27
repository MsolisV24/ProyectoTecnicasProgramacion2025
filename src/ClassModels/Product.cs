namespace ClassModels
{
    public class Product
    {
        public int Id { get; set; }
        public int ProducerId { get; set; }
        public int FairId { get; set; }
        public string Name { get; set; } = "";
        public string Unit { get; set; } = "";
        public decimal UnitPrice { get; set; }
    }
}

