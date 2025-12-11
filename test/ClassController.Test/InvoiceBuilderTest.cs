namespace ClassController.Test
{
    /// <summary>
    /// tests the invoice builder.
    /// </summary>
    [TestClass]
    public class InvoiceBuilderTest
    {
        /// <summary>
        /// Tests the invoice builder.
        /// </summary>
        [TestMethod]
        public void TestInvoiceBuilder()
        {
            var builder = new ClassController.InvoiceBuilder();
            var invoice = builder
                .SetFair("Spring Fair")
                .SetSubtotal(100.00m)
                .SetTax(10.00m)
                .SetTotal()
                .SetDate(new DateTime(2024, 5, 1))
                .Build();
            Assert.AreEqual("Spring Fair", invoice.Fair);
            Assert.AreEqual(100.00m, invoice.Subtotal);
            Assert.AreEqual(10.00m, invoice.Tax);
            Assert.AreEqual(110.00m, invoice.Total);
            Assert.AreEqual(new DateTime(2024, 5, 1), invoice.Date);
        }
    }
}
