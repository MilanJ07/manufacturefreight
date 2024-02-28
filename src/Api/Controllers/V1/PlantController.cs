using BusinessLogic.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.ResponseModels;
using Utilities.Contract;
using System;

namespace Api.Controllers.V1
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]/")]
    [ApiController]
    public class PlantController : CssControllerBase
    {
        public readonly IPlantService plantService;
        public PlantController(IPlantService plantService)
        {
            this.plantService = plantService;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            IResponseWrapper<PlantResponseModel> result = await this.plantService.GetAllPlant();
            return this.HandleResponse(result);
        }
    }
}
