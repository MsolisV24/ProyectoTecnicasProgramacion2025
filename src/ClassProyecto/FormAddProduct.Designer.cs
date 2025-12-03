namespace ClassProyecto
{
    partial class FormAddProduct
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.ComboBox cmbProducts;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblProductText;
        private System.Windows.Forms.Label lblQuantityText;
        private System.Windows.Forms.Label lblUnitText;
        private System.Windows.Forms.Label lblPriceText;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            cmbProducts = new ComboBox();
            nudQuantity = new NumericUpDown();
            lblUnit = new Label();
            lblPrice = new Label();
            btnAccept = new Button();
            btnCancel = new Button();
            lblProductText = new Label();
            lblQuantityText = new Label();
            lblUnitText = new Label();
            lblPriceText = new Label();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            SuspendLayout();

            cmbProducts.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProducts.Location = new Point(25, 40);
            cmbProducts.Name = "cmbProducts";
            cmbProducts.Size = new Size(220, 23);
            cmbProducts.TabIndex = 9;
            cmbProducts.SelectedIndexChanged += cmbProducts_SelectedIndexChanged;

            nudQuantity.Location = new Point(25, 100);
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(120, 23);
            nudQuantity.TabIndex = 8;

            lblUnit.Location = new Point(180, 100);
            lblUnit.Name = "lblUnit";
            lblUnit.Size = new Size(83, 23);
            lblUnit.TabIndex = 7;
            lblUnit.Text = "-";

            lblPrice.Location = new Point(140, 140);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(100, 23);
            lblPrice.TabIndex = 6;
            lblPrice.Text = "0.00";

            btnAccept.Location = new Point(25, 180);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(75, 23);
            btnAccept.TabIndex = 5;
            btnAccept.Text = "Add";
            btnAccept.Click += btnAccept_Click;

            btnCancel.Location = new Point(140, 180);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.Click += btnCancel_Click;

            lblProductText.Location = new Point(25, 14);
            lblProductText.Name = "lblProductText";
            lblProductText.Size = new Size(100, 23);
            lblProductText.TabIndex = 3;
            lblProductText.Text = "Product:";

            lblQuantityText.Location = new Point(25, 74);
            lblQuantityText.Name = "lblQuantityText";
            lblQuantityText.Size = new Size(100, 23);
            lblQuantityText.TabIndex = 2;
            lblQuantityText.Text = "Quantity:";

            lblUnitText.Location = new Point(180, 80);
            lblUnitText.Name = "lblUnitText";
            lblUnitText.Size = new Size(100, 23);
            lblUnitText.TabIndex = 1;
            lblUnitText.Text = "Unit:";

            lblPriceText.Location = new Point(25, 140);
            lblPriceText.Name = "lblPriceText";
            lblPriceText.Size = new Size(100, 23);
            lblPriceText.TabIndex = 0;
            lblPriceText.Text = "Price:";

            ClientSize = new Size(275, 250);
            Controls.Add(lblPriceText);
            Controls.Add(lblUnitText);
            Controls.Add(lblQuantityText);
            Controls.Add(lblProductText);
            Controls.Add(btnCancel);
            Controls.Add(btnAccept);
            Controls.Add(lblPrice);
            Controls.Add(lblUnit);
            Controls.Add(nudQuantity);
            Controls.Add(cmbProducts);
            Name = "FormAddProduct";
            Text = "Add Product";
            Load += FormAgregarProducto_Load;
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ResumeLayout(false);
        }
    }
}

