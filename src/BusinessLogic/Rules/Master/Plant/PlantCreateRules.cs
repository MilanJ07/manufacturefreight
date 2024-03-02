using DataAccess.Domain.Masters;
using DataAccess.Interfaces;

namespace BusinessLogic.Rules.Master.Plant
{
    public partial class PlantCreateRules : RuleBase<PlantCreateRules>
    {
        private readonly IPlantRepository? plantRepository;
        public PlantCreateRules(IPlantRepository plantRepository, PlantEntity plantEntity)
        {
            this.plantRepository = plantRepository;
            this.PlantEntity = plantEntity;
        }

        private PlantEntity PlantEntity { get; }
    }
}
