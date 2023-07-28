using AutoMapper;
using Model.Entities;
using Service.Contracts.Repositories;
using Service.Contracts.Services;
using Service.Contracts.Validators;
using Share.DTO;
using System;
using System.Collections;
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
        private readonly IFileValidator _fileValidator;
        public virtual IMapper Mapper { get; set; }
        MapperConfiguration Configuration { get; set; }
        public FileService(IUnitOfWorkFactory unitOfWorkFactory, IMapper mapper,IFileValidator fileValidator)
        {
            _unitOfWorkFactory = unitOfWorkFactory;
            Mapper = mapper;
            Configuration = new MapperConfiguration(cfg => cfg.CreateMap<Image, ImageDto>());
            Configuration.AssertConfigurationIsValid();
            Mapper = new Mapper(Configuration);
            _fileValidator = fileValidator;
        }

        ImageDto IBaseServices<ImageDto>.Get(int id)
        {
            throw new NotImplementedException();
        }

        IQueryable<ImageDto> IBaseServices<ImageDto>.GetAll()
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
                var res = await _fileValidator.NameExist(imageDto.Name, imageDto.Url);
                if (!string.IsNullOrEmpty(res))
                    throw new Exception(res);

                Configuration = new MapperConfiguration(cfg => cfg.CreateMap<ImageDto, Image>());
                Mapper = new Mapper(Configuration);
                var image = Mapper.Map<Image>(imageDto);
                // user.Id=userDto.Id;
                image.UploadDate = DateTime.Now;
                await unitOfWork.File.AddAsync(image);
                await unitOfWork.Commit();
            }
        }

        public async Task<ICollection<ImageDto>> GetAllAsync()
        {
            ICollection<Image> result = null;
            using (var unitOfWork = _unitOfWorkFactory.Create())
            {
                 result=await unitOfWork.File.GetAllAsync();
            }
            return Mapper.Map<ICollection<ImageDto>>(result);
        }

        public async Task RemoveImage(ImageDto source)
        {
            using (var unitOfWork = _unitOfWorkFactory.Create())
            {
                var image = unitOfWork.File.FindAsync(x => x.GUID == source.Guid).Result;
                 await unitOfWork.File.DeleteAsync(image);
            }
        }

        public async Task UpdateImage(ImageDto imageDto)
        {
            using (var unitOfWork = _unitOfWorkFactory.Create())
            {
                var image = unitOfWork.File.FindAsync(x => x.GUID == imageDto.Guid).Result;
                image.Caption = imageDto.Caption;
                image.Description = imageDto.Description;
                image.Alt = imageDto.Alt;

                await unitOfWork.File.UpdateAsync(image,image.Id);
                await unitOfWork.Commit();
            }
        }
    }
}
