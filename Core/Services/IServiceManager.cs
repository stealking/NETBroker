namespace Core.Services
{
    public interface IServiceManager
    {
        IUserService UserService { get; }
        ISupplierService SupplierService { get; }
    }
}
