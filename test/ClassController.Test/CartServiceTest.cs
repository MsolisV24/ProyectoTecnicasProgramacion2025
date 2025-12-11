using ClassModels;

namespace ClassController.Test
{
    /// <summary>
    /// test for <see cref="CartService"/>.
    /// </summary>
    [TestClass]
    public class CartServiceTest
    {
        /// <summary>
        /// Gets the current cart should return cart.
        /// </summary>
        [TestMethod]
        public void getCurrentCartShouldReturnCart()
        {
            // Arrange
            var products = new List<ClassModels.Product>
            {
                new ClassModels.Product { Id = 1, Name = "Product 1", Price = 10.0m },
                new ClassModels.Product { Id = 2, Name = "Product 2", Price = 20.0m }
            };
            var cartService = new CartService(products);

            // Act
            var cart = cartService.GetCurrentCart();
            // Assert
            Assert.IsNotNull(cart);
        }
        /// <summary>
        /// Gets the current cart should return empty items.
        /// </summary>
        [TestMethod]
        public void getCurrentCartShouldReturnEmptyItems()
        {
            // Arrange
            var products = new List<ClassModels.Product>
            {
                new ClassModels.Product { Id = 1, Name = "Product 1", Price = 10.0m },
                new ClassModels.Product { Id = 2, Name = "Product 2", Price = 20.0m }
            };
            var cartService = new CartService(products);
            // Act
            var cart = cartService.GetCurrentCart();
            // Assert
            Assert.AreEqual(0, cart.Items.Count);
        }
        /// <summary>
        /// Gets the current cart should return username and fair identifier.
        /// </summary>
        [TestMethod]
        public void getCurrentCartShouldReturnUsernameAndFairId()
        {
            // Arrange
            var products = new List<ClassModels.Product>
            {
                new ClassModels.Product { Id = 1, Name = "Product 1", Price = 10.0m },
                new ClassModels.Product { Id = 2, Name = "Product 2", Price = 20.0m }
            };
            var cartService = new CartService(products);
            var username = "testuser";
            var fairId = 123;
            // Act
            cartService.SetCurrentUserAndFair(username, fairId);
            var cart = cartService.GetCurrentCart();
            // Assert
            Assert.AreEqual(username, cart.Username);
            Assert.AreEqual(fairId, cart.FairId);
        }
        /// <summary>
        /// Sets the current user and fair should set values correctly.
        /// </summary>
        [TestMethod]
        public void setCurrentUserAndFairShouldSetValuesCorrectly()
        {
            // Arrange
            var products = new List<ClassModels.Product>
            {
                new ClassModels.Product { Id = 1, Name = "Product 1", Price = 10.0m },
                new ClassModels.Product { Id = 2, Name = "Product 2", Price = 20.0m }
            };
            var cartService = new CartService(products);
            var username = "testuser";
            var fairId = 456;
            // Act
            cartService.SetCurrentUserAndFair(username, fairId);
            var cart = cartService.GetCurrentCart();
            // Assert
            Assert.AreEqual(username, cart.Username);
            Assert.AreEqual(fairId, cart.FairId);
        }
        /// <summary>
        /// Adds the item should add new item to cart.
        /// </summary>
        [TestMethod]
        public void addItemShouldAddNewItemToCart()
        {
            // Arrange
            var products = new List<ClassModels.Product>
            {
                new ClassModels.Product { Id = 1, Name = "Product 1", Price = 10.0m },
                new ClassModels.Product { Id = 2, Name = "Product 2", Price = 20.0m }
            };
            var inventory = new List<ClassModels.InventoryItem>
            {
                new ClassModels.InventoryItem { ProductId = 1, QuantityAvailable = 100 },
                new ClassModels.InventoryItem { ProductId = 2, QuantityAvailable = 50 }
            };
            var history = new List<ClassModels.ExpenseRecord>();
            var cartService = new CartService(products, inventory, history);
            cartService.SetCurrentUserAndFair("testuser", 1);
            // Act
            cartService.AddItem(1, 5);
            var cart = cartService.GetCurrentCart();
            // Assert
            Assert.AreEqual(1, cart.Items.Count);
            Assert.AreEqual(1, cart.Items[0].ProductId);
            Assert.AreEqual(5, cart.Items[0].Quantity);
        }
        /// <summary>
        /// Adds the item should throw exception when insufficient inventory.
        /// </summary>
        [TestMethod]
        public void addItemShouldThrowExceptionWhenInsufficientInventory()
        {
            // Arrange
            var products = new List<ClassModels.Product>
            {
                new ClassModels.Product { Id = 1, Name = "Product 1", Price = 10.0m },
                new ClassModels.Product { Id = 2, Name = "Product 2", Price = 20.0m }
            };
            var inventory = new List<ClassModels.InventoryItem>
            {
                new ClassModels.InventoryItem { ProductId = 1, QuantityAvailable = 10 },
                new ClassModels.InventoryItem { ProductId = 2, QuantityAvailable = 50 }
            };
            var history = new List<ClassModels.ExpenseRecord>();
            var cartService = new CartService(products, inventory, history);
            cartService.SetCurrentUserAndFair("testuser", 1);
            // Act & Assert
            Assert.ThrowsException<Exception>(() => cartService.AddItem(1, 20));
        }
        /// <summary>
        /// Adds the item should update quantity for existing item.
        /// </summary>
        [TestMethod]
        public void addItemShouldUpdateQuantityForExistingItem()
        {
            // Arrange
            var products = new List<ClassModels.Product>
            {
                new ClassModels.Product { Id = 1, Name = "Product 1", Price = 10.0m },
                new ClassModels.Product { Id = 2, Name = "Product 2", Price = 20.0m }
            };
            var inventory = new List<ClassModels.InventoryItem>
            {
                new ClassModels.InventoryItem { ProductId = 1, QuantityAvailable = 100 },
                new ClassModels.InventoryItem { ProductId = 2, QuantityAvailable = 50 }
            };
            var history = new List<ClassModels.ExpenseRecord>();
            var cartService = new CartService(products, inventory, history);
            cartService.SetCurrentUserAndFair("testuser", 1);
            // Act
            cartService.AddItem(1, 5);
            cartService.AddItem(1, 3); // Add more of the same item
            var cart = cartService.GetCurrentCart();
            // Assert
            Assert.AreEqual(1, cart.Items.Count);
            Assert.AreEqual(1, cart.Items[0].ProductId);
            Assert.AreEqual(8, cart.Items[0].Quantity); // Quantity should be updated to 8
        }
        /// <summary>
        /// Adds the item should handle multiple products.
        /// </summary>
        [TestMethod]
        public void addItemShouldHandleMultipleProducts()
        {
            // Arrange
            var products = new List<ClassModels.Product>
            {
                new ClassModels.Product { Id = 1, Name = "Product 1", Price = 10.0m },
                new ClassModels.Product { Id = 2, Name = "Product 2", Price = 20.0m }
            };
            var inventory = new List<ClassModels.InventoryItem>
            {
                new ClassModels.InventoryItem { ProductId = 1, QuantityAvailable = 100 },
                new ClassModels.InventoryItem { ProductId = 2, QuantityAvailable = 50 }
            };
            var history = new List<ClassModels.ExpenseRecord>();
            var cartService = new CartService(products, inventory, history);
            cartService.SetCurrentUserAndFair("testuser", 1);
            // Act
            cartService.AddItem(1, 5);
            cartService.AddItem(2, 10);
            var cart = cartService.GetCurrentCart();
            // Assert
            Assert.AreEqual(2, cart.Items.Count);
            Assert.AreEqual(1, cart.Items[0].ProductId);
            Assert.AreEqual(5, cart.Items[0].Quantity);
            Assert.AreEqual(2, cart.Items[1].ProductId);
            Assert.AreEqual(10, cart.Items[1].Quantity);
        }
        /// <summary>
        /// Removes the item should remove item from cart.
        /// </summary>
        [TestMethod]
        public void removeItemShouldRemoveItemFromCart()
        {
            // Arrange
            var products = new List<ClassModels.Product>
            {
                new ClassModels.Product { Id = 1, Name = "Product 1", Price = 10.0m },
                new ClassModels.Product { Id = 2, Name = "Product 2", Price = 20.0m }
            };
            var inventory = new List<ClassModels.InventoryItem>
            {
                new ClassModels.InventoryItem { ProductId = 1, QuantityAvailable = 100 },
                new ClassModels.InventoryItem { ProductId = 2, QuantityAvailable = 50 }
            };
            var history = new List<ClassModels.ExpenseRecord>();
            var cartService = new CartService(products, inventory, history);
            cartService.SetCurrentUserAndFair("testuser", 1);
            cartService.AddItem(1, 5);
            // Act
            cartService.RemoveItem(1);
            var cart = cartService.GetCurrentCart();
            // Assert
            Assert.AreEqual(0, cart.Items.Count);
        }
        /// <summary>
        /// Removes the item should handle non existing item gracefully.
        /// </summary>
        [TestMethod]
        public void removeItemShouldHandleNonExistingItemGracefully()
        {
            // Arrange
            var products = new List<ClassModels.Product>
            {
                new ClassModels.Product { Id = 1, Name = "Product 1", Price = 10.0m },
                new ClassModels.Product { Id = 2, Name = "Product 2", Price = 20.0m }
            };
            var inventory = new List<ClassModels.InventoryItem>
            {
                new ClassModels.InventoryItem { ProductId = 1, QuantityAvailable = 100 },
                new ClassModels.InventoryItem { ProductId = 2, QuantityAvailable = 50 }
            };
            var history = new List<ClassModels.ExpenseRecord>();
            var cartService = new CartService(products, inventory, history);
            cartService.SetCurrentUserAndFair("testuser", 1);
            cartService.AddItem(1, 5);
            // Act
            cartService.RemoveItem(2); // Attempt to remove an item not in the cart
            var cart = cartService.GetCurrentCart();
            // Assert
            Assert.AreEqual(1, cart.Items.Count); // Cart should remain unchanged
        }
        /// <summary>
        /// Clears the cart should empty all items.
        /// </summary>
        [TestMethod]
        public void clearCartShouldEmptyAllItems()
        {
            // Arrange
            var products = new List<ClassModels.Product>
            {
                new ClassModels.Product { Id = 1, Name = "Product 1", Price = 10.0m },
                new ClassModels.Product { Id = 2, Name = "Product 2", Price = 20.0m }
            };
            var inventory = new List<ClassModels.InventoryItem>
            {
                new ClassModels.InventoryItem { ProductId = 1, QuantityAvailable = 100 },
                new ClassModels.InventoryItem { ProductId = 2, QuantityAvailable = 50 }
            };
            var history = new List<ClassModels.ExpenseRecord>();
            var cartService = new CartService(products, inventory, history);
            cartService.SetCurrentUserAndFair("testuser", 1);
            cartService.AddItem(1, 5);
            cartService.AddItem(2, 10);
            // Act
            cartService.ClearCart();
            var cart = cartService.GetCurrentCart();
            // Assert
            Assert.AreEqual(0, cart.Items.Count);
        }
        [TestMethod]
        public void clearCartShouldHandleAlreadyEmptyCart()
        {
            // Arrange
            var products = new List<ClassModels.Product>
            {
                new ClassModels.Product { Id = 1, Name = "Product 1", Price = 10.0m },
                new ClassModels.Product { Id = 2, Name = "Product 2", Price = 20.0m }
            };
            var inventory = new List<ClassModels.InventoryItem>
            {
                new ClassModels.InventoryItem { ProductId = 1, QuantityAvailable = 100 },
                new ClassModels.InventoryItem { ProductId = 2, QuantityAvailable = 50 }
            };
            var history = new List<ClassModels.ExpenseRecord>();
            var cartService = new CartService(products, inventory, history);
            cartService.SetCurrentUserAndFair("testuser", 1);
            // Act
            cartService.ClearCart(); // Clear an already empty cart
            var cart = cartService.GetCurrentCart();
            // Assert
            Assert.AreEqual(0, cart.Items.Count); // Cart should remain empty
        }
    }
}