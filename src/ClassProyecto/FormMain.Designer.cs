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
            this.cmbUsers = new System.Windows.Forms.ComboBox();
            this.cmbFairs = new System.Windows.Forms.ComboBox();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.btnSetUserFair = new System.Windows.Forms.Button();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnClearCart = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnViewStats = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblFair = new System.Windows.Forms.Label();
            this.lblTotalText = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.SuspendLayout();

            this.cmbUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsers.Location = new System.Drawing.Point(25, 45);
            this.cmbUsers.Name = "cmbUsers";
            this.cmbUsers.Size = new System.Drawing.Size(190, 23);

            this.cmbFairs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFairs.Location = new System.Drawing.Point(240, 45);
            this.cmbFairs.Name = "cmbFairs";
            this.cmbFairs.Size = new System.Drawing.Size(190, 23);

            this.btnLoadData.Location = new System.Drawing.Point(450, 20);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(120, 30);
            this.btnLoadData.Text = "Load CSV";
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);

            this.btnSetUserFair.Location = new System.Drawing.Point(450, 60);
            this.btnSetUserFair.Name = "btnSetUserFair";
            this.btnSetUserFair.Size = new System.Drawing.Size(120, 30);
            this.btnSetUserFair.Text = "Apply selection";
            this.btnSetUserFair.Click += new System.EventHandler(this.btnSetUserFair_Click);

            this.dgvCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCart.Location = new System.Drawing.Point(25, 100);
            this.dgvCart.ReadOnly = true;
            this.dgvCart.Size = new System.Drawing.Size(545, 220);

            this.btnAddProduct.Location = new System.Drawing.Point(25, 340);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(120, 30);
            this.btnAddProduct.Text = "Add product";
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);

            this.btnRemoveItem.Location = new System.Drawing.Point(160, 340);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(120, 30);
            this.btnRemoveItem.Text = "Remove item";
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);

            this.btnClearCart.Location = new System.Drawing.Point(295, 340);
            this.btnClearCart.Name = "btnClearCart";
            this.btnClearCart.Size = new System.Drawing.Size(120, 30);
            this.btnClearCart.Text = "Clear cart";
            this.btnClearCart.Click += new System.EventHandler(this.btnClearCart_Click);

            this.btnCheckout.Location = new System.Drawing.Point(430, 340);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(120, 30);
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);

            this.btnViewStats.Location = new System.Drawing.Point(430, 395);
            this.btnViewStats.Name = "btnViewStats";
            this.btnViewStats.Size = new System.Drawing.Size(120, 30);
            this.btnViewStats.Text = "View statistics";
            this.btnViewStats.Click += new System.EventHandler(this.btnViewStats_Click);

            this.lblUser.Location = new System.Drawing.Point(25, 25);
            this.lblUser.Text = "User:";

            this.lblFair.Location = new System.Drawing.Point(240, 25);
            this.lblFair.Text = "Fair:";

            this.lblTotalText.Location = new System.Drawing.Point(25, 405);
            this.lblTotalText.Text = "Total:";

            this.lblTotal.Location = new System.Drawing.Point(80, 405);
            this.lblTotal.Text = "0.00";

            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTotalText);
            this.Controls.Add(this.btnViewStats);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.btnClearCart);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.dgvCart);
            this.Controls.Add(this.btnSetUserFair);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.cmbFairs);
            this.Controls.Add(this.cmbUsers);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblFair);
            this.Text = "Shopping Cart - Farmer's Market";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}



