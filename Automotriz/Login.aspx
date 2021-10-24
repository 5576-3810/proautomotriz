<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Automotriz.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="usuario"></asp:Label>
            <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
            <asp:TextBox  ID="txtPassword"  runat="server" Textmode="Password" ></asp:TextBox>
            <br />
            <asp:Button ID="btnLogin" runat="server" OnClick="Button1_Click" Text="iniciar Sesion" />
            <br />
            <asp:Label ID="lblErrorMessage" runat="server" Text="Datos Incorrectos" Visible="False"></asp:Label>
        </div>
    </form>
</body>
</html>
