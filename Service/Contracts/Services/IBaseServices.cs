using Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts.Services
{
    public interface IBaseServices<T> where T :class
    {
        T Get(int id);
        Task<T> GetAsync(int id);
        IQueryable<T> GetAll();
        Task<ICollection<T>> GetAllAsync();
    }
}
