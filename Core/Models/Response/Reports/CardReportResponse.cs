namespace Core.Models.Response.Reports
{
    public class CardReportResponse
    {
        public CardReportResponse()
        {
            
        }

        public CardReportResponse(decimal currentValue, decimal preValue, decimal diffPercent)
        {
            CurrentValue = currentValue;
            PreValue = preValue;
            DiffPercent = diffPercent;
        }

        public decimal CurrentValue { get; private set; }
        public decimal PreValue { get; private set; }
        public decimal DiffPercent { get; private set; }
    }
}
