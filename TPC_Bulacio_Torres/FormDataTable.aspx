<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormDataTable.aspx.cs" Inherits="TPC_Bulacio_Torres.FormDataTable" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<div class="container-fluid">
            
     <!-- Page Heading -->
     <h1 class="h3 mb-2 text-gray-800">GRÁFICO TIPO TABLA</h1>
     <p class="mb-4">Informe según los datos seleccionados.</p>
     <!-- End Page Heading -->

     <!-- Table -->
     <div class="card shadow mb-4">
         <div class="card-header py-3">
             <h6 class="m-0 font-weight-bold text-primary">Gráfico tipo tabla según lo seleccionado.</h6>
         </div>
         <div class="card-body">
              <table id="mainTable" class="display table table-light table-hover">
                   <thead class="table-dark">
                       <tr>
                           <th scope="auto">MÁQUINA</th>
                           <th scope="auto">CÓDIGO DE PARADA</th>
                           <th scope="auto">FECHA</th>
                           <th scope="auto">TIEMPO (Min)</th>
                           <th scope="auto"></th>
                           <th scope="auto"></th>
                       </tr>
                   </thead>
                   <tbody>
                            <%foreach (Dominio.StopLog stopLog in stopLogList) 
                                { %>
                                   <tr>
                                       <th><% = stopLog.IDMachine %> </th>
                                       <th><% = stopLog.IDStopCode %></th>
                                       <th><% = stopLog.StopLogBegin.ToString("dd/MM/yyyy") %></th>
                                       <th><% = stopLog.TiempoMinutos.TotalMinutes %></th>
                                      
                                   </tr>        
                              
                    
                            <%} %>              
            

                   </tbody>
                </table>
             <hr>
             Prueba de como se vería la tabla.
             <code></code>
         </div>
     </div>
    <asp:Button ID="btnSalir" runat="server" Text="Regresar" Class="btn btn-primary" OnClick="btnSalir_Click"  />
           
  </div>
</asp:Content>
