namespace Oricform2.DTOs
{
    public class AgreementSignedDTO
    {

        public int id { get; set; }
        public int ric_form_2_id { get; set; }  // Foreign key reference

        public string typeoflinkage { get; set; }
        public string nationalorinternational { get; set; }
        public string hostinstitutionnameandaddress { get; set; }
        public string duration { get; set; }
        public string keyinitiatives { get; set; }
        public string field { get; set; }
        public string scopeofcollaboration { get; set; }
        public DateTime linkageestablishmentdate { get; set; }
        public string? financialsupport { get; set; }
        public string? evidence { get; set; }

    }
}
