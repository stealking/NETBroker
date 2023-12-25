using AutoMapper;
using AutoMapper.QueryableExtensions;
using Core.Entities.Enums;
using Core.Models.Response.Reports;
using Core.Repositories;
using Core.Services;
using Microsoft.EntityFrameworkCore;

namespace Domain.Services
{
    public class ReportService : IReportService
    {
        private readonly IRepositoryManager repositoryManager;
        private readonly IMapper mapper;

        public ReportService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            this.repositoryManager = repositoryManager;
            this.mapper = mapper;
        }

        public async Task<SummaryDashBoardReport> GetSummaryDashBoardReport(int year)
        {
            try
            {
                var selectYearStartDate = new DateTime(year - 1, 01, 01);
                var selectYearEndDate = new DateTime(year, 12, 12);
                var lastYearStartDate = selectYearStartDate.AddYears(-1);
                var lastYearEndDate = selectYearEndDate.AddYears(-1);

                var contractItems = await repositoryManager.ContractItem.FindByCondition(x => x.Status != Status.Rejected
                    && x.Status != Status.Assumed && lastYearStartDate <= x.StartDate && x.StartDate <= selectYearEndDate)
                    .ProjectTo<SummaryDashBoardReportDTO>(mapper.ConfigurationProvider)
                    .ToListAsync();

                //Total annual margin
                var totalAnnualMargin = contractItems.Where(x => selectYearStartDate <= x.StartDate && x.StartDate <= selectYearEndDate).Sum(x => x.AnnualUsage);
                var totalAnnualMarginLastYear = contractItems.Where(x => lastYearStartDate <= x.StartDate && x.StartDate <= lastYearEndDate).Sum(x => x.AnnualUsage);
                var percentTotalAnnualMargin = totalAnnualMarginLastYear == 0 ? 0 : ((totalAnnualMargin - totalAnnualMarginLastYear) * 100m / totalAnnualMarginLastYear);
                var totalAnnualMarginCard = new CardReportResponse(totalAnnualMargin, totalAnnualMarginLastYear, Math.Round(percentTotalAnnualMargin, 3, MidpointRounding.AwayFromZero));

                //Average annual margin
                var averageAnnualMargin = totalAnnualMargin / 12;
                var averageAnnualMarginLastYear = totalAnnualMarginLastYear / 12;
                var percentAverageAnnualMargin = averageAnnualMarginLastYear == 0 ? 0 : Math.Round((averageAnnualMargin - averageAnnualMarginLastYear) * 100m / averageAnnualMarginLastYear, 3, MidpointRounding.AwayFromZero);
                var averageAnnualMarginCard = new CardReportResponse(averageAnnualMargin, averageAnnualMarginLastYear, percentAverageAnnualMargin);

                //Total contract margin
                var totalContractMargin = contractItems.Where(x => selectYearStartDate <= x.StartDate && x.StartDate <= selectYearEndDate).Sum(x => x.ContractMargin);
                var totalContractMarginLastYear = contractItems.Where(x => lastYearStartDate <= x.StartDate && x.StartDate <= lastYearEndDate).Sum(x => x.ContractMargin);
                var percentTotalContractMargin = totalContractMarginLastYear == 0 ? 0 : Math.Round((totalContractMargin - totalContractMarginLastYear) * 100 / totalContractMarginLastYear, 3, MidpointRounding.AwayFromZero);
                var totalContractMarginCard = new CardReportResponse(totalContractMargin, totalContractMarginLastYear, percentTotalContractMargin);

                //Average contract margin
                var averageContractMargin = totalContractMargin / 12;
                var averageContractMarginLastYear = totalContractMarginLastYear / 12;
                var percentAverageContractMargin = averageContractMarginLastYear == 0 ? 0 : Math.Round((averageContractMargin - averageContractMarginLastYear) * 100m / averageContractMarginLastYear, 3, MidpointRounding.AwayFromZero);
                var averageContractMarginCard = new CardReportResponse(averageContractMargin, averageContractMarginLastYear, percentAverageContractMargin);

                var response = new SummaryDashBoardReport(totalAnnualMarginCard, averageAnnualMarginCard, totalContractMarginCard, averageContractMarginCard);

                //get top 10 supplier
                var top10Supplier = contractItems.GroupBy(x => new { x.SupplierId, x.SupplierName })
                    .Select(s => new { s.Key, Total = s.Sum(x => x.ContractMargin) })
                    .OrderByDescending(x => x.Total)
                    .Take(10)
                    .Select(s => new ChartReportResponse(s.Key.SupplierName, s.Total));

                response.TopSupplier.AddRange(top10Supplier);

                for (int i = 1; i <= 12; i++)
                {
                    var annualMarginOfMonth = contractItems.Where(x => x.StartDate.Month == i && x.StartDate.Year == year).Sum(x => x.AnnualUsage);
                    var contractMarginOfMonth = contractItems.Where(x => x.StartDate.Month == i & x.StartDate.Year == year).Sum(x => x.ContractMargin);
                    response.AnnualMarginTrafic.Add(new ChartReportResponse(i.ToString(), annualMarginOfMonth));
                    response.ContractMarginTrafic.Add(new ChartReportResponse(i.ToString(), contractMarginOfMonth));
                }
                return response;
            }
            catch (Exception ex)
            {

                throw;
            }
         
        }
    }
}
