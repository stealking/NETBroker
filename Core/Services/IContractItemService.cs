using Core.Models.Requests;
using Core.Models.Requests.ContractItems;
using Core.Models.Response.ContractItems;

namespace Core.Services
{
    public interface IContractItemService : IServiceBase<ContractItemResponse, IRequest, ContractItemParameters>
    {
    }
}
