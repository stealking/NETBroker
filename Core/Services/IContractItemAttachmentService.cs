using Core.Models.Response.ContractItemAttachments;

namespace Core.Services
{
    public interface IContractItemAttachmentService
    {
        Task<ContractItemAttachmentResponse?> Find(int id);
        Task<List<ContractItemAttachmentResponse>> FindAttachments(int contractItemId);

    }
}
