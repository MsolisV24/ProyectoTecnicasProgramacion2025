using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassController;
using ClassController.Abstractions;
using ClassModels;
using System.Collections.Generic;

namespace ClassController.Test
{
    /// <summary>
    ///tests for LoginController class.
    /// </summary>
    [TestClass]
    public class LoginControllerTests
    {
        /// <summary>
        /// Logins the datos correctos retorna true.
        /// </summary>
        [TestMethod]
        public void Login_DatosCorrectos_RetornaTrue()
        {
            var clientes = new List<Customer>
            {
                new Customer { Username = "usuario1", Password = "123" }
            };
            var handler = new UserHandler { Custumers = clientes };
            var controller = new LoginController(handler);

            var resultado = controller.Login("usuario1", "123");

            Assert.IsTrue(resultado);
        }
        /// <summary>
        /// Logins the password incorrecto retorna false.
        /// </summary>
        [TestMethod]
        public void Login_PasswordIncorrecto_RetornaFalse()
        {
            var clientes = new List<Customer>
            {
                new Customer { Username = "usuario1", Password = "123" }
            };
            var handler = new UserHandler { Custumers = clientes };
            var controller = new LoginController(handler);

            var resultado = controller.Login("usuario1", "clave_error");

            Assert.IsFalse(resultado);
        }
        /// <summary>
        /// Logins the usuario vacio retorna false.
        /// </summary>
        [TestMethod]
        public void Login_UsuarioVacio_RetornaFalse()
        {
            var handler = new UserHandler { Custumers = new List<Customer>() };
            var controller = new LoginController(handler);

            var resultado = controller.Login("", "123");

            Assert.IsFalse(resultado);
        }
    }
}