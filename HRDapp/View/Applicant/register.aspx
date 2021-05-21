<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="HRDapp.View.Applicant.register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>

    <script src="../../Content/js/jquery-3.3.1.js"></script>
    <script src="https://code.jquery.com/jquery-1.12.4.js"></script>
  <script src="https://code.jquery.com/ui/1.12.1/jquery-ui.js"></script>
  <script>
      $(function () { 
          $("#datepicker").datepicker(
              {
                  dateFormat: 'dd M yy',
                  changeMonth: true,
                  changeYear: true
              });

          var date = new Date();
          date.setDate(date.getDate());
          date.setFullYear(date.getFullYear() - 18);

          $("#datepicker").datepicker('setDate', date);
          $("#datepicker").datepicker('option', 'maxDate', new Date(date));

          $("#datepicker").change(function () {
              alert($("#datepicker").val());
          });
      });
  </script>

      <title>СТО Skyline</title>
   <%--<a href="register.aspx">register.aspx</a>--%>
    <link rel="stylesheet" href="//code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css" />
    <link rel="stylesheet" href="/resources/demos/style.css" />
    <link href="../../Content/css/bootstrap.css" rel="stylesheet" />
    <link href="../../Content/css/bootstrap.min.css" rel="stylesheet" />

    <style>

    Body { 
        margin: 0; 
        padding: 0px; 
        background-image: url(https://c.radikal.ru/c10/2105/57/a7d3ec30d2c0.jpg);
        background-repeat: no-repeat; 
        background-size: 1960px 1080px; 

    }

    #wrapper
        {

    }

    #form
        {

        width: auto;

    }

    #pannelid
        {

        height: auto;
        margin: 0 auto;

    }

    #wholepannel
        {

    }

    
        .btn-succes {}

    
    </style>
</head>

<body>
    <form id="form1" runat="server">

     <div id="Wrapper" class="col-lg-12">

      <div id="center-from" style="border-color: #C0C0C0; width:50%; height:auto; background-color:#FFFFFF; margin:0 auto;">

            <div id="wholepannel" class="panel panel-primary col-md-12">
            <div class="panel-heading" style="text-align:center;font-size:175%; background-color: #0066FF;">Регистрация</div>
            <div class="panel-body" id="pannelid" style="margin:0 auto; background-color: #FFFFFF;">

                <div id="form"> 
       
        <legend> Информация для входа</legend>

        <div class="form-group">

            <label for="usr">Email:</label>
            <asp:TextBox ID="txtemail" runat="server" Class="form-control" required="required"></asp:TextBox>

            </div>

        <div class="form-group">
            <label for="usr">Пароль</label>
            <asp:TextBox ID="txtpassword" runat="server" Class="form-control" TextMode="Password" required="required"></asp:TextBox>

            </div>

        <div class="form-group">
            <label for="usr">Подтвердите пароль</label>
            <asp:TextBox ID="txtсpassword" runat="server" Class="form-control" TextMode="Password" required="required"></asp:TextBox>
            <p id="errorprint" style="color:red; font-weight:bold;"></p>
            </div>
    </div>

        <fieldset>
            <legend> Персональная информация</legend>

            <div class="form-group">
            <label for="usr">ФИО:</label>
            <asp:TextBox ID="txtusername" runat="server" Class="form-control" required="required"></asp:TextBox>
            </div>

            <div class="form-group">
            <label for="pwd">Должность:</label>
            <asp:TextBox ID="txtposition" runat="server" Class="form-control" required="required"></asp:TextBox>
            </div>

             <div class="form-group">
            <label for="pwd">Моб.телефон:</label>
            <asp:TextBox ID="txtphone1" runat="server" Class="form-control" required="required"></asp:TextBox>
            </div>

             <div class="form-group">
            <label for="pwd">Дом.телефон:</label>
            <asp:TextBox ID="txtphone2" runat="server" Class="form-control" required="required"></asp:TextBox>
            </div>

             <div class="form-group">
            <label for="pwd">Пол:</label>
            <asp:RadioButton ID="Male" GroupName="gender" runat="server" Checked="true" Text="Мужской"/>
            <asp:RadioButton ID="Female" GroupName="gender" runat="server" Text="Женский" />
            </div>

            <div class="form-group">
            <label for="pwd">Фотография:</label>
                <asp:FileUpload ID="FileUpload1" runat="server" CssClass="form-control"/>
                 </div>

            

             <div class="form-group">
            <label for="pwd">Дата рождения:</label>
                  <asp:TextBox ID="datepicker" runat="server" Class="form-control" required="required"  OnTextChanged="datepicker_TextChanged"></asp:TextBox>
                 <%--<asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>--%>
                 </div>

            <div class="form-group">
            <label for="pwd">Зарплата:</label>
            <asp:TextBox ID="txtsalary" runat="server" Class="form-control" required="required"></asp:TextBox>
            </div>
             
            <div class="form-group">
                <asp:Button ID="Button1" runat="server" Text="Продолжить" Class="btn btn-succes" OnClick="Button" required="required"></asp:Button>
               </div>

            </fieldset>
         </div>
      </div>
    </div>
</div>
     </form>
</body>
</html>
