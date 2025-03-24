using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Oricform2.Models
{
    public class TrainingWorkshopSeminar
    {
        [Key]
        public int id { get; set; }

        [ForeignKey("OricForm2")]
        public int ric_form_2_id { get; set; }
        
        public OricForm2 OricForm2 { get; set; }
        
        public string eventtype { get; set; } // Training, Workshop, Seminar, Conference, Other

       
        public string eventlevel { get; set; } // National or International

        
        public string title { get; set; } // Title of Event

        
        public DateTime eventdate { get; set; } // Date of Event

        
        public int numberofparticipants { get; set; } // No. of Participants

        
        public string focusandoutcomes { get; set; } // Major Focus Area & Outcomes

        public string? evidence { get; set; }// Path for uploaded file (Event Certificate/Photograph)

    }
}
