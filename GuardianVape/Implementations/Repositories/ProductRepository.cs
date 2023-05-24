using DataAccess.Context;
using Model.Contracts.Repositories;
using Model.Entities;

namespace DataAccess.Implementations.Repositories
{
    public class ProductRepository:GenericRepository<Product>,IProductRepository
    {
        public ProductRepository(GVDbContext context):base(context) 
        {
            
        }
    }
}
