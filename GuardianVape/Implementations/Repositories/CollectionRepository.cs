using DataAccess.Context;
using Model.Contracts.Repositories;
using Model.Entities;

namespace DataAccess.Implementations.Repositories
{
    public class CollectionRepository:GenericRepository<Collection>, ICollectionRepository
    {
        public CollectionRepository(GVDbContext context):base(context) 
        {
            
        }
    }
}
