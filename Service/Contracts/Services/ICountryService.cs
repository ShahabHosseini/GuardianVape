using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Share.DTO;

namespace Service.Contracts.Services
{
    public interface ICountryService: IBaseServices<CountryDto>
    {
        Task<ICollection<CountryDto>> GetAllAsync();
    }
}
