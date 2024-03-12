using DataAccess.Domain.Masters.Plant;

namespace DataAccess.Interfaces
{
    public interface IPlantRepository : IRepository<PlantEntity>
    {
        Task<PlantSearchResponseEntity> SearchPlantAsync(PlantSearchRequestEntity request);
    }
}
