<%@ Page Title="Aplicaciones" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Aplicaciones.aspx.cs" Inherits="WebApplication1.About" %>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
       
    
    <div class="margen">
    </div>   

    <div class="centrado">
        <asp:Label ID="BuscarAplicacion" runat="server" Text="Buscar por: "></asp:Label> 
        <asp:DropDownList ID="CategoriasAplicacion" runat="server">
            <asp:ListItem>Categoria</asp:ListItem>
            <asp:ListItem>Pago</asp:ListItem>
            <asp:ListItem>Gratuitas</asp:ListItem>
        </asp:DropDownList>
        <asp:TextBox ID="BusquedaAplicacion" runat="server" Width="164px"></asp:TextBox>
    </div>
        
    
    <div class="centrado">
        <asp:Label ID="LabelNombreApp" runat="server" Text="Nombre de la App: "></asp:Label>    
            
        <asp:TextBox ID="TextNombreAPP" runat="server"></asp:TextBox>
    </div>
    <div class="centrado">
    <asp:Image ID="ImageApp" ImageUrl="Imagenes/ImagenNoDisp.jpg" runat="server" />
    </div>
    <div class="centradoulti">
            
            <asp:Label ID="LDescripApp" runat="server" Text="Descripción: "></asp:Label>
          
            <asp:TextBox ID="TDescripApp" runat="server" Height="35px" Width="294px"></asp:TextBox>
         
            <asp:Button ID="Button1" runat="server" Text="Ver App" Width="98px" />
    </div>
    <div class="margen">
    </div>    
</asp:Content>

