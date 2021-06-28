<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ABMUsuario.aspx.cs" Inherits="TPC_Bulacio_Torres.ABMUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row justify-content">
        <table id="usersTable" class="display table table-light table-hover">
            <thead class="table-dark">
                <tr>
                    <th scope="col">Nombre</th>
                    <%--<th scope="col">Apellido</th>--%>
                    <th scope="col">Perfil</th>
                    <%--<th scope="col">ID Empleado</th>--%>
                    <th scope="col">Email</th>
                </tr>
            </thead>
            <tbody>
                <%foreach (Dominio.Usuario user in list)
                    { %>
                        <tr>
                            <th><%= user.UserName %></th>
                            <th><%= user.UserIDProfile%></th>
                            <th><%= user.UserEmail%></th>
                        </tr>
                <%  } %>
            </tbody>
        </table>
    </div>

</asp:Content>
