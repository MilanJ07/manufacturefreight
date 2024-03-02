using BusinessLogic.Interfaces;
using BusinessLogic.Rules.Enums;
using BusinessLogic.Rules.Master.Plant;
using DataAccess.Domain.Masters;
using DataAccess.Interfaces;
using Models.ResponseModels;
using Utilities.Constants;
using Utilities.Contract;
using Utilities.Implementation;
using Utilities.MessageStatus;

namespace BusinessLogic.Services
{
    public class PlantService : IPlantService
    {
        private readonly IPlantRepository plantRepository;
        public PlantService(IPlantRepository plantRepository)
        {
            this.plantRepository = plantRepository;
        }

        public async Task<IResponseWrapper<PlantResponseModel>> GetAllPlant()
        {
            var wrapper = new ResponseWrapper<PlantResponseModel>();

            var plantEntity = new PlantEntity();
            //plantEntity.Name = "Test";

            // Rule is only applied if there is any complexity in request model
            var rules = new PlantCreateRules(this.plantRepository, plantEntity);
            rules.RunRules();
            foreach(var result in rules.Results)
            {
                if(result.ResultCode == RuleResultType.Fail && result.Exception != null)
                {
                    wrapper.Messages.Add(Messages.GetErrorDetail(
                        result.Exception.Code,
                        result.Exception.Message,
                        result.Exception.Element,
                        result.Exception.Category)
                        .ToDetailModel(result.Exception.ElementValue));
                }
            }

            if(rules.Result == RuleResultType.Fail)
            {
                wrapper.Messages.Add(Messages.EntityNotFound.ToDetailModel("12345"));
                return wrapper;
            }

            //wrapper.Messages.Add(Messages.EntityNotFound.ToDetailModel("12345"));
            //return wrapper;

            var response = new PlantResponseModel()
            {
                PlantId = "1001"
            };

            wrapper.Response = response;
            return wrapper;
        }
    }
}
