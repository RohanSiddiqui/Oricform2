using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Oricform2.Models
{
    public class ResearchProduct
    {
        [Key]
        public int id { get; set; }

        [ForeignKey("OricForm2")]
        public int ric_form_2_id { get; set; }
        
        public OricForm2 OricForm2 { get; set; }

        public string researchregion { get; set; }
        public string leadinventorname { get; set; }
        public string leadinventordesignation { get; set; }
        public string leadinventordepartment { get; set; }
        public string inventiontitle { get; set; }
        public string ipcategory { get; set; }
        public string developmentstatus { get; set; }
        public string keyscientificaspects { get; set; }
        public string fieldofuse { get; set; }
        public string collaboratingindustrialpartner { get; set; }
        public string? financialsupport { get; set; }
        public string? remarks { get; set; }
        public string? evidence { get; set; }


    }
}
