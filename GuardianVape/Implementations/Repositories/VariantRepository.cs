using DataAccess.Context;
using Model.Contracts.Repositories;
using Model.Entities;

namespace DataAccess.Implementations.Repositories
{
    public class VariantRepository:GenericRepository<Variant>,IVariantRepository
    {
        public VariantRepository(GVDbContext context):base(context) 
        {
            
        }
    }
}
