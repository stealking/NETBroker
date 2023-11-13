using Core.Entities;
using Core.Repositories;
using Infrastructure.Context;

namespace Infrastructure.Repositories
{
    public class ContractRepository : RepositoryBase<Contract>, IContractRepository
    {
        public ContractRepository(DataContext dataContext) : base(dataContext)
        {
        }
    }
}
