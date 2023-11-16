using Core.Repositories;
using Infrastructure.Context;

namespace Infrastructure.Repositories
{
    public sealed class RepositoryManager : IRepositoryManager
    {
        private readonly DataContext dataContext;
        private readonly Lazy<IUserRepository> userRepository;
        private readonly Lazy<ISupplierRepository> supplierRepository;
        private readonly Lazy<IContractRepository> contractRepository;
        private readonly Lazy<IContractItemRepository> contractItemRepository;
        private readonly Lazy<IContactRepository> contactRepository;
        private readonly Lazy<IContractItemAttachmentRepository> contractItemAttachmentRepository;
        public RepositoryManager(DataContext dataContext)
        {
            this.dataContext = dataContext;
            userRepository = new Lazy<IUserRepository>(() => new UserRepository(dataContext));
            supplierRepository = new Lazy<ISupplierRepository>(() => new SupplierRepository(dataContext));
            contractRepository = new Lazy<IContractRepository>(() => new ContractRepository(dataContext));
            contractItemRepository = new Lazy<IContractItemRepository>(() => new ContractItemRepository(dataContext));
            contactRepository = new Lazy<IContactRepository>(() => new ContactRepository(dataContext));
            contractItemAttachmentRepository = new Lazy<IContractItemAttachmentRepository>(() => new ContractItemAttachmentRepository(dataContext));
        }

        public IUserRepository User => userRepository.Value;
        public ISupplierRepository Supplier => supplierRepository.Value;
        public IContractRepository Contract => contractRepository.Value;
        public IContractItemRepository ContractItem => contractItemRepository.Value;
        public IContactRepository Contact => contactRepository.Value;

        public IContractItemAttachmentRepository ContractItemAttachment => contractItemAttachmentRepository.Value;

        public async Task SaveAsync() => await dataContext.SaveChangesAsync();
    }
}
