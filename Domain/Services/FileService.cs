using Core.Extensions;
using Core.Repositories;
using Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.StaticFiles;
using System.IO.Compression;

namespace Domain.Services
{
    public class FileService : IFileService
    {
        private readonly IRepositoryManager repositoryManager;
        public FileService(IRepositoryManager repositoryManager)
        {
            this.repositoryManager = repositoryManager;
        }

        public async Task<(byte[], string, string)> DownloadFile(string filePath)
        {
            var fullPath = CommonExtensions.GetFilePath(filePath);
            if (!File.Exists(fullPath))
                throw new ArgumentNullException("File not exists!");

            var provider = new FileExtensionContentTypeProvider();
            if (!provider.TryGetContentType(fullPath, out var contentType))
            {
                contentType = "application/octet-stream";
            }
            var readAllBytesAsync = await File.ReadAllBytesAsync(fullPath);
            return (readAllBytesAsync, contentType, Path.GetFileName(fullPath));
        }

        public async Task<(byte[], string, string)> DownloadZipFiles(List<string?> filesPath)
        {
            var archiveFileName = Path.Combine(CommonExtensions.GetStaticContentDirectory(), $"{Guid.NewGuid()}.zip");

            try
            {
                if (filesPath.Count == 0)
                    throw new ArgumentNullException("No file exist!");

                bool fileExist = false;
                using (var archive = ZipFile.Open(archiveFileName, ZipArchiveMode.Create))
                {

                    foreach (var filePath in filesPath)
                    {
                        var fullPath = CommonExtensions.GetFilePath(filePath ?? "");
                        if (!File.Exists(fullPath))
                            continue;

                        fileExist = true;
                        FileInfo fileInfo = new FileInfo(fullPath);
                        archive.CreateEntryFromFile(fileInfo.FullName, fileInfo.Name);
                    }
                }

                if (!fileExist)
                    throw new ArgumentNullException("No file exist!");

                var provider = new FileExtensionContentTypeProvider();
                if (!provider.TryGetContentType(archiveFileName, out var contentType))
                {
                    contentType = "application/x-zip-compressed";
                }
                var readAllBytesAsync = await File.ReadAllBytesAsync(archiveFileName);
                return (readAllBytesAsync, contentType, Path.GetFileName(archiveFileName));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (File.Exists(archiveFileName))
                {
                    File.Delete(archiveFileName);
                }
            }
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
                    return Path.Combine(folderNmae, file.FileName);
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
