using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRDapp.Model.Qualification
{
    public class QualificationSSC
    {
        public int ssc_id { get; set; }
        public float ssc_precentage{ get; set; }
        public string ssc_institue { get; set; }
        public string ssc_doc { get; set; }
        public string ssc_fk_ap_id { get; set; }
    }
}