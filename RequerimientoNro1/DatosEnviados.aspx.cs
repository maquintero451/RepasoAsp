using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RequerimientoNro1
{
    public partial class DatosEnviados : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                consulta();
            }
        
        }
        public void consulta()
        {
            txtInden.Text = (string)Session["indentificacion"];
            txtNombre.Text = (string)Session["nombre"];
            txtApellido.Text = (string)Session["apellido"];
            txtDireccion.Text = (string)Session["direccion"];
            txtTelefono.Text = (string)Session["telefono"];
            txtCorreo.Text = (string)Session["correo"];
            txtFecha.Text = (string)Session["fecha"];
            txtTipoP.Text = (string)Session["tipoP"];
            txtCiudad.Text = (string)Session["ciudad"];
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Formulario.aspx");
        }

        protected void TextBox9_TextChanged(object sender, EventArgs e)
        {

        }
    }
}