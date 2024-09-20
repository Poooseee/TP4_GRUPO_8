<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EliminarSucursal.aspx.cs" Inherits="TP5_GRUPO_8.EliminarSucursal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 256px;
            height: 23px;
            margin-left: 320px;
        }
        .auto-style5 {
            font-size: x-large;
        }
        .auto-style6 {
            width: 148px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">&nbsp;<asp:HyperLink ID="hplAgregarSucursal" runat="server" NavigateUrl="~/AgregarSucursal.aspx">AgregarSucursal</asp:HyperLink>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </td>
                <td class="auto-style2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:HyperLink ID="hplListarSucursal" runat="server" NavigateUrl="~/ListarSucursales.aspx">Listado de sucursales</asp:HyperLink>
                    </td>
                <td class="auto-style2">&nbsp;&nbsp;&nbsp;<asp:HyperLink ID="hplEliminarSucursal" runat="server" NavigateUrl="~/EliminarSucursal.aspx">EliminarSucursal</asp:HyperLink>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
            </tr>
        </table>
        <div>
            <br />
        <strong class="auto-style5">Eliminar Sucursal<br />
            </strong>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style6">Ingresar ID Sucursal:</td>
                    <td>
                        <asp:TextBox ID="txtIdSucursal" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:RequiredFieldValidator ID="rfvEliminarSucursal" runat="server" ControlToValidate="txtIdSucursal">*</asp:RequiredFieldValidator>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />
                    </td>
                    <td>
                        <asp:RegularExpressionValidator ID="revId_del" runat="server" ControlToValidate="txtIdSucursal" ErrorMessage="RegularExpressionValidator" ValidationExpression="\d+">Ingrese un número</asp:RegularExpressionValidator>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
