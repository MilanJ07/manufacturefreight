using Models.RequestModels.Plant;
using Models.ResponseModels.Plant;
using Utilities.Contract;

namespace BusinessLogic.Interfaces
{
    public interface IPlantService
    {
        Task<IResponseWrapper<PlantSearchResponseModel>> GetPlantAsync(decimal id);
        Task<IResponseWrapper<PlantSearchResponse>> SearchPlantAsync(PlantSearchRequestModel requestModel, string? offset, string count);
    }
}
