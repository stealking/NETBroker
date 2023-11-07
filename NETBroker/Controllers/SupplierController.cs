using AutoMapper;
using Core.ActionFilters;
using Core.Entities;
using Core.Models.Requests.Suppliers;
using Core.Models.Response.Suppliers;
using Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace NETBroker.Controllers
{
    [Route("api/suppliers")]
    public class SupplierController : ApiControllerBase
    {
        private readonly IServiceManager serviceManager;
        private readonly IMapper mapper;
        public SupplierController(IServiceManager serviceManager, IMapper mapper)
        {
            this.serviceManager = serviceManager;
            this.mapper = mapper;
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAll([FromQuery] SupplierParameters supplierParameters)
        {
            var result = await serviceManager.SupplierService.GetSuppliersAsync(supplierParameters);
            return CreateSuccessResult(mapper.Map<List<SupplierResponse>>(result));
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

            return CreateSuccessResult(mapper.Map<SupplierResponse>(result));
        }

        [HttpPost]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [Route("")]
        public async Task<IActionResult> Create([FromBody] SupplierRegisterRequest request)
        {
            var supplier = mapper.Map<Supplier>(request);
            var result = await serviceManager.SupplierService.Create(supplier);
            return result == null ? CreateFailResult("Create supplier failed") : CreateSuccessResult(mapper.Map<SupplierResponse>(result));
        }

        [HttpPut]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [Route("")]
        public async Task<IActionResult> Update([FromBody] SupplierUpdateRequest request)
        {
            var supplier = await serviceManager.SupplierService.GetById(request.Id ?? 0);
            if (supplier == null)
            {
                return CreateFailResult("Supplier not found.");
            }

            mapper.Map(request, supplier);
            await serviceManager.SupplierService.Update(supplier);
            return CreateSuccessResult(mapper.Map<SupplierResponse>(supplier));
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var supplier = await serviceManager.SupplierService.GetById(id);
            if (supplier == null)
            {
                return CreateFailResult("Supplier not found.");
            }

            await serviceManager.SupplierService.Delete(id);
            return CreateSuccess();
        }
    }
}
