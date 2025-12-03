using ClassModels;

namespace ClassController
{
    /// <summary>
    /// implements the Director pattern for constructing Invoice objects.
    /// </summary>
    public class InvoiceDirector
    {
        /// <summary>
        /// Creates the invoice.
        /// </summary>
        /// <param name="builder">The builder.</param>
        /// <param name="fair">The fair.</param>
        /// <param name="subtotal">The subtotal.</param>
        /// <returns></returns>
        public Invoice CreateInvoice(InvoiceBuilder builder,
                                     string fair,
                                     decimal subtotal)
        {
            decimal tax = subtotal * 0.13m;

            return builder
                .SetFair(fair)
                .SetSubtotal(subtotal)
                .SetTax(tax)
                .SetTotal()
                .SetDate(DateTime.Now)
                .Build();
        }
    }
}

