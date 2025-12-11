namespace ClassController.Test
{
    /// <summary>
    /// tests for InvoiceDirector class.
    /// </summary>
    [TestClass]
    public class InvoiceDirectorTest
    {
        /// <summary>
        /// Tests the create invoice.
        /// </summary>
        [TestMethod]
        public void TestCreateInvoice()
        {
            // Arrange
            var director = new ClassController.InvoiceDirector();
            var builder = new ClassController.InvoiceBuilder();
            string fair = "Test Fair";
            decimal subtotal = 100.00m;
            // Act
            var invoice = director.CreateInvoice(builder, fair, subtotal);
            // Assert
            Assert.AreEqual(fair, invoice.Fair);
            Assert.AreEqual(subtotal, invoice.Subtotal);
            Assert.AreEqual(13.00m, invoice.Tax);
            Assert.AreEqual(113.00m, invoice.Total);
            Assert.IsTrue((DateTime.Now - invoice.Date).TotalSeconds < 5); // Date is recent
        }
    }
}
