<%@ Page Language="C#" MasterPageFile="~/Site.Master" CodeBehind="PerfilUsuario.aspx.cs" Inherits="WebApplication1.PerfilUsuario" %>
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
        <td class="style1" rowspan="5" >
            <img alt="" src="Imagenes/chendilon.png" style="height: 240px; width: 200px" /></td>
        <td style="width:50%" colspan="2">
            <asp:Label ID="LApodo" runat="server" Text="<b>Apodo:</b>" ></asp:Label>
            <asp:Label ID="LApodo2" runat="server" Text=""></asp:Label>
        </td>
    </tr>
    <tr>
        <td colspan="2">
            <asp:Label ID="LContacto" runat="server" Text="<b>Contacto:</b>"></asp:Label>
            <asp:Label ID="LContacto2" runat="server" Text=""></asp:Label>
        </td>
    </tr>
    <tr>
        <td colspan="2">
            <asp:Label ID="LPais" runat="server" Text="<b>Pais:</b>"></asp:Label>
            <asp:Label ID="LPais2" runat="server" Text=""></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="LFacebook" runat="server" Text="<b>Facebook:</b>"></asp:Label>
            <asp:Label ID="LFacebook2" runat="server" Text=""></asp:Label>
        </td>
    </tr>
    <tr>
        <td colspan="2">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns = "False" 
                Height= "100%" Width = "100%" >
            </asp:GridView>
            <asp:TextBox ID="Mensajes" runat="server" Height= "100%" Width = "80%"></asp:TextBox>
            <asp:Button ID="BotonMensajes" runat="server" Text="Enviar" 
                onclick="BotonMensajes_Click" />
            <br />
        </td>
    </tr>
</table>
</asp:Content>
