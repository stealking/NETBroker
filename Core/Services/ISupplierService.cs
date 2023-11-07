using Core.Entities;
using Core.Models.Requests.Suppliers;

namespace Core.Services
{
    public interface ISupplierService : IServiceBase<Supplier>
    {
        Task<List<Supplier>> GetSuppliersAsync(SupplierParameters supplierParameters);
        Task<Supplier?> GetById(int id);
    }
}
