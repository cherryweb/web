<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SubirApp.aspx.cs" Inherits="WebApplication1.SubirApp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style1
        {
        }
        .style2
        {
            width: 325px;
            height: 86px;
        }
        .style3
        {
            height: 86px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width:100%;">
        <tr>
            <td class="style1">
                <asp:Label ID="subirapp_nombrelabel" runat="server" Text="Nombre: "></asp:Label>
                <asp:TextBox ID="subirapp_nombretextbox" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="subirapp_pvp" runat="server" Text="PVP:"></asp:Label>
                <asp:TextBox ID="subirapp_pvptextbox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                <asp:Label ID="subirapp_descripcionlaber" runat="server" Text="Descripción:"></asp:Label>
                <asp:TextBox ID="subirapp_descripciontextbox" runat="server" Height="68px" 
                    TextMode="MultiLine" Width="238px"></asp:TextBox>
            </td>
            <td class="style3">
                <asp:Label ID="subirapp_cargarimagenlabel" runat="server" Text="Cargar imagen:"></asp:Label>
                <asp:FileUpload ID="FileUpload1" runat="server" />
            </td>
        </tr>
        <tr>
            <td class="style1">
                <asp:Label ID="subirapp_categorialabel" runat="server" Text="Categoría:"></asp:Label>
                <asp:DropDownList ID="DropDownList1" runat="server">
                </asp:DropDownList>
            </td>
            <td>
                <asp:Label ID="subirapp_rutaapplabel" runat="server" Text="Ruta App:"></asp:Label>
                <asp:FileUpload ID="FileUpload2" runat="server" />
            </td>
        </tr>
        <tr>
            <td class="style1" colspan="2">
                <asp:Button ID="subirapp_subirboton" runat="server" Font-Bold="True" 
                    style="text-align: center" Text="SUBIR" />
            </td>
        </tr>
    </table>
</asp:Content>
