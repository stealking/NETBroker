using Core.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace NETBroker.Controllers
{
    [AllowAnonymous]
    [Route("api/reports")]
    public class ReportController : ApiControllerBase
    {

        private readonly IServiceManager serviceManager;
        public ReportController(IServiceManager serviceManager)
        {
            this.serviceManager = serviceManager;
        }

        [HttpGet]
        [Route("summary-dashboard")]
        public async Task<IActionResult> SummaryDashBoard(int year)
        {
            var result= await serviceManager.ReportService.GetSummaryDashBoardReport(year);
            return CreateSuccessResult(result);
        }
    }
}
