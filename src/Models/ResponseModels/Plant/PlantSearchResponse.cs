using Models.ResponseModels.BaseResponseSetup;

namespace Models.ResponseModels.Plant
{
    public class PlantSearchResponse : SearchResponseBase<PlantSearchResponseModel>
    {
        public List<PlantSearchResponseModel> Plants => base.Results;
    }
}
