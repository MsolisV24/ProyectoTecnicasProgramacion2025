namespace ClassProyecto
{
    partial class FormStatistics
    {
        private System.ComponentModel.IContainer components = null;
        private DateTimePicker dtpFrom;
        private DateTimePicker dtpTo;
        private Button btnApplyFilter;
        private DataGridView dgvProducers;
        private DataGridView dgvProducts;
        private DataGridView dgvMonths;
        private Label lblBestMonth;
        private Button btnExportPDF;
        private Button btnDownloadPDF;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dtpFrom = new DateTimePicker();
            dtpTo = new DateTimePicker();
            btnApplyFilter = new Button();
            dgvProducers = new DataGridView();
            dgvProducts = new DataGridView();
            dgvMonths = new DataGridView();
            lblBestMonth = new Label();
            btnExportPDF = new Button();
            btnDownloadPDF = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProducers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMonths).BeginInit();
            SuspendLayout();

            dtpFrom.Location = new Point(12, 12);
            dtpFrom.Size = new Size(200, 23);

            dtpTo.Location = new Point(218, 12);
            dtpTo.Size = new Size(200, 23);

            btnApplyFilter.Location = new Point(424, 12);
            btnApplyFilter.Size = new Size(100, 23);
            btnApplyFilter.Text = "Aplicar Filtro";
            btnApplyFilter.Click += btnApplyFilter_Click;

            dgvProducers.Location = new Point(12, 50);
            dgvProducers.Size = new Size(300, 150);
            dgvProducers.AllowUserToAddRows = false;

            dgvProducts.Location = new Point(318, 50);
            dgvProducts.Size = new Size(300, 150);
            dgvProducts.AllowUserToAddRows = false;

            dgvMonths.Location = new Point(12, 210);
            dgvMonths.Size = new Size(300, 150);
            dgvMonths.AllowUserToAddRows = false;

            lblBestMonth.Location = new Point(318, 210);
            lblBestMonth.Size = new Size(300, 50);
            lblBestMonth.Text = "Mejor mes:";

            btnExportPDF.Location = new Point(318, 270);
            btnExportPDF.Size = new Size(120, 30);
            btnExportPDF.Text = "Exportar PDF";
            btnExportPDF.Click += btnExportPDF_Click;

            btnDownloadPDF.Location = new Point(450, 270);
            btnDownloadPDF.Size = new Size(120, 30);
            btnDownloadPDF.Text = "Descargar PDF";
            btnDownloadPDF.Click += btnDownloadPDF_Click;

            ClientSize = new Size(600, 381);
            Controls.Add(dtpFrom);
            Controls.Add(dtpTo);
            Controls.Add(btnApplyFilter);
            Controls.Add(dgvProducers);
            Controls.Add(dgvProducts);
            Controls.Add(dgvMonths);
            Controls.Add(lblBestMonth);
            Controls.Add(btnExportPDF);
            Controls.Add(btnDownloadPDF);
            Text = "Estadísticas";
            Load += FormStatistics_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducers).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMonths).EndInit();
            ResumeLayout(false);
        }
    }
}

