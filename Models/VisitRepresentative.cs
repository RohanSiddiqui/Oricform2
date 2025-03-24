using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Oricform2.Models
{
    public class VisitRepresentative
    {
        [Key]
        public int id { get; set; }

        [ForeignKey("OricForm2")]
        public int ric_form_2_id { get; set; }

        public OricForm2 OricForm2 { get; set; }
        
        public string visitorname { get; set; }

        
        [DataType(DataType.Date)]
        public DateTime visitdate { get; set; }

        [Required]
        public string agenda { get; set; }

        public string? evidence { get; set; } // Path for uploaded file

    }
}
