using ClassModels;

namespace ClassController
{
    /// <summary>
    /// implements the Builder pattern for constructing Invoice objects.
    /// </summary>
    public class InvoiceBuilder
    {
        protected Invoice invoice = new();

        /// <summary>
        /// Sets the fair.
        /// </summary>
        /// <param name="fair">The fair.</param>
        /// <returns></returns>
        public InvoiceBuilder SetFair(string fair)
        {
            invoice.Fair = fair;
            return this;
        }

        /// <summary>
        /// Sets the subtotal.
        /// </summary>
        /// <param name="subtotal">The subtotal.</param>
        /// <returns></returns>
        public InvoiceBuilder SetSubtotal(decimal subtotal)
        {
            invoice.Subtotal = subtotal;
            return this;
        }

        /// <summary>
        /// Sets the tax.
        /// </summary>
        /// <param name="tax">The tax.</param>
        /// <returns></returns>
        public InvoiceBuilder SetTax(decimal tax)
        {
            invoice.Tax = tax;
            return this;
        }

        /// <summary>
        /// Sets the total.
        /// </summary>
        /// <returns></returns>
        public InvoiceBuilder SetTotal()
        {
            invoice.Total = invoice.Subtotal + invoice.Tax;
            return this;
        }

        /// <summary>
        /// Sets the date.
        /// </summary>
        /// <param name="date">The date.</param>
        /// <returns></returns>
        public InvoiceBuilder SetDate(DateTime date)
        {
            invoice.Date = date;
            return this;
        }

        /// <summary>
        /// Builds this instance.
        /// </summary>
        /// <returns></returns>
        public Invoice Build()
        {
            return invoice;
        }
    }
}

