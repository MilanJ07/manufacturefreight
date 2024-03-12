using Models.ResponseModels.BaseResponseSetup;

namespace Models.ResponseModels.Masters.Plant
{
    public class PlantSearchResponse : SearchResponseBase<PlantSearchResponseModel>
    {
        public List<PlantSearchResponseModel> Plants => Results;
    }
}
