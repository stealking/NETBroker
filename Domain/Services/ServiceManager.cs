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
        private readonly Lazy<IContractService> _contractService;
        private readonly Lazy<IContractItemService> _contractItemService;
        private readonly Lazy<IContactService> _contactService;

        public ServiceManager(IRepositoryManager repositoryManager, UserManager<UserProfile> userManager, AppSettings appSettings, IMapper mapper)
        {
            _userService = new Lazy<IUserService>(() => new UserService(repositoryManager, userManager, mapper));
            _supplierService = new Lazy<ISupplierService>(() => new SupplierService(repositoryManager, mapper));
            _authenticationService = new Lazy<IAuthenticationService>(() => new AuthenticationService(userManager, appSettings, mapper));
            _contractService = new Lazy<IContractService>(() => new ContractService(repositoryManager, mapper));
            _contractItemService = new Lazy<IContractItemService>(() => new ContractItemService(repositoryManager, mapper));
            _contactService = new Lazy<IContactService>(() => new ContactService(repositoryManager, mapper));
        }
        public IUserService UserService => _userService.Value;
        public ISupplierService SupplierService => _supplierService.Value;
        public IAuthenticationService AuthenticationService => _authenticationService.Value;
        public IContractService ContractService => _contractService.Value;
        public IContractItemService ContractItemService => _contractItemService.Value;
        public IContactService ContactService => _contactService.Value;
    }
}
