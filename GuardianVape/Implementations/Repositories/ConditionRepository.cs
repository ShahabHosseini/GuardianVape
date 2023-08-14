using DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using Model.Entities;
using Service.Contracts.Repositories;

namespace DataAccess.Implementations.Repositories
{
    public class ConditionRepository : GenericRepository<Condition>, IConditionRepository
    {
        private readonly GVDbContext _context;
        public ConditionRepository(GVDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<ICollection<ConditionType>> GetAllConditionTypeAsync()
        {
            try
            {
                return await _context.ConditionTypes.ToListAsync();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public async Task<ICollection<EqualType>> GetAllEqualTypeAsync()
        {
            try
            {
                return await _context.EqualTypes.ToListAsync();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public async Task Remove(Condition conditionToRemove)
        {
            try
            {
                _context.Conditions.Remove(conditionToRemove);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
    }
}
