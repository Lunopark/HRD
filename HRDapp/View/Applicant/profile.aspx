
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="profile.aspx.cs" Inherits="HRDapp.View.Applicant.profile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Личный кабинет</title>
    <link href="../../Content/css/bootstrap.css" rel="stylesheet" />
    <link href="../../Content/css/bootstrap.min.css" rel="stylesheet" />
   
    <style type="text/css">
        .auto-style1 {
            width: 191px;
        }
 
        td{
            padding: 5px;
        }
        html { overflow-x: hidden; }

        h4{
            margin-left: 325px;
        }

    nav { background: gainsboro; }
nav ul {
  list-style: none;
  margin: 0;
  padding: 0;

}
nav a {
    font-size: 14px;
  text-decoration: none;
  outline: none;
  display: block;
  transition: .4s ease-in-out;
}
.topmenu {
  text-align: center;
  padding: 10px 0;

}
.topmenu > li {
  display: inline-block;
  position: relative;
}
.topmenu > li:after {
  content: "";
  position: absolute;
  right: 0;
  width: 1px;
  height: 12px;
  background: #dcdcdc;
  top: 16px;
  box-shadow: 4px -2px 0 #d2d2d2;
  transform: rotate(30deg);
}
.topmenu > li:last-child:after {
  background: none;
  box-shadow: none;
}
.topmenu > li > a {
  padding: 12px 26px;
  color: #FFFFFF;
  text-transform: uppercase;
  font-weight: bold;
  letter-spacing: 1px;
  font-family: 'Exo 2', sans-serif;
}
.topmenu li a:hover { color: #0026ff; }

        .auto-style2 {
            width: 150px;
        }

        footer{
            text-align: center;
            margin-top: 400px
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
 
            <div class="row" style="background-color: #ffffff; height:1300px">
                <div class="col-lg-4 col-md-4 col-sm-4">

                    <asp:Image ID="Image1" runat="server" ImageUrl="~/Content/img/Skyline.jpg" Style="margin-left: 50px; margin-top: 50px; height: 350px; width: 300px; margin-bottom: 30px"/>
              
                    <table class="table table-responsive">

                        <tr><td class="auto-style2">ФИО:</td><td><asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></td></tr>

                        <tr><td class="auto-style2">Должность:</td><td><asp:Label ID="Label2" runat="server" Text="Label"></asp:Label><asp:Label ID="admin" runat="server" Text="Label" style="color: red"></asp:Label></td></tr>

                        <tr><td class="auto-style2">Моб. телефон:</td><td><asp:Label ID="Label3" runat="server" Text="Label"></asp:Label></td></tr>

                        <tr><td class="auto-style2">Дом. телефон:</td><td><asp:Label ID="Label4" runat="server" Text="Label"></asp:Label></td></tr>

                        <tr><td class="auto-style2">Email:</td><td><asp:Label ID="Label5" runat="server" Text="Label"></asp:Label></td></tr>

                        <tr><td class="auto-style2">Пол:</td><td><asp:Label ID="Label6" runat="server" Text="Label"></asp:Label></td></tr>

                        <tr><td class="auto-style2">Дата рождения:</td><td><asp:Label ID="Label7" runat="server" Text="Label"></asp:Label></td></tr>

                        <tr><td class="auto-style2">Зарплата:</td><td><asp:Label ID="Label8" runat="server" Text="Label"></asp:Label></td></tr>

                        <tr><td class="auto-style2">Отдел:</td><td><asp:Label ID="dept" runat="server" Text="Label"></asp:Label></td></tr>

                    </table>
                    
                </div>
               

                <div class="col-lg-8 col-md-8 col-sm-8" style="background-color: gainsboro; height:1300px">
                <nav>
                <ul class="topmenu">
                    <li><asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Список сотрудников</asp:LinkButton></li>
                    <li><asp:LinkButton ID="LinkButton5" runat="server" OnClick="LinkButton5_Click">Отделы</asp:LinkButton></li>
                    <li><asp:LinkButton ID="LinkButton4" runat="server" OnClick="LinkButton4_Click">Квалификация</asp:LinkButton></li>
                     <li><asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">Обновить записи</asp:LinkButton></li>
                      <li><asp:LinkButton ID="LinkButton3" runat="server" OnClick="LinkButton3_Click1">Выход</asp:LinkButton></li>  
                     <li><asp:LinkButton ID="LinkButton6" runat="server" OnClick="LinkButton6_Click1">Архив</asp:LinkButton></li> 
                     <li><asp:LinkButton ID="LinkButton7" runat="server" OnClick="LinkButton7_Click1">Штатное расписание</asp:LinkButton></li> 
                    <li><asp:LinkButton ID="LinkButton8" runat="server" OnClick="LinkButton8_Click1">Список обязанностей</asp:LinkButton></li> 
                </ul>
              </nav>
                    <asp:Panel ID="Panel1" runat="server">
                        <div class="row" style="height: 700px; margin: 0px; padding: 0px; width: 98.5%">
                            <table class="table4 table-responsive" style="width: 98.5%">
                                <tr>
                                    
                            <td><asp:TextBox ID="txtsearch" placeholder="Поиск" runat="server" CssClass="form-control"></asp:TextBox></td>
                                   <td><asp:Button ID="btnsearch" runat="server" CssClass="btn btn-danger" Text="Поиск" OnClick="btnsearch_Click" BackColor="Black" BorderColor="Black" /></td>      
                                   <td>
                                    <asp:Button ID="exportbutton" runat="server" CssClass="btn btn-success" style="margin-left: 5px; float:right" Text="Экспортировать в Excel" OnClick="exportbutton_Click" />   <asp:Button ID="exportbutton2" runat="server" CssClass="btn btn-primary" style="float:right" Text="Экспортировать в Word" OnClick="exportbutton2_Click" /></td>    
                                </tr>
                                </table>
                                <p></p>
                            <asp:GridView ID="GridViewSearch" runat="server" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black">
                                <FooterStyle BackColor="#CCCCCC" />
                                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                                <RowStyle BackColor="White" />
                                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                                <SortedAscendingHeaderStyle BackColor="#808080" />
                                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                                <SortedDescendingHeaderStyle BackColor="#383838" />
                            </asp:GridView>
                            <p></p>
                            <asp:Button ID="ButtonDissmis" Style="width: 120px" runat="server" CssClass="btn btn-danger" Text="Уволить" OnClick="ButtonDissmis_Click" />  <asp:TextBox ID="TextBoxCouse" placeholder="Укажите причину" Style="width:480px; margin-right: 265px; float:right" Class="form-control" runat="server"></asp:TextBox>
                            <p></p>
                            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" DataSourceID="SqlDataSource1" ForeColor="Black" GridLines="Vertical" 
                                DataKeyNames="ap_id" AllowPaging="True" PageSize="9" AllowSorting="True" >
                                <AlternatingRowStyle BackColor="#CCCCCC" />
                                <Columns>
      
                                    <asp:CommandField ShowEditButton="True" ShowDeleteButton="True" /> 
                                                     
                                    <asp:BoundField DataField="ap_id" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ap_id" />
                                    <asp:BoundField DataField="ap_name" HeaderText="ФИО" SortExpression="ap_name" />
                                    <asp:BoundField DataField="ap_position" HeaderText="Должность" SortExpression="ap_position" />
                                    <asp:BoundField DataField="ap_salary" HeaderText="Зарплата" SortExpression="ap_salary" />
                                    <asp:BoundField DataField="ap_email" HeaderText="Email" SortExpression="ap_email" />
                                    <asp:BoundField DataField="ap_dob" HeaderText="Дата рождения" SortExpression="ap_dob" />
                                    <asp:BoundField DataField="ap_phone1" HeaderText="Моб. телефон" SortExpression="ap_phone1" />
                                    <asp:BoundField DataField="ap_phone2" HeaderText="Дом.Телефон" SortExpression="ap_phone2" />
                                </Columns>
                                <FooterStyle BackColor="#CCCCCC" />
                                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                                <SortedAscendingHeaderStyle BackColor="#808080" />
                                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                                <SortedDescendingHeaderStyle BackColor="#383838" />
                            </asp:GridView>
                            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:HRDConnectionString %>" 
                                DeleteCommand="DELETE FROM [tbl_applicant_personal] WHERE [ap_id] = @ap_id"    
                                SelectCommand="SELECT * FROM [tbl_applicant_personal]"
                                UpdateCommand="UPDATE [tbl_applicant_personal] SET [ap_name] = @ap_name, [ap_position] = @ap_position, [ap_phone1] = @ap_phone1, [ap_phone2] = @ap_phone2, [ap_email] = @ap_email, [ap_dob] = @ap_dob, [ap_salary] = @ap_salary WHERE [ap_id] = @ap_id">
                                     
                                <DeleteParameters>
                                    <asp:Parameter Name="ap_id" Type="Int32" />
                                </DeleteParameters>
                               
                                
                               
                            </asp:SqlDataSource>
                          
                        </div>            
                    </asp:Panel>

                    <asp:Panel ID="Panel2" runat="server">
                        <div class="row" style="height: 700px;margin: 0px; padding: 0px; width: 98.5%">

                             <table class="table table-responsive" >

                        <tr><td class="auto-style1">ФИО:</td><td>
                            <asp:TextBox ID="txtusername" runat="server" CssClass="form-control"></asp:TextBox>
                                                             </td></tr>

                        <tr><td class="auto-style1">Должность:</td><td>
                            <asp:TextBox ID="txtposition" runat="server" CssClass="form-control"></asp:TextBox>
                                                                   </td></tr>

                        <tr><td class="auto-style1">Моб. телефон:</td><td>
                            <asp:TextBox ID="txtphone1" runat="server" CssClass="form-control"></asp:TextBox>
                                                                      </td></tr>

                        <tr><td class="auto-style1">Дом. телефон:</td><td>
                            <asp:TextBox ID="txtphone2" runat="server" CssClass="form-control"></asp:TextBox>
                                                                      </td></tr>

                        <tr><td class="auto-style1">Email:</td><td><asp:Label ID="txtemail" runat="server" Text="Label"></asp:Label></td></tr>


                        <tr><td class="auto-style1">Дата рождения:</td><td>
                            <asp:TextBox ID="datepicker" runat="server" CssClass="form-control"></asp:TextBox>
                            </td></tr>

                                 <tr><td class="auto-style1">Зарплата:</td><td>
                            <asp:TextBox ID="txtsalary" runat="server" CssClass="form-control"></asp:TextBox>
                                                                      </td></tr>

                                 <tr><td colspan="2"><asp:Button ID="Button1" runat="server" Text="Обновить" CssClass="btn btn-sucess" OnClick="Button1_Click1"/></td></tr>

                    </table>


                        </div>
                    </asp:Panel>

             <asp:Panel ID="Panel3" runat="server">
                        <div class="row" style="height:700px; margin: 0px; padding: 0px; width: 98.5%">
                            <asp:Label ID="Label9" runat="server" Text="Сотрудник:"></asp:Label><asp:Label ID="Label10" style="margin-left: 715px" runat="server" Text="Код:"></asp:Label>
                            
                            <asp:TextBox ID="TextBoxID" CssClass="form-control" style="width: 10.25%; float: right" runat="server"></asp:TextBox>
                            <asp:DropDownList ID="DropDownList2" runat="server" CssClass="form-control" style="width: 88.25%" DataSourceID="SqlDataSource1" DataTextField="ap_name" DataValueField="ap_name" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged" AutoPostBack="True">
  
                                </asp:DropDownList>
                           
                            <asp:Label ID="Label11" runat="server" Text="Разряд:"></asp:Label>
                            <asp:Button ID="Button6" runat="server" CssClass="btn btn-danger" style="margin-top: 19px; float: right" Text="Перейти к просмотру" BackColor="Black" BorderColor="Black" ForeColor="White" OnClick="Button6_Click"></asp:Button>
                            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control" style="width: 80.25%" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                               
                                <asp:ListItem Value="0">Выбрать</asp:ListItem>
                                <asp:ListItem Value="1">Разряд II</asp:ListItem>
                                <asp:ListItem Value="2">Разряд III</asp:ListItem>
                                <asp:ListItem Value="3">Разряд IV</asp:ListItem>
                                <asp:ListItem Value="4">Разряд V</asp:ListItem>
                               
                            </asp:DropDownList>
                            
                            <asp:Panel ID="PSSC" runat="server">
                                <div class="row">
                                    <div class="container">
                                        <h1>Среднее образование</h1>  
                                        <table>
                                        <tr><td>Учреждение:</td><td><asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox></td></tr>                  
                                        <tr><td>Средний балл:</td><td><asp:TextBox ID="TextBox2" runat="server" CssClass="form-control"></asp:TextBox></td></tr>
                                        <tr><td>Аттестат:</td><td><asp:FileUpload ID="FileUpload1" runat="server" CssClass="form-control"/></td></tr>
                                        <tr><td colspan="2"><asp:Button ID="Button2" runat="server" Text="Подтвердить" CssClass="btn btn-success" OnClick="Button2_Click"/></td></tr>
                                        </table> 
                                     </div>
                                </div>
                            </asp:Panel>

                            <asp:Panel ID="PHSC" runat="server">
                                <div class="row">
                                    <div class="container">
                                        <h1>Высшее образование</h1>
                                        <table>
                                        <tr><td>Учреждение:</td><td><asp:TextBox ID="TextBox3" runat="server" CssClass="form-control"></asp:TextBox></td></tr>
                                        <tr><td>Средний балл:</td><td><asp:TextBox ID="TextBox4" runat="server" CssClass="form-control"></asp:TextBox></td></tr>
                                        <tr><td>Аттестат:</td><td><asp:FileUpload ID="FileUpload2" runat="server" CssClass="form-control"/></td></tr>
                                        <tr><td colspan="2"><asp:Button ID="Button3" runat="server" Text="Подтвердить" CssClass="btn btn-success" OnClick="Button3_Click"/> </td></tr>
                                        </table>
                                     </div>
                                </div>
                            </asp:Panel>

                            <asp:Panel ID="PGRAD" runat="server">
                                <div class="row">
                                    <div class="container">
                                        <h1>Квалификационные курсы</h1>
                                        <table>
                                        <tr><td>Учреждение:</td><td><asp:TextBox ID="TextBox5" runat="server" CssClass="form-control"></asp:TextBox></td></tr>
                                        <tr><td>Балл:</td><td><asp:TextBox ID="TextBox6" runat="server" CssClass="form-control"></asp:TextBox></td></tr>
                                        <tr><td>Сертификат:</td><td><asp:FileUpload ID="FileUpload3" runat="server" CssClass="form-control"/></td></tr>
                                        <tr><td colspan="2"><asp:Button ID="Button4" runat="server" Text="Подтвердить" CssClass="btn btn-success" OnClick="Button4_Click"/> </td></tr>
                                        </table>
                                     </div>
                                </div>
                            </asp:Panel>

                            <asp:Panel ID="Pmasters" runat="server">
                                <div class="row">
                                    <div class="container">
                                        <h1>Квалификационный экзамен</h1>
                                        <table>
                                        <tr><td>Учреждение:</td><td><asp:TextBox ID="TextBox7" runat="server" CssClass="form-control"></asp:TextBox></td></tr>
                                        <tr><td>Балл:</td><td><asp:TextBox ID="TextBox8" runat="server" CssClass="form-control"></asp:TextBox></td></tr>
                                        <tr><td>Сертификат:</td><td><asp:FileUpload ID="FileUpload4" runat="server" CssClass="form-control"/></td></tr>
                                        <tr><td colspan="2"><asp:Button ID="Button5" runat="server" Text="Подтвердить" CssClass="btn btn-success" OnClick="Button5_Click"/> </td></tr>
                                        </table>
                                     </div>
                                </div>
                            </asp:Panel>
                        </div>
                    </asp:Panel>

                    <asp:Panel ID="Panel5" runat="server">
                        <div class="row" style="height:700px; margin: 0px; padding: 0px; width: 98.5%">
                            <h3>Среднее образование</h3>
                                <asp:GridView ID="GridViewSSC" runat="server" style="width: 98.5%" AutoGenerateColumns="False" DataKeyNames="ssc_id" DataSourceID="SqlDataSourceSSC" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black">
                                    <Columns>
                                        <asp:BoundField DataField="ssc_institue" HeaderText="Учреждение" SortExpression="ssc_institue" />
                                        <asp:BoundField DataField="ssc_precentage" HeaderText="Средний балл" SortExpression="ssc_precentage" />
                                        <asp:BoundField DataField="ssc_doc" HeaderText="Подтверждающий документ" SortExpression="ssc_doc" />
                                        <asp:BoundField DataField="ssc_fk_ap_id" HeaderText="Код сотрудника" SortExpression="ssc_fk_ap_id" />
                                    </Columns>
                                    <FooterStyle BackColor="#CCCCCC" />
                                    <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                                    <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                                    <RowStyle BackColor="White" />
                                    <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                                    <SortedAscendingHeaderStyle BackColor="#808080" />
                                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                                    <SortedDescendingHeaderStyle BackColor="#383838" />
                                </asp:GridView>
                            <h3>Высшее образование</h3>
                                <asp:GridView ID="GridViewHSC" runat="server" style="width: 98.5%" AutoGenerateColumns="False" DataKeyNames="hsc_id" DataSourceID="SqlDataSourceHSC" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black">
                                    <Columns>
                                        <asp:BoundField DataField="hsc_institue" HeaderText="Учреждение" SortExpression="hsc_institue" />
                                        <asp:BoundField DataField="hsc_precentage" HeaderText="Средний балл" SortExpression="hsc_precentage" />
                                        <asp:BoundField DataField="hsc_doc" HeaderText="Подтверждающий документ" SortExpression="hsc_doc" />
                                        <asp:BoundField DataField="hsc_fk_ap_id" HeaderText="Код сотрудника" SortExpression="hsc_fk_ap_id" />
                                    </Columns>
                                    <FooterStyle BackColor="#CCCCCC" />
                                    <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                                    <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                                    <RowStyle BackColor="White" />
                                    <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                                    <SortedAscendingHeaderStyle BackColor="Gray" />
                                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                                    <SortedDescendingHeaderStyle BackColor="#383838" />
                                </asp:GridView>
                            <h3>Квалификационные курсы</h3>
                                <asp:GridView ID="GridViewGRAD" runat="server" style="width: 98.5%" AutoGenerateColumns="False" DataKeyNames="grad_id" DataSourceID="SqlDataSourceGRAD" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black">
                                    <Columns>
                                        <asp:BoundField DataField="grad_institue" HeaderText="Учреждение" SortExpression="grad_institue" />
                                        <asp:BoundField DataField="grad_precentage" HeaderText="Балл" SortExpression="grad_precentage" />
                                        <asp:BoundField DataField="grad_doc" HeaderText="Подтверждающий документ" SortExpression="grad_doc" />
                                        <asp:BoundField DataField="grad_fk_ap_id" HeaderText="Код сотрудника" SortExpression="grad_fk_ap_id" />
                                    </Columns>
                                    <FooterStyle BackColor="#CCCCCC" />
                                    <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                                    <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                                    <RowStyle BackColor="White" />
                                    <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                                    <SortedAscendingHeaderStyle BackColor="#808080" />
                                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                                    <SortedDescendingHeaderStyle BackColor="#383838" />
                                </asp:GridView>
                            <h3>Квалификационный экзамен</h3>
                                <asp:GridView ID="GridViewMas" runat="server" style="width: 98.5%" AutoGenerateColumns="False" DataKeyNames="mas_id" DataSourceID="SqlDataSourceMas" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black">
                                    <Columns>
                                        <asp:BoundField DataField="mas_institue" HeaderText="Учреждение" SortExpression="mas_institue" />
                                        <asp:BoundField DataField="mas_precentage" HeaderText="Балл" SortExpression="mas_precentage" />
                                        <asp:BoundField DataField="mas_doc" HeaderText="Подтверждающий документ" SortExpression="mas_doc" />
                                        <asp:BoundField DataField="mas_fk_ap_id" HeaderText="Код сотрудника" SortExpression="mas_fk_ap_id" />
                                    </Columns>
                                    <FooterStyle BackColor="#CCCCCC" />
                                    <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                                    <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                                    <RowStyle BackColor="White" />
                                    <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                                    <SortedAscendingHeaderStyle BackColor="#808080" />
                                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                                    <SortedDescendingHeaderStyle BackColor="#383838" />
                                </asp:GridView>

                                <asp:SqlDataSource ID="SqlDataSourceSSC" runat="server" ConnectionString="<%$ ConnectionStrings:HRDConnectionString %>" SelectCommand="SELECT * FROM [tbl_ssc]"></asp:SqlDataSource>
                                <asp:SqlDataSource ID="SqlDataSourceHSC" runat="server" ConnectionString="<%$ ConnectionStrings:HRDConnectionString %>" SelectCommand="SELECT * FROM [tbl_hsc]"></asp:SqlDataSource>
                                <asp:SqlDataSource ID="SqlDataSourceGRAD" runat="server" ConnectionString="<%$ ConnectionStrings:HRDConnectionString %>" SelectCommand="SELECT * FROM [tbl_grad]"></asp:SqlDataSource>
                                <asp:SqlDataSource ID="SqlDataSourceMas" runat="server" ConnectionString="<%$ ConnectionStrings:HRDConnectionString %>" SelectCommand="SELECT * FROM [tbl_mas]"></asp:SqlDataSource>
                            </div>
                        </asp:Panel>

                    <asp:Panel ID="Panel4" runat="server"> 
                        <div class="row" style="height: 700px; margin: 0px; padding: 0px; width: 98.5%">
                            
                            <asp:Panel ID="Pdepartmens" runat="server">
                                <h3>Список отделов <asp:Button ID="exportbuttonqual1" runat="server" CssClass="btn btn-success" style="margin-left: 5px; margin-right: 15px; float:right" Text="Экспортировать в Excel" OnClick="exportbuttonqual1_Click" />   <asp:Button ID="exportbuttonqual2" runat="server" CssClass="btn btn-primary" style="float:right" Text="Экспортировать в Word" OnClick="exportbuttonqual2_Click" /> </h3>
                                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:HRDConnectionString %>" SelectCommand="SELECT [dept_id], [dept_name] FROM [tbl_department]"></asp:SqlDataSource>
                                <asp:GridView ID="GridView2" runat="server" DataSourceID="SqlDataSource2" AutoGenerateColumns="False" style="width: 98.5%" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" AllowSorting="True">
                                    <AlternatingRowStyle BackColor="#CCCCCC" />
                                    <Columns>
                                        <asp:BoundField DataField="dept_id" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="dept_id" />
                                        <asp:BoundField DataField="dept_name" HeaderText="Название" SortExpression="dept_name" />
                                    </Columns>
                                    <FooterStyle BackColor="#CCCCCC" />
                                    <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                                    <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                                    <SortedAscendingHeaderStyle BackColor="#808080" />
                                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                                    <SortedDescendingHeaderStyle BackColor="#383838" />
                                </asp:GridView>
                                </asp:Panel>
                                
                            <asp:Panel ID="Pposition" runat="server">
                                <p></p>
                                <h3>Список должностей <asp:Button ID="exportbuttonqual3" runat="server" CssClass="btn btn-success" style="margin-left: 5px; margin-right: 15px; float:right" Text="Экспортировать в Excel" OnClick="exportbuttonqual3_Click" />   <asp:Button ID="exportbuttonqual4" runat="server" CssClass="btn btn-primary" style="float:right" Text="Экспортировать в Word" OnClick="exportbuttonqual4_Click" /></h3>
                                <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:HRDConnectionString %>" SelectCommand="SELECT [pos_id], [pos_name], [pos_quantity] FROM [tbl_position]"></asp:SqlDataSource>
                                <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource3" style="width: 98.5%" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" AllowSorting="True">
                                    <AlternatingRowStyle BackColor="#CCCCCC" />
                                    <Columns>
                                        <asp:BoundField DataField="pos_id" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="pos_id" />
                                        <asp:BoundField DataField="pos_name" HeaderText="Наименование" SortExpression="pos_name" />
                                    </Columns>
                                    <FooterStyle BackColor="#CCCCCC" />
                                    <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                                    <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                                    <SortedAscendingHeaderStyle BackColor="#808080" />
                                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                                    <SortedDescendingHeaderStyle BackColor="#383838" />
                                </asp:GridView>
                                </asp:Panel>
                                  
                            </div>
                    </asp:Panel>

                    <asp:Panel ID="Panelarhiv" runat="server">
                        <div class="row" style="height: 700px;margin: 0px; padding: 0px; width: 98.5%">
                            <asp:GridView ID="GridView4" runat="server" AutoGenerateColumns="False" style="width: 98.5%" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" DataKeyNames="dis_id" DataSourceID="SqlDataSource4" CellSpacing="2" ForeColor="Black">
                                <Columns>
                                    <asp:BoundField DataField="dis_name" HeaderText="ФИО бывшего сотрудника" SortExpression="dis_name" />
                                    <asp:BoundField DataField="dis_position" HeaderText="Должность" SortExpression="dis_position" />
                                    <asp:BoundField DataField="dis_phone1" HeaderText="Моб. телефон" SortExpression="dis_phone1" />
                                    <asp:BoundField DataField="dis_phone2" HeaderText="Дом. телефон" SortExpression="dis_phone2" />
                                    <asp:BoundField DataField="dis_email" HeaderText="Email" SortExpression="dis_email" />
                                    <asp:BoundField DataField="dis_cause" HeaderText="Причина увольнения" SortExpression="dis_cause" />
                                    <asp:BoundField DataField="dis_date" HeaderText="Дата увольнения" SortExpression="dis_date" />
                                </Columns>
                                <FooterStyle BackColor="#CCCCCC" />
                                <HeaderStyle BackColor="Red" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                                <RowStyle BackColor="White" />
                                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                                <SortedAscendingHeaderStyle BackColor="#808080" />
                                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                                <SortedDescendingHeaderStyle BackColor="#383838" />
                            </asp:GridView>
                            <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:HRDConnectionString %>" SelectCommand="SELECT * FROM [dissmis]"></asp:SqlDataSource>
                            </div>
                        </asp:Panel>

                     <asp:Panel ID="Paneluslug" runat="server">
                        <div class="row" style="height: 700px;margin: 0px; padding: 0px; width: 98.5%">
                     <h3>Обязанности</h3> 
                            <asp:Button ID="Buttonuslug" runat="server" style="float:right; width: 115px" CssClass="btn btn-primary" Text="Вывести" OnClick="Buttonuslug_Click" />
                     <asp:DropDownList ID="DropDownList3" runat="server" Class="form-control" style="width: 750px" DataSourceID="SqlDataSource5" DataTextField="pos_name" DataValueField="pos_name">
                            </asp:DropDownList>
                     <p></p>
                     <asp:GridView ID="GridViewUslug" Style="width: 98.5%; height: 300px; text-align: center" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical">
                         <AlternatingRowStyle BackColor="#CCCCCC" />
                         <FooterStyle BackColor="#CCCCCC" />
                         <HeaderStyle BackColor="Black" Height="15px" Font-Bold="True" ForeColor="White" />
                         <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                         <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                         <SortedAscendingCellStyle BackColor="#F1F1F1" />
                         <SortedAscendingHeaderStyle BackColor="#808080" />
                         <SortedDescendingCellStyle BackColor="#CAC9C9" />
                         <SortedDescendingHeaderStyle BackColor="#383838" />
                         
                            </asp:GridView>
                     <asp:SqlDataSource ID="SqlDataSource5" runat="server" ConnectionString="<%$ ConnectionStrings:HRDConnectionString %>" 
                         SelectCommand="SELECT * FROM [tbl_position]" 
                         DeleteCommand="DELETE FROM [tbl_position] WHERE [pos_id] = @pos_id" 
                         InsertCommand="INSERT INTO [tbl_position] ([pos_name], [pos_quantity], [pos_description]) VALUES (@pos_name, @pos_quantity, @pos_description)" 
                         UpdateCommand="UPDATE [tbl_position] SET [pos_name] = @pos_name, [pos_quantity] = @pos_quantity, [pos_description] = @pos_description WHERE [pos_id] = @pos_id">
                         <DeleteParameters>
                             <asp:Parameter Name="pos_id" Type="Int32" />
                         </DeleteParameters>
                        
                         
                            </asp:SqlDataSource>
                                </div>
                     </asp:Panel>

                    <asp:Panel ID="Panelschedule" runat="server">
                        <div class="row" style="height: 700px;margin: 0px; padding: 0px; width: 98.5%">
                          <asp:Label ID="Label13" runat="server" style="float:right; margin-left: 10px; margin-right: 120px; margin-top: 5px" Text="Сотрудник (а / ов)"></asp:Label> <asp:Label ID="Label12" runat="server" style="float:right; margin-top: 5px" Text="Label"></asp:Label> 
                          <asp:TextBox ID="TextBox9" runat="server" CssClass="form-control" Style="width: 70%"></asp:TextBox>     
                           <p></p>
                            <asp:Button ID="Button7" runat="server" CssClass="btn btn-danger" style="width: 100px" Text="Посчитать" OnClick="Button7_Click" />
                            <asp:Button ID="Button8" runat="server" CssClass="btn btn-primary" style="width: 100px" Text="Вывести" OnClick="Button8_Click" />
                           <p></p>
                            <asp:GridView ID="GridViewschedule" runat="server" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black">
                                <FooterStyle BackColor="#CCCCCC" />
                                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                                <RowStyle BackColor="White" />
                                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                                <SortedAscendingHeaderStyle BackColor="#808080" />
                                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                                <SortedDescendingHeaderStyle BackColor="#383838" />
                            </asp:GridView>
                           

                            </div>
                        </asp:Panel>

                    <footer>
                        <asp:Image ID="Image2" runat="server" ImageUrl="../../Content/img/фон.png" Style="height: 70px; width: 200px" />
                        <p>HRD for SS "Skyline" - © Rostislav Podolskiy</p>
                    </footer>
        </div>          
       </div>
    </form>
</body>
</html>
