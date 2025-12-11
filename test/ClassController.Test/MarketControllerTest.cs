namespace ClassController.Test
{
    /// <summary>
    /// test for market controller
    /// </summary>
    [TestClass]
    public class MarketControllerTest
    {
        /// <summary>
        /// Loads the CSV files test.
        /// </summary>
        [TestMethod]
        public void LoadCsvFiles_Test()
        {
            // Arrange
            var marketController = new MarketController();
            string usersCsv = "path/to/users.csv";
            string producersCsv = "path/to/producers.csv";
            string fairsCsv = "path/to/fairs.csv";
            string productsCsv = "path/to/products.csv";
            string inventoryCsv = "path/to/inventory.csv";
            string expensesCsv = "path/to/expenses.csv";
            // Act
            marketController.LoadCsvFiles(usersCsv, producersCsv, fairsCsv, productsCsv, inventoryCsv, expensesCsv);
            // Assert
            Assert.IsNotNull(marketController.Fairs);
            Assert.IsNotNull(marketController.Products);
            Assert.IsNotNull(marketController.Inventory);
            Assert.IsNotNull(marketController.ExpenseHistory);
        }
        /// <summary>
        /// Markets the controller constructor test.
        /// </summary>
        [TestMethod]
        public void MarketController_Constructor_Test()
        {
            // Arrange & Act
            var marketController = new MarketController();
            // Assert
            Assert.IsNotNull(marketController);
        }
        /// <summary>
        /// Markets the controller properties initialization test.
        /// </summary>
        [TestMethod]
        public void MarketController_Properties_Initialization_Test()
        {
            // Arrange & Act
            var marketController = new MarketController();
            // Assert
            Assert.IsNotNull(marketController.Fairs);
            Assert.IsNotNull(marketController.Products);
            Assert.IsNotNull(marketController.Inventory);
            Assert.IsNotNull(marketController.ExpenseHistory);
        }
    }
}
