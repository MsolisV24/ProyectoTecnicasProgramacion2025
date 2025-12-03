namespace ClassProyecto
{
    partial class FormStatistics
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dgvProducers;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.DataGridView dgvMonths;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Button btnApplyFilter;
        private System.Windows.Forms.Label lblBestMonth;
        private System.Windows.Forms.Label lblFromText;
        private System.Windows.Forms.Label lblToText;
        private System.Windows.Forms.Label lblBestMonthText;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvProducers = new DataGridView();
            dgvProducts = new DataGridView();
            dgvMonths = new DataGridView();
            dtpFrom = new DateTimePicker();
            dtpTo = new DateTimePicker();
            btnApplyFilter = new Button();
            lblBestMonth = new Label();
            lblFromText = new Label();
            lblToText = new Label();
            lblBestMonthText = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProducers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMonths).BeginInit();
            SuspendLayout();
            // 
            // dgvProducers
            // 
            dgvProducers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducers.Location = new Point(25, 80);
            dgvProducers.Name = "dgvProducers";
            dgvProducers.Size = new Size(340, 150);
            dgvProducers.TabIndex = 9;
            // 
            // dgvProducts
            // 
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.Location = new Point(400, 80);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.Size = new Size(340, 150);
            dgvProducts.TabIndex = 8;
            // 
            // dgvMonths
            // 
            dgvMonths.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMonths.Location = new Point(25, 260);
            dgvMonths.Name = "dgvMonths";
            dgvMonths.Size = new Size(715, 150);
            dgvMonths.TabIndex = 7;
            // 
            // dtpFrom
            // 
            dtpFrom.Location = new Point(98, 25);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(212, 23);
            dtpFrom.TabIndex = 6;
            // 
            // dtpTo
            // 
            dtpTo.Location = new Point(371, 25);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(210, 23);
            dtpTo.TabIndex = 5;
            // 
            // btnApplyFilter
            // 
            btnApplyFilter.Location = new Point(600, 25);
            btnApplyFilter.Name = "btnApplyFilter";
            btnApplyFilter.Size = new Size(100, 23);
            btnApplyFilter.TabIndex = 2;
            btnApplyFilter.Text = "Apply filter";
            btnApplyFilter.Click += btnApplyFilter_Click;
            // 
            // lblBestMonth
            // 
            lblBestMonth.Location = new Point(160, 430);
            lblBestMonth.Name = "lblBestMonth";
            lblBestMonth.Size = new Size(150, 23);
            lblBestMonth.TabIndex = 1;
            lblBestMonth.Text = "No data";
            // 
            // lblFromText
            // 
            lblFromText.Location = new Point(25, 25);
            lblFromText.Name = "lblFromText";
            lblFromText.Size = new Size(58, 23);
            lblFromText.TabIndex = 4;
            lblFromText.Text = "From:";
            // 
            // lblToText
            // 
            lblToText.Location = new Point(318, 27);
            lblToText.Name = "lblToText";
            lblToText.Size = new Size(47, 23);
            lblToText.TabIndex = 3;
            lblToText.Text = "To:";
            // 
            // lblBestMonthText
            // 
            lblBestMonthText.Location = new Point(12, 430);
            lblBestMonthText.Name = "lblBestMonthText";
            lblBestMonthText.Size = new Size(150, 23);
            lblBestMonthText.TabIndex = 0;
            lblBestMonthText.Text = "Highest consumption:";
            // 
            // FormStatistics
            // 
            ClientSize = new Size(780, 470);
            Controls.Add(lblBestMonthText);
            Controls.Add(lblBestMonth);
            Controls.Add(btnApplyFilter);
            Controls.Add(lblToText);
            Controls.Add(lblFromText);
            Controls.Add(dtpTo);
            Controls.Add(dtpFrom);
            Controls.Add(dgvMonths);
            Controls.Add(dgvProducts);
            Controls.Add(dgvProducers);
            Name = "FormStatistics";
            Text = "Statistics";
            Load += FormStatistics_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducers).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMonths).EndInit();
            ResumeLayout(false);
        }
    }
}

