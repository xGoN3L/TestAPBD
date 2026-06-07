namespace TestAPBD.Entities
{
    public class Responsible
    {
        public int BatchId { get; set; }
        public Seedling_Batch Batch { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public string Role { get; set; }
    }
}
