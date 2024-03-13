using DataAccess.Domain.Masters.Plant;
using DataAccess.Interfaces.Masters;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories.Masters
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
            return await _context.PlantEntity.SingleOrDefaultAsync(x => x.Id == id);
        }

        public async Task<PlantSearchResponseEntity> SearchPlantAsync(PlantSearchRequestEntity request)
        {
            var response = new PlantSearchResponseEntity();
            IQueryable<PlantEntity> query = _context.PlantEntity;

            if (!string.IsNullOrWhiteSpace(request.PlantCode))
            {
                query = query.Where(t => t.PlantCode.Contains(request.PlantCode));
            }

            response.Plants = await query.Skip(request.Offset).Take(request.Count).ToListAsync();
            response.Paging.Results = response.Plants.Count();
            response.Paging.NextOffset = response.Paging.Total < request.Offset + request.Count ?
                null :
                (request.Offset + request.Count).ToString();
            return response;
        }
    }
}
