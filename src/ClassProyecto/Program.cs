using ClassController;
using ClassController.Abstractions;
using ClassModels;

namespace ClassProyecto
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var userController = LoadControllerService();
            Application.Run(new LoginView(userController));
        }

        private static LoginController LoadControllerService()
        {
            var userHandler = new UserHandler(new FileHandler<Customer>());
            var couldLoadUsers = userHandler.LoadUsers(Generals.FileNameUsers);
            if (!couldLoadUsers)
            {
                MessageBox.Show("Could not load users from data source. The application will close.");
                Environment.Exit(1);
            }
            var userController = new LoginController(userHandler);
            return userController;
        }

    }
}