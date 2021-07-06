<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ABMMaquina.aspx.cs" Inherits="TPC_Bulacio_Torres.ABMMaquina" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <div class="row justify-content">
        <table id="machinesTable" class="display table table-light table-hover">
           <thead class="table-dark">
               <tr>
                   <th scope="col">MÁQUINA</th>
                   <th scope="col">MODELO</th>
                   <th scope="col">NRO. SERIE</th>
                   <th scope="col"></th>
                   <th scope="col"></th>
               </tr>
           </thead>
           <tbody>
                    <%foreach (Dominio.Maquina maquina in machinesList) 
                        { %>
                           <tr>
                               <th><% =maquina.MachineName %> </th>
                               <th><% =maquina.MachineModel %></th>
                               <th><% =maquina.MachineSerialNumber %></th>
                               <th> <a href="FormMaquina.aspx?IDMachine=<%=maquina.IDMachine %>&Mode=M">Modificar</a> </th>
                               <th> <a href="FormMaquina.aspx?IDMachine=<%=maquina.IDMachine %>&Mode=D">Eliminar</a> </th>
                           </tr>        
                              
                    
                    <%} %>
               
            

           </tbody>
        </table>

    </div>
    <form runat="server">
        <asp:Button ID="btnAgregarMaquina" runat="server" Text="Agregar Maquina" OnClick="btnAgregarMaquina_Click" />
    </form>




</asp:Content>
