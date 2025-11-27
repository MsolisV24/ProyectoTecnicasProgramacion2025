namespace ClassProyecto
{
    partial class FormEstadisticas
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dgvProductores;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.DataGridView dgvMeses;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Button btnAplicarFiltro;
        private System.Windows.Forms.Label lblMesMayor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvProductores = new DataGridView();
            dgvProductos = new DataGridView();
            dgvMeses = new DataGridView();
            dtpDesde = new DateTimePicker();
            dtpHasta = new DateTimePicker();
            btnAplicarFiltro = new Button();
            lblMesMayor = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProductores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMeses).BeginInit();
            SuspendLayout();
            // 
            // dgvProductores
            // 
            dgvProductores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductores.Location = new Point(25, 80);
            dgvProductores.Name = "dgvProductores";
            dgvProductores.Size = new Size(340, 150);
            dgvProductores.TabIndex = 9;
            // 
            // dgvProductos
            // 
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.Location = new Point(400, 80);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.Size = new Size(340, 150);
            dgvProductos.TabIndex = 8;
            // 
            // dgvMeses
            // 
            dgvMeses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMeses.Location = new Point(25, 260);
            dgvMeses.Name = "dgvMeses";
            dgvMeses.Size = new Size(715, 150);
            dgvMeses.TabIndex = 7;
            // 
            // dtpDesde
            // 
            dtpDesde.Location = new Point(89, 27);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(200, 23);
            dtpDesde.TabIndex = 6;
            // 
            // dtpHasta
            // 
            dtpHasta.Location = new Point(339, 27);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(200, 23);
            dtpHasta.TabIndex = 5;
            // 
            // btnAplicarFiltro
            // 
            btnAplicarFiltro.Location = new Point(560, 25);
            btnAplicarFiltro.Name = "btnAplicarFiltro";
            btnAplicarFiltro.Size = new Size(75, 23);
            btnAplicarFiltro.TabIndex = 2;
            btnAplicarFiltro.Text = "Aplicar filtro";
            btnAplicarFiltro.Click += btnAplicarFiltro_Click;
            // 
            // lblMesMayor
            // 
            lblMesMayor.Location = new Point(160, 430);
            lblMesMayor.Name = "lblMesMayor";
            lblMesMayor.Size = new Size(100, 23);
            lblMesMayor.TabIndex = 1;
            lblMesMayor.Text = "Sin datos";
            // 
            // label1
            // 
            label1.Location = new Point(25, 27);
            label1.Name = "label1";
            label1.Size = new Size(58, 23);
            label1.TabIndex = 4;
            label1.Text = "Desde:";
            // 
            // label2
            // 
            label2.Location = new Point(286, 29);
            label2.Name = "label2";
            label2.Size = new Size(47, 23);
            label2.TabIndex = 3;
            label2.Text = "Hasta:";
            // 
            // label3
            // 
            label3.Location = new Point(25, 430);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 0;
            label3.Text = "Mes mayor consumo:";
            // 
            // FormEstadisticas
            // 
            ClientSize = new Size(780, 470);
            Controls.Add(label3);
            Controls.Add(lblMesMayor);
            Controls.Add(btnAplicarFiltro);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtpHasta);
            Controls.Add(dtpDesde);
            Controls.Add(dgvMeses);
            Controls.Add(dgvProductos);
            Controls.Add(dgvProductores);
            Name = "FormEstadisticas";
            Text = "Estadísticas";
            Load += FormEstadisticas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductores).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMeses).EndInit();
            ResumeLayout(false);
        }
    }
}
