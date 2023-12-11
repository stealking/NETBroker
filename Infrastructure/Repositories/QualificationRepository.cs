using Core.Entities;
using Core.Repositories;
using Infrastructure.Context;

namespace Infrastructure.Repositories
{
    public class QualificationRepository : RepositoryBase<Qualification>, IQualificationRepository
    {
        public QualificationRepository(DataContext dataContext) : base(dataContext)
        {
        }
    }
}
