using Core.Models.Requests;
using Core.Models.Requests.Suppliers;
using Core.Models.Response.Suppliers;

namespace Core.Services
{
    public interface ISupplierService : IServiceBase<SupplierResponse, IRequest, SupplierParameters>
    {
    }
}
