using DataAccess.Context;
using DataAccess.Implementations.Repositories;
using Service.Contracts.Repositories;

namespace DataAccess.Implementations
{
    public class UnitOfWork:IUnitOfWork
    {
        readonly GVDbContext _context;
        public UnitOfWork(GVDbContext context) 
        {
            _context = context;
            Address=new AddressRepository(_context);
            Body=new BodyRepository(_context);
            Category=new CategoryRepository(_context);
            Collection=new CollectionRepository(_context);
            Common=new CommonRepository(_context);
            Condition=new ConditionRepository(_context);
            Customer=new CustomerRepository(_context);
            Inventory=new InventoryRepository(_context);
            Medium=new MediumRepository(_context);
            Order=new OrderRepository(_context);
            Product=new ProductRepository(_context);
            Tag=new TagRepository(_context);
            User=new UserRepository(_context);
            Variant =new VariantRepository(_context);
            Vendor=new VendorRepository(_context);
        }

        public IAddressRepository Address { get; private set; }

        public IBodyRepository Body { get; private set; }

        public ICategoryRepository Category { get; private set; }

        public ICollectionRepository Collection { get; private set; }

        public ICommonRepository Common { get; private set; }

        public IConditionRepository Condition { get; private set; }

        public ICustomerRepository Customer { get; private set; }

        public IInventoryRepository Inventory { get; private set; }

        public IMediumRepository Medium { get; private set; }

        public IOrderRepository Order { get; private set; }

        public IProductRepository Product { get; private set; }

        public ITagRepository Tag { get; private set; }

        public IUserRepository User { get; private set; }

        public IVariantRepository Variant { get; private set; }

        public IVendorRepository Vendor { get; private set; }

        public async Task Commit()
        {
         await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
