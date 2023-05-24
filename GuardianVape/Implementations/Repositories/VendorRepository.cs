using DataAccess.Context;
using Model.Contracts.Repositories;
using Model.Entities;

namespace DataAccess.Implementations.Repositories
{
    public class VendorRepository:GenericRepository<Vendor>,IVendorRepository
    {
        public VendorRepository(GVDbContext context):base(context) 
        {
            
        }
    }
}
