﻿using Share.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts.Services
{
    public interface IFileService : IBaseServices<ImageDto>
    {
        Task AddAsync(ImageDto imageDto);
        Task<ICollection<ImageDto>> GetAllAsync();
        Task RemoveImage(ImageDto source);
        Task UpdateImage(ImageDto imageDto);
    }
}