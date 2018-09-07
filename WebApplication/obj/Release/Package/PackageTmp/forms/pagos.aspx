<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="pagos.aspx.cs" Inherits="WebApplication.forms.pagos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <h1>PAGOS</h1>
    <table style="width: 100%">
    <tr>
        <td style="width: 252px; height: 48px; font-size: large;">
            Ingresar Nombre</td>
        <td style="width: 437px; height: 48px;">
            <asp:TextBox ID="TextBoxNombre1" runat="server" Width="321px" Height="31px"></asp:TextBox>
        </td>
        <td style="height: 48px">
            </td>
    </tr>
    <tr>
        <td style="width: 252px; height: 46px;">
            <asp:Label ID="Label2" runat="server" Text="Mes a Cancelar" style="font-size: large"></asp:Label>
        </td>
        <td style="width: 437px; height: 46px;">
            <asp:TextBox ID="TextBoxMes" runat="server" Width="321px" Height="31px"></asp:TextBox>
        </td>
        <td style="height: 46px"></td>
    </tr>
    <tr>
        <td style="width: 252px; height: 44px;">
            <asp:Label ID="Label3" runat="server" Text="Total" style="font-size: medium"></asp:Label>
        </td>
        <td style="width: 437px; height: 44px;">
            <asp:TextBox ID="TextBoxTotal" runat="server" Width="176px" Height="31px"></asp:TextBox>
        </td>
        <td style="text-align: left; height: 44px;">
        </td>
    </tr>
    <tr>
        <td style="width: 252px; height: 61px;">
        </td>
        <td style="width: 437px; height: 61px;" class="right">
            <asp:Button ID="ButtonAceptar" runat="server" Text="Aceptar" style="margin-top: 24px" Height="31px" Width="107px" OnClick="ButtonAceptar_Click"  />
        </td>
        <td style="text-align: left; height: 61px;">
        </td>
    </tr>
</table>
</asp:Content>
