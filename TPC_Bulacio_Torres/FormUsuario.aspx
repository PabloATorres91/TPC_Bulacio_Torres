<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormUsuario.aspx.cs" Inherits="TPC_Bulacio_Torres.FormUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel runat="server">
            <ContentTemplate>
                <%--<form runat="server">--%>
                    <div class="form-row">
                        <div class="form-group col-md-6">
                            <label for="inputEmail4">Nombre</label>
                            <asp:TextBox ID="txtName" runat="server" ToolTip="Nombre" MaxLength="50"></asp:TextBox>
                        </div>
                        <div class="form-group col-md-6">
                            <label for="inputPassword4">Perfil</label>
                            <asp:DropDownList ID="ddlProfile" runat="server"></asp:DropDownList>
                        </div>
                    </div>
                    <div class="form-group">
                        <label for="inputAddress">Email</label>
                        <asp:TextBox ID="txtEmail" runat="server" ToolTip="Email" MaxLength="100"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="inputAddress">ID empleado</label>
                        <asp:TextBox ID="txtIdEmployee" runat="server" ToolTip="IdEmployee" MaxLength="100"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="inputAddress">Fecha Ingreso</label>
                        <asp:TextBox ID="txtIngreso" runat="server" ToolTip="Fecha de ingreso" MaxLength="100"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="inputAddress">ID Usuario</label>
                        <asp:TextBox ID="txtUserID" runat="server" ToolTip="ID de usuario"></asp:TextBox>
                    </div>
                    <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" class="btn btn-primary" OnClick="btnAceptar_Click" OnClientClick="return confirm('Estas seguro?');"/>
                <%--</form>--%>
            </ContentTemplate>
        </asp:UpdatePanel>
</asp:Content>
