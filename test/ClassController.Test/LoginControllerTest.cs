using ClassController.Abstractions;
using ClassModels;

namespace ClassController.Test
{
    /// <summary>
    /// test class for LoginController
    /// </summary>
    [TestClass]
    public class LoginControllerTest
    {
        /// <summary>
        /// Logins the should return false when credentials are incorrect.
        /// </summary>
        [TestMethod]
        public void Login_ShouldReturnFalse_WhenCredentialsAreIncorrect()
        {
            // Arrange
            var userHandler = new UserHandler();
            userHandler.Custumers.Add(new Customer { Username = "user1", Password = "pass1" });
            var loginController = new LoginController(userHandler);
            // Act
            var result = loginController.Login("user1", "wrongpass");
            // Assert
            Assert.IsFalse(result);
        }

    }
}
