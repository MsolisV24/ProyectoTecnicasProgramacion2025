using ClassModels;

namespace ClassController
{

    /// <summary>
    /// initial implementation of statistics service
    /// </summary>
    /// <seealso cref="ClassController.IStatisticsService" />
    public class StatisticsService : IStatisticsService
    {

        /// <summary>
        /// The history
        /// </summary>
        private readonly List<ExpenseRecord> _history;

        /// <summary>
        /// The producers
        /// </summary>
        private readonly List<Producer> _producers;

        /// <summary>
        /// The products
        /// </summary>
        private readonly List<Product> _products;

        /// <summary>
        /// Initializes a new instance of the <see cref="StatisticsService"/> class.
        /// </summary>
        /// <param name="history">The history.</param>
        /// <param name="producers">The producers.</param>
        /// <param name="products">The products.</param>
        public StatisticsService(List<ExpenseRecord> history, List<Producer> producers, List<Product> products)
        {
            _history = history;
            _producers = producers;
            _products = products;
        }

        /// <summary>
        /// Gets the top producers.
        /// </summary>
        /// <param name="start">The start.</param>
        /// <param name="end">The end.</param>
        /// <returns></returns>
        public List<TopProducerResult> GetTopProducers(DateTime? start, DateTime? end)
        {
            var q = _history.AsQueryable();

            if (start.HasValue) q = q.Where(x => x.Date >= start);
            if (end.HasValue) q = q.Where(x => x.Date <= end);

            return q
                .GroupBy(x => x.ProducerId)
                .Select(g => new TopProducerResult
                {
                    ProducerId = g.Key,
                    ProducerName = _producers.First(p => p.Id == g.Key).Name,
                    TotalAmount = g.Sum(x => x.TotalAmount)
                })
                .OrderByDescending(x => x.TotalAmount)
                .ToList();
        }

        /// <summary>
        /// Gets the monthly summary.
        /// </summary>
        /// <returns></returns>
        public List<MonthlySummaryResult> GetMonthlySummary()
        {
            return _history
                .GroupBy(x => new { x.Date.Year, x.Date.Month })
                .Select(g => new MonthlySummaryResult
                {
                    Year = g.Key.Year,
                    Month = g.Key.Month,
                    TotalAmount = g.Sum(x => x.TotalAmount)
                })
                .ToList();
        }

        /// <summary>
        /// Gets the month with more consumption.
        /// </summary>
        /// <returns></returns>
        public MonthlySummaryResult? GetMonthWithMoreConsumption()
        {
            return GetMonthlySummary()
                .OrderByDescending(x => x.TotalAmount)
                .FirstOrDefault();
        }

        /// <summary>
        /// Gets the top products.
        /// </summary>
        /// <param name="start">The start.</param>
        /// <param name="end">The end.</param>
        /// <returns></returns>
        public List<TopProductResult> GetTopProducts(DateTime? start, DateTime? end)
        {
            var q = _history.AsQueryable();

            if (start.HasValue) q = q.Where(x => x.Date >= start);
            if (end.HasValue) q = q.Where(x => x.Date <= end);

            return q
                .GroupBy(x => x.ProductId)
                .Select(g => new TopProductResult
                {
                    ProductId = g.Key,
                    ProductName = _products.First(p => p.Id == g.Key).Name,
                    TotalQuantity = g.Sum(x => x.Quantity)
                })
                .OrderByDescending(x => x.TotalQuantity)
                .ToList();
        }
    }
}

