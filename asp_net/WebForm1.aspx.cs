using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asp_net
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("La cantidad de aplicaciones instanciadas son: " + Application["Aplicaciones"]+"</br>");
            Response.Write("La cantidad de Sesiones son: " + Application["SesionesUsuario"] + "</br>");
        }

    }
}