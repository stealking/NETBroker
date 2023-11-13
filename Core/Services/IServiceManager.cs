namespace Core.Services
{
    public interface IServiceManager
    {
        IUserService UserService { get; }
        ISupplierService SupplierService { get; }
        IAuthenticationService AuthenticationService { get; }
        IContractService ContractService { get; }
        IContractItemService ContractItemService { get; }
        IContactService ContactService { get; }
    }
}
