namespace ClassModels
{

    /// <summary>
    /// model class for representing the top product result with product ID, name, and total quantity sold.
    /// </summary>
    public class TopProductResult
    {

        /// <summary>
        /// Gets or sets the product identifier.
        /// </summary>
        /// <value>
        /// The product identifier.
        /// </value>
        public int ProductId { get; set; }

        /// <summary>
        /// Gets or sets the name of the product.
        /// </summary>
        /// <value>
        /// The name of the product.
        /// </value>
        public string ProductName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the total quantity.
        /// </summary>
        /// <value>
        /// The total quantity.
        /// </value>
        public decimal TotalQuantity { get; set; }
    }
}

