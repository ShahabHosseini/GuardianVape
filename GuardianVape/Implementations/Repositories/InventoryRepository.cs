using DataAccess.Context;
using Model.Contracts.Repositories;
using Model.Entities;

namespace DataAccess.Implementations.Repositories
{
    public class InventoryRepository:GenericRepository<Inventory>,IInventoryRepository
    {
        public InventoryRepository(GVDbContext context):base (context) 
        {
            
        }
    }
}
