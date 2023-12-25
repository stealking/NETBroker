namespace Core.Models.Response.Reports
{
    public class SummaryDashBoardReport
    {
        public SummaryDashBoardReport()
        {
            
        }
        public SummaryDashBoardReport(CardReportResponse totalAnnualMargin, CardReportResponse averageAnnualMargin, CardReportResponse totalContractMargin, CardReportResponse averageContractMargin)
        {
            TotalAnnualMargin = totalAnnualMargin;
            AverageAnnualMargin = averageAnnualMargin;
            TotalContractMargin = totalContractMargin;
            AverageContractMargin = averageContractMargin;
        }

        public CardReportResponse TotalAnnualMargin { get; private set; } = new CardReportResponse();
        public CardReportResponse AverageAnnualMargin { get; private set; } = new CardReportResponse();
        public CardReportResponse TotalContractMargin { get; private set; } = new CardReportResponse();
        public CardReportResponse AverageContractMargin { get; private set; } = new CardReportResponse();
        public List<ChartReportResponse> TopSupplier { get; set; } = new List<ChartReportResponse>();
        public List<ChartReportResponse> AnnualMarginTrafic { get; set; } = new List<ChartReportResponse>();
        public List<ChartReportResponse> ContractMarginTrafic { get; set; } = new List<ChartReportResponse>();
    }


    public class SummaryDashBoardReportDTO
    {
        public decimal AnnualUsage { get; set; }
        public decimal ContractMargin { get; set; }
        public DateTime StartDate { get; set; }
        public int SupplierId { get; set; }
        public string? SupplierName { get; set; }
    }
}
