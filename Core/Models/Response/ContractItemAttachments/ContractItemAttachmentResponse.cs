namespace Core.Models.Response.ContractItemAttachments
{
    public class ContractItemAttachmentResponse
    {
        public int Id { get; init; }
        public string? FilePath { get; private set; }
        public string? FileName { get; private set; }
        public string? FileType { get; private set; }
    }
}
