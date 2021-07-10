<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ABMStopCodes.aspx.cs" Inherits="TPC_Bulacio_Torres.ABMStopCodes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row justify-content">
            <table id="mainTable" class="display table table-light table-hover">
                <thead class="table-dark">
                    <tr>
                        <th scope="col">Código parada</th>
                        <%--<th scope="col">Apellido</th>--%>
                        <th scope="col">Nombre código parada</th>
                        <%--<th scope="col">ID Empleado</th>--%>
                        <th scope="col"></th>
                        <th scope="col"></th>
                    </tr>
                </thead>
                <tbody>
                    <%foreach (Dominio.StopCode stopCode in list)
                        { %>
                            <tr>
                                <th><%= stopCode.IDStopCode %></th>
                                <th><%= stopCode.StopCodeName%></th>
                                <th> <a href="FormStopCode.aspx?IDStopCode=<%=stopCode.IDStopCode %>&Mode=M">Modificar</a> </th>
                                <th> <a href="FormStopCode.aspx?IDStopCode=<%=stopCode.IDStopCode %>&Mode=D">Eliminar</a> </th>
                            </tr>
                    <%  } %>
                </tbody>
            </table>
        </div>

    <form runat="server">
            <asp:Button ID="btnAgregarStopCode" runat="server" Text="Agregar Parada" OnClick="btnAgregarStopCode_Click" />
    </form>

</asp:Content>
