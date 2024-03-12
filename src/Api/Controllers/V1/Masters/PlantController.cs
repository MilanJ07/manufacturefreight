using BusinessLogic.Interfaces.Masters;
using Microsoft.AspNetCore.Mvc;
using Models.RequestModels.Masters.Plant;
using Models.ResponseModels.Masters.Plant;
using Utilities.Contract;

namespace Api.Controllers.V1.Masters
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/plant/")]
    [ApiController]
    public class PlantController : CssControllerBase
    {
        public readonly IPlantService plantService;
        public PlantController(IPlantService plantService)
        {
            this.plantService = plantService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> Get(decimal id)
        {
            IResponseWrapper<PlantSearchResponseModel> result = await plantService.GetPlantAsync(id);
            return HandleResponse(result);
        }

        [HttpPost("search")]
        public async Task<ActionResult> Search(PlantSearchRequestModel requestModel, [FromQuery] string? offset = null, [FromQuery] string? count = null)
        {
            IResponseWrapper<PlantSearchResponse> result = await plantService.SearchPlantAsync(requestModel, offset, count);
            return HandleResponse(result);
        }
    }
}
