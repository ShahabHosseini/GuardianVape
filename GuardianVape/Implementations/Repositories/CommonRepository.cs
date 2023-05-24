using DataAccess.Context;
using Model.Contracts.Repositories;
using Model.Entities;

namespace DataAccess.Implementations.Repositories
{
    public class CommonRepository :GenericRepository<ShopLocation>,ICommonRepository
    {
        public CommonRepository(GVDbContext context):base(context) 
        {
            
        }
    }
}
