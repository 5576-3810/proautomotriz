<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Automotriz.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>
        body{
            text-align:center;
        }
        .auto-style1 {
            width: 952px;
        }
        .auto-style2 {
            width: 952px;
            height: 164px;
        }
    </style>
</head>

    <body style="background-image:url(Scripts/fondo.jpg); background-repeat: no-repeat; background-attachment: fixed">
    <form id="form1" runat="server">
        
        <div>
            <asp:Image id="Image1" style="border: 1px solid; color: black;" runat="server" Height="150px" ImageUrl="~/Scripts/logo4.jpeg"  Width="300px" AlternateText="Imagen no disponible" ImageAlign="TextTop" />
      
     <br /> <br />
      

              <asp:Label ID="Label1" runat="server" Text="Usuario" ForeColor="White"></asp:Label>
            <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
            <br />
               <br style="font-family: 'Arial Black'" />
            <asp:Label ID="Label2" runat="server" Text="Contraseña" ForeColor="White"></asp:Label>
            <asp:TextBox  ID="txtPassword"  runat="server" Textmode="Password" ></asp:TextBox>
            <br />
               <br />
            <asp:Button ID="btnLogin" runat="server" OnClick="Button1_Click" Text="iniciar Sesion" />
            <br />
               <br />
            <asp:Label ID="lblErrorMessage" runat="server" Text="Datos Incorrectos" Visible="False" ForeColor="White"></asp:Label>
  




      
   
            
          
                 </div>
    </form>
</body>
</html>
