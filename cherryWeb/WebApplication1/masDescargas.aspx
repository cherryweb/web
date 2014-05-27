<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.master" CodeBehind="masDescargas.aspx.cs" Inherits="WebApplication1.masDescargas" %>

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
               AutoGenerateColumns="False"  
              runat="server" DataSourceID="MasDescargadas">
            <Columns>   
                  <asp:BoundField DataField="Aplicacion" HeaderText="Aplicacion" 
                      SortExpression="Aplicacion" />
                   
                  <asp:BoundField DataField="DESCARGAS" HeaderText="DESCARGAS" ReadOnly="True" 
                      SortExpression="DESCARGAS" />
                   
              </Columns>
            </asp:GridView>
         <asp:SqlDataSource ID="MasDescargadas" runat="server" 
             ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
             SelectCommand="SELECT        Aplicacion, COUNT(Aplicacion) AS DESCARGAS
FROM            Descargas
GROUP BY Aplicacion
ORDER BY DESCARGAS DESC">
         </asp:SqlDataSource>
     </div>    
</asp:Content>


