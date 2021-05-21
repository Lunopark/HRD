using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace HRDapp.Model.Dissmis
{
    public class DissmisLogicLayer
    {
        private string connstring = ConfigurationManager.ConnectionStrings["HRD"].ConnectionString;

        public string insert(Dissmis ds)
        {
            string msg = "-1";
            SqlConnection con = new SqlConnection(connstring);
            try
            {
                SqlCommand cmd = new SqlCommand("sp_insertdissmis", con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@dis_name", SqlDbType.NVarChar).Value = ds.dis_name;
                cmd.Parameters.Add("@dis_cause", SqlDbType.NVarChar).Value = ds.dis_cause;
                cmd.Parameters.Add("@dis_position", SqlDbType.NVarChar).Value = ds.dis_position;
                cmd.Parameters.Add("@dis_phone1", SqlDbType.NVarChar, 30).Value = ds.dis_phone1;
                cmd.Parameters.Add("@dis_phone2", SqlDbType.NVarChar, 30).Value = ds.dis_phone2;
                cmd.Parameters.Add("@dis_email", SqlDbType.NVarChar, 30).Value = ds.dis_email;
                cmd.Parameters.Add("@dis_date", SqlDbType.Date).Value = ds.dis_date;

                cmd.ExecuteNonQuery();
                msg = "1";
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.Close();
            }

            return msg;
        } //insert end
    }
}