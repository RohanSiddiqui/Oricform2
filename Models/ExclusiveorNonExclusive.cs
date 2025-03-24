using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Oricform2.Models
{
    public class ExclusiveOrNonExclusive
    {
        [Key]
        public int id { get; set; }


        [ForeignKey("OricForm2")]
        public int ric_form_2_id { get; set; }

        public OricForm2 OricForm2 { get; set; }


      
        public string licensetype { get; set; } // "Exclusive" or "Non-Exclusive"

        
        public string licenseregion { get; set; } // "National" or "International"

        
        public string leadinventorname { get; set; }

        
        public string leadinventordesignation { get; set; }

       
        public string leadinventordepartment { get; set; }

       
        public string inventiontitle { get; set; }

        
        public string ipcategory { get; set; } // "Patent", "Trademark", etc.

        
        public string developmentstatus { get; set; } // "Prototype", "Validation", etc.

        
        public string keyscientificaspects { get; set; } // Milestones

        
        public string fieldofuse { get; set; }

       
        public string dateanddurationofagreement { get; set; }

       
        public string licensedetails { get; set; } // Name, Organization

        public string? evidence { get; set; }

       
    }
}
