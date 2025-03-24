namespace Oricform2.DTOs
{
    public class VisitRepresentativeDTO
    {
        public int id { get; set; }
        public int ric_form_2_id { get; set; }  // Foreign key reference

        public string? visitorname { get; set; }
        public DateTime visitdate { get; set; }
        public string? agenda { get; set; }
        public string? evidence { get; set; }
        
    }
}
