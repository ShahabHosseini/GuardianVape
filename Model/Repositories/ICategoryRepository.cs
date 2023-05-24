using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Contracts.Repositories
{
    //Its for Gategory and CategoryGroup
    public interface ICategoryRepository : IGenericRepository<Category>
    {
    }
}
