using DataAccess.Context;
using Model.Contracts.Repositories;
using Model.Entities;

namespace DataAccess.Implementations.Repositories
{
    public class UserRepository:GenericRepository<User>,IUserRepository
    {
        public UserRepository(GVDbContext context):base(context) 
        {
            
        }
    }
}
