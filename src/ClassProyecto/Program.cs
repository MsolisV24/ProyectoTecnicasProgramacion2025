using ClassController;
using ClassController.Abstractions;
using ClassModels;

namespace ClassProyecto
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            var userController = LoadControllerService();
            Application.Run(new LoginView(userController));
        }

        private static LoginController LoadControllerService()
        {
            var context = new ClassDataAccess.DatabaseContext();
            var initializer = new ClassDataAccess.DatabaseInitializer(context);
            initializer.Initialize();

            var databaseHandler = new DatabaseCustomerHandler(context);
            var userHandler = new UserHandler(databaseHandler);

            var loaded = userHandler.LoadUsers("");
            if (!loaded)
            {
                MessageBox.Show("Could not load users from database.");
                Environment.Exit(1);
            }

            var userController = new LoginController(userHandler);
            return userController;
        }
    }
}