namespace ClassProyecto
{
    partial class RegisterView
    {
        private System.ComponentModel.IContainer components = null;

        private TextBox txtName;
        private TextBox txtLastName;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnRegister;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtName = new TextBox();
            txtLastName = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnRegister = new Button();
            lblName = new Label();
            lblLastName = new Label();
            lblUserName = new Label();
            lblPassword = new Label();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(120, 30);
            txtName.Name = "txtName";
            txtName.Size = new Size(180, 23);
            txtName.TabIndex = 4;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(120, 80);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(180, 23);
            txtLastName.TabIndex = 5;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(120, 130);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(180, 23);
            txtUsername.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(120, 180);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(180, 23);
            txtPassword.TabIndex = 7;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(144, 230);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(120, 35);
            btnRegister.TabIndex = 8;
            btnRegister.Text = "Register";
            btnRegister.Click += btnRegister_Click;
            // 
            // lblName
            // 
            lblName.Location = new Point(40, 33);
            lblName.Name = "lblName";
            lblName.Size = new Size(64, 23);
            lblName.TabIndex = 0;
            lblName.Text = "Name:";
            // 
            // lblLastName
            // 
            lblLastName.Location = new Point(40, 83);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(74, 23);
            lblLastName.TabIndex = 1;
            lblLastName.Text = "Lastname:";
            // 
            // lblUserName
            // 
            lblUserName.Location = new Point(40, 133);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(74, 23);
            lblUserName.TabIndex = 2;
            lblUserName.Text = "Username:";
            // 
            // lblPassword
            // 
            lblPassword.Location = new Point(40, 183);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(64, 23);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password:";
            // 
            // RegisterView
            // 
            ClientSize = new Size(340, 320);
            Controls.Add(lblName);
            Controls.Add(lblLastName);
            Controls.Add(lblUserName);
            Controls.Add(lblPassword);
            Controls.Add(txtName);
            Controls.Add(txtLastName);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Controls.Add(btnRegister);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "RegisterView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register - Sistema Feria del Agricultor CR";
            ResumeLayout(false);
            PerformLayout();
        }
        private Label lblName;
        private Label lblLastName;
        private Label lblUserName;
        private Label lblPassword;
    }
}
