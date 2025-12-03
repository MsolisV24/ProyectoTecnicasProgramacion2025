namespace ClassModels
{

    /// <summary>
    /// model for top producer result
    /// </summary>
    public class TopProducerResult
    {

        /// <summary>
        /// Gets or sets the producer identifier.
        /// </summary>
        /// <value>
        /// The producer identifier.
        /// </value>
        public int ProducerId { get; set; }

        /// <summary>
        /// Gets or sets the name of the producer.
        /// </summary>
        /// <value>
        /// The name of the producer.
        /// </value>
        public string ProducerName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the total amount.
        /// </summary>
        /// <value>
        /// The total amount.
        /// </value>
        public decimal TotalAmount { get; set; }
    }
}

