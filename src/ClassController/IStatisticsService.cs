using ClassModels;

namespace ClassController
{
    public interface IStatisticsService
    {
        List<TopProducerResult> GetTopProducers(DateTime? start, DateTime? end);
        List<MonthlySummaryResult> GetMonthlySummary();
        MonthlySummaryResult? GetMonthWithMoreConsumption();
        List<TopProductResult> GetTopProducts(DateTime? start, DateTime? end);
    }
}

