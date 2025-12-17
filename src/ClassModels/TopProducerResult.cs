namespace ClassModels
{
    public class TopProducerResult
    {
        public int Id { get; set; }
        public int ProducerId { get; set; }
        public string ProducerName { get; set; } = string.Empty;
        public decimal TotalAmount { get; set; }
    }
}

