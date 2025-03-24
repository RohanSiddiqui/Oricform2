using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Oricform2.Models
{
    public class IPLicensingNegotiation
    {
        [Key]
        public int id { get; set; }

        [ForeignKey("OricForm2")]
        public int ric_form_2_id { get; set; }
        
        public OricForm2 OricForm2 { get; set; }

        public string licensing_type { get; set; }
        public string lead_inventor_name { get; set; }
        public string lead_inventor_designation { get; set; }
        public string lead_inventor_department { get; set; }
        public string invention_title { get; set; }
        public string ip_category { get; set; }
        public string development_status { get; set; }
        public string key_scientific_aspects { get; set; }
        public string field_of_use { get; set; }
        public string duration_of_agreement { get; set; }
        public string license_details { get; set; }
        public string status_of_negotiation { get; set; }
        public string? evidence { get; set; }
    }
}
