using Share.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts.Services
{
    public interface IUserService
    {
        Task AddAsync(UserDto userDto);
        Task<UserDto> GetAsync(UserDto userDto);
    }
}
