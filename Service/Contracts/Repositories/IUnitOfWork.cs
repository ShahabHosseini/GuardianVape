namespace Service.Contracts.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        Task Commit();
        IAddressRepository Address { get; }
        IBodyRepository Body { get; }
        ICategoryRepository Category { get; }
        ICollectionRepository Collection { get; }
        ICollectionTypeRepository CollectionType { get; }
        IConditionTypeRepository ConditionType { get; }

        ICommonRepository Common { get; }
        IConditionRepository Condition { get; }
        ICustomerRepository Customer { get; }
        IInventoryRepository Inventory { get; }
        IMediumRepository Medium { get; }
        IOrderRepository Order { get; }
        IProductRepository Product { get; }
        ITagRepository Tag { get; }
        IUserRepository User { get; }
        IVariantRepository Variant { get; }
        IVendorRepository Vendor { get; }
        IFileRepository File { get; }
        ICountryRepository Country { get; }
    }
}
