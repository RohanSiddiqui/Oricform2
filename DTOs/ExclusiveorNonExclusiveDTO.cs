namespace Oricform2.DTOs
{
    public class ExclusiveOrNonExclusiveDTO
    {
        public int id { get; set; }
        public int ric_form_2_id { get; set; }  // Foreign key reference

        public string licensetype { get; set; }
        public string licenseregion { get; set; }
        public string leadinventorname { get; set; }
        public string leadinventordesignation { get; set; }
        public string leadinventordepartment { get; set; }
        public string inventiontitle { get; set; }
        public string ipcategory { get; set; }
        public string developmentstatus { get; set; }
        public string keyscientificaspects { get; set; }
        public string fieldofuse { get; set; }
        public string dateanddurationofagreement { get; set; }
        public string licensedetails { get; set; }
        public string? evidence { get; set; }
       
    }
}
