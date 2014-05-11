<%@ Page Title="REGISTRO" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Registro.aspx.cs" Inherits="WebApplication1.About" %>


<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    
    <div class="centrado">
       
        <asp:Label ID="UsuarioLabel" runat="server" Text="Nombre usuario: "></asp:Label>
    
        <asp:TextBox ID="UsuarioBox" runat="server"></asp:TextBox>

    </div>
    <div class="centrado">
   
        <asp:Label ID="NombreLabel" runat="server" Text="Nombre: "></asp:Label>
        
        <asp:TextBox ID="NombreBox" runat="server"></asp:TextBox>
    </div>
    <div class="centrado">
    
        <asp:Label ID="ContraseñaLabel" runat="server" Text="Contraseña: "></asp:Label>
        
        <asp:TextBox ID="ContraseñaBox" runat="server"></asp:TextBox>
    </div>
    <div class="centrado">
    
        <asp:Label ID="Contraseña2Label" runat="server" Text="Repita la contraseña: "></asp:Label>
        &nbsp;<asp:TextBox ID="Contraseña2Box" runat="server"></asp:TextBox>
    </div>
    <div class="centrado">
    
        <asp:Label ID="EmailLabel" runat="server" Text="E-mail: "></asp:Label>
        
        <asp:TextBox ID="EmailBox" runat="server"></asp:TextBox>
    </div>
    <div class="centrado">
   
        <asp:Label ID="TwitterLabel" runat="server" Text="Twitter: "></asp:Label>
        
        <asp:TextBox ID="TwitterBox" runat="server"></asp:TextBox>
    </div>
    <div class="centrado">
    
        <asp:Label ID="FacebookLabel" runat="server" Text="Facebook: "></asp:Label>
        
        <asp:TextBox ID="FacebookBox" runat="server"></asp:TextBox>
    </div>
    <div class="centrado">
    
        <asp:Label ID="TuentiLabel" runat="server" Text="Tuenti: "></asp:Label>
        
        <asp:TextBox ID="TuentiBox" runat="server"></asp:TextBox>
    </div>
    <div class="centrado">
   
        <asp:Label ID="PaísLabel" runat="server" Text="País: "></asp:Label>
        
        <asp:DropDownList ID="DespPaises" runat="server">
            <asp:ListItem>España</asp:ListItem>
            <asp:ListItem>Portugal</asp:ListItem>
            <asp:ListItem>Alemania</asp:ListItem>
            <asp:ListItem>Malta</asp:ListItem>
            <asp:ListItem>Andorra</asp:ListItem>
        </asp:DropDownList>
    </div>
    <div class="centrado">
    
        <asp:Label ID="BoletinLabel" runat="server" Text="Boletín de noticias: "></asp:Label>
        
        <asp:CheckBox ID="BoletinBox" runat="server" />

    </div>
    <div class="centrado">
   
        <asp:Label ID="TerminosLabel" runat="server" Text="Términos y condiciones: "></asp:Label>
        
        <asp:CheckBox ID="TerminosBox" runat="server" />

    </div>
    <div class="centradoulti">
        
        <asp:Button ID="Enviar" runat="server" Text="Enviar" Width="53px" />
        
        <asp:Button ID="Volver" runat="server" Text="Volver" />
    </div>
</asp:Content>
