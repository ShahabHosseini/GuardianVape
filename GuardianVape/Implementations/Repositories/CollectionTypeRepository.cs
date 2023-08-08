using DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using Model.Entities;
using Service.Contracts.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Implementations.Repositories
{
    public class CollectionTypeRepository : GenericRepository<CollectionType>, ICollectionTypeRepository
    {
        private readonly GVDbContext _context;

        public CollectionTypeRepository(GVDbContext context) : base(context)
        {
            _context = context;

        }
    }
}
