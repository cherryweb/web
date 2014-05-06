<%@ Page Title="Página principal" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="InicioDeSesion.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        INICIO DE SESIÓN<br />
        <br />
    </h2>

        <asp:Login ID="Login1" runat="server" TitleText="" RememberMeText="" DisplayRememberMe=false>
            <CheckBoxStyle Wrap="True" />
        </asp:Login>
    <asp:PasswordRecovery ID="PasswordRecovery1" runat="server" 
        
        style="z-index: 1; left: 591px; top: 278px; position: absolute; height: 97px; width: 344px">
    </asp:PasswordRecovery>

    </asp:Content>
