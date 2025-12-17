using ClassController.Abstractions;

namespace ClassController
{
    public class LoginController
    {
        public readonly UserHandler UserHandler;

        public LoginController(UserHandler userHandler)
        {
            this.UserHandler = userHandler;
        }

        public bool Login(string userName, string password)
        {
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                return false;
            }

            var customer = UserHandler.Custumers.FirstOrDefault(c =>
                c.Username.Equals(userName, StringComparison.OrdinalIgnoreCase));

            if (customer == null)
            {
                return false;
            }

            return customer.Password == password;
        }
    }
}
