using DataAccess.Domain.Masters;
using DataAccess.Interfaces;

namespace DataAccess.Repositories
{
    public class PlantRepository : IPlantRepository
    {
        public PlantRepository()
        {
            
        }

        public Task<PlantEntity?> AddAsync(PlantEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<PlantEntity?> FindAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
