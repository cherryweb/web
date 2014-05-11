<%@ Page Title="Aplicaciones" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Aplicaostias.aspx.cs" Inherits="WebApplication1.About" %>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <p align="center">
        <asp:Label ID="BuscarAplicacion" runat="server" Text="Buscar por: "></asp:Label> &nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="CategoriasAplicacion" runat="server">
            <asp:ListItem>Categoria</asp:ListItem>
            <asp:ListItem>Pago</asp:ListItem>
            <asp:ListItem>Gratuitas</asp:ListItem>
</asp:DropDownList>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="BusquedaAplicacion" runat="server" Width="164px"></asp:TextBox>
    </p>
    <p align="center">
        <asp:Label ID="LabelNombreApp" runat="server" Text="Nombre de la App: "></asp:Label>    
        &nbsp;&nbsp;&nbsp;    
        <asp:TextBox ID="TextNombreAPP" runat="server"></asp:TextBox>
        </p>
        <p style="background-color: #FFFFFF">
            <asp:Image ID="ImageApp" runat="server" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="LDescripApp" runat="server" Text="Descripción: "></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TDescripApp" runat="server" Height="35px" Width="294px"></asp:TextBox>
         &nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Text="Ver App" Width="98px" />
         </p>
         <p>
            
            </p>
</asp:Content>

