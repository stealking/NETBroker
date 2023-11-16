using Core.Extensions;
using Core.Repositories;
using Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.StaticFiles;

namespace Domain.Services
{
    public class FileService : IFileService
    {
        private readonly IRepositoryManager repositoryManager;
        public FileService(IRepositoryManager repositoryManager)
        {
            this.repositoryManager = repositoryManager;
        }

        public async Task<(byte[], string, string)> DownloadFileById(int id)
        {
            var item = await repositoryManager.ContractItemAttachment.FindById(id);
            if (item == null) 
                throw new ArgumentNullException("File not exists!");

            var filePath = CommonExtensions.GetFilePath(item?.FilePath ?? "");
            if (!File.Exists(filePath)) 
                throw new ArgumentNullException("File not exists!");

            var provider = new FileExtensionContentTypeProvider();
            if (!provider.TryGetContentType(filePath, out var contentType))
            {
                contentType = "application/octet-stream";
            }
            var readAllBytesAsync = await File.ReadAllBytesAsync(filePath);
            return (readAllBytesAsync, contentType, Path.GetFileName(filePath));
        }

        public async Task<string> UploadFileAsync(IFormFile? file, string folderNmae)
        {
            try
            {
                if (file?.Length > 0)
                {
                    var folderPath = Path.Combine(CommonExtensions.GetStaticContentDirectory(), folderNmae);
                    if (!Directory.Exists(folderPath))
                    {
                        Directory.CreateDirectory(folderPath);
                    }
                    var url = Path.Combine(folderPath, file.FileName);
                    using (var fileStream = new FileStream(url, FileMode.Create))
                    {
                        await file.CopyToAsync(fileStream);
                    }
                    return url;
                }
                else
                {
                    return string.Empty;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("File Copy Failed", ex);
            }
        }

        public Task UploadMultiFileAsync(List<IFormFile> files)
        {
            throw new NotImplementedException();
        }
    }
}
