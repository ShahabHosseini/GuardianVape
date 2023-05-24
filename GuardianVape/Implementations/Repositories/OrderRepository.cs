using DataAccess.Context;
using Model.Contracts.Repositories;
using Model.Entities;

namespace DataAccess.Implementations.Repositories
{
    public class OrderRepository:GenericRepository<Order>,IOrderRepository
    {
        public OrderRepository(GVDbContext context):base(context) 
        {
            
        }
    }
}
