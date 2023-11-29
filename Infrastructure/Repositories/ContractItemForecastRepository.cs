using Core.Entities;
using Core.Repositories;
using Infrastructure.Context;

namespace Infrastructure.Repositories
{
    internal class ContractItemForecastRepository : RepositoryBase<ContractItemForecast>, IContractItemForecastRepository
    {
        public ContractItemForecastRepository(DataContext dataContext) : base(dataContext)
        {
        }
    }
}
