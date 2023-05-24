using AutoMapper;
using Model.Entities;
using Service.Contracts.Repositories;
using Service.Contracts.Services;
using Share.DTO;

namespace Service.Implementations.Servises
{
    public class AddressService : IAddressService
    {
        private readonly IUnitOfWorkFactory _unitOfWorkFactory;
        public virtual IMapper Mapper { get; set; }
        MapperConfiguration Configuration { get; set; }

        public AddressService(IUnitOfWorkFactory unitOfWorkFactory,IMapper mapper)
        {
            _unitOfWorkFactory = unitOfWorkFactory;
            Mapper = mapper;
            Configuration = new MapperConfiguration(cfg => cfg.CreateMap<Address, AddressDto>());
            Configuration.AssertConfigurationIsValid();
        }
        public AddressDto Get(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<AddressDto> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<AddressDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<AddressDto> GetAsync(int id)
        {
            var mapper = new Mapper(Configuration);

            using (var unitOfWork = _unitOfWorkFactory.Create())
            {
                var addres = await unitOfWork.Address.GetAsync(id);
                 return mapper.Map<AddressDto>(addres);
            }
        }
    }
}
