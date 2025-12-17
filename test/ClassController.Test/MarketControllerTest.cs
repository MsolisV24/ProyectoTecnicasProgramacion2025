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
        
        /// <summary>
        /// Markets the controller constructor test.
        /// </summary>
        
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
