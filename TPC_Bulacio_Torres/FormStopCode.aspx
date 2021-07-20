<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormStopCode.aspx.cs" Inherits="TPC_Bulacio_Torres.FormStopCode" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <a1>Ventana ABM Codigo de paradas</a1>
    <asp:UpdatePanel runat="server">
            <ContentTemplate>
                    <div class="form-row">
                        <div class="form-group col-md-6">
                            <label for="inputEmail4">Nombre código parada</label>
                            <asp:TextBox ID="txtNameStopCode" runat="server" ToolTip="Nombre código parada" MaxLength="50"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group">
                        <label for="inputAddress">ID Código de parada</label>
                        <asp:TextBox ID="txtIDStopCode" runat="server" ToolTip="ID de código parada"></asp:TextBox>
                    </div>
                    <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" class="btn btn-primary" OnClick="btnAceptar_Click" OnClientClick="return confirm('Estas seguro?');"/>
            </ContentTemplate>
        </asp:UpdatePanel>
</asp:Content>
