using AutoMapper;
using Service.Contracts.Repositories;
using Service.Contracts.Services;
using Share.DTO;

namespace Service.Implementations.Servises
{
    public class AddressService : IAddressService
    {
        private readonly IUnitOfWorkFactory _unitOfWorkFactory;
        public virtual IMapper Mapper { get; set; }

        public AddressService(IUnitOfWorkFactory unitOfWorkFactory)
        {
            _unitOfWorkFactory = unitOfWorkFactory;
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
            using (var unitOfWork = _unitOfWorkFactory.Create())
            {
                var addres = await unitOfWork.Address.GetAsync(id);
                 return Mapper.Map<AddressDto>(addres);
            }
        }
    }
}
