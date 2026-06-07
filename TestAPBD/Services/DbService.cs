using Microsoft.EntityFrameworkCore;
using TestAPBD.Data;
using TestAPBD.DTOs;
using TestAPBD.Entities;
using TestAPBD.Exceptions;

namespace TestAPBD.Services
{
    public class DbService : IDbService
    {
        private readonly AppDbContext _dbContext;
        public DbService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<AddNurseryDto> AddNursery(AddNurseryDto nurseryDto)
        {
            var nursery = new Nursery
            {
                Name = nurseryDto.Nursery,
                EstablishedDate = DateTime.Now,
                

            };
            return null;
        }

        public async Task<List<GetNurcesiesWithAllInformationsDto>> GetBatches(int id)
        {
            var nursery = await _dbContext.Nursery.Where(n => n.NurseryId == id).FirstOrDefaultAsync();
            if(nursery == null)
            {
                throw new NotFoundException("Nursery not found");
            }
            var result = await _dbContext.Nursery.Where(n => n.NurseryId == id).Select(n => new GetNurcesiesWithAllInformationsDto
            {
                NurseryId = n.NurseryId,
                Name = n.Name,
                EstablishedDate = n.EstablishedDate,
                Batches = n.SeedlingBatches.Select(b => new GetSeedlingBatchesDetailsDto
                {
                    BatchId = b.BatchId,
                    Quantity = b.Quantity,
                    SownDate = b.SownDate,
                    ReadyDate = b.ReadyDate,
                    Species = new SpeciesInfoDto()
                    {
                        LatinName = b.Species.LatinName,
                        GrowthTimeInYears = b.Species.GrowthTimeInYears
                    },
                    Responsibles = b.Responsibles.Select(r => new ResponsibleDto
                    {
                        FirstName = r.Employee.FirstName,
                        LastName = r.Employee.LastName,
                        Role = r.Role
                    }).ToList()
                })
            }).ToListAsync();
            return result;
        }
    }
}
