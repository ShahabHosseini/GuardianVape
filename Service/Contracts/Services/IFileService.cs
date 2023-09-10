using Model.Entities;
using Share.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts.Services
{
    public interface IFileService : IBaseServices<ImageDto>
    {
        Task<ImageDto> AddAsync(ImageDto imageDto);
        Task<ImageDto> FindbyGuidAsync(string guid);
        Task<ICollection<ImageDto>> GetAllAsync();
        Task RemoveImage(ImageDto source);
        Task UpdateImage(ImageDto imageDto);
    }
}
