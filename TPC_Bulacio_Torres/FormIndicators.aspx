<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormIndicators.aspx.cs" Inherits="TPC_Bulacio_Torres.FormIndicators" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
        <div class="container-fluid">
            
            <!-- Page Heading -->
            <h1 class="h3 mb-2 text-gray-800">INDICADORES</h1>
            <p class="mb-4">Aquí podrá seleccionar el tipo de gráfico mediante los campos seleccionables</p>
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
            <asp:Button ID="btnIndicator" runat="server" Text="Generar Tabla" class="btn btn-primary" OnClick="btnIndicator_Click"  />
        </div>
    
</asp:Content>
