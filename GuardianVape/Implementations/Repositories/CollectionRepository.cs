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

    }
}
