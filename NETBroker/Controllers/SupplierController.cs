using Core.ActionFilters;
using Core.Models.Requests.Suppliers;
using Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace NETBroker.Controllers
{
    [Route("api/suppliers")]
    public class SupplierController : ApiControllerBase
    {
        private readonly IServiceManager serviceManager;
        public SupplierController(IServiceManager serviceManager)
        {
            this.serviceManager = serviceManager;
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAll([FromQuery] SupplierParameters supplierParameters)
        {
            var result = await serviceManager.SupplierService.GetAll(supplierParameters);
            return CreateSuccessResult(result);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await serviceManager.SupplierService.GetById(id);
            if (result == null)
            {
                return CreateFailResult("Supplier not found.", StatusCodes.Status404NotFound);
            }

            return CreateSuccessResult(result);
        }

        [HttpPost]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [Route("")]
        public async Task<IActionResult> Create([FromBody] SupplierRequest request)
        {
            var result = await serviceManager.SupplierService.Create(request);
            return result ? CreateSuccess() : CreateFailResult("Create supplier failed!");
        }

        [HttpPut]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [Route("")]
        public async Task<IActionResult> Update([FromBody] SupplierUpdateRequest request)
        {
            await serviceManager.SupplierService.Update(request);
            return CreateSuccess();
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await serviceManager.SupplierService.Delete(id);
            return CreateSuccess();
        }
    }
}
