using DataAccess.Context;
using Model.Entities;
using Service.Contracts.Repositories;

namespace DataAccess.Implementations.Repositories
{
    public class ConditionRepository:GenericRepository<ConditionRole>, IConditionRepository
    {
        public ConditionRepository(GVDbContext context):base(context) 
        {
            
        }
    }
}
