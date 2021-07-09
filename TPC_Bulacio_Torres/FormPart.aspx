<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormPart.aspx.cs" Inherits="TPC_Bulacio_Torres.FormPart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<form runat="server">
        <div class="form-row">
            <div class="form-group col-md-6">
                <label>Máquinas</label>
                <asp:DropDownList ID="ddlMachine" runat="server"></asp:DropDownList>
            </div>
            
        </div>
        <div class="form-group">
            <label for="inputAddress">Nombre</label>
            <asp:TextBox ID="txtPartName" runat="server" ToolTip="PartName" MaxLength="100"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="inputAddress">Descripción</label>
            <asp:TextBox ID="txtPartDescription" runat="server" ToolTip="PartDescription" MaxLength="100"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="inputAddress">ID Parte</label>
            <asp:TextBox ID="txtIDPart" runat="server" ToolTip="IDPart" MaxLength="100"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="inputAddress">ID Máquina</label>
            <asp:TextBox ID="txtIDMachine" runat="server" ToolTip="IDMachine" MaxLength="100"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="inputAddress">Estado</label>
            <asp:TextBox ID="txtPartStatus" runat="server" ToolTip="PartStatus" MaxLength="100"></asp:TextBox>
        </div>
    <asp:Button ID="btnAceptarParte" runat="server" Text="Aceptar" class="btn btn-primary" OnClick="btnAceptarParte_Click" />
</form>
</asp:Content>
