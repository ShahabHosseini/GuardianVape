using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Contracts.Repositories
{
    //its Common for some small Entities
    public interface ICommonRepository : IGenericRepository<ShopLocation>
    {
    }
}
