using DataAccess.Domain.Masters.Plant;
using DataAccess.Interfaces;

namespace DataAccess.Repositories
{
    public class PlantRepository : IPlantRepository
    {
        private readonly ApplicationDbContext _context;
        public PlantRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task<PlantEntity?> AddAsync(PlantEntity entity)
        {
            throw new NotImplementedException();
        }

        public async Task<PlantEntity?> FindAsync(decimal id)
        {
            return _context.PlantEntity.Where(x => x.Id == id).SingleOrDefault();
        }

        public async Task<PlantSearchResponseEntity> SearchPlantAsync(PlantSearchRequestEntity request)
        {
            var response = new PlantSearchResponseEntity();
            response.Plants = _context.PlantEntity.ToList();
            response.Paging.Results = response.Plants.Count();
            response.Paging.NextOffset = response.Paging.Total < request.Offset + request.Count ?
                null :
                (request.Offset + request.Count).ToString();
            return response;
        }
    }
}
