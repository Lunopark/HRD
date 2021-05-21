using HRDapp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using HRDapp.Model.Applicant;
using System.IO;
using HRDapp.Model.Qualification;
using System.Drawing;
using HRDapp.Model.Dissmis;

namespace HRDapp.View.Applicant
{
    public partial class profile : System.Web.UI.Page
    {
        HRDEntities db = new HRDEntities();
        private string connstring = ConfigurationManager.ConnectionStrings["HRD"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            GridViewschedule.Visible = false;
            Panelschedule.Visible = false;
            GridViewUslug.Visible = false;
            Paneluslug.Visible = false;
            TextBoxCouse.Visible = false;
            Panelarhiv.Visible = false;
            ButtonDissmis.Visible = false;
            Panel5.Visible = false;
            GridViewSearch.Visible = false;
            Panel4.Visible = false;
            Pmasters.Visible = false;
            PSSC.Visible = false;
            PHSC.Visible = false;
            PGRAD.Visible = false;
            Panel1.Visible = true;
            Panel2.Visible = false;
            Panel3.Visible = false;

            string q = "select ap_image, ap_name, ap_position, ap_phone1, ap_phone2, ap_email, ap_gender, ap_dob, ap_salary from tbl_applicant_personal where ap_id =" + Session["u_id"];
            SqlConnection conn = new SqlConnection(connstring);
            try
            {
                SqlCommand cmd = new SqlCommand(q, conn);
                conn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Label1.Text = rdr.GetValue(1).ToString();
                    Label2.Text = rdr.GetValue(2).ToString();
                    if (rdr.GetValue(2).ToString().Equals("Директор"))
                    {
                        admin.Text = "  Admin";
                        GridView1.Columns[0].Visible = true;
                        dept.Text = "Управляющий";
                    }
                    else if (rdr.GetValue(2).ToString().Equals("Бухгалтер"))
                    {
                        admin.Text = " ";
                        GridView1.Columns[0].Visible = false;
                        dept.Text = "Управляющий";
                    }
                    else if (rdr.GetValue(2).ToString().Equals("Управляющий автосервиса"))
                    {
                        admin.Text = " ";
                        GridView1.Columns[0].Visible = false;
                        dept.Text = "Управляющий";
                    }
                    else if (rdr.GetValue(2).ToString().Equals("Менеджер по запчастям"))
                    {
                        admin.Text = " ";
                        GridView1.Columns[0].Visible = false;
                        dept.Text = "Менеджерский";
                    }
                    else if (rdr.GetValue(2).ToString().Equals("Менеджер по работе с клиентами"))
                    {
                        admin.Text = " ";
                        GridView1.Columns[0].Visible = false;
                        dept.Text = "Менеджерский";
                    }
                    else if (rdr.GetValue(2).ToString().Equals("Инженер автосервиса"))
                    {
                        admin.Text = " ";
                        GridView1.Columns[0].Visible = false;
                        dept.Text = "Инженерии";
                    }
                    else if (rdr.GetValue(2).ToString().Equals("Инженер по гарантии"))
                    {
                        admin.Text = " ";
                        GridView1.Columns[0].Visible = false;
                        dept.Text = "Инженерии";
                    }
                    else if (rdr.GetValue(2).ToString().Equals("Работник кузовного цеха"))
                    {
                        admin.Text = " ";
                        GridView1.Columns[0].Visible = false;
                        dept.Text = "Кузовных работ";
                    }
                    else if (rdr.GetValue(2).ToString().Equals("Автомаляр"))
                    {
                        admin.Text = " ";
                        GridView1.Columns[0].Visible = false;
                        dept.Text = "Покраски";
                    }
                    else if (rdr.GetValue(2).ToString().Equals("Автомеханик"))
                    {
                        admin.Text = " ";
                        GridView1.Columns[0].Visible = false;
                        dept.Text = "Технических работ";
                    }
                    else if (rdr.GetValue(2).ToString().Equals("Автомеханик"))
                    {
                        admin.Text = " ";
                        GridView1.Columns[0].Visible = false;
                        dept.Text = "Технических работ";
                    }
                    else if (rdr.GetValue(2).ToString().Equals("Автослесарь"))
                    {
                        admin.Text = " ";
                        GridView1.Columns[0].Visible = false;
                        dept.Text = "Технических работ";
                    }
                    else if (rdr.GetValue(2).ToString().Equals("Автоэлектрик"))
                    {
                        admin.Text = " ";
                        GridView1.Columns[0].Visible = false;
                        dept.Text = "Электрики";
                    }
                    else if (rdr.GetValue(2).ToString().Equals("Шиномонтажник"))
                    {
                        admin.Text = " ";
                        GridView1.Columns[0].Visible = false;
                        dept.Text = "Шиномонтажный";
                    }
                    Label3.Text = rdr.GetValue(3).ToString();

                    Label4.Text = rdr.GetValue(4).ToString();
                    Label5.Text = rdr.GetValue(5).ToString();
                    if (rdr.GetValue(6).ToString().Equals("1"))
                    {
                        Label6.Text = "Мужской";
                    }
                    else
                    {
                        Label6.Text = "Женский";
                    }
                    Label7.Text = rdr.GetValue(7).ToString();

                    Label8.Text = rdr.GetValue(8).ToString();
                    Image1.ImageUrl = rdr.GetValue(0).ToString();
                }
            }
            catch (Exception)
            {
                Response.Redirect("~/View/Applicant/login.aspx");
                //throw;
            }

            if (Session["u_id"] == null)
            {
                Response.Redirect("~/View/Applicant/login.aspx");
            }
        }
        public string doc_upload(FileUpload fileupload)
        {
            string msg = "-1";
            if (fileupload.HasFile)
            {
                string fileextenion = Path.GetExtension(fileupload.FileName);
                if (fileextenion.ToLower() != ".doc" && fileextenion.ToLower() != ".docx" && fileextenion.ToLower() != ".pdf")
                {
                    Response.Write("<script>alert('Только документы могут быть загружены, выберете doc или pdf файл.');</script>");
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

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Panelschedule.Visible = false;
            Panel1.Visible = true;
            Panel5.Visible = false;
            Panel2.Visible = false;
            Panel3.Visible = false;
            Panel4.Visible = false;
            Panelarhiv.Visible = false;
            Paneluslug.Visible = false;    
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Panelschedule.Visible = false;
            Panel1.Visible = false;
            Panel3.Visible = false;
            Panel2.Visible = true;
            Panel4.Visible = false;
            Panel5.Visible = false;
            Panelarhiv.Visible = false;
            Paneluslug.Visible = false;
            
            string q = "select ap_image, ap_name, ap_position, ap_phone1, ap_phone2, ap_email, ap_gender, ap_dob, ap_salary from tbl_applicant_personal where ap_id =" + Session["u_id"];
            SqlConnection conn = new SqlConnection(connstring);
            try
            {
                SqlCommand cmd = new SqlCommand(q, conn);
                conn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    txtusername.Text = rdr.GetValue(1).ToString();
                    txtposition.Text = rdr.GetValue(2).ToString();
                    txtphone1.Text = rdr.GetValue(3).ToString();

                    txtphone2.Text = rdr.GetValue(4).ToString();
                    txtemail.Text = rdr.GetValue(5).ToString();

                    datepicker.Text = rdr.GetValue(7).ToString();
                    txtsalary.Text = rdr.GetValue(8).ToString();

                }
            }
            catch (Exception)
            {
                //Response.Redirect("~/View/Applicant/login.aspx");
                //throw;
            }
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {

            Applicants ap = new Applicants();
            ap.ap_name = txtusername.Text;
            ap.ap_email = txtemail.Text;
            ap.ap_position = txtposition.Text;
            ap.ap_phone1 = txtphone1.Text;
            ap.ap_phone2 = txtphone2.Text;
            ap.ap_dob = Convert.ToDateTime(datepicker.Text);
            ap.ap_salary = txtsalary.Text;
            ap.ap_id = Convert.ToInt32(Session["u_id"].ToString());
            ApplicantLogicLayer logic = new ApplicantLogicLayer();
            logic.Update(ap);
            Response.Redirect("~/View/Applicant/profile.aspx");
        }

        protected void LinkButton3_Click1(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Session.Abandon();
            Response.Redirect("~/View/Applicant/login.aspx");
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            if (admin.Text == "  Admin")
            {
                Panelschedule.Visible = false;
                Panel1.Visible = false;
                Panel2.Visible = false;
                Panel3.Visible = true;
                Panel4.Visible = false;
                Panel5.Visible = false;
                Panelarhiv.Visible = false;
                Paneluslug.Visible = false;
            }
            else
            {
                Panelschedule.Visible = false;
                Panel1.Visible = false;
                Panel2.Visible = false;
                Panel3.Visible = false;
                Panel4.Visible = false;
                Panel5.Visible = true;
                Panelarhiv.Visible = false;
                Paneluslug.Visible = false;
            }
        }

        protected void LinkButton6_Click1(object sender, EventArgs e)
        {
            if (admin.Text == "  Admin")
            {
                Panelschedule.Visible = false;
                Panelarhiv.Visible = true;
                GridView4.Visible = true;
                Panel1.Visible = false;
                Panel2.Visible = false;
                Panel3.Visible = false;
                Panel4.Visible = false;
                Panel5.Visible = false;
                Paneluslug.Visible = false;
            }
            else
            {
                Response.Write("<script>alert('У вас нет доступа.');</script>");
            }
        }
        protected void LinkButton7_Click1(object sender, EventArgs e)
        {
            if (admin.Text == "  Admin")
            {
                GridViewschedule.Visible = false;
                Panelschedule.Visible = true;
                Panelarhiv.Visible = false;
                GridView4.Visible = false;
                Panel1.Visible = false;
                Panel2.Visible = false;
                Panel3.Visible = false;
                Panel4.Visible = false;
                Panel5.Visible = false;
                Paneluslug.Visible = false;
                Label12.Visible = false;
            }
            else
            {
                Response.Write("<script>alert('У вас нет доступа.');</script>");
            }
        }

        protected void LinkButton8_Click1(object sender, EventArgs e)
        {
            Panelschedule.Visible = false;
            Paneluslug.Visible = true;
            Panel1.Visible = false;
            Panel5.Visible = false;
            Panel2.Visible = false;
            Panel3.Visible = false;
            Panel4.Visible = false;
            Panelarhiv.Visible = false;
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Paneluslug.Visible = false;
            Panelarhiv.Visible = false;
            Panel5.Visible = false;
            Panel1.Visible = false;
            Panel3.Visible = true;
            if (DropDownList1.SelectedValue.ToString().Equals("0"))
            {
                Response.Write("<script> alert('Выберете квалификацию')</script>");
            }
            else if (DropDownList1.SelectedValue.ToString().Equals("1"))
            {
                Pmasters.Visible = false;
                PSSC.Visible = true;
                PHSC.Visible = false;
                PGRAD.Visible = false;
            }
            else if (DropDownList1.SelectedValue.ToString().Equals("2"))
            {
                Pmasters.Visible = false;
                PSSC.Visible = true;
                PHSC.Visible = true;
                PGRAD.Visible = false;
            }
            else if (DropDownList1.SelectedValue.ToString().Equals("3"))
            {
                Pmasters.Visible = false;
                PSSC.Visible = true;
                PHSC.Visible = true;
                PGRAD.Visible = true;
            }
            else if (DropDownList1.SelectedValue.ToString().Equals("4"))
            {
                Pmasters.Visible = true;
                PSSC.Visible = true;
                PHSC.Visible = true;
                PGRAD.Visible = true;
            }
        }


        protected void Button3_Click(object sender, EventArgs e)
        {
            string msg = doc_upload(FileUpload2);
            if (msg.Equals("-1"))
            {
                Response.Write("<script>alert('Ошибка при загрузке данных...');</script>");
            }
            else
            {

                QualificationHSC hsc = new QualificationHSC();

                hsc.hsc_institue = TextBox3.Text;
                hsc.hsc_precentage = float.Parse(TextBox4.Text);
                hsc.hsc_doc = msg;
                hsc.hsc_fk_ap_id = TextBoxID.Text;
                QualificationLogicLayer obj = new QualificationLogicLayer();
                string msg2 = obj.insert(hsc);
                if (msg2.Equals("1"))
                {
                    Response.Write("<script>alert('Данные успешно сохранены.');</script>");
                    Response.Redirect("~/View/Applicant/profile.aspx");
                }
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string msg = doc_upload(FileUpload1);
            if (msg.Equals("-1"))
            {
                Response.Write("<script>alert('Ошибка при загрузке данных...');</script>");
            }
            else
            {

                QualificationSSC ssc = new QualificationSSC();

                ssc.ssc_institue = TextBox1.Text;
                ssc.ssc_precentage = float.Parse(TextBox2.Text);
                ssc.ssc_doc = msg;
                ssc.ssc_fk_ap_id = TextBoxID.Text;
                QualificationLogicLayer obj = new QualificationLogicLayer();
                string msg2 = obj.insert(ssc);
                if (msg2.Equals("1"))
                {
                    Response.Write("<script>alert('Данные успешно сохранены.');</script>");
                    Response.Redirect("~/View/Applicant/profile.aspx");

                }
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string msg = doc_upload(FileUpload3);
            if (msg.Equals("-1"))
            {
                Response.Write("<script>alert('Ошибка при загрузке данных...');</script>");
            }
            else
            {

                QualificaticGRAD grad = new QualificaticGRAD();

                grad.grad_institue = TextBox5.Text;
                grad.grad_precentage = float.Parse(TextBox6.Text);
                grad.grad_doc = msg;
                grad.grad_fk_ap_id = TextBoxID.Text;
                QualificationLogicLayer obj = new QualificationLogicLayer();
                string msg2 = obj.insert(grad);
                if (msg2.Equals("1"))
                {
                    Response.Write("<script>alert('Данные успешно сохранены.');</script>");
                    Response.Redirect("~/View/Applicant/profile.aspx");
                }
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            string msg = doc_upload(FileUpload4);
            if (msg.Equals("-1"))
            {
                Response.Write("<script>alert('Ошибка при загрузке данных...');</script>");
            }
            else
            {

                QualityMAS mas = new QualityMAS();

                mas.mas_institue = TextBox7.Text;
                mas.mas_precentage = float.Parse(TextBox8.Text);
                mas.mas_doc = msg;
                mas.mas_fk_ap_id = TextBoxID.Text;
                QualificationLogicLayer obj = new QualificationLogicLayer();
                string msg2 = obj.insert(mas);
                if (msg2.Equals("1"))
                {
                    Response.Write("<script>alert('Данные успешно сохранены.');</script>");
                    Response.Redirect("~/View/Applicant/profile.aspx");
                }
            }
        }

        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            Panel5.Visible = false;
            Panel1.Visible = false;
            Panel2.Visible = false;
            Panel3.Visible = false;
            Panel4.Visible = true;
        }

        protected void btnsearch_Click(object sender, EventArgs e)
        {
            GridViewSearch.Visible = true;
            string connstring = ConfigurationManager.ConnectionStrings["HRD"].ConnectionString;
            SqlConnection con = new SqlConnection(connstring);
            con.Open();
            SqlCommand sqlcmd = new SqlCommand();
            string sqlquery = "select ap_id, ap_name, ap_position, ap_salary, ap_email, ap_phone1, ap_phone2, ap_dob from [dbo].[tbl_applicant_personal] where ap_name like '%'+@ap_name+'%'";
            sqlcmd.CommandText = sqlquery;
            sqlcmd.Connection = con;
            sqlcmd.Parameters.AddWithValue("ap_name", txtsearch.Text);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(sqlcmd);
            sda.Fill(dt);
            GridViewSearch.DataSource = dt;
            GridViewSearch.DataBind();
            if (admin.Text == "  Admin")
            {
                ButtonDissmis.Visible = true;
                TextBoxCouse.Visible = true;

            }

        }

        protected void exportbutton_Click(object sender, EventArgs e)
        {

            Response.ClearContent();
            Response.AppendHeader("content-disposition", "attachment; filename=Employees.xls");
            Response.ContentType = "application/excel";

            StringWriter stringWriter = new StringWriter();
            HtmlTextWriter htmlTextWriter = new HtmlTextWriter(stringWriter);

            GridView1.HeaderRow.Style.Add("background-color", "white");

            foreach (TableCell tableCell in GridView1.HeaderRow.Cells)
            {
                tableCell.Style["background-color"] = "#FFFFFF";
            }

            foreach (GridViewRow gridViewRow in GridView1.Rows)
            {
                gridViewRow.BackColor = System.Drawing.Color.White;
                foreach (TableCell gridViewRowTableCell in gridViewRow.Cells)
                {
                    gridViewRowTableCell.Style["background-color"] = "#FFFFFF";
                }
            }
            GridView1.Columns[0].Visible = false;
            GridView1.AllowSorting = GridView1.AllowPaging = false;
            GridView1.DataBind();

            //GridView1.RenderControl(htmlTextWriter);

            //GridView1.AllowSorting = GridView1.AllowPaging = true;
            //GridView1.Columns[0].Visible = true;

            GridView1.RenderControl(htmlTextWriter);
            Response.Write(stringWriter.ToString());
            Response.End();

            GridView1.AllowSorting = GridView1.AllowPaging = true;
            GridView1.Columns[0].Visible = true;


        }
        public override void VerifyRenderingInServerForm(Control control)
        {

        }

        protected void exportbutton2_Click(object sender, EventArgs e)
        {
            Response.ClearContent();
            Response.AppendHeader("content-disposition", "attachment; filename=Employees.doc");
            Response.ContentType = "application/word";

            StringWriter stringWriter = new StringWriter();
            HtmlTextWriter htmlTextWriter = new HtmlTextWriter(stringWriter);

            GridView1.HeaderRow.Style.Add("background-color", "white");

            foreach (TableCell tableCell in GridView1.HeaderRow.Cells)
            {
                tableCell.Style["background-color"] = "#FFFFFF";
            }

            foreach (GridViewRow gridViewRow in GridView1.Rows)
            {
                gridViewRow.BackColor = System.Drawing.Color.White;
                foreach (TableCell gridViewRowTableCell in gridViewRow.Cells)
                {
                    gridViewRowTableCell.Style["background-color"] = "#FFFFFF";
                }
            }

            GridView1.Columns[0].Visible = false;
            GridView1.AllowSorting = GridView1.AllowPaging = false;
            GridView1.DataBind();

            //GridView1.RenderControl(htmlTextWriter);

            //GridView1.AllowSorting = GridView1.AllowPaging = true;
            //GridView1.Columns[0].Visible = true;

            GridView1.RenderControl(htmlTextWriter);
            Response.Write(stringWriter.ToString());
            Response.End();

            GridView1.AllowSorting = GridView1.AllowPaging = true;
            GridView1.Columns[0].Visible = true;
        }

        protected void exportbuttonqual1_Click(object sender, EventArgs e)
        {
            Response.ClearContent();
            Response.AppendHeader("content-disposition", "attachment; filename=Departments.xls");
            Response.ContentType = "application/excel";

            StringWriter stringWriter = new StringWriter();
            HtmlTextWriter htmlTextWriter = new HtmlTextWriter(stringWriter);

            GridView2.HeaderRow.Style.Add("background-color", "black");

            foreach (TableCell tableCell in GridView2.HeaderRow.Cells)
            {
                tableCell.Style["background-color"] = "#FFFFFF";
            }

            foreach (GridViewRow gridViewRow in GridView2.Rows)
            {
                gridViewRow.BackColor = System.Drawing.Color.White;
                foreach (TableCell gridViewRowTableCell in gridViewRow.Cells)
                {
                    gridViewRowTableCell.Style["background-color"] = "#FFFFFF";
                }
            }

            GridView2.AllowSorting = GridView2.AllowPaging = false;
            GridView2.DataBind();

            //GridView2.RenderControl(htmlTextWriter);

            //GridView2.AllowSorting = GridView2.AllowPaging = true;

            GridView2.RenderControl(htmlTextWriter);
            Response.Write(stringWriter.ToString());
            Response.End();

            GridView2.AllowSorting = GridView2.AllowPaging = true;
        }

        protected void exportbuttonqual2_Click(object sender, EventArgs e)
        {
            Response.ClearContent();
            Response.AppendHeader("content-disposition", "attachment; filename=Departments.doc");
            Response.ContentType = "application/word";

            StringWriter stringWriter = new StringWriter();
            HtmlTextWriter htmlTextWriter = new HtmlTextWriter(stringWriter);

            GridView2.HeaderRow.Style.Add("background-color", "black");

            foreach (TableCell tableCell in GridView2.HeaderRow.Cells)
            {
                tableCell.Style["background-color"] = "#FFFFFF";
            }

            foreach (GridViewRow gridViewRow in GridView2.Rows)
            {
                gridViewRow.BackColor = System.Drawing.Color.White;
                foreach (TableCell gridViewRowTableCell in gridViewRow.Cells)
                {
                    gridViewRowTableCell.Style["background-color"] = "#FFFFFF";
                }
            }

            GridView2.AllowSorting = GridView2.AllowPaging = false;
            GridView2.DataBind();

            //GridView2.RenderControl(htmlTextWriter);

            //GridView2.AllowSorting = GridView2.AllowPaging = true;

            GridView2.RenderControl(htmlTextWriter);
            Response.Write(stringWriter.ToString());
            Response.End();

            GridView2.AllowSorting = GridView2.AllowPaging = true;
        }

        protected void exportbuttonqual3_Click(object sender, EventArgs e)
        {
            Response.ClearContent();
            Response.AppendHeader("content-disposition", "attachment; filename=Positions.xls");
            Response.ContentType = "application/excel";

            StringWriter stringWriter = new StringWriter();
            HtmlTextWriter htmlTextWriter = new HtmlTextWriter(stringWriter);

            GridView3.HeaderRow.Style.Add("background-color", "black");

            foreach (TableCell tableCell in GridView3.HeaderRow.Cells)
            {
                tableCell.Style["background-color"] = "#FFFFFF";
            }

            foreach (GridViewRow gridViewRow in GridView3.Rows)
            {
                gridViewRow.BackColor = System.Drawing.Color.White;
                foreach (TableCell gridViewRowTableCell in gridViewRow.Cells)
                {
                    gridViewRowTableCell.Style["background-color"] = "#FFFFFF";
                }
            }

            GridView3.AllowSorting = GridView3.AllowPaging = false;
            GridView3.DataBind();

            //GridView3.RenderControl(htmlTextWriter);

            //GridView3.AllowSorting = GridView3.AllowPaging = true;

            GridView3.RenderControl(htmlTextWriter);
            Response.Write(stringWriter.ToString());
            Response.End();

            GridView3.AllowSorting = GridView3.AllowPaging = true;
        }

        protected void exportbuttonqual4_Click(object sender, EventArgs e)
        {
            Response.ClearContent();
            Response.AppendHeader("content-disposition", "attachment; filename=Positions.doc");
            Response.ContentType = "application/word";

            StringWriter stringWriter = new StringWriter();
            HtmlTextWriter htmlTextWriter = new HtmlTextWriter(stringWriter);

            GridView3.HeaderRow.Style.Add("background-color", "black");

            foreach (TableCell tableCell in GridView3.HeaderRow.Cells)
            {
                tableCell.Style["background-color"] = "#FFFFFF";
            }

            foreach (GridViewRow gridViewRow in GridView3.Rows)
            {
                gridViewRow.BackColor = System.Drawing.Color.White;
                foreach (TableCell gridViewRowTableCell in gridViewRow.Cells)
                {
                    gridViewRowTableCell.Style["background-color"] = "#FFFFFF";
                }
            }

            GridView3.AllowSorting = GridView3.AllowPaging = false;
            GridView3.DataBind();

            //GridView3.RenderControl(htmlTextWriter);

            //GridView3.AllowSorting = GridView3.AllowPaging = true;

            GridView3.RenderControl(htmlTextWriter);
            Response.Write(stringWriter.ToString());
            Response.End();

            GridView3.AllowSorting = GridView3.AllowPaging = true;
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
                Paneluslug.Visible = false;
                Panelarhiv.Visible = false;
                Panel5.Visible = false;
                Panel1.Visible = false;
                Panel3.Visible = true;
                string connstring = ConfigurationManager.ConnectionStrings["HRD"].ConnectionString;
                SqlConnection con = new SqlConnection(connstring);
                con.Open();
                SqlCommand sqlcmd = new SqlCommand();
                string sqlquery = "select ap_id from [dbo].[tbl_applicant_personal] where ap_name like '%'+@ap_name+'%'";
                sqlcmd.CommandText = sqlquery;
                sqlcmd.Connection = con;
                sqlcmd.Parameters.AddWithValue("ap_name", DropDownList2.Text);
                string tbl_applicant_personal = sqlcmd.ExecuteScalar().ToString();
                TextBoxID.Text = tbl_applicant_personal;
            
        }

        protected void ButtonDissmis_Click(object sender, EventArgs e)
        {
            string connstring = ConfigurationManager.ConnectionStrings["HRD"].ConnectionString;
            SqlConnection con = new SqlConnection(connstring);
            con.Open();
            Dissmis ds = new Dissmis();
            
            ds.dis_name = GridViewSearch.Rows[0].Cells[1].Text;      
            ds.dis_cause = TextBoxCouse.Text;
            ds.dis_position = GridViewSearch.Rows[0].Cells[2].Text;
            ds.dis_phone1 = GridViewSearch.Rows[0].Cells[5].Text;
            ds.dis_phone2 = GridViewSearch.Rows[0].Cells[6].Text;
            ds.dis_email = GridViewSearch.Rows[0].Cells[4].Text;
            ds.dis_date = DateTime.Today;
            
            SqlCommand sqlcmd = new SqlCommand();
            string sqlquery = "delete from [dbo].[tbl_applicant_personal] where ap_name like '%'+@ap_name+'%'";
            sqlcmd.CommandText = sqlquery;
            sqlcmd.Connection = con;
            sqlcmd.Parameters.AddWithValue("ap_name", GridViewSearch.Rows[0].Cells[1].Text);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(sqlcmd);
            sda.Fill(dt);

            DissmisLogicLayer obj = new DissmisLogicLayer();
            string msg2 = obj.insert(ds);
            if (msg2.Equals("1"))
            {
                Response.Write("<script>alert('Сотрудник уволен.');</script>");
                Response.Redirect("~/View/Applicant/profile.aspx");
            }

        }

        protected void Buttonuslug_Click(object sender, EventArgs e)
        {
            Panel1.Visible = false;
            Panel2.Visible = false;
            Panel3.Visible = false;
            Paneluslug.Visible = true;
            GridViewUslug.Visible = true;
            string connstring = ConfigurationManager.ConnectionStrings["HRD"].ConnectionString;
            SqlConnection con = new SqlConnection(connstring);
            con.Open();
            SqlCommand sqlcmd = new SqlCommand();
            string sqlquery = "select pos_description from [dbo].[tbl_position] where pos_name like '%'+@pos_name+'%'";
            sqlcmd.CommandText = sqlquery;
            sqlcmd.Connection = con;
            sqlcmd.Parameters.AddWithValue("pos_name", DropDownList3.Text);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(sqlcmd);
            sda.Fill(dt);
            GridViewUslug.DataSource = dt;
            GridViewUslug.DataBind();
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Panel1.Visible = false;
            Panel2.Visible = false;
            Panel3.Visible = false;
            Panel4.Visible = false;
            Panel5.Visible = true;
            Panelarhiv.Visible = false;
            Paneluslug.Visible = false;
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            GridViewschedule.Visible = false;
            Panelschedule.Visible = true;
            Panelarhiv.Visible = false;
            GridView4.Visible = false;
            Panel1.Visible = false;
            Panel2.Visible = false;
            Panel3.Visible = false;
            Panel4.Visible = false;
            Panel5.Visible = false;
            Paneluslug.Visible = false;

            Label12.Visible = true;
            string connstring = ConfigurationManager.ConnectionStrings["HRD"].ConnectionString;
            SqlConnection con = new SqlConnection(connstring);
            con.Open();
            SqlCommand sqlcmd = new SqlCommand();
            string sqlquery = "select count(*) from [dbo].[tbl_applicant_personal] where ap_position like '%'+@ap_position+'%'";
            sqlcmd.CommandText = sqlquery;
            sqlcmd.Connection = con;
            sqlcmd.Parameters.AddWithValue("ap_position", TextBox9.Text);
            string tbl_applicant_personal = sqlcmd.ExecuteScalar().ToString();
            Label12.Text = tbl_applicant_personal;
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            Panelschedule.Visible = true;
            Panelarhiv.Visible = false;
            GridView4.Visible = false;
            Panel1.Visible = false;
            Panel2.Visible = false;
            Panel3.Visible = false;
            Panel4.Visible = false;
            Panel5.Visible = false;
            Paneluslug.Visible = false;
            GridViewschedule.Visible = true;
            string connstring = ConfigurationManager.ConnectionStrings["HRD"].ConnectionString;
            SqlConnection con = new SqlConnection(connstring);
            con.Open();
            SqlCommand sqlcmd = new SqlCommand();
            string sqlquery = "select ap_id, ap_name, ap_position, ap_salary, ap_email, ap_phone1, ap_phone2, ap_dob from [dbo].[tbl_applicant_personal] where ap_position like '%'+@ap_position+'%'";
            sqlcmd.CommandText = sqlquery;
            sqlcmd.Connection = con;
            sqlcmd.Parameters.AddWithValue("ap_position", TextBox9.Text);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(sqlcmd);
            sda.Fill(dt);
            GridViewschedule.DataSource = dt;
            GridViewschedule.DataBind();
        }
    }
 }