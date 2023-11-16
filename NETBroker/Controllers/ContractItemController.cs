using Core.ActionFilters;
using Core.Models.Requests.ContractItems;
using Core.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace NETBroker.Controllers
{
    [Route("api/contractitems")]
    public class ContractItemController : ApiControllerBase
    {
        private readonly IServiceManager serviceManager;
        public ContractItemController(IServiceManager serviceManager)
        {
            this.serviceManager = serviceManager;
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAll([FromQuery] ContractItemParameters parameters)
        {
            var contract = await serviceManager.ContractItemService.GetAll(parameters);
            return CreateSuccessResult(contract);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var contractItem = await serviceManager.ContractItemService.GetById(id);
            return contractItem == null ? CreateFailResult("ContractItem not found!") : CreateSuccessResult(contractItem);
        }

        [HttpPost]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [Route("")]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> Create([FromForm] ContractItemRequest request)
        {
            var result = await serviceManager.ContractItemService.Create(request);
            return result ? CreateSuccess() : CreateFailResult("Create failed!");
        }

        [HttpPut]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [Route("")]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> Update([FromForm] ContractItemRequest request)
        {
            await serviceManager.ContractItemService.Update(request);
            return CreateSuccess();
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await serviceManager.ContractItemService.Delete(id);
            return CreateSuccess();
        }
    }
}
