using AutoMapper;
using Model.Entities;
using Service.Contracts.Repositories;
using Service.Contracts.Services;
using Share.DTO;

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
            Configuration = new MapperConfiguration(cfg => cfg.CreateMap<ConditionType, IdTitleDto>());
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

        public async Task<List<CollectionDto>> GetCollectionsAllAsync()
        {
            using (var unitOfWork = _unitOfWorkFactory.Create())
            {
                var collections = await unitOfWork.Collection.GetAllAsync();
                var collectionDtos = collections.Select(MapCollectionToDto).ToList();
                return collectionDtos;

            }
        }

        private CollectionDto MapCollectionToDto(Collection collection)
        {
            var collectionDto = new CollectionDto
            {
                TitleDescription = new TitleDescriptionDto
                {
                    Title = collection.Title,
                    Description = collection.Description
                },
                CollectionType = MapCollectionTypeToDto(collection.CollectionType)
            };

            return collectionDto;
        }

        private CollectionTypeDto MapCollectionTypeToDto(CollectionType collectionType)
        {
            var collectionTypeDto = new CollectionTypeDto
            {
                // Map other properties of CollectionTypeDto from CollectionType as needed
            };

            return collectionTypeDto;
        }

        public async Task Save(CollectionDto collectionDto)
        {
            try
            {
                using (var unitOfWork = _unitOfWorkFactory.Create())
                {
                    Image image = new Image();
                    if (collectionDto.ImageGuid != string.Empty)
                    {
                         image = unitOfWork.File.FindAsync(x => x.GUID == collectionDto.ImageGuid).Result;
                    }
                    var collection = new Collection
                    {
                        Title = collectionDto.TitleDescription.Title,
                        Description = collectionDto.TitleDescription.Description,
                        GUID = Guid.NewGuid().ToString(),
                        ImageId=image.Id,
                        CollectionType = new CollectionType
                        {
                            Conditions = collectionDto.CollectionType.Conditions.Select(c => new Condition
                            {
                                ConditionTypeId = c.ConditionType.Id, // Use the existing ConditionTypeId from the DTO
                                EqualType = c.EqualType,
                                Result = c.Result,
                                AllCondition = c.AllCondition,
                                GUID = Guid.NewGuid().ToString(),
                            }).ToList(),
                            CollType = collectionDto.CollectionType.CollectionType,
                            ConditionType = collectionDto.CollectionType.ConditionType
                        }
                    };

                    if (collection.ImageId == 0)
                    {
                        collection.ImageId = null;
                    }
                    var res = await unitOfWork.Collection.AddAsync(collection);
                    await unitOfWork.Commit();
                }
            }
            catch (Exception ex)
            {
                var mess = ex;
                // Handle the exception appropriately
            }
        }
    }
}
