using DataAccess.Context;
using Model.Entities;
using Service.Contracts.Repositories;

namespace DataAccess.Implementations.Repositories
{
    public class InventoryRepository:GenericRepository<Inventory>,IInventoryRepository
    {
        public InventoryRepository(GVDbContext context):base (context) 
        {
            
        }
    }
}
