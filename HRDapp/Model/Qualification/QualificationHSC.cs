using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRDapp.Model.Qualification
{
    public class QualificationHSC
    {
        public int hsc_id { get; set; }
        public float hsc_precentage { get; set; }
        public string hsc_institue { get; set; }
        public string hsc_doc { get; set; }
        public string hsc_fk_ap_id { get; set; }
    }
}