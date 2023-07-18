using AutoMapper;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
    public class CollectionService : ICollectionService
    {
        public virtual IMapper Mapper { get; set; }
        MapperConfiguration Configuration { get; set; }
        private readonly IUnitOfWorkFactory _unitOfWorkFactory;

        public CollectionService(IUnitOfWorkFactory unitOfWorkFactory, IMapper mapper)
        {
            _unitOfWorkFactory = unitOfWorkFactory;
            Mapper = mapper;
            Configuration = new MapperConfiguration(cfg => cfg.CreateMap<ConditionType , IdTitleDto>());
            Configuration.AssertConfigurationIsValid();
            Mapper = new Mapper(Configuration);
        }
        public async Task<List<IdTitleDto>> GetAllConditionTypeAsync()
        {
            using (var unitOfWork = _unitOfWorkFactory.Create())
            {
                var conditionTypes = await unitOfWork.Condition.GetAllConditionTypeAsync();
                return Mapper.Map<List<IdTitleDto>>(conditionTypes);
            }
        }

        public async Task Save(CollectionDto collectionDto)
        {
            using (var unitOfWork = _unitOfWorkFactory.Create())
            {
                var data = Mapper.Map<Collection>(collectionDto);
               var res= await unitOfWork.Collection.AddAsync(data);
            }
        }
    }
}
