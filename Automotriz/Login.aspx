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
    </style>
</head>

    <body style="background-image:url(Scripts/fondo.jpg); background-repeat: no-repeat; background-attachment: fixed">
    <form id="form1" runat="server">
        
        <div>

             <table border="1" >
    <caption>
        <asp:Label ID="Label3" runat="server" ForeColor="White" Text="Iniciar Sesion en el sistema"></asp:Label>
                 </caption>
    <tbody>
    
      <tr>
        <td>

              <asp:Label ID="Label1" runat="server" Text="Usuario" ForeColor="White"></asp:Label>
            <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
            <br />
               <br />
            <asp:Label ID="Label2" runat="server" Text="Password" ForeColor="White"></asp:Label>
            <asp:TextBox  ID="txtPassword"  runat="server" Textmode="Password" ></asp:TextBox>
            <br />
               <br />
            <asp:Button ID="btnLogin" runat="server" OnClick="Button1_Click" Text="iniciar Sesion" />
            <br />
               <br />
            <asp:Label ID="lblErrorMessage" runat="server" Text="Datos Incorrectos" Visible="False" ForeColor="White"></asp:Label>
  




        </td>
     
      </tr>
    </tbody>
  </table>
            
          
                 </div>
    </form>
</body>
</html>
