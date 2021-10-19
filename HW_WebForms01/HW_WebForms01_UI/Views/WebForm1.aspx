﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="HW_WebForms01_UI.Views.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <asp:Label ID="lblNombre" runat="server" Text="Nombre"></asp:Label>
            <asp:TextBox ID="textBox1" runat="server"></asp:TextBox>
            <asp:Label ID="lblError" runat="server" Text="" ForeColor="Red"></asp:Label>
            
        </p>
        <p>
            <asp:Button ID="btnEnviar" runat="server" Text="Enviar" OnClick="btnEnviar_Click" />
        </p>
        <p>
            <asp:Label ID="lblMensaje" runat="server" Text="" ForeColor="Blue"></asp:Label>
        </p>
    </form>
</body>
</html>
