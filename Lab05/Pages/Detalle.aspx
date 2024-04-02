<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Detalle.aspx.cs" Inherits="Lab05.Pages.Detalle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <div>
            <span>Nombre Completo</span>
            <asp:TextBox ID="txtNombreCompleto" runat="server" CssClass="form-control" ReadOnly="True" Enabled="false"></asp:TextBox>
        </div>
        <div>
            <span>Email</span>
            <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" ReadOnly="True" Enabled="false"></asp:TextBox>
        </div>
        <div>
            <span>Fecha Nacimiento</span>
            <asp:TextBox ID="txtFechaNaci" runat="server" CssClass="form-control" ReadOnly="True" Enabled="false"></asp:TextBox>
        </div>
    </div>
</asp:Content>
