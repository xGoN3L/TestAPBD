namespace TestAPBD.Entities
{
    public class Tree_Species
    {
        public int SpeciesId { get; set; }
        public string LatinName { get; set; }
        public int GrowthTimeInYears { get; set; }
        public ICollection<Seedling_Batch> SeedlingBatches { get; set; }
    }
}
