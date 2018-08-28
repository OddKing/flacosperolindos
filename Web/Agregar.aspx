<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Agregar.aspx.cs" Inherits="Web.Agregar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width: 100%; height: 180px;">
        <tr>
            <td>Codigo de Cita</td>
            <td>
                <asp:TextBox ID="txtCodigoCita" runat="server" Width="48px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Fecha del Evento:</td>
            <td>
                <input id="txtFechaEvento" type="date" runat="server" /></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Nombre del evento:</td>
            <td>
                <asp:TextBox ID="txtNombreEvento" runat="server" Width="341px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Nombre del Modelo:</td>
            <td>
                <asp:TextBox ID="txtNombreModelo" runat="server" Width="344px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Edad:</td>
            <td>
                <asp:TextBox ID="txtEdad" runat="server" Width="33px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Sexo:</td>
            <td>
                <asp:DropDownList ID="ddlSexo" runat="server">
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Servicio:</td>
            <td>
                <asp:DropDownList ID="ddlServico" runat="server">
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Valor servicio</td>
            <td>
                <asp:TextBox ID="txtValor" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="btnGrabar" runat="server" Text="Grabar" OnClick="btnGrabar_Click" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Label ID="lblMensaje" runat="server"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
