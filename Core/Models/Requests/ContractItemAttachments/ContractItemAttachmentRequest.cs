using Core.Attributes;
using Core.Entities.Enums;
using Microsoft.AspNetCore.Http;

namespace Core.Models.Requests.ContractItemAttachments
{
    public class ContractItemAttachmentRequest : IRequest
    {
        public int Id { get; set; }

        [FileType(FileTypes.PDF, FileTypes.JPG, FileTypes.JPEG, FileTypes.PNG, FileTypes.DOCX, FileTypes.MP4)]
        [MaxFileSize(2147483648)]
        public IFormFile? FileData { get; set; }

        public string? FileType => Path.GetExtension(FileData?.FileName);
    }
}
