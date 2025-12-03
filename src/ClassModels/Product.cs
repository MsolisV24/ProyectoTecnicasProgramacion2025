namespace ClassModels
{

    /// <summary>
    /// model for Product
    /// </summary>
    public class Product
    {

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the producer identifier.
        /// </summary>
        /// <value>
        /// The producer identifier.
        /// </value>
        public int ProducerId { get; set; }

        /// <summary>
        /// Gets or sets the fair identifier.
        /// </summary>
        /// <value>
        /// The fair identifier.
        /// </value>
        public int FairId { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the unit.
        /// </summary>
        /// <value>
        /// The unit.
        /// </value>
        public string Unit { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the unit price.
        /// </summary>
        /// <value>
        /// The unit price.
        /// </value>
        public decimal UnitPrice { get; set; }
    }
}

