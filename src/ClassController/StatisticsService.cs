using ClassModels;

namespace ClassController
{
    public class StatisticsService : IStatisticsService
    {
        private readonly List<ExpenseRecord> _history;
        private readonly List<Producer> _producers;
        private readonly List<Product> _products;

        public StatisticsService(List<ExpenseRecord> history, List<Producer> producers, List<Product> products)
        {
            _history = history;
            _producers = producers;
            _products = products;
        }

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

        public MonthlySummaryResult? GetMonthWithMoreConsumption()
        {
            return GetMonthlySummary()
                .OrderByDescending(x => x.TotalAmount)
                .FirstOrDefault();
        }

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

