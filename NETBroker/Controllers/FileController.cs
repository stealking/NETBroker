using Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace NETBroker.Controllers
{
    [Route("files")]
    public class FileController : ApiControllerBase
    {
        private readonly IServiceManager serviceManager;
        public FileController(IServiceManager serviceManager)
        {
            this.serviceManager = serviceManager;
        }

        [HttpGet]
        [Route("download/{id}")]
        public async Task<IActionResult> Download(int id)
        {
            var result = await serviceManager.FileService.DownloadFileById(id);
            return File(result.Item1, result.Item2, result.Item3);
        }
    }
}
