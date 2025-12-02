namespace ClassProyecto
{
    partial class FormAgregarProducto
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.ComboBox cmbProductos;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Label lblUnidad;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            cmbProductos = new ComboBox();
            nudCantidad = new NumericUpDown();
            lblUnidad = new Label();
            lblPrecio = new Label();
            btnAceptar = new Button();
            btnCancelar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            SuspendLayout();
            // 
            // cmbProductos
            // 
            cmbProductos.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProductos.Location = new Point(25, 40);
            cmbProductos.Name = "cmbProductos";
            cmbProductos.Size = new Size(220, 23);
            cmbProductos.TabIndex = 9;
            cmbProductos.SelectedIndexChanged += cmbProductos_SelectedIndexChanged;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(25, 100);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(120, 23);
            nudCantidad.TabIndex = 8;
            // 
            // lblUnidad
            // 
            lblUnidad.Location = new Point(180, 100);
            lblUnidad.Name = "lblUnidad";
            lblUnidad.Size = new Size(83, 23);
            lblUnidad.TabIndex = 7;
            lblUnidad.Text = "-";
            // 
            // lblPrecio
            // 
            lblPrecio.Location = new Point(140, 140);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(100, 23);
            lblPrecio.TabIndex = 6;
            lblPrecio.Text = "0.00";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(25, 180);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 5;
            btnAceptar.Text = "Agregar";
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(140, 180);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label1
            // 
            label1.Location = new Point(25, 14);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 3;
            label1.Text = "Producto:";
            // 
            // label2
            // 
            label2.Location = new Point(25, 74);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 2;
            label2.Text = "Cantidad:";
            // 
            // label3
            // 
            label3.Location = new Point(180, 80);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 1;
            label3.Text = "Unidad:";
            // 
            // label4
            // 
            label4.Location = new Point(25, 140);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 0;
            label4.Text = "Precio:";
            // 
            // FormAgregarProducto
            // 
            ClientSize = new Size(275, 250);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(lblPrecio);
            Controls.Add(lblUnidad);
            Controls.Add(nudCantidad);
            Controls.Add(cmbProductos);
            Name = "FormAgregarProducto";
            Text = "Agregar Producto";
            Load += FormAgregarProducto_Load;
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ResumeLayout(false);
        }
    }
}
