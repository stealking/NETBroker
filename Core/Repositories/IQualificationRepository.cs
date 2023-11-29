using Core.Entities;
using System.Linq.Expressions;

namespace Core.Repositories
{
    public interface IQualificationRepository : IRepositoryBase<Qualification>
    {
        public IQueryable<ExpirationQualification> GetExpirationQualifications(Expression<Func<ExpirationQualification, bool>> expressionparams, params Expression<Func<ExpirationQualification, object>>[] includes);
        public IQueryable<AnnualUssageQualification> GetAnnualUssageQualifications(Expression<Func<AnnualUssageQualification, bool>> expressionparams, params Expression<Func<AnnualUssageQualification, object>>[] includes);
    }
}
