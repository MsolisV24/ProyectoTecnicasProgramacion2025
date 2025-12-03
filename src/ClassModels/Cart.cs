namespace ClassModels
{

    /// <summary>
    /// implements a shopping cart for an e-commerce application
    /// </summary>
    public class Cart
    {

        /// <summary>
        /// Gets or sets the username.
        /// </summary>
        /// <value>
        /// The username.
        /// </value>
        public string Username { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the fair identifier.
        /// </summary>
        /// <value>
        /// The fair identifier.
        /// </value>
        public int FairId { get; set; }

        /// <summary>
        /// Gets or sets the delivery address identifier.
        /// </summary>
        /// <value>
        /// The delivery address identifier.
        /// </value>
        public int? DeliveryAddressId { get; set; }

        /// <summary>
        /// Gets the items.
        /// </summary>
        /// <value>
        /// The items.
        /// </value>
        public List<CartItem> Items { get; } = new List<CartItem>();


        /// <summary>
        /// Gets the total.
        /// </summary>
        /// <value>
        /// The total.
        /// </value>
        public decimal Total => Items.Sum(x => x.SubTotal);
    }
}



