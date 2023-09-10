using Model.Entities;
using Service.Contracts.Repositories;
using Share.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Service.Contracts.Services;
using System.Threading.Tasks;
using AutoMapper;
using Service.Implementations.Validators;
using Service.Contracts.Validators;

namespace Service.Implementations.Servises
{

    public class CountryService : ICountryService
    {
    private readonly IUnitOfWorkFactory _unitOfWorkFactory;
    public virtual IMapper Mapper { get; set; }
    MapperConfiguration Configuration { get; set; }

        public CountryService(IUnitOfWorkFactory unitOfWorkFactory, IMapper mapper)
        {
            _unitOfWorkFactory = unitOfWorkFactory;
            Mapper = mapper;
            Configuration = new MapperConfiguration(cfg => cfg.CreateMap<Country, CountryDto>());
            Configuration.AssertConfigurationIsValid();
            Mapper = new Mapper(Configuration);
        }
        public CountryDto Get(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<CountryDto> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<CountryDto>> GetAllAsync()
        {
            ICollection<Country> result = null;
            try
            {
                using (var unitOfWork = _unitOfWorkFactory.Create())
                {
                    result = await unitOfWork.Country.GetAllAsync();
                }
                return Mapper.Map<ICollection<CountryDto>>(result);
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }

        public Task<CountryDto> GetAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
