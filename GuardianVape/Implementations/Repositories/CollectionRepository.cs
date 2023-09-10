using DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using Model.Entities;
using Service.Contracts.Repositories;

namespace DataAccess.Implementations.Repositories
{
    public class CollectionRepository:GenericRepository<Collection>, ICollectionRepository
    {
        private readonly GVDbContext _context;
        public CollectionRepository(GVDbContext context):base(context) 
        {
            _context = context;
            
        }
        public async Task<ICollection<Collection>> GetAllWithImageAsync()
        {
            var collectionsWithImages = await _context.Set<Collection>()
        .Include(c => c.Image)
        .Include(c => c.CollectionType)
        .ThenInclude(ct => ct.Conditions)
        .ThenInclude(cond => cond.ConditionType)
        .Include(c => c.CollectionType)
        .ThenInclude(ct => ct.Conditions)
        .ThenInclude(cond => cond.EqualType).ToListAsync();

            return collectionsWithImages;
        }
        public async Task<Collection> GetByGuidsync(string guid)
        {
            var collection = await _context.Set<Collection>()
        .Include(c=>c.Image)
        .Include(c => c.CollectionType)
        .ThenInclude(ct => ct.Conditions)
        .ThenInclude(cond => cond.ConditionType)
        .Include(c => c.CollectionType)
        .ThenInclude(ct => ct.Conditions)
        .ThenInclude(cond => cond.EqualType)
        .SingleOrDefaultAsync(c => c.GUID == guid);

            return collection;
        }

     }
}
