using AutoMapper;
using Model.Entities;
using Service.Contracts.Repositories;
using Service.Contracts.Services;
using Share.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Implementations.Servises
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWorkFactory _unitOfWorkFactory;
        public virtual IMapper Mapper { get; set; }
        MapperConfiguration Configuration { get; set; }
        public UserService(IUnitOfWorkFactory unitOfWorkFactory, IMapper mapper)
        {
            _unitOfWorkFactory = unitOfWorkFactory;
            Mapper = mapper;
            Configuration = new MapperConfiguration(cfg => cfg.CreateMap<User, UserDto>());
            Configuration.AssertConfigurationIsValid();
            Mapper = new Mapper(Configuration);
        }

        public async Task AddAsync(UserDto userDto)
        {
            using (var unitOfWork = _unitOfWorkFactory.Create())
            {
                Configuration = new MapperConfiguration(cfg => cfg.CreateMap<UserDto, User>());
                Mapper = new Mapper(Configuration);
                var user= Mapper.Map<User>(userDto);
               await unitOfWork.User.AddAsync(user);
                await unitOfWork.Commit();
            }
        }

  

        public async Task<UserDto> GetAsync(UserDto userDto)
        {
            using (var unitOfWork = _unitOfWorkFactory.Create())
            {
                var user = await unitOfWork.User.FindAsync(x => 
                x.UserName.Equals(userDto.UserName) 
                && 
                x.Password.Equals(userDto.Password));

                return Mapper.Map<UserDto>(user);
            }
        }
    }
}
