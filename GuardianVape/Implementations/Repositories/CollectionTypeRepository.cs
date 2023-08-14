using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DataAccess.Context;
using Model.Entities;
using Service.Contracts.Repositories;



namespace DataAccess.Implementations.Repositories
{
    public class CollectionTypeRepository : GenericRepository<CollectionType>, ICollectionTypeRepository
    {
        private readonly GVDbContext _context;

        public CollectionTypeRepository(GVDbContext context) : base(context)
        {
            _context = context;

        }
        public async Task<CollectionType> FindWithConditionsAsync(Func<CollectionType, bool> value)
        {
            var collectionTypes = await _context.CollectionTypes
                .Include(x => x.Conditions)
                .ToListAsync(); // Retrieve all records from the database

            var result = collectionTypes.FirstOrDefault(value); // Perform local filtering

            return result;
        }
    }
}
