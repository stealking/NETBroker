using Core.Entities;

namespace Core.Services
{
    public interface ISupplierService : IServiceBase<Supplier>
    {
        Task<Supplier?> GetById(int id);
    }
}
