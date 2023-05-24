using DataAccess.Context;
using Model.Contracts.Repositories;
using Model.Entities;

namespace DataAccess.Implementations.Repositories
{
    public class BodyRepository:GenericRepository<Body>,IBodyRepository
    {
        public BodyRepository(GVDbContext context):base(context) 
        {
            
        }
    }
}
