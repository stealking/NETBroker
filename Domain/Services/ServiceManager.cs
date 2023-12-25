using AutoMapper;
using Core.Entities;
using Core.Repositories;
using Core.Services;
using Core.Settings;
using Microsoft.AspNetCore.Http;
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
        private readonly Lazy<IFileService> _fileService;
        private readonly Lazy<IContractItemAttachmentService> _contractItemAttachmentService;
        private readonly Lazy<IReportService> _reportService;

        public ServiceManager(IRepositoryManager repositoryManager, UserManager<UserProfile> userManager, AppSettings appSettings, IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            _userService = new Lazy<IUserService>(() => new UserService(repositoryManager, userManager, mapper));
            _fileService = new Lazy<IFileService>(() => new FileService(repositoryManager));
            _supplierService = new Lazy<ISupplierService>(() => new SupplierService(repositoryManager, mapper));
            _authenticationService = new Lazy<IAuthenticationService>(() => new AuthenticationService(userManager, appSettings, mapper));
            _contractService = new Lazy<IContractService>(() => new ContractService(repositoryManager, mapper, httpContextAccessor, this));
            _contractItemService = new Lazy<IContractItemService>(() => new ContractItemService(repositoryManager, mapper, _fileService.Value));
            _contactService = new Lazy<IContactService>(() => new ContactService(repositoryManager, mapper));
            _contractItemAttachmentService = new Lazy<IContractItemAttachmentService>(() => new ContractItemAttachmentService(repositoryManager, mapper));
            _reportService = new Lazy<IReportService>(() => new ReportService(repositoryManager, mapper));
        }
        public IUserService UserService => _userService.Value;
        public ISupplierService SupplierService => _supplierService.Value;
        public IAuthenticationService AuthenticationService => _authenticationService.Value;
        public IContractService ContractService => _contractService.Value;
        public IContractItemService ContractItemService => _contractItemService.Value;
        public IContactService ContactService => _contactService.Value;
        public IFileService FileService => _fileService.Value;
        public IContractItemAttachmentService ContractItemAttachmentService => _contractItemAttachmentService.Value;

        public IReportService ReportService => _reportService.Value;
    }
}
