using DataAccess.Context;
using Model.Contracts.Repositories;
using Model.Entities;

namespace DataAccess.Implementations.Repositories
{
    public class CategoryRepository :GenericRepository<Category>,ICategoryRepository
    {
        public CategoryRepository(GVDbContext context):base(context) 
        {
            
        }
    }
}
