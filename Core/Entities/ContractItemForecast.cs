namespace Core.Entities
{
    public class ContractItemForecast
    {
        private ContractItemForecast()
        {
            
        }
        public ContractItemForecast(int contractItemId, decimal amount, DateTime forecastDate)
        {
            ContractItemId = contractItemId;
            Amount = amount;
            ForecastDate = forecastDate;
            ForecastMonth = forecastDate.Month;
            ForecastYear = forecastDate.Year;
            ForecastMonthOfYear = forecastDate.ToString("MMMM");
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
