using DataAccess.Context;
using Model.Entities;
using Service.Contracts.Repositories;

namespace DataAccess.Implementations.Repositories
{
    public class TagRepository:GenericRepository<Tag>,ITagRepository
    {
        public TagRepository(GVDbContext context):base(context) 
        {
            
        }
    }
}
