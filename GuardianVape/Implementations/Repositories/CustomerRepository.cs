using DataAccess.Context;
using Model.Contracts.Repositories;
using Model.Entities;

namespace DataAccess.Implementations.Repositories
{
    public class CustomerRepository:GenericRepository<Customer>,ICustomerRepository
    {
        public CustomerRepository(GVDbContext context):base(context) 
        {
            
        }
    }
}
