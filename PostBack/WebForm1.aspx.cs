using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PostBack
{
    public partial class WebForm1 : System.Web.UI.Page
    {
      
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TextBox1.Text = "0";
            }
        }
        int n,x;
        string p;
        protected void Button1_Click(object sender, EventArgs e)
        {
          
            
            if (TextBox1.Text.Length==0)
            {
                x = 0;
                x++;
                
                TextBox1.Text = x.ToString();
            }
            
            else
            {
                
                n = Convert.ToInt32(TextBox1.Text);
                n++;
                
            }
              
            

        }
    }
}