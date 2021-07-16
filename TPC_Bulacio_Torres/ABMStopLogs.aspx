<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ABMStopLogs.aspx.cs" Inherits="TPC_Bulacio_Torres.ABMStopLogs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    
    <asp:UpdatePanel runat="server">
        <ContentTemplate>
            <div class="row justify-content">
                <table id="mainTable" class="display table table-light table-hover">
                   <thead class="table-dark">
                       <tr>
                           <th scope="auto">CÓDIGO DE PARADA</th>
                           <th scope="auto">FECHA Y HORA INICIO</th>
                           <th scope="auto">FECHA Y HORA FIN</th>
                           <th scope="auto">OBSERVACIONES</th>
                           <th scope="auto"></th>
                           <th scope="auto"></th>
                       </tr>
                   </thead>
                   <tbody>
                            <%foreach (Dominio.StopLog stopLog in stopLogList) 
                                { %>
                                   <tr>
                                       <th><% = stopLog.IDStopCode %> </th>
                                       <th><% = stopLog.StopLogBegin %></th>
                                       <th><% = stopLog.StopLogFinish %></th>
                                       <th><% = stopLog.StopLogObservation %></th>
                                       <th> <a href="FormStopLog.aspx?IDStopLog=<% = stopLog.IDStopLog %>&Mode=M">Modificar</a> </th>
                                       <th> <a href="FormStopLog.aspx?IDStopLog=<% = stopLog.IDStopLog %>&Mode=D">Eliminar</a> </th>
                                   </tr>        
                              
                    
                            <%} %>
               
            

                   </tbody>
                </table>

            </div> 

            <asp:Button ID="btnNuevaParada" runat="server" Text="Nueva Parada" CssClass="btn btn-primary" onclick="btnNuevaParada_Click" />  
            
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
