using Core.Models.Response.Reports;

namespace Core.Services
{
    public interface IReportService
    {
        Task<SummaryDashBoardReport> GetSummaryDashBoardReport(int year);
    }
}
