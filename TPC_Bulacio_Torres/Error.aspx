<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="Error.aspx.cs" Inherits="TPC_Bulacio_Torres.Error" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent2" runat="server">
    <h1>Hubo un problema...</h1>
    <asp:Label Text="Error: " ID="lblError" runat="server" />
    
    <div class="row mx-md-n5">

        <div class="col px-md-5">
            <div class="p-3 border bg-light">
                <a href='javascript:history.go(-1)' class="btn btn-primary" >Go Back to Previous Page</a>
            </div>
        </div>
        <%
        if (Session["usuario"] == null)
        {

        %>
            <div class="col px-md-5">
                <div class="p-3 border bg-light">
                    <asp:Button ID="btnLogin" runat="server" Text="Ir a login" class="btn btn-primary" OnClick="btnLogin_Click"/>
                </div>
            </div>
        <%} %>
    </div>
</asp:Content>
