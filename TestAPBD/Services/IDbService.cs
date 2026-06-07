using TestAPBD.DTOs;
using TestAPBD.Entities;

namespace TestAPBD.Services
{
    public interface IDbService
    {
        Task<AddNurseryDto> AddNursery(AddNurseryDto nurseryDto);
        Task<List<GetNurcesiesWithAllInformationsDto>> GetBatches(int id);
    }
}
