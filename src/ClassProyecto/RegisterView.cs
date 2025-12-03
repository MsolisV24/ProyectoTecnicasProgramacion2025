using ClassController.Abstractions;
using ClassModels;

namespace ClassProyecto
{
    /// <summary>
    /// manages the user registration view.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class RegisterView : Form
    {

        /// <summary>
        /// The userhandler
        /// </summary>
        private readonly UserHandler Userhandler;

        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterView"/> class.
        /// </summary>
        /// <param name="Userhandler">The userhandler.</param>
        public RegisterView(UserHandler Userhandler)
        {
            InitializeComponent();
            this.Userhandler = Userhandler;
        }

        /// <summary>
        /// Handles the Click event of the btnRegister control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnRegister_Click(object sender, EventArgs e)
        {
            var name = txtName.Text.Trim();
            var lastname = txtLastName.Text.Trim();
            var username = txtUsername.Text.Trim();
            var password = txtPassword.Text.Trim();

            if (name == "" || lastname == "" || username == "" || password == "")
            {
                MessageBox.Show("Data is missing.");
                return;
            }

            if (Userhandler.Custumers.Any(x => x.Username.Equals(username, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("The user already exists.");
                return;
            }

            var further = CreateUser(name, lastname, username, password);
            Userhandler.Custumers.Add(further);
            SaveUserRegister(further);

            MessageBox.Show("Registered.");
            Close();
        }

        /// <summary>
        /// Creates the user.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="lastname">The lastname.</param>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        private Customer CreateUser(string name, string lastname, string username, string password)
        {
            return new Customer
            {
                Name = name,
                LastName = lastname,
                Username = username,
                Password = password,
            };
        }

        /// <summary>
        /// Saves the user register.
        /// </summary>
        /// <param name="add">The add.</param>
        private void SaveUserRegister(Customer add)
        {
            var route = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "users.csv");
            var line = $"{add.Name},{add.LastName},{add.Username},{add.Password},[]";
            File.AppendAllLines(route, [line]);
        }

        /// <summary>
        /// Handles the Load event of the RegisterView control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        
    }
}

