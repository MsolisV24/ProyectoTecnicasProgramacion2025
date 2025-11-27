using ClassController;
using ClassController.Abstractions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ClassProyecto
{
    public partial class LoginView : Form
    {

        private readonly LoginController loginController;
        private UserHandler userHandler;
        private MarketController _market;

        public LoginView(LoginController loginController)
        {
            InitializeComponent();
            this.loginController = loginController;
        }

        public LoginView(UserHandler userHandler)
        {
            this.userHandler = userHandler;
        }

        private bool ValidateArgs(string userName, string password)
        {
            if (!userName.IsValidadString())
            {
                MessageBox.Show("The UserName cannot be empty");
                this.txt_Password.Clear();
            }
            else if (!password.IsValidadString())
            {
                MessageBox.Show("The Password cannot be empty");
                this.txt_Password.Clear();
            }
            return true;
        }

        private bool Login(string userName, string password)
        {
            var loginValidation = this.loginController.Login(userName, password);

            if (loginValidation)
            {
                MessageBox.Show($"Login Successful! Welcome {userName}!");
                var formMainView = new LoginView(this.loginController.UserHandler);
                formMainView.Show();
                return true;
            }

            return loginValidation;
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            var userName = txt_UserName.Text;
            var password = txt_Password.Text;
            var isUserValid = ValidateArgs(userName, password);

            if (isUserValid)
            {
                var loginSuccess = Login(userName, password);
                if (!loginSuccess)
                {
                    MessageBox.Show("UserName or Password incorrect");
                    this.txt_Password.Clear();
                }
            }
            else
            {
                MessageBox.Show("Please enter valid values.");
            }
            var form = new FormMain(userName);
            form.Show();
            this.Hide();

        }

        private void LoginView_Load(object sender, EventArgs e)
        {

        }
    }
}
