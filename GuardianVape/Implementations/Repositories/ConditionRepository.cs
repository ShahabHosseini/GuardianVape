using DataAccess.Context;
using Model.Contracts.Repositories;
using Model.Entities;

namespace DataAccess.Implementations.Repositories
{
    public class ConditionRepository:GenericRepository<ConditionRole>, IConditionRepository
    {
        public ConditionRepository(GVDbContext context):base(context) 
        {
            
        }
    }
}
