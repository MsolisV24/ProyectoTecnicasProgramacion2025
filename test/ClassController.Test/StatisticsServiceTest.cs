using ClassModels;

namespace ClassController.Test
{
    /// <summary>
    /// test class for statistics service
    /// </summary>
    [TestClass]
    public class StatisticsServiceTest
    {
        /// <summary>
        /// Gets the top producers should return correct results.
        /// </summary>
        [TestMethod]
        public void GetTopProducers_ShouldReturnCorrectResults()
        {
            // Arrange
            var history = new List<ExpenseRecord>
            {
                new ExpenseRecord { ProducerId = 1, Quantity = 1, UnitPrice = 100, Date = new DateTime(2023, 1, 1) },
                new ExpenseRecord { ProducerId = 1, Quantity = 2, UnitPrice = 100, Date = new DateTime(2023, 1, 2) },
                new ExpenseRecord { ProducerId = 2, Quantity = 1, UnitPrice = 150, Date = new DateTime(2023, 1, 1) },
            };
            var producers = new List<Producer>
            {
                new Producer { Id = 1, Name = "Producer A" },
                new Producer { Id = 2, Name = "Producer B" },
            };
            var products = new List<Product>();
            var service = new StatisticsService(history, producers, products);
            // Act
            var results = service.GetTopProducers(null, null);
            // Assert
            Assert.AreEqual(2, results.Count);
            Assert.AreEqual(1, results[0].ProducerId);
            Assert.AreEqual("Producer A", results[0].ProducerName);
            Assert.AreEqual(300, results[0].TotalAmount);
            Assert.AreEqual(2, results[1].ProducerId);
            Assert.AreEqual("Producer B", results[1].ProducerName);
            Assert.AreEqual(150, results[1].TotalAmount);
        }
        /// <summary>
        /// Gets the top producers no data should return empty list.
        /// </summary>
        [TestMethod]
        public void GetTopProducers_NoData_ShouldReturnEmptyList()
        {
            // Arrange
            var history = new List<ExpenseRecord>();
            var producers = new List<Producer>();
            var products = new List<Product>();
            var service = new StatisticsService(history, producers, products);
            // Act
            var results = service.GetTopProducers(null, null);
            // Assert
            Assert.AreEqual(0, results.Count);
        }
    }
}
