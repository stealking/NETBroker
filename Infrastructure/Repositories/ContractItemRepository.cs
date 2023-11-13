using Core.Entities;
using Core.Repositories;
using Infrastructure.Context;

namespace Infrastructure.Repositories
{
    internal class ContractItemRepository : RepositoryBase<ContractItem>, IContractItemRepository
    {
        public ContractItemRepository(DataContext dataContext) : base(dataContext)
        {
        }
    }
}
