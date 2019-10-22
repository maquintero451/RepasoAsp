using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace RequerimientoNro1
{
    public partial class Formulario : System.Web.UI.Page
    {
      
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataSet ds = new DataSet();
                ds.ReadXml(Server.MapPath("XMLFile1.xml"));
                cboCiudades.DataSource = ds;
                cboCiudades.DataTextField = "nombre";
                cboCiudades.DataValueField = "id";
                cboCiudades.DataBind();
            }
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
            Session["ciudad"] = cboCiudades.SelectedItem.ToString();
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