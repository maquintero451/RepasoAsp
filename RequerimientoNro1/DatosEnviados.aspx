<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DatosEnviados.aspx.cs" Inherits="RequerimientoNro1.DatosEnviados" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtInden" runat="server"></asp:TextBox>
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
            <asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox>
            <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
            <asp:TextBox ID="txtCorreo" runat="server"></asp:TextBox>
            <asp:TextBox ID="txtFecha" runat="server"></asp:TextBox>
            <asp:TextBox ID="txtTipoP" runat="server"></asp:TextBox>
            <asp:TextBox ID="txtCiudad" runat="server" OnTextChanged="TextBox9_TextChanged"></asp:TextBox>

            <asp:Button ID="btnVolver" runat="server" OnClick="btnVolver_Click" Text="Volver" />

        </div>
    </form>
</body>
</html>
