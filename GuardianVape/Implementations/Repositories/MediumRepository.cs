using DataAccess.Context;
using Model.Entities;
using Service.Contracts.Repositories;

namespace DataAccess.Implementations.Repositories
{
    public class MediumRepository:GenericRepository<Image> ,IMediumRepository
    {
        public MediumRepository(GVDbContext context):base(context) 
        {
            
        }
    }
}
