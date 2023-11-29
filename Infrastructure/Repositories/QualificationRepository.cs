using Core.Entities;
using Core.Repositories;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Infrastructure.Repositories
{
    public class QualificationRepository : RepositoryBase<Qualification>, IQualificationRepository
    {
        public QualificationRepository(DataContext dataContext) : base(dataContext)
        {
        }

        public IQueryable<AnnualUssageQualification> GetAnnualUssageQualifications(Expression<Func<AnnualUssageQualification, bool>> expressionparams, params Expression<Func<AnnualUssageQualification, object>>[] includes)
        {
            var query = DataContext.Set<Qualification>().OfType<AnnualUssageQualification>().Where(expressionparams);
            if (includes != null)
            {
                query = includes.Aggregate(query,
                          (current, include) => current.Include(include));
            }

            return query;
        }

        public IQueryable<ExpirationQualification> GetExpirationQualifications(Expression<Func<ExpirationQualification, bool>> expressionparams, params Expression<Func<ExpirationQualification, object>>[] includes)
        {
            var query = DataContext.Set<Qualification>().OfType<ExpirationQualification>().Where(expressionparams);
            if (includes != null)
            {
                query = includes.Aggregate(query,
                          (current, include) => current.Include(include));
            }

            return query;
        }
    }
}
