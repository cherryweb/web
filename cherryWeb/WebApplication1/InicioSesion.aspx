<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InicioSesion.aspx.cs" Inherits="WebApplication1.InicioSesion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server"> 
    <table style="width:100%;">
        <tr>
            <td>
                <asp:Login ID="Login1" runat="server">
                </asp:Login>
            </td>
            <td>
                <asp:PasswordRecovery ID="PasswordRecovery1" runat="server">
                </asp:PasswordRecovery>
            </td>
        </tr>
    </table>
</asp:Content>
