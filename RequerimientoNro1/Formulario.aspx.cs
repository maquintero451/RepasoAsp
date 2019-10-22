using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RequerimientoNro1
{
    public partial class Formulario : System.Web.UI.Page
    {
      
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            Session["indentificacion"] = txtIden.Text;
            Session["nombre"] = txtNombre.Text;
            Session["apellido"] = txtApellido.Text;
            Session["direccion"] = txtDireccion.Text;
            Session["telefono"] = txtTelefono.Text;
            Session["correo"] = txtCorreo.Text;
            Session["fecha"] = txtFecha.Text;
            if (rbJuridica.Checked == true)
            {
                Session["tipoP"] = "juridica";
            }
            else if(rbNatural.Checked==true)
            {
                Session["tipoP"] ="Natural";
            }
            Response.Redirect("DatosEnviados.aspx");
        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtIden.Text="";
            txtNombre.Text="";
            txtApellido.Text="";
            txtDireccion.Text="";
            txtTelefono.Text="";
            txtCorreo.Text="";
            txtFecha.Text="";
        }
    }
}