<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="Error.aspx.cs" Inherits="TPC_Bulacio_Torres.Error" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent2" runat="server">
    <h1>Hubo un problema...</h1>
    <asp:Label Text="Error: " ID="lblError" runat="server" />
    
    <div>
        <a href='javascript:history.go(-1)'>Go Back to Previous Page</a>
    </div>
</asp:Content>
