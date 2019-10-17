using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Incrementar
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        int i = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtNumero.Text = i.ToString();
            }
            
        }

        protected void btnIncrementar_Click(object sender, EventArgs e)
        {
            if (ViewState["conteo"] != null)
            {
                i = (int)ViewState["conteo"] + 1;
                
                
            }
            txtNumero.Text = i.ToString();
            ViewState["conteo"] = i;
        }
    }
}