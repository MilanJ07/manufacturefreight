using BusinessLogic.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Models.RequestModels.Plant;
using Models.ResponseModels.Plant;
using Utilities.Contract;

namespace Api.Controllers.V1
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
            IResponseWrapper<PlantSearchResponseModel> result = await this.plantService.GetPlantAsync(id);
            return this.HandleResponse(result);
        }

        [HttpPost("search")]
        public async Task<ActionResult> Search(PlantSearchRequestModel requestModel, [FromQuery] string? offset = null, [FromQuery] string? count = null)
        {
            IResponseWrapper<PlantSearchResponse> result = await this.plantService.SearchPlantAsync(requestModel, offset, count);
            return this.HandleResponse(result);
        }
    }
}
