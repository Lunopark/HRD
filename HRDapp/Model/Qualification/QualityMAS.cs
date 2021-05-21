using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRDapp.Model.Qualification
{
    public class QualityMAS
    {
        public int mas_id { get; set; }
        public float mas_precentage { get; set; }
        public string mas_institue { get; set; } 
        public string mas_doc { get; set; }
        public string mas_fk_ap_id { get; set; }
    }
}