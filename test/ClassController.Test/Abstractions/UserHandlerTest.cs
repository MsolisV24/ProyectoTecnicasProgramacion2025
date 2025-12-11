using ClassController.Abstractions;
using ClassModels;
using Moq;

namespace ClassExampleController.Test.Abstractions
{
    /// <summary>
    /// Test for <see cref="UserHandler"/>.
    /// </summary>
    [TestClass]
    public class UserHandlerTest
    {
        /// <summary>
        /// Saves the users should return true.
        /// </summary>
        [TestMethod]
        public void SaveUsersShouldReturnTrue()
        {
            // Arrange
            var dataHandlerMock = new Mock<IDataHandler<Customer>>();
            var filename = "testfile.txt";
            var userHandler = new UserHandler(dataHandlerMock.Object);

            dataHandlerMock.Setup(x => x.SaveData(new List<Customer>(), filename)).Returns(true);

            // Act
            var result = userHandler.SaveUsers(filename);

            // Assert
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Saves the users should return false.
        /// </summary>
        [TestMethod]
        public void SaveUsersShouldReturnFalse()
        {
            // Arrange
            var dataHandlerMock = new Mock<IDataHandler<Customer>>();
            var filename = "testfile.txt";
            var userHandler = new UserHandler(dataHandlerMock.Object);

            dataHandlerMock.Setup(x => x.SaveData(It.IsAny<List<Customer>>(), filename)).Returns(false);

            // Act
            var result = userHandler.SaveUsers(filename);
            //Assert.ThrowsException<ArgumentNullException>(() => userHandler.SaveUsers(filename));

            // Assert
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Loads the users should fill elements.
        /// </summary>
        [TestMethod]
        public void LoadUsersShouldFillElements()
        {
            // Arrange
            var dataHandlerMock = new Mock<IDataHandler<Customer>>();
            var filename = "testfile.txt";
            var userHandler = new UserHandler(dataHandlerMock.Object);
            var users = new List<Customer>()
            {
                new("Joaquin", "Vargas", "jvargas", "123", string.Empty)
            };

            dataHandlerMock.Setup(x => x.LoadData(filename)).Returns(users);

            // Act
            var result = userHandler.LoadUsers(filename);

            // Assert
            Assert.IsTrue(result);
            Assert.IsNotNull(userHandler.Custumers);
            Assert.IsTrue(userHandler.Custumers.Count > 0);
            Assert.AreEqual("Joaquin", userHandler.Custumers[0].Name);
        }

        /// <summary>
        /// Loads the users should fill elements with any filename.
        /// </summary>
        [TestMethod]
        public void LoadUsersShouldFillElementsWithAnyFilename()
        {
            // Arrange
            var dataHandlerMock = new Mock<IDataHandler<Customer>>();
            var filename = "testfile.txt";
            var userHandler = new UserHandler(dataHandlerMock.Object);
            var users = new List<Customer>()
            {
                new("Joaquin", "Vargas", "jvargas", "123", string.Empty)
            };

            dataHandlerMock.Setup(x => x.LoadData(It.IsAny<string>())).Returns(users);

            // Act
            var result = userHandler.LoadUsers(filename);

            // Assert
            Assert.IsTrue(result);
            Assert.IsNotNull(userHandler.Custumers);
            Assert.IsTrue(userHandler.Custumers.Count > 0);
            Assert.AreEqual("Joaquin", userHandler.Custumers[0].Name);
        }
    }
}
