<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormMaquina.aspx.cs" Inherits="TPC_Bulacio_Torres.FormMaquina" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form runat="server">
        <div class="form-row">
            <div class="form-group col-md-6">
                <label>Líneas de Producción</label>
                <asp:DropDownList ID="ddlProductionLine" runat="server"></asp:DropDownList>
            </div>
            
        </div>
        
        <div class="form-group">
            <label for="inputAddress">Máquina</label>
            <asp:TextBox ID="txtMachineName" runat="server" ToolTip="MachineName" MaxLength="100"></asp:TextBox>
        </div>
         <div class="form-group">
            <label for="inputAddress">Modelo</label>
            <asp:TextBox ID="txtMachineModel" runat="server" ToolTip="MachineModel" MaxLength="100"></asp:TextBox>
        </div>
         <div class="form-group">
            <label for="inputAddress">Número de Serie</label>
            <asp:TextBox ID="txtMachineSerialNumber" runat="server" ToolTip="MachineSerialNumber" MaxLength="100"></asp:TextBox>
        </div>
         <div class="form-group">
            <label for="inputAddress">ID</label>
            <asp:TextBox ID="txtIDMachine" runat="server" ToolTip="IDMachine" MaxLength="100"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="inputAddress">Estado</label>
            <asp:TextBox ID="txtMachineStatus" runat="server" ToolTip="MachineStatus" MaxLength="100"></asp:TextBox>
        </div>

        <asp:Button ID="btnAceptarMaquina" runat="server" Text="Aceptar" class="btn btn-primary" OnClick="btnAceptarMaquina_Click" />

    </form>
</asp:Content>
