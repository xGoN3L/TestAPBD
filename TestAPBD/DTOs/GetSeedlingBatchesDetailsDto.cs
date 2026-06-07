using TestAPBD.Entities;

namespace TestAPBD.DTOs
{
    public class GetSeedlingBatchesDetailsDto
    {
        public int BatchId { get; set; }
        public int Quantity { get; set; }
        public DateTime SownDate { get; set; }
        public DateTime? ReadyDate { get; set; }
        public int SpeciesId { get; set; }
        public SpeciesInfoDto Species { get; set; }
        public IEnumerable<ResponsibleDto> Responsibles { get; set; }
    }
}
