<%@ Page Title="" Language="C#" MasterPageFile="~/privado.Master" AutoEventWireup="true" CodeBehind="PerfilApp.aspx.cs" Inherits="WebApplication1.PerfilApp" %>
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
            <asp:Label ID="Label1" runat="server" Text="Nombre:"></asp:Label>
            <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
        </td>
    </tr>
    <tr>
        <td colspan="2">
            <asp:Label ID="Label2" runat="server" Text="Descripción:"></asp:Label>
            <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
        </td>
    </tr>
    <tr>
        <td colspan="2">
            <asp:Label ID="Label3" runat="server" Text="Precio:"></asp:Label>
            <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label4" runat="server" Text="Valoración:"></asp:Label>
            <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>
        </td>
        <td>
            <asp:Label ID="Label9" runat="server" Text="Mi valoración:"></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server" 
                style="top: 434px; left: 797px; position: absolute; height: 22px; width: 40px">
                <asp:ListItem>0</asp:ListItem>
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
                <asp:ListItem>4</asp:ListItem>
                <asp:ListItem>5</asp:ListItem>
                <asp:ListItem>6</asp:ListItem>
                <asp:ListItem>7</asp:ListItem>
                <asp:ListItem>8</asp:ListItem>
                <asp:ListItem>9</asp:ListItem>
                <asp:ListItem>10</asp:ListItem>
                <asp:ListItem></asp:ListItem>
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td colspan="2">
            <asp:Button ID="Button1" runat="server" Text="DESCARGAR" />
        </td>
    </tr>
</table>
</asp:Content>
