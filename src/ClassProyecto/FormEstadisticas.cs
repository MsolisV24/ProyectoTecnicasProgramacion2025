using System;
using System;
using System.Windows.Forms;
using ClassController;

namespace ClassProyecto
{
    public partial class FormEstadisticas : Form
    {
        private readonly IStatisticsService _stats;

        public FormEstadisticas(IStatisticsService stats)
        {
            InitializeComponent();
            _stats = stats;
        }

        private void FormEstadisticas_Load(object sender, EventArgs e)
        {
            dtpDesde.Value = DateTime.Today.AddMonths(-1);
            dtpHasta.Value = DateTime.Today;

            CargarEstadisticas();
        }

        private void btnAplicarFiltro_Click(object sender, EventArgs e)
        {
            CargarEstadisticas();
        }

        private void CargarEstadisticas()
        {
            var desde = dtpDesde.Value;
            var hasta = dtpHasta.Value;

            dgvProductores.DataSource = _stats.GetTopProducers(desde, hasta);
            dgvProductos.DataSource = _stats.GetTopProducts(desde, hasta);
            dgvMeses.DataSource = _stats.GetMonthlySummary();

            var mejorMes = _stats.GetMonthWithMoreConsumption();
            lblMesMayor.Text = mejorMes == null
                ? "Sin datos"
                : $"{mejorMes.Year}-{mejorMes.Month:00} Total: {mejorMes.TotalAmount:N2}";
        }
    }
}


