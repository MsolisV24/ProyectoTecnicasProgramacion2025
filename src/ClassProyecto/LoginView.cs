using ClassController;
using ClassModels;

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

        private void btn_Login_Click(object sender, EventArgs e)
        {
            var userName = txt_UserName.Text;
            var password = txt_Password.Text;

            if (string.IsNullOrWhiteSpace(userName))
            {
                MessageBox.Show("The UserName cannot be empty");
                txt_Password.Clear();
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("The Password cannot be empty");
                txt_Password.Clear();
                return;
            }

            var loginSuccess = loginController.Login(userName, password);

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

        private void btn_RegisterUser_Click(object sender, EventArgs e)
        {
            var view = new RegisterView(loginController.UserHandler);
            view.ShowDialog();
        }
    }
}

