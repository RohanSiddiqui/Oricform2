using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Oricform2.Models
{
    public class Patent
    {
        [Key]
        public int id { get; set; }

        [ForeignKey("OricForm2")]
        public int ric_form_2_id { get; set; }
        
        public OricForm2 OricForm2 { get; set; }

        public string filedorgranted { get; set; }
        public string nationalorinternational { get; set; }
        public string leadinventorname { get; set; }
        public string leadinventordesignation { get; set; }
        public string leadinventordepartment { get; set; }
        public string inventiontitle { get; set; }
        public string ipcategory { get; set; }
        public string developmentstatus { get; set; }
        public string keyscientificaspects { get; set; }
        public string? commercialpartner { get; set; }
        public string patentfiledwith { get; set; }
        public string patentgrantingauthority { get; set; }
        public string? financialsupport { get; set; }
        public DateTime dateoffiling { get; set; }
        public string? filingevidence { get; set; }
        public string? grantingevidence { get; set; }
    }
}
