using AutoMapper;
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
        public async Task<IActionResult> GetAll()
        {
            var result = await serviceManager.SupplierService.GetAll();
            return CreateSuccessResult(result);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await serviceManager.SupplierService.GetById(id);
            if (result == null)
            {
                return CreateFailResult("Supplier not found.");
            }

            return CreateSuccessResult(result);
        }
    }
}
