using Models.ResponseModels.BaseResponseSetup;

namespace DataAccess.Domain.Masters.Plant
{
    public class PlantSearchResponseEntity
    {
        public IEnumerable<PlantEntity>? Plants { get; set; } = new List<PlantEntity>();
        public PagingModel Paging { get; set; } = new PagingModel();
    }
}
