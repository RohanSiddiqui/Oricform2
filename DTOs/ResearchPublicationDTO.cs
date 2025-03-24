namespace Oricform2.DTOs
{
    public class ResearchPublicationDTO
    {
        public int id { get; set; }
        public int ric_form_2_id { get; set; }  // Foreign key reference

        public string publicationcategory { get; set; }
        public string publicationreference { get; set; }
        public string publicationlink { get; set; }
        public string? evidence { get; set; }
        
    }
}
