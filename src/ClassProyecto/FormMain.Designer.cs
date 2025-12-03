namespace ClassProyecto
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.ComboBox cmbUsers;
        private System.Windows.Forms.ComboBox cmbFairs;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.Button btnSetUserFair;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnClearCart;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnViewStats;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblFair;
        private System.Windows.Forms.Label lblTotalText;
        private System.Windows.Forms.Label lblTotal;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            cmbUsers = new ComboBox();
            cmbFairs = new ComboBox();
            btnLoadData = new Button();
            btnSetUserFair = new Button();
            dgvCart = new DataGridView();
            btnAddProduct = new Button();
            btnRemoveItem = new Button();
            btnClearCart = new Button();
            btnCheckout = new Button();
            btnViewStats = new Button();
            lblUser = new Label();
            lblFair = new Label();
            lblTotalText = new Label();
            lblTotal = new Label();
            btnGenerateInvoice = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
            SuspendLayout();
            // 
            // cmbUsers
            // 
            cmbUsers.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUsers.Location = new Point(25, 45);
            cmbUsers.Name = "cmbUsers";
            cmbUsers.Size = new Size(190, 23);
            cmbUsers.TabIndex = 11;
            // 
            // cmbFairs
            // 
            cmbFairs.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFairs.Location = new Point(240, 45);
            cmbFairs.Name = "cmbFairs";
            cmbFairs.Size = new Size(190, 23);
            cmbFairs.TabIndex = 10;
            // 
            // btnLoadData
            // 
            btnLoadData.Location = new Point(450, 20);
            btnLoadData.Name = "btnLoadData";
            btnLoadData.Size = new Size(120, 30);
            btnLoadData.TabIndex = 9;
            btnLoadData.Text = "Load CSV";
            btnLoadData.Click += btnLoadData_Click;
            // 
            // btnSetUserFair
            // 
            btnSetUserFair.Location = new Point(450, 60);
            btnSetUserFair.Name = "btnSetUserFair";
            btnSetUserFair.Size = new Size(120, 30);
            btnSetUserFair.TabIndex = 8;
            btnSetUserFair.Text = "Apply selection";
            btnSetUserFair.Click += btnSetUserFair_Click;
            // 
            // dgvCart
            // 
            dgvCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCart.Location = new Point(25, 100);
            dgvCart.Name = "dgvCart";
            dgvCart.ReadOnly = true;
            dgvCart.Size = new Size(545, 220);
            dgvCart.TabIndex = 7;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(25, 340);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(120, 30);
            btnAddProduct.TabIndex = 6;
            btnAddProduct.Text = "Add product";
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // btnRemoveItem
            // 
            btnRemoveItem.Location = new Point(160, 340);
            btnRemoveItem.Name = "btnRemoveItem";
            btnRemoveItem.Size = new Size(120, 30);
            btnRemoveItem.TabIndex = 5;
            btnRemoveItem.Text = "Remove item";
            btnRemoveItem.Click += btnRemoveItem_Click;
            // 
            // btnClearCart
            // 
            btnClearCart.Location = new Point(295, 340);
            btnClearCart.Name = "btnClearCart";
            btnClearCart.Size = new Size(120, 30);
            btnClearCart.TabIndex = 4;
            btnClearCart.Text = "Clear cart";
            btnClearCart.Click += btnClearCart_Click;
            // 
            // btnCheckout
            // 
            btnCheckout.Location = new Point(430, 340);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(120, 30);
            btnCheckout.TabIndex = 3;
            btnCheckout.Text = "Checkout";
            btnCheckout.Click += btnCheckout_Click;
            // 
            // btnViewStats
            // 
            btnViewStats.Location = new Point(430, 395);
            btnViewStats.Name = "btnViewStats";
            btnViewStats.Size = new Size(120, 30);
            btnViewStats.TabIndex = 2;
            btnViewStats.Text = "View statistics";
            btnViewStats.Click += btnViewStats_Click;
            // 
            // lblUser
            // 
            lblUser.Location = new Point(25, 25);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(100, 23);
            lblUser.TabIndex = 12;
            lblUser.Text = "User:";
            // 
            // lblFair
            // 
            lblFair.Location = new Point(240, 25);
            lblFair.Name = "lblFair";
            lblFair.Size = new Size(100, 23);
            lblFair.TabIndex = 13;
            lblFair.Text = "Fair:";
            // 
            // lblTotalText
            // 
            lblTotalText.Location = new Point(25, 405);
            lblTotalText.Name = "lblTotalText";
            lblTotalText.Size = new Size(100, 23);
            lblTotalText.TabIndex = 1;
            lblTotalText.Text = "Total:";
            // 
            // lblTotal
            // 
            lblTotal.Location = new Point(80, 405);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(100, 23);
            lblTotal.TabIndex = 0;
            lblTotal.Text = "0.00";
            // 
            // btnGenerateInvoice
            // 
            btnGenerateInvoice.Location = new Point(295, 395);
            btnGenerateInvoice.Name = "btnGenerateInvoice";
            btnGenerateInvoice.Size = new Size(120, 30);
            btnGenerateInvoice.TabIndex = 14;
            btnGenerateInvoice.Text = "Generate Invoice";
            btnGenerateInvoice.UseVisualStyleBackColor = true;
            btnGenerateInvoice.Click += btnGenerateInvoice_Click;
            // 
            // FormMain
            // 
            ClientSize = new Size(600, 450);
            Controls.Add(btnGenerateInvoice);
            Controls.Add(lblTotal);
            Controls.Add(lblTotalText);
            Controls.Add(btnViewStats);
            Controls.Add(btnCheckout);
            Controls.Add(btnClearCart);
            Controls.Add(btnRemoveItem);
            Controls.Add(btnAddProduct);
            Controls.Add(dgvCart);
            Controls.Add(btnSetUserFair);
            Controls.Add(btnLoadData);
            Controls.Add(cmbFairs);
            Controls.Add(cmbUsers);
            Controls.Add(lblUser);
            Controls.Add(lblFair);
            Name = "FormMain";
            Text = "Shopping Cart - Sistema Feria del Agricultor CR";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCart).EndInit();
            ResumeLayout(false);
        }
        private Button btnGenerateInvoice;
    }
}



