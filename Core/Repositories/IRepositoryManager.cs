namespace Core.Repositories
{
    public interface IRepositoryManager
    {
        IUserRepository User { get; }
        ISupplierRepository Supplier { get; }
        IContractRepository Contract { get; }
        IContractItemRepository ContractItem { get; }
        IContactRepository Contact { get; }
        IContractItemAttachmentRepository ContractItemAttachment { get; }
        Task SaveAsync();
    }
}
