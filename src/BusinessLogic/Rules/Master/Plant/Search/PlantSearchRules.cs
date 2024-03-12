using DataAccess.Domain.Masters.Plant;

namespace BusinessLogic.Rules.Master.Plant
{
    public partial class PlantSearchRules : RuleBase<PlantSearchRules>
    {
        public PlantSearchRules(PlantSearchRequestEntity plantSearchRequestEntity, string? offset, string? count)
        {
            this.PlantSearchRequestEntity = plantSearchRequestEntity;
            this.Offset = offset;
            this.Count = count;
        }

        private PlantSearchRequestEntity PlantSearchRequestEntity { get; }
        private string? Offset { get; set; }
        private string? Count { get; set; }
    }
}
