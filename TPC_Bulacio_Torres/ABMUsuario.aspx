﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ABMUsuario.aspx.cs" Inherits="TPC_Bulacio_Torres.ABMUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
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
                    <%foreach (Dominio.Usuario user in list)
                        { %>
                            <tr>
                                <th><%= user.UserName %></th>
                                <th><%= user.UserIDProfile%></th>
                                <th><%= user.UserEmail%></th>
                                <th> <a href="FormUsuario.aspx?IDUser=<%=user.UserID %>&Mode=M">Modificar</a> </th>
                                <th> <a href="FormUsuario.aspx?IDUser=<%=user.UserID %>&Mode=D">Eliminar</a> </th>
                            </tr>
                    <%  } %>
                </tbody>
            </table>
        </div>
    <form runat="server">
            <asp:Button ID="btnAgregar" runat="server" Text="Agregar Usuario" OnClick="btnAgregar_Click" />
    </form>
</asp:Content>
