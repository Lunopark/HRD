using HRDapp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HRDapp.View.Applicant
{
    public partial class login : System.Web.UI.Page
    {
        helperclass hc = new helperclass();
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Session["u_id"] == null)
            //{
            //    Response.Redirect("~/View/Applicant/login.aspx");
            //}
        }


        protected void Button(object sender, EventArgs e)
        {
            string count = hc.scalarReturn("select count(ap_id) from tbl_applicant_personal where ap_email='"+txtlogemail.Text+"'");
            if (count.Equals("0"))
            {
                Label2.Text = "Такого аккаунта не существует..";
                //Response.Write("<script>alert('Такого аккаунта не существует...');</script>");
            }
            else
            {
                string pwdfromdb = hc.scalarReturn("select ap_password from tbl_applicant_personal where ap_email='" + txtlogemail.Text +"'");
                if (pwdfromdb.Equals(txtlogpassword.Text))
                {
                    Session["u_id"] = hc.scalarReturn("select ap_id from tbl_applicant_personal where ap_email='" + txtlogemail.Text + "'");
                    Response.Redirect("~/View/Applicant/profile.aspx");
                }
                else
                {
                    Label2.Text = "Неверный пароль.";
                    //Response.Write("<script>alert('Неверный пароль.');</script>");
                }
            }
        }
    }
}