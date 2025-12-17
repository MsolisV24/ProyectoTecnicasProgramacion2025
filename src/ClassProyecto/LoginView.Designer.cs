namespace ClassProyecto
{
    /// <summary>
    /// implements the login view.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    partial class LoginView
    {
        /// <summary>
        /// The components
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Disposes of the resources (other than memory) used by the <see cref="T:System.Windows.Forms.Form" />.
        /// </summary>
        /// <param name="disposing"><see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Initializes the component.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_RegisterUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.topPanel = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Login
            // 
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Login.Location = new System.Drawing.Point(225, 260);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(160, 50);
            this.btn_Login.TabIndex = 0;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_RegisterUser
            // 
            this.btn_RegisterUser.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_RegisterUser.Location = new System.Drawing.Point(415, 260);
            this.btn_RegisterUser.Name = "btn_RegisterUser";
            this.btn_RegisterUser.Size = new System.Drawing.Size(160, 50);
            this.btn_RegisterUser.TabIndex = 1;
            this.btn_RegisterUser.Text = "Register User";
            this.btn_RegisterUser.UseVisualStyleBackColor = true;
            this.btn_RegisterUser.Click += new System.EventHandler(this.btn_RegisterUser_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(180, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(180, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // txt_UserName
            // 
            this.txt_UserName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_UserName.Location = new System.Drawing.Point(325, 120);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(250, 34);
            this.txt_UserName.TabIndex = 4;
            // 
            // txt_Password
            // 
            this.txt_Password.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_Password.Location = new System.Drawing.Point(325, 180);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '●';
            this.txt_Password.Size = new System.Drawing.Size(250, 34);
            this.txt_Password.TabIndex = 5;
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.lblTitle);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(800, 70);
            this.topPanel.TabIndex = 6;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(800, 70);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Welcome to Sistema Feria del Agricultor CR";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_UserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_RegisterUser);
            this.Controls.Add(this.btn_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoginView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.topPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Button btn_Login;
        private Button btn_RegisterUser;
        private Label label1;
        private Label label2;
        private TextBox txt_UserName;
        private TextBox txt_Password;
        private Panel topPanel;
        private Label lblTitle;
    }
}


