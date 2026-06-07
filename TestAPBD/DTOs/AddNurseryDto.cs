namespace TestAPBD.DTOs
{
    public class AddNurseryDto
    {
        public int Quantity { get; set; }
        public string Species { get; set; }
        public string Nursery { get; set; }
        public AddNurseyResponsibleDto Responsible { get; set; }
    }
}
