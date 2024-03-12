using AutoMapper;
using DataAccess.Domain.Masters.Plant;
using Models.RequestModels.Plant;
using Models.ResponseModels.Plant;

namespace BusinessLogic.Mappings
{
    public class PlantMappingProfile : Profile
    {
        public PlantMappingProfile()
        {
            this.CreateMap<PlantSearchRequestModel, PlantSearchRequestEntity>();
            this.CreateMap<PlantEntity, PlantSearchResponseModel>();
            this.CreateMap<PlantSearchResponseEntity, PlantSearchResponse>();
        }
    }
}
