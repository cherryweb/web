<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.master" CodeBehind="masVotadas.aspx.cs" Inherits="WebApplication1.masVotadas" %>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
       
    <div class = "margen"></div>
    <div class = "centrado">

         <asp:Label ID="LabelNombre" runat="server" Text="Buscar: "></asp:Label>
        <asp:TextBox ID="BusquedaAplicacion" runat="server" Width="164px"></asp:TextBox>

        
        <asp:Button ID="BotonBuscar" runat="server" Text="Enviar" Height ="20 px" 
            onclick="BotonBuscar_Click"/>

    </div>
    
    <div class="centrado">
    
         <asp:Label ID="LabelError" runat="server" Text=""></asp:Label>

     </div>
     <div class = "centrado">
     <asp:GridView ID="GridView3"  Width="100%" Height="100%" 
               AutoGenerateColumns="False"  onrowdatabound = "grdAplicaciones_RowDataBound"
              runat="server" DataSourceID="SqlDataSource1">
            <Columns>
            
                      
                  <asp:BoundField DataField="aplicacion" HeaderText="aplicacion" 
                      SortExpression="aplicacion" />
                  <asp:BoundField DataField="valoracion" HeaderText="valoracion" ReadOnly="True" 
                      SortExpression="valoracion" />
                  
              </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
              ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT        aplicacion, AVG(valoracion) AS valoracion
FROM            Valoraciones
GROUP BY aplicacion
ORDER BY valoracion DESC"></asp:SqlDataSource>
     </div>    
</asp:Content>

