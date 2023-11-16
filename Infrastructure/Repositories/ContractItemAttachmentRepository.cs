using Core.Entities;
using Core.Repositories;
using Infrastructure.Context;

namespace Infrastructure.Repositories
{
    public class ContractItemAttachmentRepository : RepositoryBase<ContractItemAttachment>, IContractItemAttachmentRepository
    {
        public ContractItemAttachmentRepository(DataContext dataContext) : base(dataContext)
        {
        }
    }
}
