using Core.Repositories;
using Core.Services;

namespace Domain.Services
{
    public sealed class ServiceManager : IServiceManager
    {
        private readonly Lazy<IUserService> _userService;
        private readonly Lazy<ISupplierService> _supplierService;

        public ServiceManager(IRepositoryManager repositoryManager)
        {
            _userService = new Lazy<IUserService>(() => new  UserService(repositoryManager));
            _supplierService = new Lazy<ISupplierService>(() => new  SupplierService(repositoryManager));
        }
        public IUserService UserService => _userService.Value;
        public ISupplierService SupplierService => _supplierService.Value;
    }
}
