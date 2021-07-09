<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ABMPart.aspx.cs" Inherits="TPC_Bulacio_Torres.ABMPart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
 <div class="row justify-content">
        <table id="machinesTable" class="display table table-light table-hover">
           <thead class="table-dark">
               <tr>
                   <th scope="col">NOMBRE</th>
                   <th scope="col">MÁQUINA</th>
                   <th scope="col">DESCRIPCIÓN</th>
                   <th scope="col"></th>
                   <th scope="col"></th>
               </tr>
           </thead>
           <tbody>
                    <%foreach (Dominio.Part part in partsList) 
                        { %>
                           <tr>
                               <th><% =part.PartName %> </th>
                               <th><% =part.IDMachine %> </th>
                               <th><% =part.PartDescription %></th>
                               <th> <a href="FormPart.aspx?IDPart=<%=part.IDPart %>&Mode=M">Modificar</a> </th>
                               <th> <a href="FormPart.aspx?IDPart=<%=part.IDPart %>&Mode=D">Eliminar</a> </th>
                           </tr>        
                              
                    
                    <%} %>
               
            

           </tbody>
        </table>

    </div>
    <form runat="server">
        <asp:Button ID="btnAgregarParte" runat="server" Text="Agregar Parte" OnClick="btnAgregarParte_Click"  />
    </form>
</asp:Content>
