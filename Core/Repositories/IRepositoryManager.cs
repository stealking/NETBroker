namespace Core.Repositories
{
    public interface IRepositoryManager
    {
        IUserRepository User { get; }
        ISupplierRepository Supplier { get; }
        Task SaveAsync();
    }
}
