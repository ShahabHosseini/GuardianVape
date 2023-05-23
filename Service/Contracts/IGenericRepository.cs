using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task GetById(int id);
        Task Add(int Id);
        Task AddRange(IEnumerable<T> entiteis);
        Task<IEnumerable<T>> Find(Expression<Func<T,bool>> predicate);
        Task Remove(int id);
        Task RemoveRange(IEnumerable<T> entiteis);
    }
}
