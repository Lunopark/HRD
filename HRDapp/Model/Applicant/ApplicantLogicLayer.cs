using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace HRDapp.Model.Applicant
{
    public class ApplicantLogicLayer
    {
        private string connstring = ConfigurationManager.ConnectionStrings["HRD"].ConnectionString;

        public string insert(Applicants ap)
        {
            string msg = "-1";
            SqlConnection con = new SqlConnection(connstring);
            try
            {
                SqlCommand cmd = new SqlCommand("sp_insertemployee", con);
                con.Open();                
                cmd.CommandType = CommandType.StoredProcedure;            
                cmd.Parameters.Add("@ap_name", SqlDbType.NVarChar).Value = ap.ap_name;
                cmd.Parameters.Add("@ap_password", SqlDbType.NVarChar, 20).Value = ap.ap_password;
                cmd.Parameters.Add("@ap_position", SqlDbType.NVarChar).Value = ap.ap_position;
                cmd.Parameters.Add("@ap_phone1", SqlDbType.NVarChar, 30).Value = ap.ap_phone1;
                cmd.Parameters.Add("@ap_phone2", SqlDbType.NVarChar, 30).Value = ap.ap_phone2;
                cmd.Parameters.Add("@ap_email", SqlDbType.NVarChar, 30).Value = ap.ap_email;
                cmd.Parameters.Add("@ap_image", SqlDbType.NVarChar).Value = ap.ap_image;
                cmd.Parameters.Add("@ap_gender", SqlDbType.Int).Value = ap.ap_gender;
                cmd.Parameters.Add("@ap_dob", SqlDbType.Date).Value = ap.ap_dob;  
                cmd.Parameters.Add("@ap_salary", SqlDbType.NVarChar, 10).Value = ap.ap_salary;
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

        public string Update(Applicants ap)
        {
            string msg = "-1";
            SqlConnection con = new SqlConnection(connstring);
            try
            {
                SqlCommand cmd = new SqlCommand("sp_updatepersonaldetails", con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ap_name", SqlDbType.NVarChar).Value = ap.ap_name;
                
                cmd.Parameters.Add("@ap_position", SqlDbType.NVarChar).Value = ap.ap_position;
                cmd.Parameters.Add("@ap_phone1", SqlDbType.NVarChar, 30).Value = ap.ap_phone1;
                cmd.Parameters.Add("@ap_phone2", SqlDbType.NVarChar, 30).Value = ap.ap_phone2;
                cmd.Parameters.Add("@ap_email", SqlDbType.NVarChar, 30).Value = ap.ap_email;
             
            
                cmd.Parameters.Add("@ap_dob", SqlDbType.Date).Value = ap.ap_dob;
                cmd.Parameters.Add("@ap_salary", SqlDbType.NVarChar, 10).Value = ap.ap_salary;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = ap.ap_id;
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
        }
    }
}