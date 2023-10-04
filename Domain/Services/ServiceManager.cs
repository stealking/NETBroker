using Core.Repositories;
using Core.Services;
using Core.Settings;

namespace Domain.Services
{
    public sealed class ServiceManager : IServiceManager
    {
        private readonly Lazy<IUserService> _userService;
        private readonly Lazy<ISupplierService> _supplierService;
        private readonly Lazy<IAuthenticationService> _authenticationService;

        public ServiceManager(IRepositoryManager repositoryManager, AppSettings appSettings)
        {
            _userService = new Lazy<IUserService>(() => new UserService(repositoryManager));
            _supplierService = new Lazy<ISupplierService>(() => new SupplierService(repositoryManager));
            _authenticationService = new Lazy<IAuthenticationService>(() => new AuthenticationService(appSettings));
        }
        public IUserService UserService => _userService.Value;
        public ISupplierService SupplierService => _supplierService.Value;
        public IAuthenticationService AuthenticationService => _authenticationService.Value;
    }
}
