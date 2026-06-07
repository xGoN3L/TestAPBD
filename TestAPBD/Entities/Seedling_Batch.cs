namespace TestAPBD.Entities
{
    public class Seedling_Batch
    {
        public int BatchId { get; set; }
        public int NurseryId { get; set; }
        public Nursery Nursery { get; set; }
        public int SpeciesId { get; set; }
        public Tree_Species Species { get; set; }
        public int Quantity { get; set; }
        public DateTime SownDate { get; set; }
        public DateTime? ReadyDate { get; set; }
        public ICollection<Responsible> Responsibles { get; set; }
    }
}
