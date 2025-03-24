using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Oricform2.Models
{
    public class ScienceArtsProduct
    {
        [Key]
        public int id { get; set; }

        [ForeignKey("OricForm2")] // Matches navigation property name
        public int ric_form_2_id { get; set; }

        public OricForm2 OricForm2 { get; set; } // Navigation property
    

        public string displayregion { get; set; } // "National" or "International"

        
        public string title { get; set; }

       
        public string leadname { get; set; }

       
        public string leaddesignation { get; set; }

       
        public string leaddepartment { get; set; }

        
        public string productcategory { get; set; } // "Science", "Arts", "Design Product", etc.

       
        public string forum { get; set; } // Forum where registered/performed/displayed

       
        public string status { get; set; }

        public string? financialsupport { get; set; } // Optional

        
        public string fieldofuse { get; set; }

        public string? evidence { get; set; } // Path for uploaded file

    }
}
