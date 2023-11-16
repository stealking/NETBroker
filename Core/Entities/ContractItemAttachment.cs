using System.ComponentModel.DataAnnotations;

namespace Core.Entities
{
    public class ContractItemAttachment
    {
        public ContractItemAttachment(string? filePath, string? fileName, string? fileType)
        {
            FilePath = filePath;
            FileName = fileName;
            FileType = fileType;
        }

        public int Id { get; init; }
        public string? FilePath { get; set; }
        public string? FileName { get; set; }
        public string? FileType { get; set; }

        public int? ContractItemId { get; set; }
        public ContractItem? ContractItem { get; set; }
    }
}
