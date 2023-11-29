using Core.ActionFilters;
using Core.Extensions;
using Core.Models.Requests.ContractItems;
using Core.Services;
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


        [HttpGet]
        [Route("attachments/download/{attachmentId}")]
        public async Task<IActionResult> Download(int attachmentId)
        {
            var item = await serviceManager.ContractItemAttachmentService.Find(attachmentId);
            if (item == null)
                return CreateFailResult("File not exists!");

            var filePath = CommonExtensions.GetFilePath(item?.FilePath ?? "");
            var result = await serviceManager.FileService.DownloadFile(filePath);
            return File(result.Item1, result.Item2, result.Item3);
        }

        [HttpGet]
        [Route("{contractItemId}/attachments/download")]
        public async Task<IActionResult> DownloadAll(int contractItemId)
        {
            var attachments = await serviceManager.ContractItemAttachmentService.FindAttachments(contractItemId);
            var filesPath = attachments?.Select(s => s.FilePath).ToList();
            if (filesPath?.Count() == 0)
                return CreateFailResult($"Contract item id {contractItemId} has no attachments!");

            var result = await serviceManager.FileService.DownloadZipFiles(filesPath ?? new List<string?>());
            return File(result.Item1, result.Item2, result.Item3);
        }
    }
}
