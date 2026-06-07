namespace TestAPBD.Entities
{
    public class Nursery
    {
        public int NurseryId { get; set; }
        public string Name { get; set; }
        public DateTime EstablishedDate { get; set; }
        public ICollection<Seedling_Batch> SeedlingBatches { get; set; }
    }
}
