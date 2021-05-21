using HRDapp.Model.Applicant;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HRDapp.View.Applicant
{
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button(object sender, EventArgs e)
        {
            
            string msg = file_upload(FileUpload1);
            if (msg.Equals("-1"))
            {
                Response.Write("<script>alert('Ошибка при загрузке данных...');</script>");
            }
            else if (txtposition.Text == "Директор")
            {
                Response.Write("<script>alert('На предприятии уже есть директор.');</script>");
            }
            else
            {
                DateTime date1 = new DateTime(2003, 3, 4);
                Applicants ap = new Applicants();
                ap.ap_email = txtemail.Text;
                ap.ap_password = txtpassword.Text;
                ap.ap_name = txtusername.Text;
                ap.ap_position = txtposition.Text;

                ap.ap_phone1 = txtphone1.Text;
                ap.ap_phone2 = txtphone2.Text;
                ap.ap_image = msg;
                //ap.ap_dob = Convert.ToDateTime(datepicker.Text);
                
                ap.ap_dob = DateTime.Parse(datepicker.Text, new System.Globalization.CultureInfo("en-CA"));

               // ap.ap_dob = Convert.ToDateTime(datepicker.Text);
                ap.ap_salary = txtsalary.Text;
                if (Male.Checked == true)
                {
                    ap.ap_gender = 1;
                }
                else
                {
                    ap.ap_gender = 0;
                }
                ApplicantLogicLayer obj = new ApplicantLogicLayer();
                string msg2 = obj.insert(ap);
                if(msg2.Equals("1"))
                {
                    Response.Write("<script>alert('Данные успешно сохранены.');</script>");
                    Response.Redirect("~/View/Applicant/login.aspx");
                }
            }
        }

        public string file_upload(FileUpload fileupload)
        {
            string msg = "-1";
            if (fileupload.HasFile)
            {
                string fileextenion = Path.GetExtension(fileupload.FileName);
                if (fileextenion.ToLower() != ".png" && fileextenion.ToLower() != ".jpg")
                {
                    Response.Write("<script>alert('Только изображение может быть загружено, выберете jpg или png файл.');</script>");
                }
                else
                {
                    int filesize = fileupload.PostedFile.ContentLength;
                    if (filesize > 2097152)
                    {
                        Response.Write("<script>alert('Файл слишком большой.');</script>");
                    }
                    else
                    {
                        Random r = new Random();
                        int r1 = r.Next();
                        int r2 = r.Next();
                        msg = "~/Content/Uploads/" + r1 + r2 + fileupload.FileName;
                        fileupload.SaveAs(Server.MapPath(msg));
                    }
                }
            }
            else
            {
                Response.Write("<script>alert('Выберете файл.');</script>");
            }
            return msg;
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {

        }

        protected void datepicker_TextChanged(object sender, EventArgs e)
        {

        }
    }
}