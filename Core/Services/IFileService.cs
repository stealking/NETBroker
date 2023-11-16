using Microsoft.AspNetCore.Http;

namespace Core.Services
{
    public interface IFileService
    {
        Task<string> UploadFileAsync(IFormFile? file, string folderName);

        Task UploadMultiFileAsync(List<IFormFile> files);

        Task<(byte[], string, string)> DownloadFileById(int id);
    }
}
