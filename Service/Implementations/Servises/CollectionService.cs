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

        public async Task<List<IdTitleDto>> GetAllEqualTypeAsync()
        {
            Configuration = new MapperConfiguration(cfg => cfg.CreateMap<EqualType, IdTitleDto>());
            Configuration.AssertConfigurationIsValid();
            Mapper = new Mapper(Configuration);

            using (var unitOfWork = _unitOfWorkFactory.Create())
            {

                var equalTypes = await unitOfWork.Condition.GetAllEqualTypeAsync();
                return Mapper.Map<List<IdTitleDto>>(equalTypes);
            }
        }

        public async Task<List<CollectionDto>> GetCollectionsAllAsync()
        {
            using (var unitOfWork = _unitOfWorkFactory.Create())
            {
                var collections = await unitOfWork.Collection.GetAllWithImageAsync();
                var collectionDtos = collections.Select(MapCollectionToDto).ToList();
                return collectionDtos;

            }
        }
        public async Task<CollectionDto> GetCollectionAsync(string guid)
        {
            using (var unitOfWork = _unitOfWorkFactory.Create())
            {
                var collection = await unitOfWork.Collection.GetByGuidsync(guid);
                var collectionDtos = MapCollectionToDto(collection);
                return collectionDtos;

            }
        }

        private CollectionDto MapCollectionToDto(Collection collection)
        {
            var collectionDto = new CollectionDto
            {
                Guid=collection.GUID,
                TitleDescription = new TitleDescriptionDto
                {
                    Title = collection.Title,
                    Description = collection.Description
                },
                CollectionType = MapCollectionTypeToDto(collection.CollectionType),
                Image=MapImageToDto(collection.Image),
                
            };

            return collectionDto;
        }

        private ImageDto MapImageToDto(Image? image)
        {
            if (image == null)
                return null;

            var imageDto = new ImageDto 
            { 
                Alt=image.Alt,
                Caption=image.Caption,
                Description=image.Description,
                Url=image.Url,
                UploadDate=image.UploadDate,
                Guid=image.GUID,

            };
            return imageDto;
        }

        private CollectionTypeDto MapCollectionTypeToDto(CollectionType collectionType)
        {
            if (collectionType != null)
            {
                var collectionTypeDto = new CollectionTypeDto
                {
                    //     CollType = collectionType.CollType,
                    //ConditionType = collectionType.ConditionType,
                    Guid= collectionType.GUID,
                    Conditions = collectionType.Conditions.Select(c => new ConditionDto
                    {
                        // Map properties of ConditionDto from Condition as needed
                        // For example:
                        ConditionType = new IdTitleDto { Id = c.ConditionTypeId, Title = c.ConditionType.Title,Guid=c.ConditionType.GUID },
                        EqualType = new IdTitleDto { Id = c.EqualTypeId, Title = c.EqualType.Title,Guid=c.EqualType.GUID },
                        Result = c.Result,
                        Guid=c.GUID,
                        // ...
                    }).ToList()
                };

                return collectionTypeDto;
            }
            else
                return null;
        }
        public async Task<ICollection<CollectionDto>> GetParents()
        {
            using (var unitOfWork = _unitOfWorkFactory.Create())
            {
                var collections = await unitOfWork.Collection.GetAllAsync();

                var dto = collections.Select(MapCollectionToDto).ToList(); 

                return dto;
            }
        }

        public async Task Save(CollectionDto collectionDto)
        {
            try
            {
                using (var unitOfWork = _unitOfWorkFactory.Create())
                {
                    Image image = new Image();
                    int? imageid=null ;

                    if (collectionDto.Image != null)
                    {
                         image = unitOfWork.File.FindAsync(x => x.GUID == collectionDto.Image.Guid).Result;
                    }
                    if (image != null && image.Id!=0)
                    {
                        imageid = image.Id;
                    }

                    var collection = new Collection
                    {
                        Title = collectionDto.TitleDescription.Title,
                        Description = collectionDto.TitleDescription.Description,
                        GUID = Guid.NewGuid().ToString(),
                        ImageId= imageid,
                        CollectionType = new CollectionType
                        {
                            GUID= collectionDto.CollectionType.Guid,
                            Conditions = collectionDto.CollectionType.Conditions.Select(c => new Condition
                            {
                                ConditionTypeId = c.ConditionType.Id, // Use the existing ConditionTypeId from the DTO
                                EqualTypeId = c.EqualType.Id,
                                Result = c.Result,
                                AllCondition = c.AllCondition,
                                GUID = Guid.NewGuid().ToString(),
                            }).ToList(),
                            //CollType = collectionDto.CollectionType.CollectionType,
                            //ConditionType = collectionDto.CollectionType.ConditionType
                        }
                    };

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

        public async Task Update(CollectionDto collectionDto)
        {
            try
            {
                using (var unitOfWork = _unitOfWorkFactory.Create())
                {
                    Image image = null;
                    int? imageId = null;

                    if (collectionDto.Image.Guid != string.Empty)
                    {
                        image = await unitOfWork.File.FindAsync(x => x.GUID == collectionDto.Image.Guid);
                    }

                    if (image != null && image.Id != 0)
                    {
                        imageId = image.Id;
                    }
                    else
                    {
                        imageId = null;
                    }

                    var existingCollection = await unitOfWork.Collection.FindAsync(x => x.GUID == collectionDto.Guid);
                    if (existingCollection != null)
                    {
                        existingCollection.Title = collectionDto.TitleDescription.Title;
                        existingCollection.Description = collectionDto.TitleDescription.Description;
                        existingCollection.Image = image;
                        existingCollection.ImageId=imageId;

                        // Update CollectionType
                        var existingCollectionType = await unitOfWork.CollectionType.FindWithConditionsAsync(x => x.GUID == collectionDto.CollectionType.Guid);
                        if (existingCollectionType != null)
                        {
                            // Update existing CollectionType
                            //existingCollectionType.CollType = collectionDto.CollectionType.CollectionType;
                            //existingCollectionType.ConditionType = collectionDto.CollectionType.ConditionType;
                        }
                        else
                        {
                            // Create a new CollectionType
                            existingCollection.CollectionType = new CollectionType
                            {
                                //CollType = collectionDto.CollectionType.CollectionType,
                                //ConditionType = collectionDto.CollectionType.ConditionType
                            };
                        }

                // Remove conditions that are not present in the DTO
                var conditionsToRemove = existingCollectionType.Conditions
                    .Where(existingCondition => !collectionDto.CollectionType.Conditions.Any(dtoCondition => dtoCondition.Guid == existingCondition.GUID))
                    .ToList();
                foreach (var conditionToRemove in conditionsToRemove)
                {
                    existingCollectionType.Conditions.Remove(conditionToRemove);
                   await unitOfWork.Condition.Remove(conditionToRemove); // Remove from the context
                }


                        // Update or add Conditions
                        foreach (var conditionDto in collectionDto.CollectionType.Conditions)
                        {
                            var existingCondition = await unitOfWork.Condition.FindAsync(c => c.GUID == conditionDto.Guid);
                            if (existingCondition != null)
                            {
                                existingCondition.ConditionTypeId = conditionDto.ConditionType.Id;
                                existingCondition.EqualTypeId = conditionDto.EqualType.Id;
                                existingCondition.Result = conditionDto.Result;
                                existingCondition.AllCondition = conditionDto.AllCondition;
                            }
                            else
                            {
                                // Create a new Condition
                                var newCondition = new Condition
                                {
                                    ConditionTypeId = conditionDto.ConditionType.Id,
                                    EqualTypeId = conditionDto.EqualType.Id,
                                    Result = conditionDto.Result,
                                    AllCondition = conditionDto.AllCondition,
                                    GUID = conditionDto.Guid
                                };
                                existingCollectionType?.Conditions.Add(newCondition);
                            }
                        }
                    }

                    await unitOfWork.Commit();
                }
            }
            catch (Exception ex)
            {
                // Log the exception
                throw ex;
            }
        }

    }

}
