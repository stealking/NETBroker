namespace Core.Models.Response.Reports
{
    public class ChartReportResponse
    {
        public ChartReportResponse()
        {
            
        }

        public ChartReportResponse(string? name, decimal value)
        {
            Name = name;
            Value = value;
        }

        public string? Name { get; set; }
        public decimal Value { get; set; }
    }
}
