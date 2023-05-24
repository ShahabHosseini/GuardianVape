using DataAccess.Context;
using Model.Entities;
using Service.Contracts.Repositories;

namespace DataAccess.Implementations.Repositories
{
    public class CommonRepository :GenericRepository<ShopLocation>,ICommonRepository
    {
        public CommonRepository(GVDbContext context):base(context) 
        {
            
        }
    }
}
