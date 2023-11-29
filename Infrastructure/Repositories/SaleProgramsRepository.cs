using Core.Entities;
using Core.Repositories;
using Infrastructure.Context;

namespace Infrastructure.Repositories
{
    public class SaleProgramsRepository : RepositoryBase<SaleProgram>, ISaleProgramsRepository
    {
        public SaleProgramsRepository(DataContext dataContext) : base(dataContext)
        {
        }
    }
}
