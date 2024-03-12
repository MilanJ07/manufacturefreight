using AutoMapper;
using BusinessLogic.Interfaces;
using BusinessLogic.Interfaces.Masters;
using BusinessLogic.Rules.Enums;
using BusinessLogic.Rules.Master.Plant;
using DataAccess.Domain.Masters.Plant;
using DataAccess.Interfaces;
using DataAccess.Interfaces.Masters;
using Models.RequestModels.Masters.Plant;
using Models.ResponseModels.Masters.Plant;
using Utilities.Constants;
using Utilities.Contract;
using Utilities.Implementation;
using Utilities.MessageStatus;

namespace BusinessLogic.Services.Masters
{
    public class PlantService : IPlantService
    {
        private readonly IPlantRepository plantRepository;
        private readonly IMapper mapper;
        public PlantService(
            IPlantRepository plantRepository,
            IMapper mapper)
        {
            this.plantRepository = plantRepository;
            this.mapper = mapper;
        }

        public async Task<IResponseWrapper<PlantSearchResponseModel>> GetPlantAsync(decimal id)
        {
            var wrapper = new ResponseWrapper<PlantSearchResponseModel>();
            PlantEntity? plantEntity = await plantRepository.FindAsync(id);

            if (plantEntity == null)
            {
                wrapper.Messages.Add(Messages.EntityNotFound.ToDetailModel(id.ToString()));
            }

            PlantSearchResponseModel response = mapper.Map<PlantSearchResponseModel>(plantEntity);

            wrapper.Response = response;

            return wrapper;
        }

        public async Task<IResponseWrapper<PlantSearchResponse>> SearchPlantAsync(PlantSearchRequestModel requestModel, string? offset, string count)
        {
            var wrapper = new ResponseWrapper<PlantSearchResponse>();

            PlantSearchRequestEntity? request = mapper.Map<PlantSearchRequestEntity>(requestModel);

            /*var rules = new PlantSearchRules(request, offset, count);
            rules.RunRules();
            foreach (var result in rules.Results)
            {
                if (result.ResultCode == RuleResultType.Fail && result.Exception != null)
                {
                    wrapper.Messages.Add(Messages.GetErrorDetail(
                        result.Exception.Code,
                        result.Exception.Message,
                        result.Exception.Element,
                        result.Exception.Category)
                        .ToDetailModel(result.Exception.ElementValue));
                }
            }

            if (rules.Result == RuleResultType.Fail)
            {
                return wrapper;
            }*/

            PlantSearchResponseEntity entityResponse = await plantRepository.SearchPlantAsync(request);
            PlantSearchResponse plantSearchResponse = mapper.Map<PlantSearchResponse>(entityResponse);

            wrapper.Response = plantSearchResponse;

            return wrapper;
        }
    }
}
