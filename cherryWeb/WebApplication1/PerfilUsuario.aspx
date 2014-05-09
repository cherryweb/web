<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PerfilUsuario.aspx.cs" Inherits="WebApplication1.PerfilApp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
    .style1
    {
        width: 16px;
    }
    #Text1
    {
        width: 247px;
        top: 236px;
        left: 446px;
        position: absolute;
        height: 22px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width:100%;">
    <tr>
        <td class="style1" rowspan="5">
            <img alt="" src="" style="height: 356px; width: 349px" /></td>
        <td colspan="2">
            <asp:Label ID="LApodo" runat="server" Text="Apodo:"></asp:Label>
            <asp:Label ID="LApodo2" runat="server" Text="Label"></asp:Label>
        </td>
    </tr>
    <tr>
        <td colspan="2">
            <asp:Label ID="LContacto" runat="server" Text="Contacto:"></asp:Label>
            <asp:Label ID="LContacto2" runat="server" Text="Label"></asp:Label>
        </td>
    </tr>
    <tr>
        <td colspan="2">
            <asp:Label ID="LPais" runat="server" Text="Pais:"></asp:Label>
            <asp:Label ID="LPais2" runat="server" Text="Label"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="LFacebook" runat="server" Text="Facebook:"></asp:Label>
            <asp:Label ID="LFacebook2" runat="server" Text="Label"></asp:Label>
        </td>
    </tr>
    <tr>
        <td colspan="2">
            <asp:Button ID="BotonEliminarCuenta" runat="server" Text="Eliminar Cuenta" />
        </td>
    </tr>
</table>
</asp:Content>
