using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts.Repositories
{
    //Its for Product ProductCollection ProductType ProductTag and ProductVariant
    public interface IProductRepository : IGenericRepository<Product>
    {
    }
}
