<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormUsuario.aspx.cs" Inherits="TPC_Bulacio_Torres.FormUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <form runat="server">
        <div class="form-row">
            <div class="form-group col-md-6">
                <label for="inputEmail4">Nombre</label>
                <asp:TextBox ID="txtName" runat="server" ToolTip="Nombre" MaxLength="50"></asp:TextBox>
            </div>
            <div class="form-group col-md-6">
                <label for="inputPassword4">Perfil</label>
                <asp:TextBox ID="txtProfile" runat="server" ToolTip="Perfil"></asp:TextBox>
            </div>
        </div>
        <div class="form-group">
            <label for="inputAddress">Email</label>
            <asp:TextBox ID="txtEmail" runat="server" ToolTip="Email" MaxLength="100"></asp:TextBox>
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
        <button type="submit" class="btn btn-primary">Sign in</button>
    </form>
</asp:Content>
