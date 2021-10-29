<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="Automotriz.Dashboard" %>

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
            <asp:Image id="Image1" style="border: 1px solid; color: black;" runat="server" Height="150px" ImageUrl="~/Scripts/logo4.jpeg"  Width="300px" AlternateText="Imagen no disponible" ImageAlign="TextTop" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" ForeColor="White" Text="Desea Salir del sistema?"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblUserDetails" runat="server" Text="Usuario" ForeColor="White"></asp:Label>
            <br />
            <asp:Button ID="btnLogout" runat="server" OnClick="btnLogout_Click" Text="Cerrar Sesion" />
            <br />
            <br />
            <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Regresar" />
        </div>
    </form>
</body>
</html>
