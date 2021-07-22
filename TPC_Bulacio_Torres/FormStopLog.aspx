<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormStopLog.aspx.cs" Inherits="TPC_Bulacio_Torres.FormStopLog" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
      
    <div class="container-fluid">
         <!-- Page Heading -->
            <h1 class="h3 mb-2 text-gray-800">FORMULARIO DE PARADAS DIARIAS</h1>
            <p class="mb-4">Sección para la Creación, Modificación y Eliminación de Paradas Diarias.</p>
            <!-- End Page Heading -->  
        
        <div class="form-row">
            <div class="form-group col-md-6">
                <label>Motivo de Parada</label>
                <asp:DropDownList ID="ddlStopCode" runat="server"></asp:DropDownList>                
            </div>
            
        </div>
        <div class="form-row">
            <div class="form-group col-md-6">
                 <%if (Request.QueryString["Mode"] !="D")
                    { %>
                        <label>Hora Desde</label>
                        <input ID="inputStopLogBegin" runat="server" type="time" name="inputStopLogBegin"/>
                       
                <%} %>
                
                <%if (Request.QueryString["IDStopLog"] != null)
                    { %>
                        <label for="inputAddress">Hora Inicio</label> 
                        <asp:TextBox ID="txtStopLogBegin" runat="server" width="80" Enabled="false" />
                <%} %>
            </div>
            
        </div>
        <div class="form-row">
            <div class="form-group col-md-6">
                 <%if (Request.QueryString["Mode"] !="D")
                    { %>
                        <label>Hora Hasta</label>
                        <input id="inputStopLogFinish" runat="server" type="time" name="inputStopLogFinish" />

                 <%} %>

                 <%if (Request.QueryString["IDStopLog"] != null)
                    { %>
                        <label for="inputAddress">Hora Fin</label> 
                        <asp:TextBox ID="txtStopLogFinish" runat="server" width="80" Enabled="false" />
                 <%} %>
            </div>
            
        </div>        
        <div class="align-bottom">
            <label for="inputAddress">Observaciones</label> 
        </div>    
        <div class="justify-content-around">
            <asp:TextBox ID="txtStopLogObservation" runat="server" ToolTip="StopLogObservation" MaxLength="1000" TextMode="MultiLine" Width="500" Height="150"></asp:TextBox>
        </div>
        <div class="container">
            <div class="row">
                <div class="col-md-4 text-left">
                    <asp:Button ID="btnAceptarParada" runat="server" Text="Aceptar" class="btn btn-primary" OnClick="btnAceptarParada_Click"/>
                </div>
                <div class="col-md-4 text-rigth">
                    <asp:Button ID="btnCancelarParada" runat="server" Text="Cancelar" class="btn btn-primary" OnClick="btnCancelarParada_Click"/>
                </div>
            </div>
        </div>   
    </div>    
  
         
</asp:Content>
