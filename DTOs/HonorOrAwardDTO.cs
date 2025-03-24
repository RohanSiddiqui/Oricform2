namespace Oricform2.DTOs
{
    public class HonorOrAwardDTO
    {
        public int id { get; set; }
        public int ric_form_2_id { get; set; }  // Foreign key reference

        public string title { get; set; }
        public string forumororganization { get; set; }
        public string awardreceived { get; set; }
        public string workdetails { get; set; }
        public decimal? prizemoney { get; set; }
        public string awardwinnerdetails { get; set; }
        public string? remarks { get; set; }
        public string? evidence { get; set; }
       
    }
}
