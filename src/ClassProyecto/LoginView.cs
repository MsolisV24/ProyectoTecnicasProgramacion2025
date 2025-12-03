using ClassController;
using Microsoft.Win32;

namespace ClassProyecto
{
    public partial class LoginView : Form
    {
        private readonly LoginController loginController;

        public LoginView(LoginController loginController)
        {
            InitializeComponent();
            this.loginController = loginController;
        }

        private bool ValidateArgs(string userName, string password)
        {
            if (string.IsNullOrWhiteSpace(userName))
            {
                MessageBox.Show("The UserName cannot be empty");
                txt_Password.Clear();
                return false;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("The Password cannot be empty");
                txt_Password.Clear();
                return false;
            }

            return true;
        }

        private bool Login(string userName, string password)
        {
            var loginValidation = loginController.Login(userName, password);

            if (loginValidation)
            {
                MessageBox.Show($"Login Successful! Welcome {userName}!");
                return true;
            }

            return false;
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            var userName = txt_UserName.Text;
            var password = txt_Password.Text;

            if (!ValidateArgs(userName, password))
                return;

            var loginSuccess = Login(userName, password);

            if (!loginSuccess)
            {
                MessageBox.Show("UserName or Password incorrect");
                txt_Password.Clear();
                return;
            }
            var carrito = new FormMain(userName);
            carrito.Show();
            this.Hide();
        }

        private void LoginView_Load(object sender, EventArgs e)
        {

        }

        private void btn_RegisterUser_Click(object sender, EventArgs e)
        {
            var view = new RegisterView(loginController.UserHandler);
            view.ShowDialog();
        }
    }
}

