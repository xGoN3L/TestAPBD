using TestAPBD.Entities;

namespace TestAPBD.DTOs
{
    public class GetNurcesiesWithAllInformationsDto
    {
        public int NurseryId { get; set; }
        public string Name { get; set; }
        public DateTime EstablishedDate { get; set; }
        public IEnumerable<GetSeedlingBatchesDetailsDto> Batches { get; set; }
    }
}
