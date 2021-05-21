using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRDapp.Model.Qualification
{
    public class QualificaticGRAD
    {
        public int grad_id { get; set; }
        public float grad_precentage { get; set; }
        public string grad_institue { get; set; }
        public string grad_doc { get; set; }
        public string grad_fk_ap_id { get; set; }
    }
}