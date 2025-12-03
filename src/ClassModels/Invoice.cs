namespace ClassModels
{
    /// <summary>
    /// implements the Invoice class.
    /// </summary>
    public class Invoice
    {
        /// <summary>
        /// Gets or sets the fair.
        /// </summary>
        /// <value>
        /// The fair.
        /// </value>
        public string Fair { get; set; }
        /// <summary>
        /// Gets or sets the subtotal.
        /// </summary>
        /// <value>
        /// The subtotal.
        /// </value>
        public decimal Subtotal { get; set; }
        /// <summary>
        /// Gets or sets the tax.
        /// </summary>
        /// <value>
        /// The tax.
        /// </value>
        public decimal Tax { get; set; }
        /// <summary>
        /// Gets or sets the total.
        /// </summary>
        /// <value>
        /// The total.
        /// </value>
        public decimal Total { get; set; }
        /// <summary>
        /// Gets or sets the date.
        /// </summary>
        /// <value>
        /// The date.
        /// </value>
        public DateTime Date { get; set; }

        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return $"Fair: {Fair}\n" +
                   $"Date: {Date}\n" +
                   $"Subtotal: {Subtotal:C}\n" +
                   $"Tax: {Tax:C}\n" +
                   $"Total: {Total:C}\n";
        }
    }
}

