<%@ Page Title="Aplicaciones" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Aplicaciones.aspx.cs" Inherits="WebApplication1.Aplicaciones" %>

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
              runat="server" DataSourceID="SqlDataSource1">
            <Columns>
                  <asp:BoundField DataField="APLICACIONES" HeaderText="APLICACIONES" 
                      SortExpression="APLICACIONES" />
              </Columns>
            </asp:GridView>
     
      
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
              ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT        nombre AS Aplicaciones
FROM            Aplicaciones
GROUP BY nombre"></asp:SqlDataSource>
     </div>    
</asp:Content>

