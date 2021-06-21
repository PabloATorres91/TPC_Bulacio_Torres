<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TPC_Bulacio_Torres.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="css/styles.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.6.0/dist/css/bootstrap.min.css" integrity="sha384-B0vP5xmATw1+K9KRQjQERJvTumQW0nPEzvF6L/Z6nronJ3oUOFUFpCjEUQouq2+l" crossorigin="anonymous">
</head>
<body>
    <div class="container well contenedor">
            <div style="text-align:center;">
                <h2>Iniciar sesión</h2>
            </div>
        <form runat="server" class="form-horizontal">
            <%-- Agregamos controles de Usuario --%>
            <div class="form-group">
                <asp:Label ID="lblUser" runat="server" Text="Usuario" CssClass="control-label col-sm-2"></asp:Label>
                <div class="col-sm-10">
                    <asp:TextBox ID="txtUser" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <%-- Agregamos controles de Password--%>
            <div class="form-group">
                <asp:Label ID="lblPassword" runat="server" Text="Contraseña" CssClass="control-label col-sm-2"></asp:Label>
                <div class="col-sm-10">
                    <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <%-- Agregamos control de boton--%>
            <div class="form-group">
                <asp:Button ID="btnAccept" runat="server" Text="Aceptar" OnClick="btnAccept_Click" CssClass="form-control btn btn-primary"/>
            </div>
        </form>
    </div>
</body>
</html>
