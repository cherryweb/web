<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="WebApplication1.Inicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <asp:Label ID="BuscarLabel" runat="server" Text="Buscar" Height="20px"></asp:Label>
        <asp:TextBox ID="BuscarBox" runat="server" Height="20px"></asp:TextBox>
        <asp:Button ID="BotonBuscar" runat="server" Text="Enviar" Height ="20 px" 
            onclick="BotonBuscar_Click"/>
        <asp:Label ID="LabelError" runat="server" Text=""></asp:Label>
    </div>
    <div style="height:auto; width: auto;">
          <asp:GridView ID="GridView1" Width="33%" Height="100%" style="display:inline" HeaderStyle-ForeColor="Red" AutoGenerateColumns="False" BackColor="Aqua" runat="server">
              <Columns>
                  <asp:BoundField DataField="prueba" HeaderText="New" />
              </Columns>
            </asp:GridView>
        
        
            <asp:GridView ID="GridView3"  Width="33%" Height="100%" 
              style="display:inline" AutoGenerateColumns="False" BackColor="Aqua" 
              HeaderStyle-ForeColor="Red" runat="server" DataSourceID="SqlDataSource1">
            <Columns>
                  <asp:BoundField DataField="aplicacion" HeaderText="aplicacion" 
                      SortExpression="aplicacion" />
                  <asp:BoundField DataField="valoracion" HeaderText="valoracion" ReadOnly="True" 
                      SortExpression="valoracion" />
              </Columns>

<HeaderStyle ForeColor="Red"></HeaderStyle>
            </asp:GridView>
     
      
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
              ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT        aplicacion, AVG(valoracion) AS valoracion
FROM            Valoraciones
GROUP BY aplicacion"></asp:SqlDataSource>
     
      
            <asp:GridView ID="GridView2" Width="33.9%" Height="100%" style="display:inline" AutoGenerateColumns="false" BackColor="Aqua" HeaderStyle-ForeColor="Red" runat="server">
            <Columns>
                  <asp:BoundField DataField="prueba" HeaderText="Most Download" />
              </Columns>
            </asp:GridView>
       
    </div>
</asp:Content>
 