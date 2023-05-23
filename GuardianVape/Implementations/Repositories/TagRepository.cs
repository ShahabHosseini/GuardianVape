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
    public class TagRepository:GenericRepository<Tag>,ITagRepository
    {
        public TagRepository(GVDbContext context):base(context) 
        {
            
        }
    }
}
