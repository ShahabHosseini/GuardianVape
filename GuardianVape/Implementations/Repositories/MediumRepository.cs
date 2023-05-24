using DataAccess.Context;
using Model.Contracts.Repositories;
using Model.Entities;

namespace DataAccess.Implementations.Repositories
{
    public class MediumRepository:GenericRepository<Medium> ,IMediumRepository
    {
        public MediumRepository(GVDbContext context):base(context) 
        {
            
        }
    }
}
