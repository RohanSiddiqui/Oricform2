using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Oricform2.Models
{
    public class IPDisclosure
    {
        [Key]
        public int id { get; set; }

        [ForeignKey("OricForm2")]
        public int ric_form_2_id { get; set; }

        public OricForm2 OricForm2 { get; set; }
       
        public string leadinventorname { get; set; }

       
        public string leadinventordesignation { get; set; }

        
        public string leadinventordepartment { get; set; }

        
        public string inventiontitle { get; set; }

        
        public string ipcategory { get; set; } // "Patents", "Trade mark", "Design patent", etc.

        
        public string developmentstatus { get; set; } // "Idea", "Prototype", etc.

       
        public string keyscientificaspects { get; set; }

        public string? commercialpartner { get; set; }

       
        public string disclosuremadewith { get; set; } // Name and details of patent dept or attorney

        
        public DateTime disclosuremadedate { get; set; }

        public string? financialsupport { get; set; }

        public string? previousdisclosure { get; set; }

      
        public string? evidence { get; set; } // Path for "IP Disclosure Form Copy"

    }
}
