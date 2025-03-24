﻿namespace Oricform2.DTOs
{
    public class ScienceArtsProductDTO
    {
        
            public int id { get; set; }
        public int ric_form_2_id { get; set; }  // Foreign key reference

        public string? displayregion { get; set; }
            public string? title { get; set; }
            public string? leadname { get; set; }
            public string? leaddesignation { get; set; }
            public string? leaddepartment { get; set; }
            public string? productcategory { get; set; }
            public string? forum { get; set; }
            public string? status { get; set; }
            public string? financialsupport { get; set; }
            public string? fieldofuse { get; set; }
            public string? evidence { get; set; }
            
        }

    }

