<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="inscripciones.aspx.cs" Inherits="WebApplication.forms.inscripciones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <table style="width: 100%; ">
         
     <h1>INSCRIPCIONES </h1>
    <tr>
        <td style="width: 177px; height: 49px">
            <asp:Label ID="Label2" runat="server" Text="Nombres" style="font-size: medium"></asp:Label>
        </td>
        <td style="width: 165px; height: 49px">
            <asp:TextBox ID="TextBoxNombres" runat="server" Width="322px" Height="31px"></asp:TextBox>
        </td>
        <td style="width: 165px; height: 49px"></td>
    </tr>
    <tr>
        <td style="width: 177px; height: 33px">
            <asp:Label ID="Label1" runat="server" Text="Apellidos" style="font-size: medium"></asp:Label>
        </td>
        <td style="width: 165px; height: 33px">
            <asp:TextBox ID="TextBoxApellidos" runat="server" Width="322px" Height="31px" style="margin-bottom: 12px"></asp:TextBox>
        </td>
        <td style="width: 165px; height: 33px"></td>
    </tr>
    <tr>
        <td style="width: 177px; height: 39px;">
            <asp:Label ID="Label3" runat="server" Text="Fecha de Nacimiento" style="font-size: medium"></asp:Label>
        </td>
        <td style="width: 165px; height: 39px;">
            <asp:TextBox ID="TextBoxNacimiento" runat="server" Width="322px" Height="31px"></asp:TextBox>
        </td>
        <td style="width: 165px; height: 39px;"></td>
    </tr>
    <tr>
        <td style="width: 177px; height: 38px">
            <asp:Label ID="Label4" runat="server" Text="Residencia" style="font-size: medium"></asp:Label>
        </td>
        <td style="width: 165px; height: 38px">
            <asp:TextBox ID="TextBoxResidencia" runat="server" Width="322px" Height="31px"></asp:TextBox>
        </td>
        <td style="width: 165px; height: 38px"></td>
    </tr>
    <tr>
        <td style="width: 177px; height: 43px;">
            <asp:Label ID="Label6" runat="server" Text="Telefono Encargado" style="font-size: medium"></asp:Label>
        </td>
        <td style="width: 165px; height: 43px;">
            <asp:TextBox ID="TextBoxTelefono" runat="server" Width="322px" Height="31px"></asp:TextBox>
        </td>
        <td style="width: 165px; height: 43px;"></td>
    </tr>
    <tr>
        <td style="width: 177px; height: 39px;">
            <asp:Label ID="Label7" runat="server" Text="Horario Inscripción" style="font-size: medium"></asp:Label>
        </td>
        <td style="width: 165px; height: 39px;">
            <asp:TextBox ID="TextBoxHorario" runat="server" Width="322px" Height="31px"></asp:TextBox>
        </td>
        <td style="width: 165px; height: 39px;"></td>
    </tr>
    <tr>
      
        <td style="width: 165px; height: 11px;">
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Conectar %>" SelectCommand="SELECT * FROM [Tb_Alumnos]"></asp:SqlDataSource>
        </td>
        <td style="width: 165px; height: 11px;">
            <asp:Button ID="ButtonGrabar" runat="server"  Text="Aceptar" Height="37px" Width="75px" OnClick="ButtonGrabar_Click" />
            </td>
    </tr>
</table>
</asp:Content>
