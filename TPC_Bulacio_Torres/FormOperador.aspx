<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormOperador.aspx.cs" Inherits="TPC_Bulacio_Torres.FormOperador" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid">
         <!-- Page Heading -->
            <h1 class="h3 mb-2 text-gray-800">CARGAS DIARIAS</h1>
            <p class="mb-4">Seleccione la Línea, Equipo y el turno para inciar la Carga de Paradas Diarias.</p>
            <!-- End Page Heading --> 
        
        <div class="form-row">
            <div class="form-group col-md-6">
                <label>Líneas de Producción</label>
                <asp:DropDownList ID="ddlProductionLine" runat="server"></asp:DropDownList>
            </div>  
        </div>              
        <div class="form-row">
            <div class="form-group col-md-6">
                <label>Máquina</label>
                <asp:DropDownList ID="ddlMachine" runat="server"></asp:DropDownList>
            </div>            
        </div>
        <div class="form-row">
            <div class="form-group col-md-6">
                <label>Turno</label>
                <asp:DropDownList ID="ddlTurn" runat="server"></asp:DropDownList>
            </div>            
        </div>
    <asp:Button ID="btnRegistrarParadas" runat="server" text="Registrar Paradas" class="btn btn-primary" OnClick="btnRegistrarParadas_Click" />

    </div>    
    
  
        
        
</asp:Content>
