using AutoMapper;
using Model.Entities;
using Service.Contracts.Repositories;
using Service.Contracts.Services;
using Share.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Implementations.Servises
{
    public class FileService : IFileService
    {
        private readonly IUnitOfWorkFactory _unitOfWorkFactory;
        public virtual IMapper Mapper { get; set; }
        MapperConfiguration Configuration { get; set; }
        public FileService(IUnitOfWorkFactory unitOfWorkFactory, IMapper mapper)
        {
            _unitOfWorkFactory = unitOfWorkFactory;
            Mapper = mapper;
            Configuration = new MapperConfiguration(cfg => cfg.CreateMap<Image, ImageDto>());
            Configuration.AssertConfigurationIsValid();
            Mapper = new Mapper(Configuration);
        }

        ImageDto IBaseServices<ImageDto>.Get(int id)
        {
            throw new NotImplementedException();
        }

        IQueryable<ImageDto> IBaseServices<ImageDto>.GetAll()
        {
            throw new NotImplementedException();
        }

        Task<ICollection<ImageDto>> IBaseServices<ImageDto>.GetAllAsync()
        {
            throw new NotImplementedException();
        }

        Task<ImageDto> IBaseServices<ImageDto>.GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task AddAsync(ImageDto imageDto)
        {
            using (var unitOfWork = _unitOfWorkFactory.Create())
            {
                Configuration = new MapperConfiguration(cfg => cfg.CreateMap<ImageDto, Image>());
                Mapper = new Mapper(Configuration);
                var image = Mapper.Map<Image>(imageDto);
                // user.Id=userDto.Id;
                await unitOfWork.File.AddAsync(image);
                await unitOfWork.Commit();
            }
        }
    }
}
