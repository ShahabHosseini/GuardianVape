using DataAccess.Context;
using Model.Entities;
using Service.Contracts.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Implementations.Repositories
{
    public class CountryRepository : GenericRepository<Country>, ICountryRepository
    {
        private readonly GVDbContext _context;
        public CountryRepository(GVDbContext context) : base(context)
        {
            _context = context;

        }
    }
}
