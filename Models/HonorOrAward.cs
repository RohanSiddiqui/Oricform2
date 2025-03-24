using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Oricform2.Models
{
    public class HonorOrAward
    {
        [Key] public int id { get; set; }

        [ForeignKey("OricForm2")] 
        public int ric_form_2_id{ get; set; }

        public OricForm2 OricForm2 { get; set; }

         public string title { get; set; }
         public string forumororganization { get; set; }
         public string awardreceived { get; set; }
        public string workdetails { get; set; }

        public decimal? prizemoney { get; set; }

         public string awardwinnerdetails { get; set; }

        public string? remarks { get; set; }
        public string? evidence { get; set; }

   
    }
}