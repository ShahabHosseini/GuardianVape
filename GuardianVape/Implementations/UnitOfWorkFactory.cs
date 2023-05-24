using DataAccess.Context;
using Service.Contracts.Repositories;

namespace DataAccess.Implementations
{
    public class UnitOfWorkFactory :IUnitOfWorkFactory
    {
        public IUnitOfWork Create()
        {
            return new UnitOfWork(new GVDbContext());
        }
    }
}
