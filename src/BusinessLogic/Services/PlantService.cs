using BusinessLogic.Interfaces;
using DataAccess.Domain.Masters;
using Models.ResponseModels;
using Utilities.Contract;
using Utilities.Implementation;

namespace BusinessLogic.Services
{
    public class PlantService : IPlantService
    {
        public PlantService()
        {

        }

        public async Task<IResponseWrapper<PlantResponseModel>> GetAllPlant()
        {
            var wrapper = new ResponseWrapper<PlantResponseModel>();

            ////wrapper.Messages.Add(Messages.EntityNotFound.ToDetailModel("12345"));
            ////return wrapper;
            ///return new ResponseWrapper_ResponseMessage

            var response = new PlantResponseModel()
            {
                PlantId = "1001"
            };

            wrapper.Response = response;
            return wrapper;
        }
    }
}
