using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Oricform2.Models
{
    public class ResearchPublication
    {
        [Key]
        public int id { get; set; }

        [ForeignKey("OricForm2")]
        public int ric_form_2_id { get; set; }
        

        public OricForm2 OricForm2 { get; set; }


        
        public string publicationcategory { get; set; } // W, X, Y (HJRS Categories)

        
        public string publicationreference { get; set; } // Full reference of the publication

        
        [Url]
        public string publicationlink { get; set; } // URL of the publication

        public string? evidence { get; set; } // Path for uploaded first page of the publication

    
    }
}
