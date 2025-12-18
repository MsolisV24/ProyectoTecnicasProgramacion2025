using System;
using System.Windows.Forms;
using System.IO;
using ClassController;
using iTextSharpDoc = iTextSharp.text.Document;
using iTextSharpPara = iTextSharp.text.Paragraph;
using iTextSharpWriter = iTextSharp.text.pdf.PdfWriter;

namespace ClassProyecto
{
    public partial class FormStatistics : Form
    {
        private readonly IStatisticsService _stats;

        public FormStatistics(IStatisticsService stats)
        {
            InitializeComponent();
            _stats = stats;
        }

        private void FormStatistics_Load(object sender, EventArgs e)
        {
            dtpFrom.Value = DateTime.Today.AddMonths(-1);
            dtpTo.Value = DateTime.Today;
            LoadStatistics();
        }

        private void btnApplyFilter_Click(object sender, EventArgs e)
        {
            LoadStatistics();
        }

        private void LoadStatistics()
        {
            var from = dtpFrom.Value;
            var to = dtpTo.Value;

            dgvProducers.DataSource = _stats.GetTopProducers(from, to);
            dgvProducts.DataSource = _stats.GetTopProducts(from, to);
            dgvMonths.DataSource = _stats.GetMonthlySummary();

            var bestMonth = _stats.GetMonthWithMoreConsumption();
            lblBestMonth.Text = bestMonth == null
                ? "No data"
                : $"{bestMonth.Year}-{bestMonth.Month:00} Total: {bestMonth.TotalAmount:N2}";
        }

        private void btnExportPDF_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF files (*.pdf)|*.pdf";
                save.FileName = "estadisticas.pdf";

                if (save.ShowDialog() == DialogResult.OK)
                {
                    MakePDF(save.FileName);
                    MessageBox.Show("PDF guardado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void MakePDF(string filePath)
        {
            var doc = new iTextSharpDoc();
            var writer = iTextSharpWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));
            doc.Open();

            doc.Add(new iTextSharpPara("REPORTE DE ESTADISTICAS"));
            doc.Add(new iTextSharpPara(" "));
            doc.Add(new iTextSharpPara($"Fecha: {DateTime.Now}"));
            doc.Add(new iTextSharpPara($"Desde: {dtpFrom.Value.ToShortDateString()}"));
            doc.Add(new iTextSharpPara($"Hasta: {dtpTo.Value.ToShortDateString()}"));
            doc.Add(new iTextSharpPara(" "));

            doc.Add(new iTextSharpPara("Productores Top:"));
            var producers = _stats.GetTopProducers(dtpFrom.Value, dtpTo.Value);
            if (producers != null)
            {
                foreach (var item in producers)
                {
                    doc.Add(new iTextSharpPara("- " + item.ToString()));
                }
            }

            doc.Add(new iTextSharpPara(" "));
            doc.Add(new iTextSharpPara("Productos Top:"));
            var products = _stats.GetTopProducts(dtpFrom.Value, dtpTo.Value);
            if (products != null)
            {
                foreach (var item in products)
                {
                    doc.Add(new iTextSharpPara("- " + item.ToString()));
                }
            }

            doc.Add(new iTextSharpPara(" "));
            doc.Add(new iTextSharpPara("Resumen Mensual:"));
            var months = _stats.GetMonthlySummary();
            if (months != null)
            {
                foreach (var item in months)
                {
                    doc.Add(new iTextSharpPara("- " + item.ToString()));
                }
            }

            var bestMonth = _stats.GetMonthWithMoreConsumption();
            if (bestMonth != null)
            {
                doc.Add(new iTextSharpPara(" "));
                doc.Add(new iTextSharpPara($"Mejor Mes: {bestMonth.Year}-{bestMonth.Month} Total: {bestMonth.TotalAmount}"));
            }

            doc.Close();
        }

        private void btnDownloadPDF_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF files (*.pdf)|*.pdf";
                save.FileName = "reporte_completo.pdf";

                if (save.ShowDialog() == DialogResult.OK)
                {
                    CrearPDFCompleto(save.FileName);
                    MessageBox.Show("Reporte PDF descargado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void CrearPDFCompleto(string filePath)
        {
            var doc = new iTextSharpDoc();
            iTextSharpWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));
            doc.Open();

            doc.Add(new iTextSharpPara("REPORTE COMPLETO"));
            doc.Add(new iTextSharpPara(" "));
            doc.Add(new iTextSharpPara($"Fecha: {DateTime.Now}"));
            doc.Add(new iTextSharpPara(" "));

            doc.Add(new iTextSharpPara("1. Top 5 Productores:"));
            var producers = _stats.GetTopProducers(dtpFrom.Value, dtpTo.Value);
            if (producers != null)
            {
                for (int i = 0; i < 5 && i < producers.Count; i++)
                {
                    var p = producers[i];
                    doc.Add(new iTextSharpPara($"   {i + 1}. {p.ProducerName} - ₡{p.TotalAmount:N2}"));
                }
            }

            doc.Add(new iTextSharpPara(" "));
            doc.Add(new iTextSharpPara("2. Top 5 Productos:"));
            var products = _stats.GetTopProducts(dtpFrom.Value, dtpTo.Value);
            if (products != null)
            {
                for (int i = 0; i < 5 && i < products.Count; i++)
                {
                    var p = products[i];
                    doc.Add(new iTextSharpPara($"   {i + 1}. {p.ProductName} - {p.TotalQuantity} unidades"));
                }
            }

            doc.Add(new iTextSharpPara(" "));
            doc.Add(new iTextSharpPara("3. Ventas por Mes:"));
            var months = _stats.GetMonthlySummary();
            if (months != null)
            {
                foreach (var m in months)
                {
                    doc.Add(new iTextSharpPara($"   {m.Year}-{m.Month}: ₡{m.TotalAmount:N2}"));
                }
            }

            doc.Add(new iTextSharpPara(" "));
            doc.Add(new iTextSharpPara("4. Mejor Mes:"));
            var bestMonth = _stats.GetMonthWithMoreConsumption();
            if (bestMonth != null)
            {
                doc.Add(new iTextSharpPara($"   {bestMonth.Year}-{bestMonth.Month}: ₡{bestMonth.TotalAmount:N2}"));
            }

            doc.Close();
        }
    }
}



