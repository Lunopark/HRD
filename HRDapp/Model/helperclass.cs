using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using System.Configuration;

namespace HRDapp.Model
{
    public class helperclass
    {
        private string connstring = ConfigurationManager.ConnectionStrings["HRD"].ConnectionString;
        public string scalarReturn(string q)
        {
            string s;
            SqlConnection conn = new SqlConnection(connstring);
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(q, conn);
                s = cmd.ExecuteScalar().ToString();
            }
            catch(Exception)
            {
                s = "-1";
            }
            
            return s;

        }
    }
}