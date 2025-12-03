namespace ClassModels
{

    /// <summary>
    /// inventory item model
    /// </summary>
    public class InventoryItem
    {

        /// <summary>
        /// Gets or sets the product identifier.
        /// </summary>
        /// <value>
        /// The product identifier.
        /// </value>
        public int ProductId { get; set; }

        /// <summary>
        /// Gets or sets the quantity available.
        /// </summary>
        /// <value>
        /// The quantity available.
        /// </value>
        public decimal QuantityAvailable { get; set; }
    }
}

