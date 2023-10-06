using AutoMapper;
using Core.Entities;
using Core.Repositories;
using Core.Services;
using Core.Settings;
using Microsoft.AspNetCore.Identity;

namespace Domain.Services
{
    public sealed class ServiceManager : IServiceManager
    {
        private readonly Lazy<IUserService> _userService;
        private readonly Lazy<ISupplierService> _supplierService;
        private readonly Lazy<IAuthenticationService> _authenticationService;

        public ServiceManager(IRepositoryManager repositoryManager, UserManager<UserProfile> userManager, AppSettings appSettings, IMapper mapper)
        {
            _userService = new Lazy<IUserService>(() => new UserService(repositoryManager, userManager));
            _supplierService = new Lazy<ISupplierService>(() => new SupplierService(repositoryManager));
            _authenticationService = new Lazy<IAuthenticationService>(() => new AuthenticationService(userManager, appSettings, mapper));
        }
        public IUserService UserService => _userService.Value;
        public ISupplierService SupplierService => _supplierService.Value;
        public IAuthenticationService AuthenticationService => _authenticationService.Value;
    }
}
