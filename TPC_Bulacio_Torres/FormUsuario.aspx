<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormUsuario.aspx.cs" Inherits="TPC_Bulacio_Torres.FormUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <script type="text/javascript">
        function Confirmacion() {
            var seleccion = confirm("acepta el mensaje ?");
            if (seleccion)
                alert("se acepto el mensaje");
            else
                alert("NO se acepto el mensaje");
            //usado para que no haga postback el boton de asp.net cuando 
            //no se acepte el confirm
            return seleccion;
        }
    </script>
    <form runat="server">
        <div class="form-row">
            <div class="form-group col-md-6">
                <label for="inputEmail4">Nombre</label>
                <asp:TextBox ID="txtName" runat="server" ToolTip="Nombre" MaxLength="50"></asp:TextBox>
            </div>
            <div class="form-group col-md-6">
                <label for="inputPassword4">Perfil</label>
                <asp:DropDownList ID="ddlProfile" runat="server"></asp:DropDownList>
            </div>
        </div>
        <div class="form-group">
            <label for="inputAddress">Email</label>
            <asp:TextBox ID="txtEmail" runat="server" ToolTip="Email" MaxLength="100"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="inputAddress">ID empleado</label>
            <asp:TextBox ID="txtIdEmployee" runat="server" ToolTip="IdEmployee" MaxLength="100"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="inputAddress">Fecha Ingreso</label>
            <asp:TextBox ID="txtIngreso" runat="server" ToolTip="Fecha de ingreso" MaxLength="100"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="inputAddress">ID Usuario</label>
            <asp:TextBox ID="txtUserID" runat="server" ToolTip="ID de usuario"></asp:TextBox>
        </div>
        <%--<div class="form-group">
        <label for="inputAddress2">Address 2</label>
        <input type="text" class="form-control" id="inputAddress2" placeholder="Apartment, studio, or floor">
      </div>
      <div class="form-row">
        <div class="form-group col-md-6">
          <label for="inputCity">City</label>
          <input type="text" class="form-control" id="inputCity">
        </div>
        <div class="form-group col-md-4">
          <label for="inputState">State</label>
          <select id="inputState" class="form-control">
            <option selected>Choose...</option>
            <option>...</option>
          </select>
        </div>
        <div class="form-group col-md-2">
          <label for="inputZip">Zip</label>
          <input type="text" class="form-control" id="inputZip">
        </div>
      </div>
      <div class="form-group">
        <div class="form-check">
          <input class="form-check-input" type="checkbox" id="gridCheck">
          <label class="form-check-label" for="gridCheck">
            Check me out
          </label>
        </div>
      </div>--%>
        <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" class="btn btn-primary" OnClick="btnAceptar_Click" OnClientClick="return Confirmacion();"/>
    </form>
</asp:Content>
