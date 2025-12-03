namespace ClassModels
{

    /// <summary>
    /// implements a shopping cart item
    /// </summary>
    public class CartItem
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
        /// Gets or sets the unit price.
        /// </summary>
        /// <value>
        /// The unit price.
        /// </value>
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// Gets or sets the quantity.
        /// </summary>
        /// <value>
        /// The quantity.
        /// </value>
        public decimal Quantity { get; set; }

        /// <summary>
        /// Gets the sub total.
        /// </summary>
        /// <value>
        /// The sub total.
        /// </value>
        public decimal SubTotal => UnitPrice * Quantity;
    }
}

