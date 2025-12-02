namespace ClassProyecto
{
    partial class LoginView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_Login = new Button();
            btn_RegisterUser = new Button();
            label1 = new Label();
            label2 = new Label();
            txt_UserName = new TextBox();
            txt_Password = new TextBox();
            SuspendLayout();
            // 
            // btn_Login
            // 
            btn_Login.Location = new Point(138, 260);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(141, 77);
            btn_Login.TabIndex = 0;
            btn_Login.Text = "Login";
            btn_Login.UseVisualStyleBackColor = true;
            btn_Login.Click += btn_Login_Click;
            // 
            // btn_RegisterUser
            // 
            btn_RegisterUser.Location = new Point(336, 260);
            btn_RegisterUser.Name = "btn_RegisterUser";
            btn_RegisterUser.Size = new Size(141, 77);
            btn_RegisterUser.TabIndex = 1;
            btn_RegisterUser.Text = "Register User";
            btn_RegisterUser.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 55);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 104);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // txt_UserName
            // 
            txt_UserName.Location = new Point(245, 55);
            txt_UserName.Name = "txt_UserName";
            txt_UserName.Size = new Size(142, 23);
            txt_UserName.TabIndex = 4;
            // 
            // txt_Password
            // 
            txt_Password.Location = new Point(245, 101);
            txt_Password.Name = "txt_Password";
            txt_Password.Size = new Size(142, 23);
            txt_Password.TabIndex = 5;
            // 
            // LoginView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_Password);
            Controls.Add(txt_UserName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_RegisterUser);
            Controls.Add(btn_Login);
            Name = "LoginView";
            Text = "Form1";
            Load += LoginView_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Login;
        private Button btn_RegisterUser;
        private Label label1;
        private Label label2;
        private TextBox txt_UserName;
        private TextBox txt_Password;
    }
}
