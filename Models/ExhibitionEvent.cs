using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Oricform2.Models
{
    public class ExhibitionEvent
    {
        [Key]
        public int id { get; set; }

  
        [ForeignKey("OricForm2")]
        public int ric_form_2_id { get; set; }


        public OricForm2 OricForm2 { get; set; }
 

        
        public string eventlevel { get; set; }

        
        public string eventtype { get; set; }

       
        public DateTime eventdate { get; set; }

        
        public int numberofparticipants { get; set; }

        
        public string focusandoutcomes { get; set; }

        
        public string audiencetype { get; set; }

        public string? evidence { get; set; }

     
    }
}
