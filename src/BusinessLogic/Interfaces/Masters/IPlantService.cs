using Models.RequestModels.Masters.Plant;
using Models.ResponseModels.Masters.Plant;
using Utilities.Contract;

namespace BusinessLogic.Interfaces.Masters
{
    public interface IPlantService
    {
        Task<IResponseWrapper<PlantSearchResponseModel>> GetPlantAsync(decimal id);
        Task<IResponseWrapper<PlantSearchResponse>> SearchPlantAsync(PlantSearchRequestModel requestModel, string? offset, string count);
    }
}
