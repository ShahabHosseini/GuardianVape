using DataAccess.Context;
using Model.Entities;
using Service.Contracts.Repositories;

namespace DataAccess.Implementations.Repositories
{
    public class CollectionRepository:GenericRepository<Collection>, ICollectionRepository
    {
        public CollectionRepository(GVDbContext context):base(context) 
        {
            
        }
    }
}
