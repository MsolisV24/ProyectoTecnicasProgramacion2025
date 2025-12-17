using ClassController;
using ClassModels;
using ClassDataAccess;

namespace ClassProyecto
{
    public partial class RegisterView : Form
    {
        private readonly UserHandler _userHandler;
        private readonly DatabaseContext _context;

        public RegisterView(UserHandler userHandler)
        {
            InitializeComponent();
            _userHandler = userHandler;
            _context = new DatabaseContext();
        }

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

            if (_context.Customers.Any(c => c.Username == username))
            {
                MessageBox.Show("The user already exists.");
                return;
            }

            var maxId = _context.Customers.Any() ? _context.Customers.Max(c => c.Id) : 0;
            var customer = new Customer
            {
                Id = maxId + 1,
                Name = name,
                LastName = lastname,
                Username = username,
                Password = password,
                Directions = "[]"
            };

            _context.Customers.Add(customer);
            _context.SaveChanges();

            _userHandler.Custumers.Add(customer);

            MessageBox.Show("Registered.");
            Close();
        }
    }
}

