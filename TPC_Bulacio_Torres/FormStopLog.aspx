<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormStopLog.aspx.cs" Inherits="TPC_Bulacio_Torres.FormStopLog" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
      
        <div class="form-row">
            <div class="form-group col-md-6">
                <label>Motivo de Parada</label>
                <asp:DropDownList ID="ddlStopCode" runat="server"></asp:DropDownList>                
            </div>
            
        </div>
        <div class="form-row">
            <div class="form-group col-md-6">
                <label>Hora Inicial</label>
                <input ID="inputStopLogBegin" type="time" name="inputStopLogBegin" step="3600" />
            </div>
            
        </div>
        <div class="form-row">
            <div class="form-group col-md-6">
                <label>Hora Final</label>
                <input ID= "inputStopLogFinish" type="time" name="inputStopLogFinish" step="3600" />
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
         
</asp:Content>
