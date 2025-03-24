using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Oricform2.Models
{
    public class AgreementSigned
    {
        [Key]
        public int id { get; set; }

        [ForeignKey("OricForm2")]
        public int ric_form_2_id { get; set; }

        public OricForm2 OricForm2 { get; set; }

       
        public string typeoflinkage { get; set; } // Academic, Research

        
        public string nationalorinternational { get; set; } // National, International

        
        public string hostinstitutionnameandaddress { get; set; }

        
        public string duration { get; set; }

        
        public string keyinitiatives { get; set; }

        
        public string field { get; set; }

       
        public string scopeofcollaboration { get; set; }

        
        [DataType(DataType.Date)]
        public DateTime linkageestablishmentdate { get; set; }

        public string? financialsupport { get; set; }
        public string? evidence { get; set; } // Path for uploaded file

       
    }
}
