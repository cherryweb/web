<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="WebApplication1.Inicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Buscar" Height="20px"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" Height="20px"></asp:TextBox>
        <asp:Button ID="BotonBuscar" runat="server" Text="Enviar" Height ="20 px"/>
    </div>
    <div>
          <asp:GridView ID="GridView1" Width="33%" style="float:left" 
              AutoGenerateColumns="False" runat="server">
              <Columns>
                  <asp:BoundField HeaderText="New" />
              </Columns>
            </asp:GridView>
        
        
            <asp:GridView ID="GridView3" Width="33%" style="float:left" AutoGenerateColumns="false" runat="server">
            <Columns>
                  <asp:BoundField HeaderText="Most Valored" />
              </Columns>
            </asp:GridView>
     
      
            <asp:GridView ID="GridView2" Width="33%" style="float:left" AutoGenerateColumns="false" runat="server">
            <Columns>
                  <asp:BoundField HeaderText="Most Download" />
              </Columns>
            </asp:GridView>
       
    </div>
</asp:Content>
 