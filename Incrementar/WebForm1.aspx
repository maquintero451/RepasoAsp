<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Incrementar.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-bottom: 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtNumero" runat="server" CssClass="auto-style1"></asp:TextBox>
            <asp:Button ID="btnIncrementar" runat="server" OnClick="btnIncrementar_Click" Text="Incrementar" />
        </div>
    </form>
</body>
</html>
