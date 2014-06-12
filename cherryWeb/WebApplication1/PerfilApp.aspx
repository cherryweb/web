<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PerfilApp.aspx.cs" Inherits="WebApplication1.PerfilApp" %>
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
        .style2
        {
            height: 35px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width:100%;">
    <tr>
        <td class="style1" rowspan="5">
            <asp:Image ID="ImagenApp" runat="server" Height="300px" ImageAlign="Right" 
                Width="300px" />
        </td>
        <td colspan="3">
            <asp:Label ID="NombreLabel" runat="server" Text="Nombre:"></asp:Label>
            <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
        </td>
    </tr>
    <tr>
        <td colspan="3">
            <asp:Label ID="DescripcionLabel" runat="server" Text="Descripción:"></asp:Label>
            <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
        </td>
    </tr>
    <tr>
        <td colspan="3">
            <asp:Label ID="PrecioLabel" runat="server" Text="Precio:"></asp:Label>
            <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="style2">
            <asp:Label ID="ValoracionLabel" runat="server" Text="Valoración:"></asp:Label>
            <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>
        </td>
        <td class="style2">
            <asp:Label ID="MiValoracionLabel" runat="server" Text="Mi valoración:"></asp:Label>
            <asp:DropDownList ID="ValoracionList" runat="server">
                <asp:ListItem Selected="True">1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
                <asp:ListItem>4</asp:ListItem>
                <asp:ListItem>5</asp:ListItem>
            </asp:DropDownList>
        </td>
        <td class="style2">
            &nbsp;</td>
    </tr>
    <tr>
            

        <td style="text-align: center">
         <asp:Label ID="Label1" runat="server" Text="Diseñador: "></asp:Label>
        <asp:Label ID="duenyo" runat="server" Text=""
               onclick="label_Click" />
            <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Button" />
        </td>
            

        <td colspan="2" style="text-align: center">
            <asp:Button ID="BotonDescargar" runat="server" Text="DESCARGAR" 
                onclick="BotonDescargar_Click" />
                <asp:Label ID="LabelError" runat="server" Text=""></asp:Label>
        </td>
    </tr>
</table>
</asp:Content>
