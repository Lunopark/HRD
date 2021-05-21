using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRDapp.Model.Applicant
{
    public class Applicants
    {
        public int ap_id { get; set; }
        public string ap_name {get; set;}
        public string ap_password { get; set; }
        public string ap_position { get; set; }
        public string ap_phone1 { get; set; }
        public string ap_phone2 { get; set; }
        public string ap_email { get; set; }
        public string ap_image { get; set; }
        public int ap_gender { get; set; }
        public DateTime ap_dob { get; set; }
        public string ap_salary { get; set; }
    }
}