using Model.Entities;
using Share.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts.Repositories
{
    public interface IFileRepository : IGenericRepository<Image>
    {
    }
}
