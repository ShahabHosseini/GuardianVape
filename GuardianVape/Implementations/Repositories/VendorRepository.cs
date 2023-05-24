using DataAccess.Context;
using Model.Entities;
using Service.Contracts.Repositories;

namespace DataAccess.Implementations.Repositories
{
    public class VendorRepository:GenericRepository<Vendor>,IVendorRepository
    {
        public VendorRepository(GVDbContext context):base(context) 
        {
            
        }
    }
}
