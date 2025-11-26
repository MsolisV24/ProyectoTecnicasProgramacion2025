using ClassController.Abstractions;

namespace ClassController
{
    /// <summary>
    /// Class for handling login operations.
    /// </summary>
    public class LoginController
    {
        public readonly UserHandler UserHandler;

        /// <summary>
        /// Initializes a new instance of the <see cref="LoginController"/> class.
        /// </summary>
        /// <param name="userHandler">The user handler.</param>
        public LoginController(UserHandler userHandler)
        {
            this.UserHandler = userHandler;
        }

        /// <summary>
        /// Logins the specified user name.
        /// </summary>
        /// <param name="userName">Name of the user.</param>
        /// <param name="password">The password.</param>
        /// <returns>true if login correct otherwise false.</returns>
        public bool Login(string userName, string password)
        {
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                return false;
            }

            foreach (var costumer in UserHandler.Custumers)
            {
                if (costumer.Username == userName && costumer.Password == password)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
