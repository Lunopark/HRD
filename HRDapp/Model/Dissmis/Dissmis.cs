using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRDapp.Model.Dissmis
{
    public class Dissmis
    {
        public int dis_id { get; set; }
        public string dis_name { get; set; }
        public string dis_cause { get; set; }
        public string dis_position { get; set; }
        public string dis_phone1 { get; set; }
        public string dis_phone2 { get; set; }
        public string dis_email { get; set; }
        public DateTime dis_date { get; set; }
    }
}