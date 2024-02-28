using Models.ResponseModels;
using Utilities.Contract;

namespace BusinessLogic.Interfaces
{
    public interface IPlantService
    {
        Task<IResponseWrapper<PlantResponseModel>> GetAllPlant();
    }
}
