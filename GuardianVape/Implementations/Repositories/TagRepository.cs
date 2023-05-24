using DataAccess.Context;
using Model.Contracts.Repositories;
using Model.Entities;

namespace DataAccess.Implementations.Repositories
{
    public class TagRepository:GenericRepository<Tag>,ITagRepository
    {
        public TagRepository(GVDbContext context):base(context) 
        {
            
        }
    }
}
