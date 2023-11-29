namespace Core.Entities
{
    public class ContractItemForecast
    {
        public ContractItemForecast(int id, decimal amount, DateTime forecastDate, int forecastMonth, int forecastYear, string? forecastMonthOfYear)
        {
            Id = id;
            Amount = amount;
            ForecastDate = forecastDate;
            ForecastMonth = forecastMonth;
            ForecastYear = forecastYear;
            ForecastMonthOfYear = forecastMonthOfYear;
        }

        public int Id { get; init; }
        public decimal Amount { get; private set; }
        public DateTime ForecastDate { get; private set; }
        public int ForecastMonth { get; private set; }
        public int ForecastYear { get; private set; }
        public string? ForecastMonthOfYear { get; private set; }

        public int? ContractItemId { get; private set; }
        public ContractItem? ContractItem { get; private set; }
    }
}
