using Core.Repositories;
using Infrastructure.Context;

namespace Infrastructure.Repositories
{
    public sealed class RepositoryManager : IRepositoryManager
    {
        private readonly DataContext dataContext;
        private readonly Lazy<IUserRepository> userRepository;
        private readonly Lazy<ISupplierRepository> supplierService;
        public RepositoryManager(DataContext dataContext)
        {
            this.dataContext = dataContext;
            userRepository = new Lazy<IUserRepository>(() => new UserRepository(dataContext));
            supplierService = new Lazy<ISupplierRepository>(() => new SupplierRepository(dataContext));
        }

        public IUserRepository User => userRepository.Value;
        public ISupplierRepository Supplier => supplierService.Value;

        public async Task SaveAsync() => await dataContext.SaveChangesAsync();
    }
}
