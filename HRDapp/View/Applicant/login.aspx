<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="HRDapp.View.Applicant.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
 
    
    <title>СТО Skyline</title>

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
    a {
        text-align: center;
    }

    p{
        text-align: center;
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
            <div class="panel-heading" style="text-align:center;font-size:175%; background-color: #0066FF; font-family: Arial, Helvetica, sans-serif; color: #FFFFFF;">Авторизация</div>
            <div class="panel-body" id="pannelid" style="margin:0 auto; background-color: #FFFFFF;">

                <div id="form"> 
       <legend> Введите данные</legend>

        <div class="form-group">

            <label for="usr">Email:</label>
            <asp:TextBox ID="txtlogemail" runat="server" Class="form-control" placeholder="Email" required="required"></asp:TextBox>

            </div>

        <div class="form-group">
            <label for="usr">Пароль</label>
            <asp:TextBox ID="txtlogpassword" runat="server" Class="form-control" TextMode="Password" placeholder="Password" required="required"></asp:TextBox>
        </div>
                    <div class="form-group" style="text-align:center">
                <asp:Button ID="Button1" runat="server" Text="Войти" Class="btn btn-succes" OnClick="Button" required="required" Width="139px"></asp:Button>
               </div>
                    <div class="form-group" style="text-align:center">
                        <asp:Label ID="Label2" runat="server" ForeColor="Red"></asp:Label>
                        <div>
                  <p></p>
            <p>Нет аккаунта?<a href="register.aspx"> Перейти к регистрации</a></p>
                 
                    </div>
                </div>
                </div>
          </div>
            </div>
    </form>
</body>
</html>
