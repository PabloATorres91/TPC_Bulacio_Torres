<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ABMUsuario.aspx.cs" Inherits="TPC_Bulacio_Torres.ABMUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

    <asp:UpdatePanel runat="server">
        <ContentTemplate>
            <div class="row justify-content">
                <table id="mainTable" class="display table table-light table-hover">
                    <thead class="table-dark">
                        <tr>
                            <th scope="col">Nombre</th>
                            <%--<th scope="col">Apellido</th>--%>
                            <th scope="col">Perfil</th>
                            <%--<th scope="col">ID Empleado</th>--%>
                            <th scope="col">Email</th>
                            <th scope="col"></th>
                            <th scope="col"></th>
                        </tr>
                    </thead>
                    <tbody>
                        <%
                            if (Session["usuario"] != null || Convert.ToBoolean(Application.Get("debugMode")) == true)
                            {
                                foreach (Dominio.Usuario user in list)
                                { %>
                                    <tr>
                                        <th><%= user.UserName %></th>
                                        <th><%= user.UserIDProfile%></th>
                                        <th><%= user.UserEmail%></th>
                                        <th> <a href="FormUsuario.aspx?IDUser=<%=user.UserID %>&Mode=M">Modificar</a> </th>
                                        <th> <a href="FormUsuario.aspx?IDUser=<%=user.UserID %>&Mode=D">Eliminar</a> </th>
                                    </tr>
                              <%}
                            }
                        %>
                    </tbody>
                </table>
            </div>
            <asp:Button ID="btnAgregar" runat="server" Text="Agregar Usuario" OnClick="btnAgregar_Click" />
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
