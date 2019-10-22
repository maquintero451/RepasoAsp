<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Formulario.aspx.cs" Inherits="RequerimientoNro1.Formulario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
</head>
<body>
    <div class="row justify-content-start bg-danger">
            <header class="mx-auto ">
                <h1 >Formulario</h1>
            </header>
        </div>
        
    <form id="form1" runat="server">
        
      
            <div class="row justify-content-center mt-4">

                <div class="col-3">
                  <asp:Label ID="Label1" runat="server" Text="Numero De identificacion" ></asp:Label>
                    <asp:TextBox ID="txtIden" runat="server" class="form-control"></asp:TextBox>
                </div>
            
                <div class="col-3">
                    <asp:Label ID="Label2" runat="server" Text="Nombre" ></asp:Label>
                    <asp:TextBox ID="txtNombre" runat="server" class="form-control"></asp:TextBox>
                </div>
            
                <div class="col-3">
                    <asp:Label ID="Label3" runat="server" Text="Apellido" ></asp:Label> 
                    <asp:TextBox ID="txtApellido" runat="server" class="form-control"></asp:TextBox>
                </div>
            </div>
           
            <div class="row justify-content-center my-2">

                <div class="col-3">
                  <asp:Label ID="Label4" runat="server" Text="Direccion" ></asp:Label>
                    <asp:TextBox ID="txtDireccion" runat="server" class="form-control"></asp:TextBox>
                </div>
            
                <div class="col-3">
                    <asp:Label ID="Label5" runat="server" Text="Telefono" ></asp:Label>
                    <asp:TextBox ID="txtTelefono" runat="server" class="form-control"></asp:TextBox>
                </div>
            
                <div class="col-3">
                    <asp:Label ID="Label6" runat="server" Text="Correo Electronico" ></asp:Label> 
                    <asp:TextBox ID="txtCorreo" type="email" runat="server" class="form-control"></asp:TextBox>
                </div>
            </div>
        <div class="row justify-content-center my-2">
            <div class="col-3">
                     <asp:Label ID="Label8" runat="server" Text="Fecha de nacimiento" ></asp:Label> 
                    <asp:TextBox ID="txtFecha" type="date" runat="server" class="form-control"></asp:TextBox>
            </div>
            <div class="col-3">
                <asp:Label ID="Label7" runat="server" Text="Tipo de persona" ></asp:Label> 
                <asp:RadioButton ID="rbNatural" runat="server" Text="Natural" GroupName="rb" CssClass="form-control" />
                <asp:RadioButton ID="rbJuridica" runat="server" Text="Juridica" GroupName="rb" CssClass="form-control" />
            </div>
            <div class="col-3">
                <asp:Label ID="Label9" runat="server" Text="Ciudad" ></asp:Label> 
                <asp:DropDownList ID="cboCiudades" runat="server"></asp:DropDownList>
            </div>
        </div>
        <div class="container">
        <div class="row ">
            <div class="col-3">
                <asp:Button ID="btnEnviar" runat="server" Text="Enviar"  CssClass="btn btn-primary" OnClick="btnEnviar_Click" />
            
                <asp:Button ID="btnLimpiar" runat="server" Text="Limpiar"  CssClass="btn btn-primary" OnClick="btnLimpiar_Click"/>
            </div>
        </div>
       </div>
    </form>




    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>
</body>
</html>
