using DataAccess.Context;
using Model.Entities;
using Service.Contracts.Repositories;

namespace DataAccess.Implementations.Repositories
{
    public class VariantRepository:GenericRepository<Variant>,IVariantRepository
    {
        public VariantRepository(GVDbContext context):base(context) 
        {
            
        }
    }
}
