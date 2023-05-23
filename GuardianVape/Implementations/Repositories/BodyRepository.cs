using DataAccess.Context;
using Model.Entities;
using Service.Contracts.Repositories;

namespace DataAccess.Implementations.Repositories
{
    public class BodyRepository:GenericRepository<Body>,IBodyRepository
    {
        public BodyRepository(GVDbContext context):base(context) 
        {
            
        }
    }
}
