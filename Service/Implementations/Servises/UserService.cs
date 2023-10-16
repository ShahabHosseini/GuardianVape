using AutoMapper;
using Model.Entities;
using Service.Contracts.Inquiry;
using Service.Contracts.Repositories;
using Service.Contracts.Services;
using Service.Contracts.Validation;
using Share.DTO;
using Share.Helper;

namespace Service.Implementations.Servises
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWorkFactory _unitOfWorkFactory;
        private readonly IUserDeleteInquiry _userInquiry;
        private readonly IUserValidator _userValidator;

        public virtual IMapper Mapper { get; set; }
        MapperConfiguration Configuration { get; set; }
        public UserService(IUnitOfWorkFactory unitOfWorkFactory, IMapper mapper, IUserDeleteInquiry inquiry, IUserValidator validator)
        {
            _unitOfWorkFactory = unitOfWorkFactory;
            Mapper = mapper;
            Configuration = new MapperConfiguration(cfg => cfg.CreateMap<User, UserDto>());
            Configuration.AssertConfigurationIsValid();
            Mapper = new Mapper(Configuration);
            _userValidator = validator;
            _userInquiry = inquiry;
        }

        public async Task AddAsync(UserDto userDto)
        {
            var password = PasswordHasher.HashPassword(userDto.Password);
            var res = await _userValidator.UserNameExist(userDto.UserName, userDto.Email, userDto.Password);
            if (!string.IsNullOrEmpty(res))
                throw new Exception(res);

            using (var unitOfWork = _unitOfWorkFactory.Create())
            {
                Configuration = new MapperConfiguration(cfg => cfg.CreateMap<UserDto, User>());
                Mapper = new Mapper(Configuration);
                var user = Mapper.Map<User>(userDto);
                user.Password = password;
                await unitOfWork.User.AddAsync(user);
                await unitOfWork.Commit();
            }
        }



        public async Task<UserDto> GetAsync(UserDto userDto)
        {
            using (var unitOfWork = _unitOfWorkFactory.Create())
            {
                var user = await unitOfWork.User.FindAsync(x =>
                x.UserName.Equals(userDto.UserName));

                if (user != null)
                    if (PasswordHasher.VerifyPassword(userDto.Password, user.Password))
                        return Mapper.Map<UserDto>(user);
                return null;
            }
        }

        public async Task<List<UserDto>> GetAllAsync()
        {
            using (var unitOfWork = _unitOfWorkFactory.Create())
            {
                var user = await unitOfWork.User.GetAllAsync();
                return Mapper.Map<List<UserDto>>(user);
            }
        }

        public async Task UpdateAsync(UserDto userDto)
        {
            using (var unitOfWork = _unitOfWorkFactory.Create())
            {
                Configuration = new MapperConfiguration(cfg => cfg.CreateMap<UserDto, User>());
                Mapper = new Mapper(Configuration);
                var user = Mapper.Map<User>(userDto);
                await unitOfWork.User.UpdateAsync(user, user.Id);
                await unitOfWork.Commit();
            }
        }

        public async Task<UserDto> FindAsync(string userName)
        {
            using (var unitOfWork = _unitOfWorkFactory.Create())
            {
                var user = await unitOfWork.User.FindAsync(x => x.UserName.Equals(userName));
                return Mapper.Map<UserDto>(user);
            }
        }
    }
}
