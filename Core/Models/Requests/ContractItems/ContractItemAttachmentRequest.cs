using Core.Attributes;
using Core.Entities.Enums;
using Microsoft.AspNetCore.Http;

namespace Core.Models.Requests.ContractItems
{
    public class ContractItemAttachmentRequest : IRequest
    {
        public int Id { get; set; }

        [FileType(FileTypes.PDF, FileTypes.JPEG, FileTypes.PNG, FileTypes.DOCX)]
        [MaxFileSize(2147483648)]
        public IFormFile? FileData { get; set; }

        public string? FileType => Path.GetExtension(FileData?.FileName);
    }
}
