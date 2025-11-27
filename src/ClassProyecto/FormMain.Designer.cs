namespace ClassProyecto
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.ComboBox cmbUsuarios;
        private System.Windows.Forms.ComboBox cmbFerias;
        private System.Windows.Forms.Button btnCargarDatos;
        private System.Windows.Forms.Button btnSetUsuarioFeria;
        private System.Windows.Forms.DataGridView dgvCarrito;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Button btnEliminarItem;
        private System.Windows.Forms.Button btnLimpiarCarrito;
        private System.Windows.Forms.Button btnProcesarCompra;
        private System.Windows.Forms.Button btnVerEstadisticas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotal;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.cmbUsuarios = new System.Windows.Forms.ComboBox();
            this.cmbFerias = new System.Windows.Forms.ComboBox();
            this.btnCargarDatos = new System.Windows.Forms.Button();
            this.btnSetUsuarioFeria = new System.Windows.Forms.Button();
            this.dgvCarrito = new System.Windows.Forms.DataGridView();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.btnEliminarItem = new System.Windows.Forms.Button();
            this.btnLimpiarCarrito = new System.Windows.Forms.Button();
            this.btnProcesarCompra = new System.Windows.Forms.Button();
            this.btnVerEstadisticas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbUsuarios
            // 
            this.cmbUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuarios.Location = new System.Drawing.Point(25, 45);
            this.cmbUsuarios.Name = "cmbUsuarios";
            this.cmbUsuarios.Size = new System.Drawing.Size(190, 23);
            // 
            // cmbFerias
            // 
            this.cmbFerias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFerias.Location = new System.Drawing.Point(240, 45);
            this.cmbFerias.Name = "cmbFerias";
            this.cmbFerias.Size = new System.Drawing.Size(190, 23);
            // 
            // btnCargarDatos
            // 
            this.btnCargarDatos.Location = new System.Drawing.Point(450, 20);
            this.btnCargarDatos.Name = "btnCargarDatos";
            this.btnCargarDatos.Size = new System.Drawing.Size(120, 30);
            this.btnCargarDatos.Text = "Cargar CSV";
            this.btnCargarDatos.Click += new System.EventHandler(this.btnCargarDatos_Click);
            // 
            // btnSetUsuarioFeria
            // 
            this.btnSetUsuarioFeria.Location = new System.Drawing.Point(450, 60);
            this.btnSetUsuarioFeria.Text = "Usar selección";
            this.btnSetUsuarioFeria.Click += new System.EventHandler(this.btnSetUsuarioFeria_Click);
            // 
            // dgvCarrito
            // 
            this.dgvCarrito.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCarrito.Location = new System.Drawing.Point(25, 100);
            this.dgvCarrito.ReadOnly = true;
            this.dgvCarrito.Size = new System.Drawing.Size(545, 220);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(25, 340);
            this.btnAgregarProducto.Text = "Agregar producto";
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // btnEliminarItem
            // 
            this.btnEliminarItem.Location = new System.Drawing.Point(160, 340);
            this.btnEliminarItem.Text = "Eliminar ítem";
            this.btnEliminarItem.Click += new System.EventHandler(this.btnEliminarItem_Click);
            // 
            // btnLimpiarCarrito
            // 
            this.btnLimpiarCarrito.Location = new System.Drawing.Point(295, 340);
            this.btnLimpiarCarrito.Text = "Limpiar carrito";
            this.btnLimpiarCarrito.Click += new System.EventHandler(this.btnLimpiarCarrito_Click);
            // 
            // btnProcesarCompra
            // 
            this.btnProcesarCompra.Location = new System.Drawing.Point(430, 340);
            this.btnProcesarCompra.Text = "Procesar compra";
            this.btnProcesarCompra.Click += new System.EventHandler(this.btnProcesarCompra_Click);
            // 
            // btnVerEstadisticas
            // 
            this.btnVerEstadisticas.Location = new System.Drawing.Point(430, 395);
            this.btnVerEstadisticas.Text = "Ver estadísticas";
            this.btnVerEstadisticas.Click += new System.EventHandler(this.btnVerEstadisticas_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(240, 25);
            this.label2.Text = "Feria:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(25, 405);
            this.label3.Text = "Total:";
            // 
            // lblTotal
            // 
            this.lblTotal.Location = new System.Drawing.Point(80, 405);
            this.lblTotal.Text = "0.00";
            // 
            // FormMain
            // 
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnVerEstadisticas);
            this.Controls.Add(this.btnProcesarCompra);
            this.Controls.Add(this.btnLimpiarCarrito);
            this.Controls.Add(this.btnEliminarItem);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.dgvCarrito);
            this.Controls.Add(this.btnSetUsuarioFeria);
            this.Controls.Add(this.btnCargarDatos);
            this.Controls.Add(this.cmbFerias);
            this.Controls.Add(this.cmbUsuarios);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Text = "Carrito de compras - Feria del Agricultor";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

