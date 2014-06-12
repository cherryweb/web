<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="EditarPerfil.aspx.cs" Inherits="WebApplication1.EditarPerfil" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
    .style1
    {
        width: 204px;
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
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server" >
    <table style="width:100%;">
    <tr>
        <td colspan="2">
            <asp:Label ID="Editar" runat="server" Text="<b>Editar Perfil</b>"></asp:Label>
        </td>
    </tr>
    <tr>
        <td colspan="2">
            <asp:Label ID="NombreLabel" runat="server" Text="<b>Nombre:</b>"></asp:Label>
            <asp:TextBox ID="NombreBox" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td colspan="2">
            <asp:Label ID="Contrasena" runat="server" Text="<b>Contraseña:</b>"></asp:Label>
            <asp:TextBox ID="ContrasenaBox" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td colspan="2">
            <asp:Label ID="ContrasenaRepetir" runat="server" Text="<b>Repetir Contraseña:</b>"></asp:Label>
            <asp:TextBox ID="ContrasenaRepetirBox" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td colspan="2">
            <asp:Label ID="LContacto" runat="server" Text="<b>Contacto:</b>"></asp:Label>
            <asp:TextBox ID="ContactoBox" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td colspan="2">
            <asp:Label ID="LPais" runat="server" Text="<b>Pais:</b>"></asp:Label>
             <asp:DropDownList ID="DespPaises" runat="server">
                <asp:ListItem>España</asp:ListItem>
                <asp:ListItem>Portugal</asp:ListItem>
                <asp:ListItem>Alemania</asp:ListItem>
                <asp:ListItem>Malta</asp:ListItem>
                <asp:ListItem>Andorra</asp:ListItem>
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="LFacebook" runat="server" Text="<b>Facebook:</b>"></asp:Label>
            <asp:TextBox ID="FacebookBox" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="LTwitter" runat="server" Text="<b>Twitter:</b>"></asp:Label>
            <asp:TextBox ID="TwitterBox" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td colspan="2">
            <asp:Label ID="SubirImgLabel" runat="server" Text="<b>Foto de perfil</b>"></asp:Label>
            <asp:FileUpload ID="ImgBox" runat="server" />
        </td>
    </tr>
    <tr>
        <td colspan="2">
            <asp:Button ID="Confirmar" runat="server" Text="Confirmar" 
                onclick="Confirmar_Click"></asp:Button>
        </td>
    </tr>
</table>
</asp:Content>