using Core.ActionFilters;
using Core.Models.Requests.Contracts;
using Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace NETBroker.Controllers
{
    [Route("api/contracts")]
    public class ContractController : ApiControllerBase
    {
        private readonly IServiceManager serviceManager;
        public ContractController(IServiceManager serviceManager)
        {
            this.serviceManager = serviceManager;
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> Get([FromQuery] ContractParameters parameters)
        {
            var contracts = await serviceManager.ContractService.GetAll(parameters);
            return CreateSuccessResult(contracts);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var contract = await serviceManager.ContractService.GetById(id);
            return CreateSuccessResult(contract);
        }

        [HttpPost]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [Route("")]
        public async Task<IActionResult> Create([FromBody] ContractRequest request)
        {
            var result = await serviceManager.ContractService.Create(request);
            return CreateSuccess();
        }

        [HttpPut]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [Route("")]
        public async Task<IActionResult> Update([FromBody] ContractUpdateRequest request)
        {
            await serviceManager.ContractService.Update(request);
            return CreateSuccess();
        }
    }
}
