using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace HRDapp.Model.Qualification
{
    public class QualificationLogicLayer
    {
        private string connstring = ConfigurationManager.ConnectionStrings["HRD"].ConnectionString;

        public string insert(QualificationSSC ssc)
        {
            string msg = "-1";
            SqlConnection con = new SqlConnection(connstring);
            try
            {
                SqlCommand cmd = new SqlCommand("sp_sscinsert", con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ssc_precentage", SqlDbType.Float).Value = ssc.ssc_precentage;
                cmd.Parameters.Add("@ssc_institue", SqlDbType.NVarChar, 100).Value = ssc.ssc_institue;
                cmd.Parameters.Add("@ssc_doc", SqlDbType.NVarChar).Value = ssc.ssc_doc;
                cmd.Parameters.Add("@ssc_fk_ap_id", SqlDbType.Int).Value = ssc.ssc_fk_ap_id;
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
        public string insert(QualificationHSC hsc)
        {
            string msg = "-1";
            SqlConnection con = new SqlConnection(connstring);
            try
            {
                SqlCommand cmd = new SqlCommand("sp_hscinsert", con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@hsc_precentage", SqlDbType.Float).Value = hsc.hsc_precentage;
                cmd.Parameters.Add("@hsc_institue", SqlDbType.NVarChar, 100).Value = hsc.hsc_institue;
                cmd.Parameters.Add("@hsc_doc", SqlDbType.NVarChar).Value = hsc.hsc_doc;
                cmd.Parameters.Add("@hsc_fk_ap_id", SqlDbType.Int).Value = hsc.hsc_fk_ap_id;
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
        public string insert(QualificaticGRAD grad)
        {
            string msg = "-1";
            SqlConnection con = new SqlConnection(connstring);
            try
            {
                SqlCommand cmd = new SqlCommand("sp_gradinsert", con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@grad_precentage", SqlDbType.Float).Value = grad.grad_precentage;
                cmd.Parameters.Add("@grad_institue", SqlDbType.NVarChar, 100).Value = grad.grad_institue;
                cmd.Parameters.Add("@grad_doc", SqlDbType.NVarChar).Value = grad.grad_doc;
                cmd.Parameters.Add("@grad_fk_ap_id", SqlDbType.Int).Value = grad.grad_fk_ap_id;
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
        public string insert(QualityMAS mas)
        {
            string msg = "-1";
            SqlConnection con = new SqlConnection(connstring);
            try
            {
                SqlCommand cmd = new SqlCommand("sp_masinsert", con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@mas_precentage", SqlDbType.Float).Value = mas.mas_precentage;
                cmd.Parameters.Add("@mas_institue", SqlDbType.NVarChar, 100).Value = mas.mas_institue;
                cmd.Parameters.Add("@mas_doc", SqlDbType.NVarChar).Value = mas.mas_doc;
                cmd.Parameters.Add("@mas_fk_ap_id", SqlDbType.Int).Value = mas.mas_fk_ap_id;
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