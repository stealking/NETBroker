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
        public string? FilePath { get; private set; }
        public string? FileName { get; private set; }
        public string? FileType { get; private set; }

        public int? ContractItemId { get; private set; }
        public ContractItem? ContractItem { get; private set; }
    }
}
