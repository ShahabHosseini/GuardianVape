using DataAccess.Context;
using Model.Contracts.Repositories;
using Model.Entities;

namespace DataAccess.Implementations.Repositories
{
    public class AddressRepository : GenericRepository<Address>, IAddressRepository
    {
        public AddressRepository(GVDbContext context):base(context) 
        { 

        }
    }
}
