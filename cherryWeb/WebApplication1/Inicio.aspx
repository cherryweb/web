<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="WebApplication1.Inicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Buscar" Height="20px"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" Height="20px"></asp:TextBox>
        <asp:Button ID="BotonBuscar" runat="server" Text="Enviar" Height ="20 px"/>
    </div>
    <div style="height:auto; width: auto;">
          <asp:GridView ID="GridView1" Width="33%" Height="100%" style="display:inline" HeaderStyle-ForeColor="Red" AutoGenerateColumns="False" BackColor="Aqua" runat="server">
              <Columns>
                  <asp:BoundField DataField="prueba" HeaderText="New" />
              </Columns>
            </asp:GridView>
        
        
            <asp:GridView ID="GridView3"  Width="33%" Height="100%" style="display:inline" AutoGenerateColumns="false" BackColor="Aqua" HeaderStyle-ForeColor="Red" runat="server">
            <Columns>
                  <asp:BoundField DataField="prueba" HeaderText="Most Valored" />
              </Columns>
            </asp:GridView>
     
      
            <asp:GridView ID="GridView2" Width="33.9%" Height="100%" style="display:inline" AutoGenerateColumns="false" BackColor="Aqua" HeaderStyle-ForeColor="Red" runat="server">
            <Columns>
                  <asp:BoundField DataField="prueba" HeaderText="Most Download" />
              </Columns>
            </asp:GridView>
       
    </div>
</asp:Content>
 