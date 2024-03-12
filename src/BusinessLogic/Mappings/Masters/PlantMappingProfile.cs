using AutoMapper;
using DataAccess.Domain.Masters.Plant;
using Models.RequestModels.Masters.Plant;
using Models.ResponseModels.Masters.Plant;

namespace BusinessLogic.Mappings.Masters
{
    public class PlantMappingProfile : Profile
    {
        public PlantMappingProfile()
        {
            CreateMap<PlantSearchRequestModel, PlantSearchRequestEntity>();
            CreateMap<PlantEntity, PlantSearchResponseModel>();
            CreateMap<PlantSearchResponseEntity, PlantSearchResponse>();
        }
    }
}
